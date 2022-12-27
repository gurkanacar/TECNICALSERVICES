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
    public partial class FrmNotes : Form
    {
        public FrmNotes()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void FrmNotes_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBL_NOTES.Where(x => x.STATUS == false).ToList();
            gridControl2.DataSource = db.TBL_NOTES.Where(x => x.STATUS == true).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBL_NOTES t = new TBL_NOTES();
            t.HEADING = txtHead.Text;
            t.CONTENT1 = textEdit1.Text;
            t.STATUS = false;
            db.TBL_NOTES.Add(t);
            db.SaveChanges();
            MessageBox.Show("The Note has been successfully added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBL_NOTES.Where(x => x.STATUS == false).ToList();
            gridControl2.DataSource = db.TBL_NOTES.Where(x => x.STATUS == true).ToList();
        }

        private void btnProductsOps_Click(object sender, EventArgs e)
        {
            if(checkEdit1.Checked == true)
            {
                int ID = int.Parse(txtid.Text);
                var deger = db.TBL_NOTES.Find(ID);
                deger.STATUS = true;
                db.SaveChanges();
                MessageBox.Show("THE Note Status HAS BEEN SUCCESSFULLY UPDATED", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
