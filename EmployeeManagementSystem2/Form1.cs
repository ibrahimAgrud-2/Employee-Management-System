using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagementSystem2
{
    public partial class Form1 : Form
    {
        /// <summary>Initializes a new instance of the Form1 class.</summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>Sets initial control states and verifies inputs when the form loads.</summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            rbDetails.Checked = true;
            rbMale.Checked = true;
            cbPhoneCode.SelectedIndex = 0;
            verifyInputs();
            
        }

        //=================================GLobal variable Section===============================

        /// <summary>Stores a reference to the currently selected ListViewItem for update operations.</summary>
        ListViewItem currentEmployee = new ListViewItem();

        /// <summary>A structure to hold detailed information about an employee.</summary>
        struct employeeInfo
        {
            public string ID;
            public string fullName;
            public string department;
            public string Job;
            public string Salary;
            public string PhoneCode;
            public string PhoneNumber;
            public string hireDate;
            public string email;
        }
        //============================================================================


        //========================== Functions that are independent of UI=====================

        /// <summary>Checks if all MaskedTextBox controls in 'gbRequiredFields' have completed masks.</summary>
        bool isEmailValid(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            if (!char.IsLetterOrDigit(email[0]) || email.Length <= 6)
            {
                return false;
            }
            foreach (char c in email)
            {
                if (!(Char.IsLetterOrDigit(c) || c == '.'))
                {
                    return false;
                }
            }
            return true;
            //or 
            /* 
                          var regex = new Regex(@"^[a-zA-Z0-9](\.?[a-zA-Z0-9]){5,34}$");
                           return regex.IsMatch(email);


            */
        }
        //============================================================================

        private bool verifyInputs()
        {
            bool isAllInputsCorrect = true;
            foreach (Control item in gbRequiredFields.Controls)
            {
                if (item is MaskedTextBox)
                {
                    if (!isMaskInputCorrect(item))
                    {
                        isAllInputsCorrect = false;
                    }
                }
            }
           
            return isAllInputsCorrect;
        }

        /// <summary>Sets an ErrorProvider or 'OK' provider message for a control, clearing the other.</summary>
        private void setProvider(Control control, ErrorProvider provider, string message)
        {
            if (provider != errorProvider1)
            {
                errorProvider1.SetError(control, null);
                okProvider.SetError(control, message);
            }
            else
            {
                okProvider.SetError(control, null);
                errorProvider1.SetError(control, message);
            }
        }

        /// <summary>Validates if a MaskedTextBox's mask is complete and provides visual feedback.</summary>
        private bool isMaskInputCorrect(object sender)
        {
            MaskedTextBox msk = (MaskedTextBox)sender;
            if (sender == mskEmail)
            {
                if (isEmailValid(mskEmail.Text))
                {
                    setProvider(lblGmail, okProvider, "Successfully");
                    return true;
                }
                else
                {
                    return false;
                }
            }
         
            if (msk.MaskCompleted)
            {
                setProvider(msk, okProvider, "Successfully");
                return true;
            }
            else
            {
                setProvider(msk, errorProvider1, msk.Tag.ToString());
                return false;
            }
        }

        /// <summary>Checks if an employee with the given ID already exists in the ListView.</summary>
        bool isEmployeeExist(string employeeId)
        {
            if (listView1.Items.ContainsKey(employeeId))
            {
                return true;
            }
            return false;
        }

        /// <summary>Displays a notification message to the user using a NotifyIcon balloon tip.</summary>
        void notifyUser(string messageToUser, ToolTipIcon icon)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.Text = messageToUser;
            notifyIcon1.BalloonTipIcon = icon;
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipText = messageToUser;
            notifyIcon1.ShowBalloonTip(3000);
        }

        /// <summary>Adds a new employee's information from an 'employeeInfo' struct to the ListView.</summary>
        private void addDataToList(employeeInfo employeeInfoToAdd)
        {
            ListViewItem newItem = new ListViewItem();
            newItem.Name = employeeInfoToAdd.ID;
            newItem.Text = employeeInfoToAdd.ID;
            newItem.SubItems.Add(employeeInfoToAdd.fullName);
            newItem.SubItems.Add(employeeInfoToAdd.department);
            newItem.SubItems.Add(employeeInfoToAdd.Job);
            newItem.SubItems.Add(employeeInfoToAdd.Salary);
            newItem.SubItems.Add(employeeInfoToAdd.hireDate);
            newItem.SubItems.Add(employeeInfoToAdd.PhoneCode);
            newItem.SubItems.Add(employeeInfoToAdd.PhoneNumber);
            newItem.SubItems.Add(employeeInfoToAdd.email);
            newItem.SubItems.Add("@gmail.com");


            if (rbMale.Checked)
            {
                newItem.ImageIndex = 0;
            }
            else
            {
                newItem.ImageIndex = 1;
            }
            listView1.Items.Add(newItem);
        }

        /// <summary>Collects all employee information from the form's input fields into an 'employeeInfo' struct.</summary>
        private employeeInfo collectInfo()
        {
            employeeInfo collectedInfo = new employeeInfo();
            collectedInfo.ID = mskID.Text;
            collectedInfo.fullName = mskFullName.Text;
            collectedInfo.department = mskDepartment.Text;
            collectedInfo.Job = mskJob.Text;
            collectedInfo.Salary = mskSalary.Text;
            collectedInfo.hireDate = dateTimePicker1.Text;
            collectedInfo.PhoneCode = cbPhoneCode.Text;
            collectedInfo.PhoneNumber = mskPhoneNumber.Text;
            collectedInfo.email= mskEmail.Text;
            return collectedInfo;
        }

        /// <summary>Retrieves an employee's data from the ListView by ID and returns it as a list of strings.</summary>
        List<string> addDataFromListToCollection(string employeeID)
        {
            sbyte indexOfItem = (sbyte)listView1.Items.IndexOfKey(employeeID);
            List<string> fields = new List<string>();
            if (indexOfItem != -1)
            {
                ListViewItem item = listView1.Items[listView1.Items.IndexOfKey(employeeID)];
                for (int i = 0; i < 10; i++)
                {
                  
                    fields.Add(item.SubItems[i].Text);
                }
            }
            return fields;
        }

        //============================================================================


        //=======================Add employee section==================

        /// <summary>Attempts to add a new employee, checking for existence and input validity.</summary>
        private bool addEmployeeToList()
        {
            if (isEmployeeExist(mskID.Text))
            {
                notifyUser("This Employee is already exist", ToolTipIcon.Error);
                return false;
            }
            if (!verifyInputs())
            {
                notifyUser("Please fill in the required fields", ToolTipIcon.Error);
                return false;
            }
            addDataToList(collectInfo());
            return true;
        }

        /// <summary>Handles the 'Add' button click, adding a new employee if valid.</summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (addEmployeeToList())
            {
                clearAllField();
                notifyUser("Employee Added Successfully", ToolTipIcon.Info);
            }
        }

        //============================================================================

        //=======================REMOVE SECTION=============================

        /// <summary>Fills the 'Remove Employee' section's labels with the employee's details.</summary>
        void fillEmployeeToRemove()
        {
            List<string> fields = addDataFromListToCollection(mskIDRemove.Text);
            if (fields.Count > 0)
            {
                lblFullName.Text = fields[1];
                lblDeparment.Text = fields[2];
                lblJob.Text = fields[3];
                lblSalary.Text = fields[4];
                lblHireDate.Text = fields[5];
                lblPhoneNuber.Text = fields[7];
                lblEmail.Text = fields[8]+"@gmail.com";
            }

        }

        /// <summary>Validates and populates employee details in the remove section as ID is typed.</summary>
        private void mskIdFroRemove_TextChanged(object sender, EventArgs e)
        {
            if (isEmployeeExist(mskIDRemove.Text))
            {
                fillEmployeeToRemove();
                setProvider(mskIDRemove, okProvider, "Successfully");
                if (currentEmployee.Text == mskIDRemove.Text)
                {
                    clearAllField();
                }
            }
            else
            {
                setProvider(mskIDRemove, errorProvider1, "ID Does not exist");
                clearRemoveSection();
            }
        }

        /// <summary>Resets all employee info labels in the remove section to "Not Found".</summary>
        private void clearRemoveSection()
        {
            foreach (Control item in gbEmployeeInfo.Controls)
            {
                if (item is Label)
                {
                    item.Text = "Not Found";
                }
            }
        }

        /// <summary>Displays a confirmation dialog and returns true if the user clicks 'OK'.</summary>
        bool GetConfirmationUser(string warningMessage)
        {
            return MessageBox.Show(warningMessage, "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK;
        }

        /// <summary>Handles the 'Remove' button click, removing an employee after confirmation.</summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (isEmployeeExist(mskIDRemove.Text))
            {
                if (GetConfirmationUser("Are you sure you want to remove this employee"))
                {
                    sbyte indexOfItem = (sbyte)listView1.Items.IndexOfKey(mskIDRemove.Text);
                    if (indexOfItem >= 0)
                    {
                        listView1.Items.RemoveAt(indexOfItem);
                        clearRemoveSection();
                        okProvider.SetError(mskIDRemove, null);
                        mskIDRemove.Clear();
                        notifyUser("Employee removed successfully", ToolTipIcon.Info);
                    }

                }
            }
        }


        //============================================================================


        //=========================UPDATE SECTION===============================

        /// <summary>Updates an existing employee's information in the ListView, handling ID changes with confirmation.</summary>
        private bool updateEmployee()
        {
            if (!verifyInputs())
            {
                notifyUser("Please fill in the required fields", ToolTipIcon.Error);
                return false;
            }

            if (isEmployeeExist(mskID.Text))
            {
                if (currentEmployee.Text != mskID.Text)
                {
                    notifyUser("This ID is already taken", ToolTipIcon.Error);
                    mskID.Clear();
                    return false;
                }
            }
            else
            {
                if (GetConfirmationUser("Are you sure! you want to update employee ID"))
                {
                    currentEmployee.Text = mskID.Text;
                    currentEmployee.Name = mskID.Text;
                }
                else
                {
                    return false;
                }
            }
            currentEmployee.SubItems[1].Text = mskFullName.Text;
            currentEmployee.SubItems[2].Text = mskDepartment.Text;
            currentEmployee.SubItems[3].Text = mskJob.Text;
            currentEmployee.SubItems[4].Text = mskSalary.Text;
            currentEmployee.SubItems[5].Text = dateTimePicker1.Value.ToString("dd MMMMyyyy");
            currentEmployee.SubItems[6].Text = cbPhoneCode.Text;
            currentEmployee.SubItems[7].Text = mskPhoneNumber.Text;
            currentEmployee.SubItems[8].Text = mskEmail.Text;

            if (rbFemale.Checked)
            {
                currentEmployee.ImageIndex = 1;
            }
            else if (rbMale.Checked)
            {
                currentEmployee.ImageIndex = 0;
            }
            return true;
        }

        /// <summary>Handles the 'Update' button click, performing the employee update if valid.</summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (updateEmployee())
            {
                notifyUser("Employee updated successfully", ToolTipIcon.Info);
                clearAllField();
                btnUpdate.Enabled = false;
            }
        }


        //============================================================================

        /// <summary>Populates the main input fields with details of a specified employee ID.</summary>
        void FillFormWithEmployee(string employeeID)
        {
            List<string> fields = addDataFromListToCollection(employeeID);
            if (fields.Count > 0)
            {
                mskID.Text = fields[0];
                mskFullName.Text = fields[1];
                mskDepartment.Text = fields[2];
                mskJob.Text = fields[3];
                mskSalary.Text = fields[4];
                mskPhoneNumber.Text = fields[7];
                mskEmail.Text = fields[8];
            }
        }

        /// <summary>Handles the 'Search Employee' button click, filling the form if the employee exists.</summary>
        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            if (isEmployeeExist(mskID.Text))
            {
                FillFormWithEmployee(mskID.Text);
                btnUpdate.Enabled = true;

                if (mskID.Text is string)
                {
                    currentEmployee = listView1.Items[listView1.Items.IndexOfKey(mskID.Text)];
                }
            }
            else
            {
                notifyUser("Employee does not exist", ToolTipIcon.Error);
                btnUpdate.Enabled = false;
            }
        }

        /// <summary>Provides real-time validation feedback for MaskedTextBoxes as text changes.</summary>
        private void msk_TextChanged(object sender, EventArgs e)
        {
            isMaskInputCorrect(sender);
        }

        /// <summary>Defines an enumeration for different ListView display modes.</summary>
        enum listViews { details = 1, largeIcon = 2, title = 3, smallIcon = 4, list = 5 };

        /// <summary>Changes the ListView's display mode based on the selected RadioButton.</summary>
        private void rbCheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked)
            {
                return;
            }
            if (!int.TryParse(rb.Tag.ToString(), out int result))
            {
                return;
            }
            listViews viewType = (listViews)result;
            switch (viewType)
            {
                case listViews.details:
                    listView1.View = View.Details;
                    break;
                case listViews.largeIcon:
                    listView1.View = View.LargeIcon;
                    break;
                case listViews.title:
                    listView1.View = View.Tile;
                    break;
                case listViews.smallIcon:
                    listView1.View = View.SmallIcon;
                    break;
                case listViews.list:
                    listView1.View = View.List;
                    break;
                default:
                    break;
            }
        }

        /// <summary>Sets the PictureBox image to the male icon if the 'Male' radio button is checked.</summary>
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                if (imageList2.Images.Count > 0)
                {
                    pictureBox1.Image = imageList2.Images[0];
                }
            }
        }

        /// <summary>Sets the PictureBox image to the female icon if the 'Female' radio button is checked.</summary>
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                if (imageList2.Images.Count > 0)
                {
                    pictureBox1.Image = imageList2.Images[1];
                }
            }
        }

        /// <summary>Clears all main input fields on the form, with an option to clear the ID field.</summary>
        void clearAllField(bool clearID = true)
        {
            if (clearID)
            {
                mskID.Clear();
            }
            mskDepartment.Clear();
            mskFullName.Clear();
            mskJob.Clear();
            mskSalary.Clear();
            dateTimePicker1.Value = DateTime.Now;
            mskPhoneNumber.Clear();
            mskEmail.Clear();
            cbPhoneCode.SelectedIndex = 0;
        }

        /// <summary>Handles the 'Clear' button click, resetting all input fields.</summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllField(true);
        }

        private void mskEmail_TextChanged(object sender, EventArgs e)
        {
            if (isEmailValid(mskEmail.Text))
            {
                setProvider(lblGmail, okProvider, "Successfully");
            }
            else
            {
                setProvider(lblGmail, errorProvider1, "Email invalid");
            }
        }



        //=======================Email=========================================


    }
}