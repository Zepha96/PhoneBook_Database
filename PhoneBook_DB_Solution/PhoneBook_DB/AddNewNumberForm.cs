using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook_DB
{
    public partial class AddNewNumberForm : MaterialSkin.Controls.MaterialForm
    {
        public AddNewNumberForm()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.ROBOTO_REGULAR_11 = new Font("Century Gothic", 11f, FontStyle.Regular);
            //materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Century Gothic", 12f, FontStyle.Bold);
            //materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Century Gothic", 11f, FontStyle.Regular);
            //materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Century Gothic", 10f, FontStyle.Bold);
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue500,
            //                                                               MaterialSkin.Primary.LightBlue800,
            //                                                               MaterialSkin.Primary.LightBlue200,
            //                                                               MaterialSkin.Accent.Pink400,
            //                                                               MaterialSkin.TextShade.WHITE);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void AddNewNumberForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pb_dataset.phone_book_table' table. You can move, or remove it, as needed.
            this.phone_book_tableTableAdapter.Fill(this.pb_dataset.phone_book_table);
            
        }

        private void phone_book_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_book_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pb_dataset);
            MessageBox.Show("Data saved successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.groupBoxInfo.Enabled = false;
        }

        // ----------------------------First Name
        private void textboxMS_FirstName_Click(object sender, EventArgs e)
        {
            
        }

        private void textboxMS_FirstName_TextChanged(object sender, EventArgs e)
        {
            
            first_NameTextBox.Text = this.textboxMS_FirstName.Text;
        }
        private void textboxMS_FirstName_Leave(object sender, EventArgs e)
        {

        }
        //------------------------------------------------
        //------------------------------LastName
        private void textboxMS_LastName_Click(object sender, EventArgs e)
        {

        }

        private void textboxMS_LastName_TextChanged(object sender, EventArgs e)
        {
            last_NameTextBox.Text = this.textboxMS_LastName.Text;
        }
        //------------------------------------------------
        //------------------------------Customer ID
        private void textboxMS_CustomerID_Click(object sender, EventArgs e)
        {

        }

        private void textboxMS_CustomerID_TextChanged(object sender, EventArgs e)
        {
            customer_IDTextBox.Text = this.textboxMS_CustomerID.Text;
        }
        //------------------------------------------------
        //------------------------------Gender
        private void textboxMS_Gender_Click(object sender, EventArgs e)
        {

        }

        private void textboxMS_Gender_TextChanged(object sender, EventArgs e)
        {
            genderTextBox.Text = this.textboxMS_Gender.Text;
        }
        //------------------------------------------------
        //------------------------------Education
        private void textboxMS_Education_Click(object sender, EventArgs e)
        {

        }

        private void textboxMS_Education_TextChanged(object sender, EventArgs e)
        {
            educationTextBox.Text = this.textboxMS_Education.Text;
        }
        //------------------------------------------------
        //------------------------------StudyField
        private void textboxMS_StudyField_Click(object sender, EventArgs e)
        {

        }

        private void textboxMS_StudyField_TextChanged(object sender, EventArgs e)
        {
            study_FieldTextBox.Text = this.textboxMS_StudyField.Text;
        }
        //------------------------------------------------
        //------------------------------Phone1
        private void textboxMS_Phone1_Click(object sender, EventArgs e)
        {

        }

        private void textboxMS_Phone1_TextChanged(object sender, EventArgs e)
        {
            phone1TextBox.Text = this.textboxMS_Phone1.Text;
        }
        //------------------------------------------------
        //------------------------------Phone2
        private void textboxMS_Phone2_Click(object sender, EventArgs e)
        {

        }

        private void textboxMS_Phone2_TextChanged(object sender, EventArgs e)
        {
            phone2TextBox.Text = this.textboxMS_Phone2.Text;
        }
        //------------------------------------------------
        //------------------------------Email
        private void textboxMS_Email_TextChanged(object sender, EventArgs e)
        {
            emailTextBox.Text = this.textboxMS_Email.Text;
        }

        private void textboxMS_webURL_TextChanged(object sender, EventArgs e)
        {
            web_URLTextBox.Text = this.textboxMS_webURL.Text;
        }

        private void textboxMS_Country_TextChanged(object sender, EventArgs e)
        {
            countryTextBox.Text = this.textboxMS_Country.Text;
        }

        private void textboxMS_State_TextChanged(object sender, EventArgs e)
        {
            stateTextBox.Text = this.textboxMS_State.Text;
        }

        private void textboxMS_City_TextChanged(object sender, EventArgs e)
        {
            cityTextBox.Text = this.textboxMS_City.Text;
        }

        private void textboxMS_ZIPCode_TextChanged(object sender, EventArgs e)
        {
            zIP_CodeTextBox.Text = this.textboxMS_ZIPCode.Text;
        }

        private void textboxMS_Address1_TextChanged(object sender, EventArgs e)
        {
            address1TextBox.Text = this.textboxMS_Address1.Text;
        }

        private void textboxMS_Address2_TextChanged(object sender, EventArgs e)
        {
            address2TextBox.Text = this.textboxMS_Address2.Text;
        }

        private void textboxMS_Description_TextChanged(object sender, EventArgs e)
        {
            descriptionTextBox.Text = this.textboxMS_Description.Text;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.groupBoxInfo.Enabled = true;
            this.phone_book_tableBindingNavigatorSaveItem.Enabled = true;
            this.textboxMS_FirstName.Text = null;
            this.textboxMS_LastName.Text = null;
            this.textboxMS_CustomerID.Text = null;
            this.textboxMS_Gender.Text = null;
            this.textboxMS_Education.Text = null;
            this.textboxMS_StudyField.Text = null;
            this.textboxMS_Phone1.Text = null;
            this.textboxMS_Phone2.Text = null;
            this.textboxMS_Email.Text = null;
            this.textboxMS_webURL.Text = null;
            this.textboxMS_Country.Text = null;
            this.textboxMS_State.Text = null;
            this.textboxMS_City.Text = null;
            this.textboxMS_ZIPCode.Text = null;
            this.textboxMS_Address1.Text = null;
            this.textboxMS_Address2.Text = null;
            this.textboxMS_Description.Text = null;
            
        }

        private void toolStripButton_Close_Click(object sender, EventArgs e)
        {
            //Form1 grid = new Form1();
            //this.phone_book_tableTableAdapter.Fill(this.pb_dataset.phone_book_table);
            //grid.phone_book_tableDataGridView.Update();
            //grid.phone_book_tableDataGridView.Refresh();

            this.Close();
        }

    }
}
