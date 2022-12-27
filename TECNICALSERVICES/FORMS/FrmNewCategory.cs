using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECNICALSERVICES.FORMS
{
    public partial class FrmNewCategory : Form
    {
        public FrmNewCategory()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text != "" || txtCategoryName.Text.Length <= 30)
            {
                TBL_CATEGORIES t = new TBL_CATEGORIES();
                t.NAME = txtCategoryName.Text;
                db.TBL_CATEGORIES.Add(t);
                db.SaveChanges();
                MessageBox.Show("The Category has been successfully added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR !! The Category hasn't been successfully added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
