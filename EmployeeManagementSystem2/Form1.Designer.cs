namespace EmployeeManagementSystem2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbAddUpdateEmployee = new System.Windows.Forms.TabPage();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbRequiredFields = new System.Windows.Forms.GroupBox();
            this.mskEmail = new System.Windows.Forms.MaskedTextBox();
            this.lblGmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.mskFullName = new System.Windows.Forms.MaskedTextBox();
            this.mskDepartment = new System.Windows.Forms.MaskedTextBox();
            this.mskJob = new System.Windows.Forms.MaskedTextBox();
            this.mskSalary = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPhoneCode = new System.Windows.Forms.ComboBox();
            this.mskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRemoveEmployee = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDeparment = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.visibleLabel = new System.Windows.Forms.Label();
            this.lblPhoneNuber = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mskIDRemove = new System.Windows.Forms.MaskedTextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbEmployeeInfo = new System.Windows.Forms.TabPage();
            this.rbLargeIcon = new System.Windows.Forms.RadioButton();
            this.rbDetails = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbSmallIcon = new System.Windows.Forms.RadioButton();
            this.rbTitle = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.okProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tbAddUpdateEmployee.SuspendLayout();
            this.gbRequiredFields.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbRemoveEmployee.SuspendLayout();
            this.gbEmployeeInfo.SuspendLayout();
            this.tbEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbAddUpdateEmployee);
            this.tabControl1.Controls.Add(this.tbRemoveEmployee);
            this.tabControl1.Controls.Add(this.tbEmployeeInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 193);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1387, 569);
            this.tabControl1.TabIndex = 72;
            // 
            // tbAddUpdateEmployee
            // 
            this.tbAddUpdateEmployee.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbAddUpdateEmployee.Controls.Add(this.btnSearchEmployee);
            this.tbAddUpdateEmployee.Controls.Add(this.btnUpdate);
            this.tbAddUpdateEmployee.Controls.Add(this.gbRequiredFields);
            this.tbAddUpdateEmployee.Controls.Add(this.btnClear);
            this.tbAddUpdateEmployee.Controls.Add(this.groupBox1);
            this.tbAddUpdateEmployee.Controls.Add(this.dateTimePicker1);
            this.tbAddUpdateEmployee.Controls.Add(this.btnAdd);
            this.tbAddUpdateEmployee.Controls.Add(this.label6);
            this.tbAddUpdateEmployee.Location = new System.Drawing.Point(4, 34);
            this.tbAddUpdateEmployee.Name = "tbAddUpdateEmployee";
            this.tbAddUpdateEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddUpdateEmployee.Size = new System.Drawing.Size(1379, 531);
            this.tbAddUpdateEmployee.TabIndex = 0;
            this.tbAddUpdateEmployee.Text = "Add-Update employee";
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackColor = System.Drawing.Color.White;
            this.btnSearchEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnSearchEmployee.Location = new System.Drawing.Point(672, 446);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(195, 69);
            this.btnSearchEmployee.TabIndex = 62;
            this.btnSearchEmployee.Text = "Search Employee";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(439, 444);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 69);
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbRequiredFields
            // 
            this.gbRequiredFields.Controls.Add(this.mskEmail);
            this.gbRequiredFields.Controls.Add(this.lblGmail);
            this.gbRequiredFields.Controls.Add(this.label1);
            this.gbRequiredFields.Controls.Add(this.mskID);
            this.gbRequiredFields.Controls.Add(this.mskFullName);
            this.gbRequiredFields.Controls.Add(this.mskDepartment);
            this.gbRequiredFields.Controls.Add(this.mskJob);
            this.gbRequiredFields.Controls.Add(this.mskSalary);
            this.gbRequiredFields.Controls.Add(this.label7);
            this.gbRequiredFields.Controls.Add(this.cbPhoneCode);
            this.gbRequiredFields.Controls.Add(this.mskPhoneNumber);
            this.gbRequiredFields.Controls.Add(this.label3);
            this.gbRequiredFields.Controls.Add(this.label8);
            this.gbRequiredFields.Controls.Add(this.label2);
            this.gbRequiredFields.Controls.Add(this.label5);
            this.gbRequiredFields.Controls.Add(this.label4);
            this.gbRequiredFields.Location = new System.Drawing.Point(220, 38);
            this.gbRequiredFields.Name = "gbRequiredFields";
            this.gbRequiredFields.Size = new System.Drawing.Size(940, 312);
            this.gbRequiredFields.TabIndex = 60;
            this.gbRequiredFields.TabStop = false;
            this.gbRequiredFields.Text = "Required Information";
            // 
            // mskEmail
            // 
            this.mskEmail.HidePromptOnLeave = true;
            this.mskEmail.Location = new System.Drawing.Point(620, 235);
            this.mskEmail.Margin = new System.Windows.Forms.Padding(2);
            this.mskEmail.Name = "mskEmail";
            this.mskEmail.PromptChar = ' ';
            this.mskEmail.ResetOnSpace = false;
            this.mskEmail.Size = new System.Drawing.Size(169, 30);
            this.mskEmail.TabIndex = 64;
            this.mskEmail.Tag = "Job";
            this.mskEmail.TextChanged += new System.EventHandler(this.mskEmail_TextChanged);
            // 
            // lblGmail
            // 
            this.lblGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGmail.Location = new System.Drawing.Point(786, 235);
            this.lblGmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(127, 30);
            this.lblGmail.TabIndex = 63;
            this.lblGmail.Text = "@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(524, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Email : ";
            // 
            // mskID
            // 
            this.mskID.HidePromptOnLeave = true;
            this.mskID.Location = new System.Drawing.Point(200, 67);
            this.mskID.Margin = new System.Windows.Forms.Padding(2);
            this.mskID.Mask = "000";
            this.mskID.Name = "mskID";
            this.mskID.PromptChar = ' ';
            this.mskID.ResetOnSpace = false;
            this.mskID.Size = new System.Drawing.Size(169, 30);
            this.mskID.TabIndex = 0;
            this.mskID.Tag = "ID must contains 11 digit";
            this.mskID.TextChanged += new System.EventHandler(this.msk_TextChanged);
            // 
            // mskFullName
            // 
            this.mskFullName.HidePromptOnLeave = true;
            this.mskFullName.Location = new System.Drawing.Point(200, 109);
            this.mskFullName.Margin = new System.Windows.Forms.Padding(2);
            this.mskFullName.Mask = "LL???????????????????????????????????????????";
            this.mskFullName.Name = "mskFullName";
            this.mskFullName.PromptChar = ' ';
            this.mskFullName.ResetOnSpace = false;
            this.mskFullName.Size = new System.Drawing.Size(169, 30);
            this.mskFullName.TabIndex = 1;
            this.mskFullName.Tag = "Full name";
            this.mskFullName.TextChanged += new System.EventHandler(this.msk_TextChanged);
            // 
            // mskDepartment
            // 
            this.mskDepartment.HidePromptOnLeave = true;
            this.mskDepartment.Location = new System.Drawing.Point(200, 165);
            this.mskDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.mskDepartment.Mask = "LL????????????????";
            this.mskDepartment.Name = "mskDepartment";
            this.mskDepartment.PromptChar = ' ';
            this.mskDepartment.ResetOnSpace = false;
            this.mskDepartment.Size = new System.Drawing.Size(169, 30);
            this.mskDepartment.TabIndex = 2;
            this.mskDepartment.Tag = "Departmant";
            this.mskDepartment.TextChanged += new System.EventHandler(this.msk_TextChanged);
            // 
            // mskJob
            // 
            this.mskJob.HidePromptOnLeave = true;
            this.mskJob.Location = new System.Drawing.Point(620, 67);
            this.mskJob.Margin = new System.Windows.Forms.Padding(2);
            this.mskJob.Mask = "L????????????????????????????????????????????";
            this.mskJob.Name = "mskJob";
            this.mskJob.PromptChar = ' ';
            this.mskJob.ResetOnSpace = false;
            this.mskJob.Size = new System.Drawing.Size(169, 30);
            this.mskJob.TabIndex = 3;
            this.mskJob.Tag = "Job";
            this.mskJob.TextChanged += new System.EventHandler(this.msk_TextChanged);
            // 
            // mskSalary
            // 
            this.mskSalary.HidePromptOnLeave = true;
            this.mskSalary.Location = new System.Drawing.Point(620, 126);
            this.mskSalary.Margin = new System.Windows.Forms.Padding(2);
            this.mskSalary.Mask = "099999999999";
            this.mskSalary.Name = "mskSalary";
            this.mskSalary.PromptChar = ' ';
            this.mskSalary.ResetOnSpace = false;
            this.mskSalary.Size = new System.Drawing.Size(169, 30);
            this.mskSalary.TabIndex = 4;
            this.mskSalary.Tag = "Salary";
            this.mskSalary.TextChanged += new System.EventHandler(this.msk_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(440, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 26);
            this.label7.TabIndex = 46;
            this.label7.Text = "Phone Number : ";
            // 
            // cbPhoneCode
            // 
            this.cbPhoneCode.BackColor = System.Drawing.Color.AliceBlue;
            this.cbPhoneCode.DropDownHeight = 70;
            this.cbPhoneCode.DropDownWidth = 90;
            this.cbPhoneCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPhoneCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPhoneCode.FormattingEnabled = true;
            this.cbPhoneCode.IntegralHeight = false;
            this.cbPhoneCode.Items.AddRange(new object[] {
            "TR +90",
            "US +1",
            "GB +44",
            "DE +49",
            "FR +33",
            "IT +39",
            "ES +34",
            "RU +7",
            "CN +86",
            "JP +81",
            "IN +91",
            "BR +55",
            "CA +1",
            "AU +61",
            "ZA +27",
            "MX +52",
            "AR +54",
            "EG +20",
            "SA +966",
            "AE +971",
            "NL +31",
            "BE +32",
            "CH +41",
            "AT +43",
            "SE +46",
            "NO +47",
            "DK +45",
            "FI +358",
            "PL +48",
            "CZ +420",
            "GR +30",
            "PT +351",
            "IE +353",
            "NZ +64",
            "SG +65",
            "MY +60",
            "TH +66",
            "ID +62",
            "VN +84",
            "PH +63",
            "KR +82",
            "CL +56",
            "CO +57",
            "PE +51",
            "VE +58",
            "NG +234",
            "KE +254",
            "GH +233",
            "MA +212",
            "DZ +213"});
            this.cbPhoneCode.Location = new System.Drawing.Point(620, 184);
            this.cbPhoneCode.Margin = new System.Windows.Forms.Padding(4);
            this.cbPhoneCode.Name = "cbPhoneCode";
            this.cbPhoneCode.Size = new System.Drawing.Size(95, 30);
            this.cbPhoneCode.TabIndex = 57;
            this.cbPhoneCode.Tag = "Phone Code";
            // 
            // mskPhoneNumber
            // 
            this.mskPhoneNumber.HidePromptOnLeave = true;
            this.mskPhoneNumber.Location = new System.Drawing.Point(713, 184);
            this.mskPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.mskPhoneNumber.Mask = "000-000-0000";
            this.mskPhoneNumber.Name = "mskPhoneNumber";
            this.mskPhoneNumber.Size = new System.Drawing.Size(120, 30);
            this.mskPhoneNumber.TabIndex = 47;
            this.mskPhoneNumber.Tag = "Phone";
            this.mskPhoneNumber.TextChanged += new System.EventHandler(this.msk_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = " Employee ID : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(38, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 29);
            this.label8.TabIndex = 59;
            this.label8.Text = "Department : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Full Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(545, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "Job : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(518, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 41;
            this.label4.Text = "Salary : ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(919, 446);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(195, 69);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(216, 357);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(326, 65);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMale.Location = new System.Drawing.Point(79, 22);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(72, 28);
            this.rbMale.TabIndex = 52;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFemale.Location = new System.Drawing.Point(180, 22);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(95, 28);
            this.rbFemale.TabIndex = 51;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(830, 374);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 30);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(178, 446);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(195, 69);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(696, 375);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Hire Date :";
            // 
            // tbRemoveEmployee
            // 
            this.tbRemoveEmployee.Controls.Add(this.label14);
            this.tbRemoveEmployee.Controls.Add(this.label11);
            this.tbRemoveEmployee.Controls.Add(this.gbEmployeeInfo);
            this.tbRemoveEmployee.Controls.Add(this.label17);
            this.tbRemoveEmployee.Controls.Add(this.label19);
            this.tbRemoveEmployee.Controls.Add(this.label21);
            this.tbRemoveEmployee.Controls.Add(this.label13);
            this.tbRemoveEmployee.Controls.Add(this.label10);
            this.tbRemoveEmployee.Controls.Add(this.label9);
            this.tbRemoveEmployee.Controls.Add(this.mskIDRemove);
            this.tbRemoveEmployee.Controls.Add(this.btnRemove);
            this.tbRemoveEmployee.Location = new System.Drawing.Point(4, 34);
            this.tbRemoveEmployee.Name = "tbRemoveEmployee";
            this.tbRemoveEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tbRemoveEmployee.Size = new System.Drawing.Size(1379, 531);
            this.tbRemoveEmployee.TabIndex = 1;
            this.tbRemoveEmployee.Text = "Remove employee";
            this.tbRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(113, 439);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 29);
            this.label14.TabIndex = 77;
            this.label14.Text = "Email : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(23, 489);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 29);
            this.label11.TabIndex = 76;
            this.label11.Text = "Phone Number :";
            // 
            // gbEmployeeInfo
            // 
            this.gbEmployeeInfo.Controls.Add(this.lblEmail);
            this.gbEmployeeInfo.Controls.Add(this.lblFullName);
            this.gbEmployeeInfo.Controls.Add(this.lblDeparment);
            this.gbEmployeeInfo.Controls.Add(this.lblJob);
            this.gbEmployeeInfo.Controls.Add(this.lblSalary);
            this.gbEmployeeInfo.Controls.Add(this.lblHireDate);
            this.gbEmployeeInfo.Controls.Add(this.visibleLabel);
            this.gbEmployeeInfo.Controls.Add(this.lblPhoneNuber);
            this.gbEmployeeInfo.Location = new System.Drawing.Point(218, 101);
            this.gbEmployeeInfo.Name = "gbEmployeeInfo";
            this.gbEmployeeInfo.Size = new System.Drawing.Size(416, 455);
            this.gbEmployeeInfo.TabIndex = 75;
            this.gbEmployeeInfo.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(113, 338);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(126, 29);
            this.lblEmail.TabIndex = 75;
            this.lblEmail.Text = "Not Found";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFullName.Location = new System.Drawing.Point(113, 23);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(126, 29);
            this.lblFullName.TabIndex = 58;
            this.lblFullName.Text = "Not Found";
            // 
            // lblDeparment
            // 
            this.lblDeparment.AutoSize = true;
            this.lblDeparment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeparment.Location = new System.Drawing.Point(113, 100);
            this.lblDeparment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeparment.Name = "lblDeparment";
            this.lblDeparment.Size = new System.Drawing.Size(126, 29);
            this.lblDeparment.TabIndex = 69;
            this.lblDeparment.Text = "Not Found";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblJob.Location = new System.Drawing.Point(113, 169);
            this.lblJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(126, 29);
            this.lblJob.TabIndex = 70;
            this.lblJob.Text = "Not Found";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalary.Location = new System.Drawing.Point(113, 230);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(126, 29);
            this.lblSalary.TabIndex = 71;
            this.lblSalary.Text = "Not Found";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHireDate.Location = new System.Drawing.Point(113, 287);
            this.lblHireDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(126, 29);
            this.lblHireDate.TabIndex = 72;
            this.lblHireDate.Text = "Not Found";
            // 
            // visibleLabel
            // 
            this.visibleLabel.AutoSize = true;
            this.visibleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.visibleLabel.Location = new System.Drawing.Point(113, 348);
            this.visibleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visibleLabel.Name = "visibleLabel";
            this.visibleLabel.Size = new System.Drawing.Size(0, 29);
            this.visibleLabel.TabIndex = 61;
            this.visibleLabel.Visible = false;
            // 
            // lblPhoneNuber
            // 
            this.lblPhoneNuber.AutoSize = true;
            this.lblPhoneNuber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNuber.Location = new System.Drawing.Point(113, 388);
            this.lblPhoneNuber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNuber.Name = "lblPhoneNuber";
            this.lblPhoneNuber.Size = new System.Drawing.Size(126, 29);
            this.lblPhoneNuber.TabIndex = 74;
            this.lblPhoneNuber.Text = "Not Found";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(113, 331);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 29);
            this.label17.TabIndex = 67;
            this.label17.Text = "Salary : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(79, 388);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 29);
            this.label19.TabIndex = 65;
            this.label19.Text = "Hire Date : ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(140, 270);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 29);
            this.label21.TabIndex = 63;
            this.label21.Text = "Job : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(50, 197);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 29);
            this.label13.TabIndex = 59;
            this.label13.Text = " Departmant : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(69, 124);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 29);
            this.label10.TabIndex = 57;
            this.label10.Text = "Full Name : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(36, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 29);
            this.label9.TabIndex = 56;
            this.label9.Text = " Employee ID : ";
            // 
            // mskIDRemove
            // 
            this.mskIDRemove.HidePromptOnLeave = true;
            this.mskIDRemove.Location = new System.Drawing.Point(217, 68);
            this.mskIDRemove.Margin = new System.Windows.Forms.Padding(2);
            this.mskIDRemove.Mask = "000";
            this.mskIDRemove.Name = "mskIDRemove";
            this.mskIDRemove.PromptChar = ' ';
            this.mskIDRemove.ResetOnSpace = false;
            this.mskIDRemove.Size = new System.Drawing.Size(169, 30);
            this.mskIDRemove.TabIndex = 55;
            this.mskIDRemove.Tag = "ID Dont exist";
            this.mskIDRemove.TextChanged += new System.EventHandler(this.mskIdFroRemove_TextChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(651, 113);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(169, 53);
            this.btnRemove.TabIndex = 54;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbEmployeeInfo
            // 
            this.tbEmployeeInfo.Controls.Add(this.rbLargeIcon);
            this.tbEmployeeInfo.Controls.Add(this.rbDetails);
            this.tbEmployeeInfo.Controls.Add(this.listView1);
            this.tbEmployeeInfo.Controls.Add(this.rbList);
            this.tbEmployeeInfo.Controls.Add(this.rbSmallIcon);
            this.tbEmployeeInfo.Controls.Add(this.rbTitle);
            this.tbEmployeeInfo.Location = new System.Drawing.Point(4, 34);
            this.tbEmployeeInfo.Name = "tbEmployeeInfo";
            this.tbEmployeeInfo.Size = new System.Drawing.Size(1379, 531);
            this.tbEmployeeInfo.TabIndex = 2;
            this.tbEmployeeInfo.Text = "Show All Employee";
            this.tbEmployeeInfo.UseVisualStyleBackColor = true;
            // 
            // rbLargeIcon
            // 
            this.rbLargeIcon.AutoSize = true;
            this.rbLargeIcon.Location = new System.Drawing.Point(1243, 104);
            this.rbLargeIcon.Margin = new System.Windows.Forms.Padding(4);
            this.rbLargeIcon.Name = "rbLargeIcon";
            this.rbLargeIcon.Size = new System.Drawing.Size(125, 29);
            this.rbLargeIcon.TabIndex = 8;
            this.rbLargeIcon.TabStop = true;
            this.rbLargeIcon.Tag = "2";
            this.rbLargeIcon.Text = "Large Icon";
            this.rbLargeIcon.UseVisualStyleBackColor = true;
            this.rbLargeIcon.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbDetails
            // 
            this.rbDetails.AutoSize = true;
            this.rbDetails.Location = new System.Drawing.Point(874, 104);
            this.rbDetails.Margin = new System.Windows.Forms.Padding(4);
            this.rbDetails.Name = "rbDetails";
            this.rbDetails.Size = new System.Drawing.Size(92, 29);
            this.rbDetails.TabIndex = 4;
            this.rbDetails.TabStop = true;
            this.rbDetails.Tag = "1";
            this.rbDetails.Text = "Details";
            this.rbDetails.UseVisualStyleBackColor = true;
            this.rbDetails.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.Column,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(2, 153);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1381, 375);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 58;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Full Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Department";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Job";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Salary";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hire Date";
            this.columnHeader6.Width = 150;
            // 
            // Column
            // 
            this.Column.Text = "";
            this.Column.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Phone Number";
            this.columnHeader7.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Email";
            this.columnHeader8.Width = 90;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "icons8-male-user-64.png");
            this.imageList2.Images.SetKeyName(1, "icons8-female-user-64.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-male-user-64.png");
            this.imageList1.Images.SetKeyName(1, "icons8-female-user-64.png");
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(1136, 104);
            this.rbList.Margin = new System.Windows.Forms.Padding(4);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(56, 29);
            this.rbList.TabIndex = 7;
            this.rbList.TabStop = true;
            this.rbList.Tag = "3";
            this.rbList.Text = "list";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbSmallIcon
            // 
            this.rbSmallIcon.AutoSize = true;
            this.rbSmallIcon.Location = new System.Drawing.Point(701, 104);
            this.rbSmallIcon.Margin = new System.Windows.Forms.Padding(4);
            this.rbSmallIcon.Name = "rbSmallIcon";
            this.rbSmallIcon.Size = new System.Drawing.Size(123, 29);
            this.rbSmallIcon.TabIndex = 5;
            this.rbSmallIcon.TabStop = true;
            this.rbSmallIcon.Tag = "3";
            this.rbSmallIcon.Text = "Small icon";
            this.rbSmallIcon.UseVisualStyleBackColor = true;
            this.rbSmallIcon.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbTitle
            // 
            this.rbTitle.AutoSize = true;
            this.rbTitle.Location = new System.Drawing.Point(1015, 104);
            this.rbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.rbTitle.Name = "rbTitle";
            this.rbTitle.Size = new System.Drawing.Size(70, 29);
            this.rbTitle.TabIndex = 6;
            this.rbTitle.TabStop = true;
            this.rbTitle.Tag = "4";
            this.rbTitle.Text = "Title";
            this.rbTitle.UseVisualStyleBackColor = true;
            this.rbTitle.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // okProvider
            // 
            this.okProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.okProvider.ContainerControl = this;
            this.okProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("okProvider.Icon")));
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(491, 56);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(461, 32);
            this.label12.TabIndex = 74;
            this.label12.Text = "Employee Management System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EmployeeManagementSystem2.Properties.Resources.icons8_management_system_100;
            this.pictureBox2.Location = new System.Drawing.Point(370, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 102);
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::EmployeeManagementSystem2.Properties.Resources.question_mark_96;
            this.pictureBox1.Location = new System.Drawing.Point(1068, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "";
            this.columnHeader9.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1387, 762);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbAddUpdateEmployee.ResumeLayout(false);
            this.tbAddUpdateEmployee.PerformLayout();
            this.gbRequiredFields.ResumeLayout(false);
            this.gbRequiredFields.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbRemoveEmployee.ResumeLayout(false);
            this.tbRemoveEmployee.PerformLayout();
            this.gbEmployeeInfo.ResumeLayout(false);
            this.gbEmployeeInfo.PerformLayout();
            this.tbEmployeeInfo.ResumeLayout(false);
            this.tbEmployeeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbAddUpdateEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox mskSalary;
        private System.Windows.Forms.MaskedTextBox mskDepartment;
        private System.Windows.Forms.MaskedTextBox mskJob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.MaskedTextBox mskPhoneNumber;
        private System.Windows.Forms.MaskedTextBox mskFullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox mskID;
        private System.Windows.Forms.ComboBox cbPhoneCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tbRemoveEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbEmployeeInfo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDeparment;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label visibleLabel;
        private System.Windows.Forms.Label lblPhoneNuber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskIDRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TabPage tbEmployeeInfo;
        private System.Windows.Forms.RadioButton rbLargeIcon;
        private System.Windows.Forms.RadioButton rbDetails;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbSmallIcon;
        private System.Windows.Forms.RadioButton rbTitle;
        private System.Windows.Forms.GroupBox gbRequiredFields;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider okProvider;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader Column;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mskEmail;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

