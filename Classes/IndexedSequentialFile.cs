using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_2_CSharp.Classes
{
    public class IndexedSequentialFile<T> : IDisposable
    {
        private readonly string dataFilePath;
        private readonly string indexFilePath;
        private readonly Dictionary<int, long> index;

        public IndexedSequentialFile(string dataFilePath, string indexFilePath)
        {
            this.dataFilePath = dataFilePath ?? throw new ArgumentNullException(nameof(dataFilePath));
            this.indexFilePath = indexFilePath ?? throw new ArgumentNullException(nameof(indexFilePath));
            this.index = new Dictionary<int, long>();
        }

        public List<T> GetAllRecords()
        {
            LoadIndex();

            List<T> records = new List<T>();

            using (StreamReader reader = new StreamReader(dataFilePath))
            {
                foreach (var position in index.Values)
                {
                    reader.BaseStream.Seek(position, SeekOrigin.Begin);
                    string line = reader.ReadLine();
                    T record = ParseRecord(line);
                    records.Add(record);
                }
            }

            return records;
        }

        public void InsertRecord(int key, T record)
        {
            long position = GetEndOfFilePosition(dataFilePath);

            using (StreamWriter dataWriter = new StreamWriter(dataFilePath, true))
            using (StreamWriter indexWriter = new StreamWriter(indexFilePath, true))
            {
                dataWriter.WriteLine(record.ToString());
                indexWriter.WriteLine($"{key}:{position}");
            }
        }

        public T GetRecordByKey(int key)
        {
            LoadIndex();

            if (!index.TryGetValue(key, out long position))
            {
                throw new KeyNotFoundException($"Key {key} not found in index.");
            }

            using (StreamReader reader = new StreamReader(dataFilePath))
            {
                reader.BaseStream.Seek(position, SeekOrigin.Begin);
                string line = reader.ReadLine();
                return ParseRecord(line);
            }
        }

        public void LoadIndex()
        {
            // Clear the index dictionary before loading new index data
            index.Clear();

            try
            {
                // Check if the index file exists
                if (!File.Exists(indexFilePath))
                {
                    // Log or debug message if the index file doesn't exist
                    Console.WriteLine($"Error: The index file does not exist at the specified location: {indexFilePath}");
                    return;
                }

                // Open the index file for reading
                using (StreamReader indexReader = new StreamReader(indexFilePath))
                {
                    string line;
                    // Read each line of the index file
                    while ((line = indexReader.ReadLine()) != null)
                    {
                        // Split the line by ':' to separate key and position
                        string[] parts = line.Split(':');
                        // Ensure the line has correct format and parse key and position
                        if (parts.Length == 2 && int.TryParse(parts[0], out int key) && long.TryParse(parts[1], out long position))
                        {
                            // Add the key-position pair to the index dictionary
                            index[key] = position;
                        }
                        else
                        {
                            // Log or debug message for lines with incorrect format
                            Console.WriteLine($"Error: Line with incorrect format in the index file: {line}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exception handling to catch any errors while reading the index file
                Console.WriteLine($"Error loading the index: {ex.Message}");
            }
        }


        private long GetEndOfFilePosition(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return fileStream.Length;
            }
        }

        private T ParseRecord(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                return (T)(object)"";
            }

            string[] parts = line.Split(',');

            int id = int.Parse(parts[0]);
            string name = parts[1];
            string phone = parts[2];
            string email = parts[3];

            return (T)(object)new Contact(id, name, phone, email);
        }

        public void UpdateRecord(int key, T newRecord)
        {
            if (!index.TryGetValue(key, out long position))
            {
                throw new KeyNotFoundException($"Key {key} not found in index.");
                return;
            }

            using (StreamWriter dataWriter = new StreamWriter(dataFilePath))
            using (StreamReader reader = new StreamReader(dataFilePath))
            {
                string line;
                long currentPosition = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (currentPosition == position)
                    {
                        dataWriter.WriteLine(newRecord.ToString());
                    }
                    else
                    {
                        dataWriter.WriteLine(line);
                    }
                    currentPosition = reader.BaseStream.Position;
                }
            }
        }

        public void DeleteRecord(int key)
        {
            if (!index.TryGetValue(key, out long position))
            {
                throw new KeyNotFoundException($"Key {key} not found in index.");
                return;
            }

            // Remove record from index
            index.Remove(key);

            using (StreamWriter indexWriter = new StreamWriter(indexFilePath))
            {
                foreach (var kvp in index)
                {
                    indexWriter.WriteLine($"{kvp.Key}:{kvp.Value}");
                }
            }

            // Update data file
            UpdateDataFile(position);
        }

        private void UpdateDataFile(long positionToRemove)
        {
            string tempFilePath = Path.GetTempFileName();

            using (StreamWriter tempWriter = new StreamWriter(tempFilePath))
            using (StreamReader reader = new StreamReader(dataFilePath))
            {
                string line;
                long currentPosition = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (currentPosition != positionToRemove)
                    {
                        tempWriter.WriteLine(line);
                    }
                    currentPosition = reader.BaseStream.Position;
                }
            }

            // Replace the original data file with the temp file
            File.Delete(dataFilePath);
            File.Move(tempFilePath, dataFilePath);
        }

        public void Dispose()
        {
            // No hay recursos adicionales que cerrar, pero puedes agregarlos si es necesario
        }
    }

}
