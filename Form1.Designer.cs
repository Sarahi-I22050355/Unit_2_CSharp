namespace Unit_2_CSharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvEmployeeTable = new System.Windows.Forms.DataGridView();
            this.cbDepartament = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailSql = new System.Windows.Forms.TextBox();
            this.txtPhoneSql = new System.Windows.Forms.TextBox();
            this.txtNameSql = new System.Windows.Forms.TextBox();
            this.btnDeleteSql = new System.Windows.Forms.Button();
            this.btnUpdateSql = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNameDA = new System.Windows.Forms.TextBox();
            this.cbDepartamentDA = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvEmpTabl = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOpenDA = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpTabl)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.dgvEmployeeTable);
            this.tabPage1.Controls.Add(this.cbDepartament);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.txtAge);
            this.tabPage1.Controls.Add(this.txtSecondName);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnOpenFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(847, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sequential Operations";
            // 
            // dgvEmployeeTable
            // 
            this.dgvEmployeeTable.AllowUserToAddRows = false;
            this.dgvEmployeeTable.AllowUserToResizeColumns = false;
            this.dgvEmployeeTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmployeeTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeTable.EnableHeadersVisualStyles = false;
            this.dgvEmployeeTable.Location = new System.Drawing.Point(9, 68);
            this.dgvEmployeeTable.MultiSelect = false;
            this.dgvEmployeeTable.Name = "dgvEmployeeTable";
            this.dgvEmployeeTable.ReadOnly = true;
            this.dgvEmployeeTable.RowHeadersVisible = false;
            this.dgvEmployeeTable.RowHeadersWidth = 51;
            this.dgvEmployeeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeTable.Size = new System.Drawing.Size(503, 215);
            this.dgvEmployeeTable.StandardTab = true;
            this.dgvEmployeeTable.TabIndex = 17;
            // 
            // cbDepartament
            // 
            this.cbDepartament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartament.FormattingEnabled = true;
            this.cbDepartament.Items.AddRange(new object[] {
            "Office",
            "Library",
            "Servers",
            "Administration"});
            this.cbDepartament.Location = new System.Drawing.Point(613, 184);
            this.cbDepartament.Name = "cbDepartament";
            this.cbDepartament.Size = new System.Drawing.Size(154, 28);
            this.cbDepartament.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(552, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(523, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(523, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Departament";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(573, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(514, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Second name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "EMPLOYEE REGISTRATION";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(523, 288);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 35);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(613, 133);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(154, 27);
            this.txtAge.TabIndex = 7;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(613, 75);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(154, 27);
            this.txtSecondName.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(613, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 27);
            this.txtName.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(523, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenFile.Location = new System.Drawing.Point(9, 302);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(80, 45);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dgvContactos);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtEmailSql);
            this.tabPage2.Controls.Add(this.txtPhoneSql);
            this.tabPage2.Controls.Add(this.txtNameSql);
            this.tabPage2.Controls.Add(this.btnDeleteSql);
            this.tabPage2.Controls.Add(this.btnUpdateSql);
            this.tabPage2.Controls.Add(this.btnInsert);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(847, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Indexed Sequential Operations";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 37);
            this.label8.TabIndex = 29;
            this.label8.Text = "CONTACTS";
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToResizeColumns = false;
            this.dgvContactos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvContactos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NName,
            this.PPhone,
            this.EEmail});
            this.dgvContactos.EnableHeadersVisualStyles = false;
            this.dgvContactos.Location = new System.Drawing.Point(6, 52);
            this.dgvContactos.MultiSelect = false;
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            this.dgvContactos.RowHeadersVisible = false;
            this.dgvContactos.RowHeadersWidth = 51;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(567, 253);
            this.dgvContactos.StandardTab = true;
            this.dgvContactos.TabIndex = 28;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // NName
            // 
            this.NName.HeaderText = "Name";
            this.NName.MinimumWidth = 6;
            this.NName.Name = "NName";
            this.NName.ReadOnly = true;
            this.NName.Width = 125;
            // 
            // PPhone
            // 
            this.PPhone.HeaderText = "Phone";
            this.PPhone.MinimumWidth = 6;
            this.PPhone.Name = "PPhone";
            this.PPhone.ReadOnly = true;
            this.PPhone.Width = 125;
            // 
            // EEmail
            // 
            this.EEmail.HeaderText = "Email";
            this.EEmail.MinimumWidth = 6;
            this.EEmail.Name = "EEmail";
            this.EEmail.ReadOnly = true;
            this.EEmail.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(586, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(580, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(582, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Name";
            // 
            // txtEmailSql
            // 
            this.txtEmailSql.Location = new System.Drawing.Point(643, 147);
            this.txtEmailSql.Name = "txtEmailSql";
            this.txtEmailSql.Size = new System.Drawing.Size(202, 27);
            this.txtEmailSql.TabIndex = 23;
            // 
            // txtPhoneSql
            // 
            this.txtPhoneSql.Location = new System.Drawing.Point(643, 100);
            this.txtPhoneSql.Name = "txtPhoneSql";
            this.txtPhoneSql.Size = new System.Drawing.Size(202, 27);
            this.txtPhoneSql.TabIndex = 22;
            // 
            // txtNameSql
            // 
            this.txtNameSql.Location = new System.Drawing.Point(643, 52);
            this.txtNameSql.Name = "txtNameSql";
            this.txtNameSql.Size = new System.Drawing.Size(202, 27);
            this.txtNameSql.TabIndex = 21;
            // 
            // btnDeleteSql
            // 
            this.btnDeleteSql.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSql.Location = new System.Drawing.Point(670, 206);
            this.btnDeleteSql.Name = "btnDeleteSql";
            this.btnDeleteSql.Size = new System.Drawing.Size(86, 46);
            this.btnDeleteSql.TabIndex = 19;
            this.btnDeleteSql.Text = "Delete";
            this.btnDeleteSql.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSql
            // 
            this.btnUpdateSql.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateSql.Location = new System.Drawing.Point(762, 206);
            this.btnUpdateSql.Name = "btnUpdateSql";
            this.btnUpdateSql.Size = new System.Drawing.Size(86, 46);
            this.btnUpdateSql.TabIndex = 17;
            this.btnUpdateSql.Text = "Update";
            this.btnUpdateSql.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(578, 206);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 46);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Add";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txtNameDA);
            this.tabPage3.Controls.Add(this.cbDepartamentDA);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.txtID);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.dgvEmpTabl);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btnOpenDA);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(847, 413);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Direct Access";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(99, 297);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 46);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(442, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Name";
            // 
            // txtNameDA
            // 
            this.txtNameDA.Location = new System.Drawing.Point(503, 166);
            this.txtNameDA.Name = "txtNameDA";
            this.txtNameDA.Size = new System.Drawing.Size(129, 27);
            this.txtNameDA.TabIndex = 30;
            // 
            // cbDepartamentDA
            // 
            this.cbDepartamentDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamentDA.FormattingEnabled = true;
            this.cbDepartamentDA.Items.AddRange(new object[] {
            "Office",
            "Library",
            "Servers",
            "Administration"});
            this.cbDepartamentDA.Location = new System.Drawing.Point(503, 209);
            this.cbDepartamentDA.Name = "cbDepartamentDA";
            this.cbDepartamentDA.Size = new System.Drawing.Size(129, 28);
            this.cbDepartamentDA.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(638, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 46);
            this.button2.TabIndex = 28;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(387, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Departament";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(470, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "ID";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(638, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 46);
            this.button3.TabIndex = 24;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(503, 120);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 27);
            this.txtID.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(638, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 46);
            this.button4.TabIndex = 21;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvEmpTabl
            // 
            this.dgvEmpTabl.AllowUserToAddRows = false;
            this.dgvEmpTabl.AllowUserToResizeColumns = false;
            this.dgvEmpTabl.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmpTabl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEmpTabl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpTabl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5});
            this.dgvEmpTabl.EnableHeadersVisualStyles = false;
            this.dgvEmpTabl.Location = new System.Drawing.Point(3, 65);
            this.dgvEmpTabl.MultiSelect = false;
            this.dgvEmpTabl.Name = "dgvEmpTabl";
            this.dgvEmpTabl.ReadOnly = true;
            this.dgvEmpTabl.RowHeadersVisible = false;
            this.dgvEmpTabl.RowHeadersWidth = 51;
            this.dgvEmpTabl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpTabl.Size = new System.Drawing.Size(380, 215);
            this.dgvEmpTabl.StandardTab = true;
            this.dgvEmpTabl.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NAME";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DEPARTAMENT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(368, 37);
            this.label10.TabIndex = 19;
            this.label10.Text = "EMPLOYEE REGISTRATION";
            // 
            // btnOpenDA
            // 
            this.btnOpenDA.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenDA.Location = new System.Drawing.Point(3, 297);
            this.btnOpenDA.Name = "btnOpenDA";
            this.btnOpenDA.Size = new System.Drawing.Size(90, 45);
            this.btnOpenDA.TabIndex = 18;
            this.btnOpenDA.Text = "Open";
            this.btnOpenDA.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 439);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Unit 2 CSharp";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpTabl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnOpenFile;
        private Button btnSave;
        private TextBox txtAge;
        private TextBox txtSecondName;
        private TextBox txtName;
        private Button btnSearch;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Button btnDeleteSql;
        private Button btnUpdateSql;
        private Button btnInsert;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEmailSql;
        private TextBox txtPhoneSql;
        private TextBox txtNameSql;
        private Label label9;
        private ComboBox cbDepartament;
        private DataGridView dgvEmployeeTable;
        private DataGridView dgvContactos;
        private Label label8;
        private TabPage tabPage3;
        private DataGridView dgvEmpTabl;
        private Label label10;
        private Button btnOpenDA;
        private Label label14;
        private TextBox txtNameDA;
        private ComboBox cbDepartamentDA;
        private Button button2;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button button3;
        private TextBox txtAgeDA;
        private TextBox txtID;
        private Button button4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NName;
        private DataGridViewTextBoxColumn PPhone;
        private DataGridViewTextBoxColumn EEmail;
    }
}