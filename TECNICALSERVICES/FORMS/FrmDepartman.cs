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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        void metod1()
        {
            // istenilen degerleri getirme
            var degerler = from u in db.TBL_DEPARTMAN
                           select new
                           {
                               u.ID,
                               u.NAME,
                               
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            metod1();
            labelControl6.Text = db.TBL_DEPARTMAN.Count().ToString();
            labelControl15.Text = db.TBL_PERSON.Count().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBL_DEPARTMAN t = new TBL_DEPARTMAN();
            if (txtName.Text.Length <= 50 && txtName.Text != null && rchExp.Text.Length >= 1)
            {
                t.NAME = txtName.Text;
                t.EXPLANATION = rchExp.Text;
                db.TBL_DEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("The Depatman has been successfully added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //SILME
            int ID = int.Parse(txtid.Text);
            var deger = db.TBL_DEPARTMAN.Find(ID);
            db.TBL_DEPARTMAN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("THE PRODUCT HAS BEEN SUCCESSFULLY DELETED", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void btnProductsOps_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtid.Text);
            var deger = db.TBL_DEPARTMAN.Find(ID);
            deger.NAME = txtName.Text;      
            db.SaveChanges();
            MessageBox.Show("THE PRODUCT HAS BEEN SUCCESSFULLY UPDATED", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            metod1();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtName.Text = gridView1.GetFocusedRowCellValue("NAME").ToString();
         //   rchExp.Text = gridView1.GetFocusedRowCellValue("EXPLANATION").ToString();
        }
    }
}
