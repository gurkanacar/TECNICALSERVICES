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
    public partial class FrmCategori : Form
    {
        public FrmCategori()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }


        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();

        void metod1()
        {
            // istenilen degerleri getirme
            var degerler = from u in db.TBL_CATEGORIES
                           select new
                           {
                               u.ID,
                               u.NAME,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmCategori_Load(object sender, EventArgs e)
        {
            metod1();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCategoryName.Text !="" && txtCategoryName.Text.Length <= 30)
            {
                TBL_CATEGORIES t = new TBL_CATEGORIES();
                t.NAME = txtCategoryName.Text;
                db.TBL_CATEGORIES.Add(t);
                db.SaveChanges();
                MessageBox.Show("The category has been successfully added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error the Category name hasn't added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            metod1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtCategoryName.Text = gridView1.GetFocusedRowCellValue("NAME").ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtid.Text);
            var deger = db.TBL_CATEGORIES.Find(ID);
            db.TBL_CATEGORIES.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("THE CATEGORY HAS BEEN SUCCESSFULLY DELETED", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnProductsOps_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtid.Text);
            var deger = db.TBL_CATEGORIES.Find(ID);
            deger.NAME = txtCategoryName.Text;
            db.SaveChanges();
            MessageBox.Show("THE CATEGORY HAS BEEN SUCCESSFULLY UPDATED", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategoryName.Text = "";
            txtid.Text = "";

        }
    }
}
