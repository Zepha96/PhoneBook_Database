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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Century Gothic", 11f, FontStyle.Regular);
            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Century Gothic", 12f, FontStyle.Bold);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Century Gothic", 11f, FontStyle.Regular);
            materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Century Gothic", 10f, FontStyle.Bold);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500,
                                                                           MaterialSkin.Primary.Blue800,
                                                                           MaterialSkin.Primary.Blue200,
                                                                           MaterialSkin.Accent.Pink400,
                                                                           MaterialSkin.TextShade.BLACK);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pb_dataset.phone_book_table' table. You can move, or remove it, as needed.
            this.phone_book_tableTableAdapter.Fill(this.pb_dataset.phone_book_table);
            this.phone_book_tableBindingNavigator.Renderer = new ToolStripRenderFIX();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMS_deleteRow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
            {
                this.phone_book_tableBindingSource.RemoveCurrent();
                this.Validate();
                this.phone_book_tableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pb_dataset);
            }
        }

        private void buttonMS_AddRecord_Click(object sender, EventArgs e)
        {
            AddNewNumberForm addData = new AddNewNumberForm();
            var form = Application.OpenForms["AddNewNumberForm"];
            if (form == null)
            {
                addData.ShowDialog();
            }
            else
            {
                MessageBox.Show("Form is already Open", "Error");
            }
        }
    }
}
