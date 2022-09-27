namespace PhoneBook_DB
{
    partial class AddNewNumberForm
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label customer_IDLabel;
            System.Windows.Forms.Label birth_DateLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label educationLabel;
            System.Windows.Forms.Label study_FieldLabel;
            System.Windows.Forms.Label phone1Label;
            System.Windows.Forms.Label phone2Label;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label web_URLLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label zIP_CodeLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewNumberForm));
            this.pb_dataset = new PhoneBook_DB.Dataset.pb_dataset();
            this.phone_book_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phone_book_tableTableAdapter = new PhoneBook_DB.Dataset.pb_datasetTableAdapters.phone_book_tableTableAdapter();
            this.tableAdapterManager = new PhoneBook_DB.Dataset.pb_datasetTableAdapters.TableAdapterManager();
            this.textboxMS_FirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.customer_IDTextBox = new System.Windows.Forms.TextBox();
            this.birth_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.educationTextBox = new System.Windows.Forms.TextBox();
            this.study_FieldTextBox = new System.Windows.Forms.TextBox();
            this.phone1TextBox = new System.Windows.Forms.TextBox();
            this.phone2TextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.web_URLTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zIP_CodeTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.textboxMS_LastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_CustomerID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_Gender = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_Education = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_Phone1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_Phone2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_Email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_webURL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_Country = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_State = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_City = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_ZIPCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_Address1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_Address2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_Description = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxMS_StudyField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelMS_BirthDate = new MaterialSkin.Controls.MaterialLabel();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.phone_book_tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.phone_book_tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton_Close = new System.Windows.Forms.ToolStripButton();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            iDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            customer_IDLabel = new System.Windows.Forms.Label();
            birth_DateLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            educationLabel = new System.Windows.Forms.Label();
            study_FieldLabel = new System.Windows.Forms.Label();
            phone1Label = new System.Windows.Forms.Label();
            phone2Label = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            web_URLLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            zIP_CodeLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableBindingNavigator)).BeginInit();
            this.phone_book_tableBindingNavigator.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(581, 130);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(581, 156);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 4;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(581, 182);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 6;
            last_NameLabel.Text = "Last Name:";
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Location = new System.Drawing.Point(581, 208);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(68, 13);
            customer_IDLabel.TabIndex = 8;
            customer_IDLabel.Text = "Customer ID:";
            // 
            // birth_DateLabel
            // 
            birth_DateLabel.AutoSize = true;
            birth_DateLabel.ForeColor = System.Drawing.Color.White;
            birth_DateLabel.Location = new System.Drawing.Point(581, 238);
            birth_DateLabel.Name = "birth_DateLabel";
            birth_DateLabel.Size = new System.Drawing.Size(57, 13);
            birth_DateLabel.TabIndex = 10;
            birth_DateLabel.Text = "Birth Date:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(581, 260);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 12;
            genderLabel.Text = "Gender:";
            // 
            // educationLabel
            // 
            educationLabel.AutoSize = true;
            educationLabel.Location = new System.Drawing.Point(581, 286);
            educationLabel.Name = "educationLabel";
            educationLabel.Size = new System.Drawing.Size(58, 13);
            educationLabel.TabIndex = 14;
            educationLabel.Text = "Education:";
            // 
            // study_FieldLabel
            // 
            study_FieldLabel.AutoSize = true;
            study_FieldLabel.Location = new System.Drawing.Point(581, 312);
            study_FieldLabel.Name = "study_FieldLabel";
            study_FieldLabel.Size = new System.Drawing.Size(62, 13);
            study_FieldLabel.TabIndex = 16;
            study_FieldLabel.Text = "Study Field:";
            // 
            // phone1Label
            // 
            phone1Label.AutoSize = true;
            phone1Label.Location = new System.Drawing.Point(581, 338);
            phone1Label.Name = "phone1Label";
            phone1Label.Size = new System.Drawing.Size(47, 13);
            phone1Label.TabIndex = 18;
            phone1Label.Text = "Phone1:";
            // 
            // phone2Label
            // 
            phone2Label.AutoSize = true;
            phone2Label.Location = new System.Drawing.Point(581, 364);
            phone2Label.Name = "phone2Label";
            phone2Label.Size = new System.Drawing.Size(47, 13);
            phone2Label.TabIndex = 20;
            phone2Label.Text = "Phone2:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(581, 390);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Email:";
            // 
            // web_URLLabel
            // 
            web_URLLabel.AutoSize = true;
            web_URLLabel.Location = new System.Drawing.Point(581, 416);
            web_URLLabel.Name = "web_URLLabel";
            web_URLLabel.Size = new System.Drawing.Size(58, 13);
            web_URLLabel.TabIndex = 24;
            web_URLLabel.Text = "Web URL:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(581, 442);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 26;
            countryLabel.Text = "Country:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(581, 468);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 28;
            stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(581, 494);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 30;
            cityLabel.Text = "City:";
            // 
            // zIP_CodeLabel
            // 
            zIP_CodeLabel.AutoSize = true;
            zIP_CodeLabel.Location = new System.Drawing.Point(581, 520);
            zIP_CodeLabel.Name = "zIP_CodeLabel";
            zIP_CodeLabel.Size = new System.Drawing.Size(55, 13);
            zIP_CodeLabel.TabIndex = 32;
            zIP_CodeLabel.Text = "ZIP Code:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(581, 546);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(54, 13);
            address1Label.TabIndex = 34;
            address1Label.Text = "Address1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(581, 572);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(54, 13);
            address2Label.TabIndex = 36;
            address2Label.Text = "Address2:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(581, 598);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 38;
            descriptionLabel.Text = "Description:";
            // 
            // pb_dataset
            // 
            this.pb_dataset.DataSetName = "pb_dataset";
            this.pb_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phone_book_tableBindingSource
            // 
            this.phone_book_tableBindingSource.DataMember = "phone_book_table";
            this.phone_book_tableBindingSource.DataSource = this.pb_dataset;
            // 
            // phone_book_tableTableAdapter
            // 
            this.phone_book_tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.phone_book_tableTableAdapter = this.phone_book_tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = PhoneBook_DB.Dataset.pb_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textboxMS_FirstName
            // 
            this.textboxMS_FirstName.Depth = 0;
            this.textboxMS_FirstName.ForeColor = System.Drawing.Color.White;
            this.textboxMS_FirstName.Hint = "First Name";
            this.textboxMS_FirstName.Location = new System.Drawing.Point(6, 66);
            this.textboxMS_FirstName.MaxLength = 32767;
            this.textboxMS_FirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_FirstName.Name = "textboxMS_FirstName";
            this.textboxMS_FirstName.PasswordChar = '\0';
            this.textboxMS_FirstName.SelectedText = "";
            this.textboxMS_FirstName.SelectionLength = 0;
            this.textboxMS_FirstName.SelectionStart = 0;
            this.textboxMS_FirstName.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_FirstName.TabIndex = 0;
            this.textboxMS_FirstName.TabStop = false;
            this.textboxMS_FirstName.UseSystemPasswordChar = false;
            this.textboxMS_FirstName.Click += new System.EventHandler(this.textboxMS_FirstName_Click);
            this.textboxMS_FirstName.Leave += new System.EventHandler(this.textboxMS_FirstName_Leave);
            this.textboxMS_FirstName.TextChanged += new System.EventHandler(this.textboxMS_FirstName_TextChanged);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(655, 127);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 3;
            this.iDTextBox.TabStop = false;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(655, 153);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.ReadOnly = true;
            this.first_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.first_NameTextBox.TabIndex = 5;
            this.first_NameTextBox.TabStop = false;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(655, 179);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.ReadOnly = true;
            this.last_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.last_NameTextBox.TabIndex = 7;
            this.last_NameTextBox.TabStop = false;
            // 
            // customer_IDTextBox
            // 
            this.customer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Customer_ID", true));
            this.customer_IDTextBox.Location = new System.Drawing.Point(655, 205);
            this.customer_IDTextBox.Name = "customer_IDTextBox";
            this.customer_IDTextBox.ReadOnly = true;
            this.customer_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.customer_IDTextBox.TabIndex = 9;
            this.customer_IDTextBox.TabStop = false;
            // 
            // birth_DateDateTimePicker
            // 
            this.birth_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.phone_book_tableBindingSource, "Birth_Date", true));
            this.birth_DateDateTimePicker.Location = new System.Drawing.Point(6, 179);
            this.birth_DateDateTimePicker.Name = "birth_DateDateTimePicker";
            this.birth_DateDateTimePicker.Size = new System.Drawing.Size(237, 21);
            this.birth_DateDateTimePicker.TabIndex = 3;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(655, 257);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(200, 20);
            this.genderTextBox.TabIndex = 13;
            this.genderTextBox.TabStop = false;
            // 
            // educationTextBox
            // 
            this.educationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Education", true));
            this.educationTextBox.Location = new System.Drawing.Point(655, 283);
            this.educationTextBox.Name = "educationTextBox";
            this.educationTextBox.ReadOnly = true;
            this.educationTextBox.Size = new System.Drawing.Size(200, 20);
            this.educationTextBox.TabIndex = 15;
            this.educationTextBox.TabStop = false;
            // 
            // study_FieldTextBox
            // 
            this.study_FieldTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Study_Field", true));
            this.study_FieldTextBox.Location = new System.Drawing.Point(655, 309);
            this.study_FieldTextBox.Name = "study_FieldTextBox";
            this.study_FieldTextBox.ReadOnly = true;
            this.study_FieldTextBox.Size = new System.Drawing.Size(200, 20);
            this.study_FieldTextBox.TabIndex = 17;
            this.study_FieldTextBox.TabStop = false;
            // 
            // phone1TextBox
            // 
            this.phone1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Phone1", true));
            this.phone1TextBox.Location = new System.Drawing.Point(655, 335);
            this.phone1TextBox.Name = "phone1TextBox";
            this.phone1TextBox.ReadOnly = true;
            this.phone1TextBox.Size = new System.Drawing.Size(200, 20);
            this.phone1TextBox.TabIndex = 19;
            this.phone1TextBox.TabStop = false;
            // 
            // phone2TextBox
            // 
            this.phone2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Phone2", true));
            this.phone2TextBox.Location = new System.Drawing.Point(655, 361);
            this.phone2TextBox.Name = "phone2TextBox";
            this.phone2TextBox.ReadOnly = true;
            this.phone2TextBox.Size = new System.Drawing.Size(200, 20);
            this.phone2TextBox.TabIndex = 21;
            this.phone2TextBox.TabStop = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(655, 387);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 23;
            this.emailTextBox.TabStop = false;
            // 
            // web_URLTextBox
            // 
            this.web_URLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Web_URL", true));
            this.web_URLTextBox.Location = new System.Drawing.Point(655, 413);
            this.web_URLTextBox.Name = "web_URLTextBox";
            this.web_URLTextBox.ReadOnly = true;
            this.web_URLTextBox.Size = new System.Drawing.Size(200, 20);
            this.web_URLTextBox.TabIndex = 25;
            this.web_URLTextBox.TabStop = false;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(655, 439);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(200, 20);
            this.countryTextBox.TabIndex = 27;
            this.countryTextBox.TabStop = false;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(655, 465);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(200, 20);
            this.stateTextBox.TabIndex = 29;
            this.stateTextBox.TabStop = false;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(655, 491);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 31;
            this.cityTextBox.TabStop = false;
            // 
            // zIP_CodeTextBox
            // 
            this.zIP_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "ZIP_Code", true));
            this.zIP_CodeTextBox.Location = new System.Drawing.Point(655, 517);
            this.zIP_CodeTextBox.Name = "zIP_CodeTextBox";
            this.zIP_CodeTextBox.ReadOnly = true;
            this.zIP_CodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.zIP_CodeTextBox.TabIndex = 33;
            this.zIP_CodeTextBox.TabStop = false;
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(655, 543);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.ReadOnly = true;
            this.address1TextBox.Size = new System.Drawing.Size(200, 20);
            this.address1TextBox.TabIndex = 35;
            this.address1TextBox.TabStop = false;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(655, 569);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.ReadOnly = true;
            this.address2TextBox.Size = new System.Drawing.Size(200, 20);
            this.address2TextBox.TabIndex = 37;
            this.address2TextBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phone_book_tableBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(655, 595);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 39;
            this.descriptionTextBox.TabStop = false;
            // 
            // textboxMS_LastName
            // 
            this.textboxMS_LastName.Depth = 0;
            this.textboxMS_LastName.Hint = "Last Name";
            this.textboxMS_LastName.Location = new System.Drawing.Point(6, 96);
            this.textboxMS_LastName.MaxLength = 32767;
            this.textboxMS_LastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_LastName.Name = "textboxMS_LastName";
            this.textboxMS_LastName.PasswordChar = '\0';
            this.textboxMS_LastName.SelectedText = "";
            this.textboxMS_LastName.SelectionLength = 0;
            this.textboxMS_LastName.SelectionStart = 0;
            this.textboxMS_LastName.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_LastName.TabIndex = 1;
            this.textboxMS_LastName.TabStop = false;
            this.textboxMS_LastName.UseSystemPasswordChar = false;
            this.textboxMS_LastName.Click += new System.EventHandler(this.textboxMS_LastName_Click);
            this.textboxMS_LastName.TextChanged += new System.EventHandler(this.textboxMS_LastName_TextChanged);
            // 
            // textboxMS_CustomerID
            // 
            this.textboxMS_CustomerID.Depth = 0;
            this.textboxMS_CustomerID.Hint = "Customer ID";
            this.textboxMS_CustomerID.Location = new System.Drawing.Point(6, 126);
            this.textboxMS_CustomerID.MaxLength = 32767;
            this.textboxMS_CustomerID.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_CustomerID.Name = "textboxMS_CustomerID";
            this.textboxMS_CustomerID.PasswordChar = '\0';
            this.textboxMS_CustomerID.SelectedText = "";
            this.textboxMS_CustomerID.SelectionLength = 0;
            this.textboxMS_CustomerID.SelectionStart = 0;
            this.textboxMS_CustomerID.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_CustomerID.TabIndex = 2;
            this.textboxMS_CustomerID.TabStop = false;
            this.textboxMS_CustomerID.UseSystemPasswordChar = false;
            this.textboxMS_CustomerID.Click += new System.EventHandler(this.textboxMS_CustomerID_Click);
            this.textboxMS_CustomerID.TextChanged += new System.EventHandler(this.textboxMS_CustomerID_TextChanged);
            // 
            // textboxMS_Gender
            // 
            this.textboxMS_Gender.Depth = 0;
            this.textboxMS_Gender.Hint = "Gender";
            this.textboxMS_Gender.Location = new System.Drawing.Point(6, 208);
            this.textboxMS_Gender.MaxLength = 32767;
            this.textboxMS_Gender.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_Gender.Name = "textboxMS_Gender";
            this.textboxMS_Gender.PasswordChar = '\0';
            this.textboxMS_Gender.SelectedText = "";
            this.textboxMS_Gender.SelectionLength = 0;
            this.textboxMS_Gender.SelectionStart = 0;
            this.textboxMS_Gender.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_Gender.TabIndex = 4;
            this.textboxMS_Gender.TabStop = false;
            this.textboxMS_Gender.UseSystemPasswordChar = false;
            this.textboxMS_Gender.Click += new System.EventHandler(this.textboxMS_Gender_Click);
            this.textboxMS_Gender.TextChanged += new System.EventHandler(this.textboxMS_Gender_TextChanged);
            // 
            // textboxMS_Education
            // 
            this.textboxMS_Education.Depth = 0;
            this.textboxMS_Education.Hint = "Education";
            this.textboxMS_Education.Location = new System.Drawing.Point(6, 238);
            this.textboxMS_Education.MaxLength = 32767;
            this.textboxMS_Education.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_Education.Name = "textboxMS_Education";
            this.textboxMS_Education.PasswordChar = '\0';
            this.textboxMS_Education.SelectedText = "";
            this.textboxMS_Education.SelectionLength = 0;
            this.textboxMS_Education.SelectionStart = 0;
            this.textboxMS_Education.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_Education.TabIndex = 5;
            this.textboxMS_Education.TabStop = false;
            this.textboxMS_Education.UseSystemPasswordChar = false;
            this.textboxMS_Education.Click += new System.EventHandler(this.textboxMS_Education_Click);
            this.textboxMS_Education.TextChanged += new System.EventHandler(this.textboxMS_Education_TextChanged);
            // 
            // textboxMS_Phone1
            // 
            this.textboxMS_Phone1.Depth = 0;
            this.textboxMS_Phone1.Hint = "Phone1";
            this.textboxMS_Phone1.Location = new System.Drawing.Point(6, 299);
            this.textboxMS_Phone1.MaxLength = 32767;
            this.textboxMS_Phone1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_Phone1.Name = "textboxMS_Phone1";
            this.textboxMS_Phone1.PasswordChar = '\0';
            this.textboxMS_Phone1.SelectedText = "";
            this.textboxMS_Phone1.SelectionLength = 0;
            this.textboxMS_Phone1.SelectionStart = 0;
            this.textboxMS_Phone1.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_Phone1.TabIndex = 7;
            this.textboxMS_Phone1.TabStop = false;
            this.textboxMS_Phone1.UseSystemPasswordChar = false;
            this.textboxMS_Phone1.Click += new System.EventHandler(this.textboxMS_Phone1_Click);
            this.textboxMS_Phone1.TextChanged += new System.EventHandler(this.textboxMS_Phone1_TextChanged);
            // 
            // textboxMS_Phone2
            // 
            this.textboxMS_Phone2.Depth = 0;
            this.textboxMS_Phone2.Hint = "Phone2";
            this.textboxMS_Phone2.Location = new System.Drawing.Point(6, 328);
            this.textboxMS_Phone2.MaxLength = 32767;
            this.textboxMS_Phone2.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_Phone2.Name = "textboxMS_Phone2";
            this.textboxMS_Phone2.PasswordChar = '\0';
            this.textboxMS_Phone2.SelectedText = "";
            this.textboxMS_Phone2.SelectionLength = 0;
            this.textboxMS_Phone2.SelectionStart = 0;
            this.textboxMS_Phone2.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_Phone2.TabIndex = 8;
            this.textboxMS_Phone2.TabStop = false;
            this.textboxMS_Phone2.UseSystemPasswordChar = false;
            this.textboxMS_Phone2.Click += new System.EventHandler(this.textboxMS_Phone2_Click);
            this.textboxMS_Phone2.TextChanged += new System.EventHandler(this.textboxMS_Phone2_TextChanged);
            // 
            // textboxMS_Email
            // 
            this.textboxMS_Email.Depth = 0;
            this.textboxMS_Email.Hint = "Email";
            this.textboxMS_Email.Location = new System.Drawing.Point(6, 358);
            this.textboxMS_Email.MaxLength = 32767;
            this.textboxMS_Email.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_Email.Name = "textboxMS_Email";
            this.textboxMS_Email.PasswordChar = '\0';
            this.textboxMS_Email.SelectedText = "";
            this.textboxMS_Email.SelectionLength = 0;
            this.textboxMS_Email.SelectionStart = 0;
            this.textboxMS_Email.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_Email.TabIndex = 9;
            this.textboxMS_Email.TabStop = false;
            this.textboxMS_Email.UseSystemPasswordChar = false;
            this.textboxMS_Email.TextChanged += new System.EventHandler(this.textboxMS_Email_TextChanged);
            // 
            // textboxMS_webURL
            // 
            this.textboxMS_webURL.Depth = 0;
            this.textboxMS_webURL.Hint = "Web URL";
            this.textboxMS_webURL.Location = new System.Drawing.Point(6, 388);
            this.textboxMS_webURL.MaxLength = 32767;
            this.textboxMS_webURL.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_webURL.Name = "textboxMS_webURL";
            this.textboxMS_webURL.PasswordChar = '\0';
            this.textboxMS_webURL.SelectedText = "";
            this.textboxMS_webURL.SelectionLength = 0;
            this.textboxMS_webURL.SelectionStart = 0;
            this.textboxMS_webURL.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_webURL.TabIndex = 10;
            this.textboxMS_webURL.TabStop = false;
            this.textboxMS_webURL.UseSystemPasswordChar = false;
            this.textboxMS_webURL.TextChanged += new System.EventHandler(this.textboxMS_webURL_TextChanged);
            // 
            // textboxMS_Country
            // 
            this.textboxMS_Country.Depth = 0;
            this.textboxMS_Country.Hint = "Country";
            this.textboxMS_Country.Location = new System.Drawing.Point(6, 418);
            this.textboxMS_Country.MaxLength = 32767;
            this.textboxMS_Country.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_Country.Name = "textboxMS_Country";
            this.textboxMS_Country.PasswordChar = '\0';
            this.textboxMS_Country.SelectedText = "";
            this.textboxMS_Country.SelectionLength = 0;
            this.textboxMS_Country.SelectionStart = 0;
            this.textboxMS_Country.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_Country.TabIndex = 11;
            this.textboxMS_Country.TabStop = false;
            this.textboxMS_Country.UseSystemPasswordChar = false;
            this.textboxMS_Country.TextChanged += new System.EventHandler(this.textboxMS_Country_TextChanged);
            // 
            // textboxMS_State
            // 
            this.textboxMS_State.Depth = 0;
            this.textboxMS_State.Hint = "State";
            this.textboxMS_State.Location = new System.Drawing.Point(6, 448);
            this.textboxMS_State.MaxLength = 32767;
            this.textboxMS_State.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_State.Name = "textboxMS_State";
            this.textboxMS_State.PasswordChar = '\0';
            this.textboxMS_State.SelectedText = "";
            this.textboxMS_State.SelectionLength = 0;
            this.textboxMS_State.SelectionStart = 0;
            this.textboxMS_State.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_State.TabIndex = 12;
            this.textboxMS_State.TabStop = false;
            this.textboxMS_State.UseSystemPasswordChar = false;
            this.textboxMS_State.TextChanged += new System.EventHandler(this.textboxMS_State_TextChanged);
            // 
            // textboxMS_City
            // 
            this.textboxMS_City.Depth = 0;
            this.textboxMS_City.Hint = "City";
            this.textboxMS_City.Location = new System.Drawing.Point(6, 478);
            this.textboxMS_City.MaxLength = 32767;
            this.textboxMS_City.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_City.Name = "textboxMS_City";
            this.textboxMS_City.PasswordChar = '\0';
            this.textboxMS_City.SelectedText = "";
            this.textboxMS_City.SelectionLength = 0;
            this.textboxMS_City.SelectionStart = 0;
            this.textboxMS_City.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_City.TabIndex = 13;
            this.textboxMS_City.TabStop = false;
            this.textboxMS_City.UseSystemPasswordChar = false;
            this.textboxMS_City.TextChanged += new System.EventHandler(this.textboxMS_City_TextChanged);
            // 
            // textboxMS_ZIPCode
            // 
            this.textboxMS_ZIPCode.Depth = 0;
            this.textboxMS_ZIPCode.Hint = "ZIP Code";
            this.textboxMS_ZIPCode.Location = new System.Drawing.Point(6, 508);
            this.textboxMS_ZIPCode.MaxLength = 32767;
            this.textboxMS_ZIPCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_ZIPCode.Name = "textboxMS_ZIPCode";
            this.textboxMS_ZIPCode.PasswordChar = '\0';
            this.textboxMS_ZIPCode.SelectedText = "";
            this.textboxMS_ZIPCode.SelectionLength = 0;
            this.textboxMS_ZIPCode.SelectionStart = 0;
            this.textboxMS_ZIPCode.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_ZIPCode.TabIndex = 14;
            this.textboxMS_ZIPCode.TabStop = false;
            this.textboxMS_ZIPCode.UseSystemPasswordChar = false;
            this.textboxMS_ZIPCode.TextChanged += new System.EventHandler(this.textboxMS_ZIPCode_TextChanged);
            // 
            // textboxMS_Address1
            // 
            this.textboxMS_Address1.Depth = 0;
            this.textboxMS_Address1.Hint = "Address1";
            this.textboxMS_Address1.Location = new System.Drawing.Point(6, 538);
            this.textboxMS_Address1.MaxLength = 32767;
            this.textboxMS_Address1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_Address1.Name = "textboxMS_Address1";
            this.textboxMS_Address1.PasswordChar = '\0';
            this.textboxMS_Address1.SelectedText = "";
            this.textboxMS_Address1.SelectionLength = 0;
            this.textboxMS_Address1.SelectionStart = 0;
            this.textboxMS_Address1.Size = new System.Drawing.Size(483, 23);
            this.textboxMS_Address1.TabIndex = 15;
            this.textboxMS_Address1.TabStop = false;
            this.textboxMS_Address1.UseSystemPasswordChar = false;
            this.textboxMS_Address1.TextChanged += new System.EventHandler(this.textboxMS_Address1_TextChanged);
            // 
            // textboxMS_Address2
            // 
            this.textboxMS_Address2.Depth = 0;
            this.textboxMS_Address2.Hint = "Address2";
            this.textboxMS_Address2.Location = new System.Drawing.Point(6, 568);
            this.textboxMS_Address2.MaxLength = 32767;
            this.textboxMS_Address2.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_Address2.Name = "textboxMS_Address2";
            this.textboxMS_Address2.PasswordChar = '\0';
            this.textboxMS_Address2.SelectedText = "";
            this.textboxMS_Address2.SelectionLength = 0;
            this.textboxMS_Address2.SelectionStart = 0;
            this.textboxMS_Address2.Size = new System.Drawing.Size(483, 23);
            this.textboxMS_Address2.TabIndex = 16;
            this.textboxMS_Address2.TabStop = false;
            this.textboxMS_Address2.UseSystemPasswordChar = false;
            this.textboxMS_Address2.TextChanged += new System.EventHandler(this.textboxMS_Address2_TextChanged);
            // 
            // textboxMS_Description
            // 
            this.textboxMS_Description.Depth = 0;
            this.textboxMS_Description.Hint = "Desctiption";
            this.textboxMS_Description.Location = new System.Drawing.Point(6, 598);
            this.textboxMS_Description.MaxLength = 32767;
            this.textboxMS_Description.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_Description.Name = "textboxMS_Description";
            this.textboxMS_Description.PasswordChar = '\0';
            this.textboxMS_Description.SelectedText = "";
            this.textboxMS_Description.SelectionLength = 0;
            this.textboxMS_Description.SelectionStart = 0;
            this.textboxMS_Description.Size = new System.Drawing.Size(483, 23);
            this.textboxMS_Description.TabIndex = 17;
            this.textboxMS_Description.TabStop = false;
            this.textboxMS_Description.UseSystemPasswordChar = false;
            this.textboxMS_Description.TextChanged += new System.EventHandler(this.textboxMS_Description_TextChanged);
            // 
            // textboxMS_StudyField
            // 
            this.textboxMS_StudyField.Depth = 0;
            this.textboxMS_StudyField.Hint = "Study Field";
            this.textboxMS_StudyField.Location = new System.Drawing.Point(6, 268);
            this.textboxMS_StudyField.MaxLength = 32767;
            this.textboxMS_StudyField.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxMS_StudyField.Name = "textboxMS_StudyField";
            this.textboxMS_StudyField.PasswordChar = '\0';
            this.textboxMS_StudyField.SelectedText = "";
            this.textboxMS_StudyField.SelectionLength = 0;
            this.textboxMS_StudyField.SelectionStart = 0;
            this.textboxMS_StudyField.Size = new System.Drawing.Size(237, 23);
            this.textboxMS_StudyField.TabIndex = 6;
            this.textboxMS_StudyField.TabStop = false;
            this.textboxMS_StudyField.UseSystemPasswordChar = false;
            this.textboxMS_StudyField.Click += new System.EventHandler(this.textboxMS_StudyField_Click);
            this.textboxMS_StudyField.TextChanged += new System.EventHandler(this.textboxMS_StudyField_TextChanged);
            // 
            // labelMS_BirthDate
            // 
            this.labelMS_BirthDate.AutoSize = true;
            this.labelMS_BirthDate.Depth = 0;
            this.labelMS_BirthDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelMS_BirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMS_BirthDate.Location = new System.Drawing.Point(7, 155);
            this.labelMS_BirthDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMS_BirthDate.Name = "labelMS_BirthDate";
            this.labelMS_BirthDate.Size = new System.Drawing.Size(79, 19);
            this.labelMS_BirthDate.TabIndex = 4;
            this.labelMS_BirthDate.Text = "Birth Date:";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(97, 61);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // phone_book_tableBindingNavigatorSaveItem
            // 
            this.phone_book_tableBindingNavigatorSaveItem.Enabled = false;
            this.phone_book_tableBindingNavigatorSaveItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_book_tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phone_book_tableBindingNavigatorSaveItem.Image")));
            this.phone_book_tableBindingNavigatorSaveItem.Name = "phone_book_tableBindingNavigatorSaveItem";
            this.phone_book_tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(106, 61);
            this.phone_book_tableBindingNavigatorSaveItem.Text = "Save Data";
            this.phone_book_tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.phone_book_tableBindingNavigatorSaveItem_Click);
            // 
            // phone_book_tableBindingNavigator
            // 
            this.phone_book_tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phone_book_tableBindingNavigator.AutoSize = false;
            this.phone_book_tableBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.phone_book_tableBindingNavigator.BindingSource = this.phone_book_tableBindingSource;
            this.phone_book_tableBindingNavigator.CountItem = null;
            this.phone_book_tableBindingNavigator.DeleteItem = null;
            this.phone_book_tableBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.phone_book_tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.phone_book_tableBindingNavigatorSaveItem,
            this.toolStripButton_Close});
            this.phone_book_tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phone_book_tableBindingNavigator.MoveFirstItem = null;
            this.phone_book_tableBindingNavigator.MoveLastItem = null;
            this.phone_book_tableBindingNavigator.MoveNextItem = null;
            this.phone_book_tableBindingNavigator.MovePreviousItem = null;
            this.phone_book_tableBindingNavigator.Name = "phone_book_tableBindingNavigator";
            this.phone_book_tableBindingNavigator.PositionItem = null;
            this.phone_book_tableBindingNavigator.Size = new System.Drawing.Size(514, 64);
            this.phone_book_tableBindingNavigator.TabIndex = 1;
            this.phone_book_tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton_Close
            // 
            this.toolStripButton_Close.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_Close.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Close.Image")));
            this.toolStripButton_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Close.Name = "toolStripButton_Close";
            this.toolStripButton_Close.Size = new System.Drawing.Size(70, 61);
            this.toolStripButton_Close.Text = "Close";
            this.toolStripButton_Close.ToolTipText = "Close";
            this.toolStripButton_Close.Click += new System.EventHandler(this.toolStripButton_Close_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxInfo.Controls.Add(this.textboxMS_Gender);
            this.groupBoxInfo.Controls.Add(this.labelMS_BirthDate);
            this.groupBoxInfo.Controls.Add(this.textboxMS_FirstName);
            this.groupBoxInfo.Controls.Add(this.textboxMS_StudyField);
            this.groupBoxInfo.Controls.Add(this.birth_DateDateTimePicker);
            this.groupBoxInfo.Controls.Add(this.textboxMS_Description);
            this.groupBoxInfo.Controls.Add(this.textboxMS_LastName);
            this.groupBoxInfo.Controls.Add(this.textboxMS_Address2);
            this.groupBoxInfo.Controls.Add(this.textboxMS_CustomerID);
            this.groupBoxInfo.Controls.Add(this.textboxMS_Address1);
            this.groupBoxInfo.Controls.Add(this.textboxMS_Education);
            this.groupBoxInfo.Controls.Add(this.textboxMS_ZIPCode);
            this.groupBoxInfo.Controls.Add(this.textboxMS_Phone1);
            this.groupBoxInfo.Controls.Add(this.textboxMS_City);
            this.groupBoxInfo.Controls.Add(this.textboxMS_Phone2);
            this.groupBoxInfo.Controls.Add(this.textboxMS_State);
            this.groupBoxInfo.Controls.Add(this.textboxMS_Email);
            this.groupBoxInfo.Controls.Add(this.textboxMS_Country);
            this.groupBoxInfo.Controls.Add(this.textboxMS_webURL);
            this.groupBoxInfo.Enabled = false;
            this.groupBoxInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 67);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(495, 631);
            this.groupBoxInfo.TabIndex = 40;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Information";
            // 
            // AddNewNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 710);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.customer_IDTextBox);
            this.Controls.Add(birth_DateLabel);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(educationLabel);
            this.Controls.Add(this.educationTextBox);
            this.Controls.Add(study_FieldLabel);
            this.Controls.Add(this.study_FieldTextBox);
            this.Controls.Add(phone1Label);
            this.Controls.Add(this.phone1TextBox);
            this.Controls.Add(phone2Label);
            this.Controls.Add(this.phone2TextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(web_URLLabel);
            this.Controls.Add(this.web_URLTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(zIP_CodeLabel);
            this.Controls.Add(this.zIP_CodeTextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.phone_book_tableBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewNumberForm";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewNumberForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddNewNumberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_book_tableBindingNavigator)).EndInit();
            this.phone_book_tableBindingNavigator.ResumeLayout(false);
            this.phone_book_tableBindingNavigator.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Dataset.pb_dataset pb_dataset;
        private System.Windows.Forms.BindingSource phone_book_tableBindingSource;
        private Dataset.pb_datasetTableAdapters.phone_book_tableTableAdapter phone_book_tableTableAdapter;
        private Dataset.pb_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_FirstName;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox customer_IDTextBox;
        private System.Windows.Forms.DateTimePicker birth_DateDateTimePicker;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox educationTextBox;
        private System.Windows.Forms.TextBox study_FieldTextBox;
        private System.Windows.Forms.TextBox phone1TextBox;
        private System.Windows.Forms.TextBox phone2TextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox web_URLTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zIP_CodeTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_LastName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_CustomerID;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_Gender;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_Education;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_Phone1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_Phone2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_Email;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_webURL;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_Country;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_State;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_City;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_ZIPCode;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_Address1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_Address2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_Description;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxMS_StudyField;
        private MaterialSkin.Controls.MaterialLabel labelMS_BirthDate;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton phone_book_tableBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator phone_book_tableBindingNavigator;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.ToolStripButton toolStripButton_Close;
    }
}