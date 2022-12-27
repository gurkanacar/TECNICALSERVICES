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
    public partial class FRMPRODUCTLIST : Form
    {
        public FRMPRODUCTLIST()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();

        void metod1()
        {
            // istenilen degerleri getirme
            var degerler = from u in db.TBL_PRODUCTS
                           select new
                           {
                               u.ID,
                               u.NAME,
                               u.BRAND,
                               CATEGORY = u.TBL_CATEGORIES.NAME,
                               u.STOCK,
                               u.BUYINGPRICE,
                               u.SELLINGPRICE
                           };
            gridControl1.DataSource = degerler.ToList();
        }


        private void FRMPRODUCTLIST_Load(object sender, EventArgs e)
        {
            //Listeleme Tolist  Ekleme Add silme Remove
            //  var degerler = db.TBL_PRODUCTS.ToList();
            metod1();
            // lookupedit kullanimi
            //lookUpEdit1.Properties.DataSource = db.TBL_CATEGORIES.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBL_CATEGORIES
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.NAME,
                                                 }).ToList();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBL_PRODUCTS t = new TBL_PRODUCTS();
            t.NAME = txtProductName.Text;
            t.BRAND = txtProductBrand.Text;
            t.BUYINGPRICE = decimal.Parse(txtBuyingPrice.Text);
            t.SELLINGPRICE = decimal.Parse(txtSellingPrice.Text);
            t.STOCK = short.Parse(txtStock.Text);
            t.STATUS = false;
            t.CATEGORIES = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBL_PRODUCTS.Add(t);
            db.SaveChanges();
            MessageBox.Show("The product has been successfully added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            metod1();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {


            try
            {
                txtid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtProductName.Text = gridView1.GetFocusedRowCellValue("NAME").ToString();
                txtProductBrand.Text = gridView1.GetFocusedRowCellValue("BRAND").ToString();
                txtBuyingPrice.Text = gridView1.GetFocusedRowCellValue("BUYINGPRICE").ToString();
                txtSellingPrice.Text = gridView1.GetFocusedRowCellValue("SELLINGPRICE").ToString();
                txtStock.Text = gridView1.GetFocusedRowCellValue("STOCK").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("CATEGORY").ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {       //SILME
            int ID = int.Parse(txtid.Text);
            var deger = db.TBL_PRODUCTS.Find(ID);
            db.TBL_PRODUCTS.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("THE PRODUCT HAS BEEN SUCCESSFULLY DELETED", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void btnProductsOps_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtid.Text);
            var deger = db.TBL_PRODUCTS.Find(ID);
            deger.NAME = txtProductName.Text;
            deger.STOCK = short.Parse(txtStock.Text);
            deger.BRAND = txtProductBrand.Text;
            deger.BUYINGPRICE = decimal.Parse(txtBuyingPrice.Text);
            deger.SELLINGPRICE = decimal.Parse(txtSellingPrice.Text);
            deger.CATEGORIES = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("THE PRODUCT HAS BEEN SUCCESSFULLY UPDATED", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBuyingPrice.Text = "";
            txtSellingPrice.Text = "";
            txtStock.Text = "";
            txtProductBrand.Text = "";
            txtProductName.Text = "";
            txtid.Text = "";
        }
    }
}
