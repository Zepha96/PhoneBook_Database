namespace PhoneBook_DB
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
            this.pb_dataset = new PhoneBook_DB.Dataset.pb_dataset();
            this.pbdatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonebooktableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phone_book_tableTableAdapter = new PhoneBook_DB.Dataset.pb_datasetTableAdapters.phone_book_tableTableAdapter();
            this.button_AddNumber = new MaterialSkin.Controls.MaterialFlatButton();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zIPCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDatabase = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebooktableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_dataset
            // 
            this.pb_dataset.DataSetName = "pb_dataset";
            this.pb_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pbdatasetBindingSource
            // 
            this.pbdatasetBindingSource.DataSource = this.pb_dataset;
            this.pbdatasetBindingSource.Position = 0;
            // 
            // phonebooktableBindingSource
            // 
            this.phonebooktableBindingSource.DataMember = "phone_book_table";
            this.phonebooktableBindingSource.DataSource = this.pbdatasetBindingSource;
            // 
            // phone_book_tableTableAdapter
            // 
            this.phone_book_tableTableAdapter.ClearBeforeFill = true;
            // 
            // button_AddNumber
            // 
            this.button_AddNumber.AutoSize = true;
            this.button_AddNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_AddNumber.BackColor = System.Drawing.SystemColors.Control;
            this.button_AddNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddNumber.Depth = 0;
            this.button_AddNumber.Icon = null;
            this.button_AddNumber.Location = new System.Drawing.Point(13, 81);
            this.button_AddNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_AddNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_AddNumber.Name = "button_AddNumber";
            this.button_AddNumber.Primary = false;
            this.button_AddNumber.Size = new System.Drawing.Size(109, 36);
            this.button_AddNumber.TabIndex = 1;
            this.button_AddNumber.Text = "Add Number";
            this.button_AddNumber.UseVisualStyleBackColor = false;
            this.button_AddNumber.Click += new System.EventHandler(this.button_AddNumber_Click);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "Address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "Address2";
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "Address1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "Address1";
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            // 
            // zIPCodeDataGridViewTextBoxColumn
            // 
            this.zIPCodeDataGridViewTextBoxColumn.DataPropertyName = "ZIP_Code";
            this.zIPCodeDataGridViewTextBoxColumn.HeaderText = "ZIP_Code";
            this.zIPCodeDataGridViewTextBoxColumn.Name = "zIPCodeDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // webURLDataGridViewTextBoxColumn
            // 
            this.webURLDataGridViewTextBoxColumn.DataPropertyName = "Web_URL";
            this.webURLDataGridViewTextBoxColumn.HeaderText = "Web_URL";
            this.webURLDataGridViewTextBoxColumn.Name = "webURLDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phone2DataGridViewTextBoxColumn
            // 
            this.phone2DataGridViewTextBoxColumn.DataPropertyName = "Phone2";
            this.phone2DataGridViewTextBoxColumn.HeaderText = "Phone2";
            this.phone2DataGridViewTextBoxColumn.Name = "phone2DataGridViewTextBoxColumn";
            // 
            // phone1DataGridViewTextBoxColumn
            // 
            this.phone1DataGridViewTextBoxColumn.DataPropertyName = "Phone1";
            this.phone1DataGridViewTextBoxColumn.HeaderText = "Phone1";
            this.phone1DataGridViewTextBoxColumn.Name = "phone1DataGridViewTextBoxColumn";
            // 
            // studyFieldDataGridViewTextBoxColumn
            // 
            this.studyFieldDataGridViewTextBoxColumn.DataPropertyName = "Study_Field";
            this.studyFieldDataGridViewTextBoxColumn.HeaderText = "Study_Field";
            this.studyFieldDataGridViewTextBoxColumn.Name = "studyFieldDataGridViewTextBoxColumn";
            // 
            // educationDataGridViewTextBoxColumn
            // 
            this.educationDataGridViewTextBoxColumn.DataPropertyName = "Education";
            this.educationDataGridViewTextBoxColumn.HeaderText = "Education";
            this.educationDataGridViewTextBoxColumn.Name = "educationDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "Birth_Date";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Birth_Date";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewDatabase
            // 
            this.dataGridViewDatabase.AutoGenerateColumns = false;
            this.dataGridViewDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.educationDataGridViewTextBoxColumn,
            this.studyFieldDataGridViewTextBoxColumn,
            this.phone1DataGridViewTextBoxColumn,
            this.phone2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.webURLDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.zIPCodeDataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewDatabase.DataSource = this.phonebooktableBindingSource;
            this.dataGridViewDatabase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDatabase.Location = new System.Drawing.Point(0, 370);
            this.dataGridViewDatabase.Name = "dataGridViewDatabase";
            this.dataGridViewDatabase.Size = new System.Drawing.Size(1050, 333);
            this.dataGridViewDatabase.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 703);
            this.Controls.Add(this.button_AddNumber);
            this.Controls.Add(this.dataGridViewDatabase);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebooktableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pbdatasetBindingSource;
        private Dataset.pb_dataset pb_dataset;
        private System.Windows.Forms.BindingSource phonebooktableBindingSource;
        private Dataset.pb_datasetTableAdapters.phone_book_tableTableAdapter phone_book_tableTableAdapter;
        private MaterialSkin.Controls.MaterialFlatButton button_AddNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zIPCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studyFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridViewDatabase;
    }
}

