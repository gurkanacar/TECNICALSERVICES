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
    public partial class FrmNewDepartman : Form
    {
        public FrmNewDepartman()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void btnSave_Click(object sender, EventArgs e)
        {
            TBL_DEPARTMAN t = new TBL_DEPARTMAN();
            if (txtName.Text.Length <= 50 && txtName.Text != null )
            {
                t.NAME = txtName.Text;
                db.TBL_DEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("The Depatman has been successfully added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
