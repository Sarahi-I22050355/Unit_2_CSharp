using Unit_2_CSharp.Classes;

namespace Unit_2_CSharp
{
    public partial class Form1 : Form
    {
        private string filePath;
        private string FilePathEmployee = "datos.bin";
        private int selectedUserId;
        string dataFilePath = "datos.txt";
        string indexFilePath = "indices.txt";
        private IndexedSequentialFile<Contact> indexedFile;

        public Form1()
        {
            InitializeComponent();
            ShowAllContacts();
        }


        #region Sequential Operations
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            filePath = openFileDialog.FileName;
            OpenDataGridView();
        }

        public void OpenDataGridView()
        {
            dgvEmployeeTable.Rows.Clear();
            dgvEmployeeTable.Columns.Clear();

            // Read lines from the CSV file
            string[] lines = File.ReadAllLines(filePath);

            // If there are lines in the file
            if (lines.Length > 0)
            {
                // Get column names from the first record
                string[] columnNames = lines[0].Split(',');

                // Add columns to the DataGridView using the column names from the CSV
                foreach (string columnName in columnNames)
                {
                    dgvEmployeeTable.Columns.Add(columnName, columnName);
                }

                // Add rows to the DataGridView with the content from the CSV (excluding the first line)
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    dgvEmployeeTable.Rows.Add(fields);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Select a file to work with.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtName.Text == "" || txtSecondName.Text == "" || txtAge.Text == "" || cbDepartament.Text == "")
            {
                MessageBox.Show("Fill in all fields correctly.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{txtName.Text},{txtSecondName.Text},{txtAge.Text},{cbDepartament.Text}");
            }
            OpenDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Select a file to work with.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("To search, you must use a NAME.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            try
            {
                // Read the CSV file line by line
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] fields = line.Split(',');

                        // Compare the search term with the first field (in this case, the name)
                        if (fields.Length > 0 && fields[0] == txtName.Text)
                        {
                            MessageBox.Show("Found: " + string.Join(", ", fields), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtName.Text = fields[0];
                            txtSecondName.Text = fields[1];
                            txtAge.Text = fields[2];
                            cbDepartament.Text = fields[3];

                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching in the CSV file: " + ex.Message);
            }
            MessageBox.Show("No matching name found in the file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a file is selected
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Select a valid file to work with.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Check if a name to search for is entered
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name to search for.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                // Read the CSV file line by line and write the non-deleted lines to a new temporary file
                string tempFilePath = Path.GetTempFileName();
                using (StreamReader reader = new StreamReader(filePath))
                using (StreamWriter writer = new StreamWriter(tempFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Check if the current line contains the name to delete
                        if (!line.Contains(txtName.Text))
                        {
                            writer.WriteLine(line);
                        }
                    }
                }

                // Replace the original file with the temporary file
                File.Delete(filePath);
                File.Move(tempFilePath, filePath);
                OpenDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting line from the CSV file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Indexed Sequential Operations
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Get contact data from the form fields
            string name = txtNameSql.Text;
            string phone = txtPhoneSql.Text;
            string email = txtEmailSql.Text;

            // Insert the new contact into the indexed sequential file
            InsertContact(name, phone, email);
        }

        private void InsertContact(string name, string phone, string email)
        {
            using (indexedFile = new IndexedSequentialFile<Contact>(dataFilePath, indexFilePath))
            {
                try
                {
                    // Get the ID of the last inserted contact to assign a new one
                    int lastID = GetLastID();

                    // Increment the ID for the new contact
                    int newID = lastID + 1;
                    Contact newContact = new Contact(newID, name, phone, email);
                    // Insert the new contact into the file
                    indexedFile.InsertRecord(newID, newContact);

                    // Update the contacts list in the DataGridView
                    ShowAllContacts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting the contact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            indexedFile = null;
        }

        private int GetLastID()
        {
            using (indexedFile = new IndexedSequentialFile<Contact>(dataFilePath, indexFilePath))
            {
                // Get all contacts from the file to find the last ID
                List<Contact> contacts = indexedFile.GetAllRecords();

                // Check if there are any contacts in the list
                if (contacts.Count > 0)
                {
                    // Sort the contacts list by ID in descending order
                    contacts.Sort((x, y) => y.ID.CompareTo(x.ID));

                    // Return the ID of the first contact (the highest one)
                    return contacts[0].ID;
                }
                else
                {
                    // If there are no contacts in the file, return 0
                    return 0;
                }
            }
            indexedFile = null;
        }

        private void ShowAllContacts()
        {
            using (indexedFile = new IndexedSequentialFile<Contact>(dataFilePath, indexFilePath))
            {
                try
                {
                    List<Contact> contacts = indexedFile.GetAllRecords();

                    if (contacts != null)
                    {
                        foreach (var contact in contacts)
                        {
                            dgvContactos.Rows.Add(contact.ID, contact.Name, contact.Phone, contact.Email);
                        }
                    }
                    else
                    {
                        // Handle the case where the contacts list is null
                        MessageBox.Show("The contacts list is null.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur while reading contacts
                    MessageBox.Show("Error reading contacts: " + ex.Message);
                }
            }
            indexedFile = null;
        }

        private void dgvContacts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (indexedFile = new IndexedSequentialFile<Contact>(dataFilePath, indexFilePath))
            {
                if (dgvContactos.SelectedRows.Count == 0)
                {
                    return;
                }

                // Get the selected contact
                Contact selectedContact = dgvContactos.SelectedRows[0].DataBoundItem as Contact;

                // Check if the selected contact could be obtained
                if (selectedContact == null)
                {
                    return;
                }

                // Get the ID of the selected user
                selectedUserId = (int)dgvContactos.SelectedRows[0].Cells["ID"].Value;

                // Show the contact information in the TextBoxes
                txtNameSql.Text = selectedContact.Name;
                txtPhoneSql.Text = selectedContact.Phone;
                txtEmailSql.Text = selectedContact.Email;
            }
            indexedFile = null;
        }

        private void btnUpdateSql_Click(object sender, EventArgs e)
        {
            // Check if a user has been selected for modification
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the modified data from the TextBoxes
            string name = txtNameSql.Text;
            string phone = txtPhoneSql.Text;
            string email = txtEmailSql.Text;

            // Create a Contact object with the modified data
            Contact modifiedContact = new Contact(selectedUserId, name, phone, email);
            ModifyUser(modifiedContact);

        }

        private void ModifyUser(Contact modifiedContact)
        {
            using (indexedFile = new IndexedSequentialFile<Contact>(dataFilePath, indexFilePath))
            {
                indexedFile.LoadIndex();
                try
                {
                    // Modify the contact in the file
                    indexedFile.UpdateRecord(modifiedContact.ID, modifiedContact);

                    // Show the updated contacts in the DataGridView
                    ShowAllContacts();

                    MessageBox.Show("User modified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error modifying the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            indexedFile = null;

        }

        private void dgvContacts_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the selected row
            DataGridViewRow selectedRow = dgvContactos.CurrentRow;

            if (selectedRow != null)
            {
                // Get the values of the cells in the selected row
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                string phone = Convert.ToString(selectedRow.Cells["Phone"].Value);
                string email = Convert.ToString(selectedRow.Cells["Email"].Value);

                // Show the data in the TextBoxes
                txtNameSql.Text = name;
                txtPhoneSql.Text = phone;
                txtEmailSql.Text = email;

                // Assign the ID of the selected user
                selectedUserId = id;
            }
        }

        private void btnDeleteSql_Click(object sender, EventArgs e)
        {
            // Check if a user has been selected for deletion
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (indexedFile = new IndexedSequentialFile<Contact>(dataFilePath, indexFilePath))
            {
                indexedFile.LoadIndex();
                try
                {
                    // Delete the contact from the file
                    indexedFile.DeleteRecord(selectedUserId);

                    // Show the updated contacts in the DataGridView
                    ShowAllContacts();

                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            indexedFile = null;
        }

        #endregion

        #region Direct Access
        private void btnOpenDA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary Files (*.bin)|*.bin|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            FilePathEmployee = openFileDialog.FileName;
            // Read the content of the selected file and display it in the DataGridView
            DisplayFileContent(FilePathEmployee);
            MessageBox.Show("File opened successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayFileContent(string filePath)
        {
            if (new FileInfo(filePath).Length == 0)
            {
                // The file is empty, there is nothing to read
                MessageBox.Show("The file is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear the DataGridView before loading new data
            dgvEmpTabl.Rows.Clear();
            dgvEmpTabl.Columns.Clear();

            // Read the content of the file and display it in the DataGridView
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                // Read the data from the file and add it to the DataGridView
                while (reader.PeekChar() != -1)
                {
                    // Read employee data from the file
                    int id = reader.ReadInt32();
                    string name = reader.ReadString();
                    string department = reader.ReadString();

                    // Add a row to the DataGridView with the employee data
                    dgvEmpTabl.Rows.Add(id, name, department);
                }
            }
        }

        private Employee SearchEmployeeByID(int id)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(FilePathEmployee, FileMode.Open)))
            {
                while (reader.PeekChar() != -1)
                {
                    Employee employee = Employee.ReadFromFile(reader);
                    if (employee.ID == id)
                    {
                        return employee;
                    }
                }
            }
            return null; // Employee not found
        }

        private void UpdateEmployee(Employee updatedEmployee)
        {
            string tempFilePath = Path.GetTempFileName();

            using (BinaryReader reader = new BinaryReader(File.Open(FilePathEmployee, FileMode.Open)))
            using (BinaryWriter writer = new BinaryWriter(File.Open(tempFilePath, FileMode.Create)))
            {
                while (reader.PeekChar() != -1)
                {
                    Employee employee = Employee.ReadFromFile(reader);
                    if (employee.ID == updatedEmployee.ID)
                    {
                        updatedEmployee.WriteToFile(writer);
                    }
                    else
                    {
                        employee.WriteToFile(writer);
                    }
                }
            }
            File.Delete(FilePathEmployee);
            File.Move(tempFilePath, FilePathEmployee);
        }

        private void DeleteEmployee(Employee employeeToDelete)
        {
            string tempFilePath = Path.GetTempFileName();

            using (BinaryReader reader = new BinaryReader(File.Open(FilePathEmployee, FileMode.Open)))
            using (BinaryWriter writer = new BinaryWriter(File.Open(tempFilePath, FileMode.Create)))
            {
                while (reader.PeekChar() != -1)
                {
                    Employee employee = Employee.ReadFromFile(reader);
                    if (employee.ID != employeeToDelete.ID)
                    {
                        employee.WriteToFile(writer);
                    }
                }
            }
            File.Delete(FilePathEmployee);
            File.Move(tempFilePath, FilePathEmployee);
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtNameDA.Clear();
            cbDepartamentDA.Text = "";
        }

        private void LoadData()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(FilePathEmployee, FileMode.Open)))
            {
                while (reader.PeekChar() != -1)
                {
                    Employee employee = Employee.ReadFromFile(reader);
                    dgvEmpTabl.Rows.Add(employee.ID, employee.Name, employee.Department);
                }
            }
        }

        private void ShowEmployeeData(Employee employee)
        {
            txtID.Text = employee.ID.ToString();
            txtNameDA.Text = employee.Name;
            cbDepartamentDA.Text = employee.Department;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNameDA.Text) || string.IsNullOrEmpty(cbDepartamentDA.Text))
            {
                return;
            }

            // Save employee data
            int id = Convert.ToInt32(txtID.Text);
            string name = txtNameDA.Text;
            string department = cbDepartamentDA.Text;

            Employee employee = new Employee(id, name, department);

            using (BinaryWriter writer = new BinaryWriter(File.Open(FilePathEmployee, FileMode.Append)))
            {
                employee.WriteToFile(writer);
            }
            ClearFields();
            LoadData(); // Reload data in the DataGridView after adding a new employee
            MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                return;
            }

            int searchId = Convert.ToInt32(txtID.Text);
            Employee employee = SearchEmployeeByID(searchId);

            if (employee == null)
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ShowEmployeeData(employee);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                return;
            }

            int searchId = Convert.ToInt32(txtID.Text);
            Employee employee = SearchEmployeeByID(searchId);

            if (employee == null)
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            employee.Name = txtNameDA.Text;
            employee.Department = cbDepartamentDA.Text;
            UpdateEmployee(employee);
            ClearFields();
            LoadData(); // Reload data in the DataGridView after updating an employee
            MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                return;
            }

            int searchId = Convert.ToInt32(txtID.Text);
            Employee employee = SearchEmployeeByID(searchId);

            if (employee == null)
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DeleteEmployee(employee);
            ClearFields();
            LoadData(); // Reload data in the DataGridView after deleting an employee
            MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion


    }

}