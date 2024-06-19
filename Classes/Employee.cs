using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_2_CSharp.Classes
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(int id, string name, string department)
        {
            ID = id;
            Name = name;
            Department = department;
        }

        public void WriteToFile(BinaryWriter writer)
        {
            writer.Write(ID);
            writer.Write(Name);
            writer.Write(Department);
        }

        public static Employee ReadFromFile(BinaryReader reader)
        {
            try
            {
                int id = reader.ReadInt32();
                string name = reader.ReadString();
                string department = reader.ReadString();
                return new Employee(id, name, department);
            }
            catch (EndOfStreamException)
            {
                throw new InvalidOperationException("No se pudieron leer los datos del archivo correctamente.");
            }
        }

    }
}
