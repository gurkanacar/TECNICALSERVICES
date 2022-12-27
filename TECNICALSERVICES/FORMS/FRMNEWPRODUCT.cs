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
    public partial class FRMNEWPRODUCT : Form
    {
        public FRMNEWPRODUCT()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
            TBL_PRODUCTS t = new TBL_PRODUCTS();
            try
            {
                t.NAME = txtProductName.Text;
                t.BUYINGPRICE = decimal.Parse(txtBuyingPrice.Text);
                t.SELLINGPRICE = decimal.Parse(txtSellingPrice.Text);
                t.STOCK = short.Parse(txtStock.Text);
                t.CATEGORIES = byte.Parse(lookUpEdit1.EditValue.ToString());
                t.BRAND = txtBrandName.Text;
                db.TBL_PRODUCTS.Add(t);
                db.SaveChanges();
                MessageBox.Show("URUN BASARI ILE YUKLENDI", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
               
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void FRMNEWPRODUCT_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBL_CATEGORIES
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.NAME,
                                                 }).ToList();
        }

        private void txtProductName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtProductName.Focus();
        }

        private void txtBrandName_Click(object sender, EventArgs e)
        {
            txtBrandName.Text = "";
            txtBrandName.Focus();
        }

        //private void txtCategory_Click(object sender, EventArgs e)
        //{
        //    txtCategory.Text = "";
        //    txtCategory.Focus();
        //}

        private void txtBuyingPrice_Click(object sender, EventArgs e)
        {
            txtBuyingPrice.Text = "";
            txtBuyingPrice.Focus();
        }

        private void txtSellingPrice_Click(object sender, EventArgs e)
        {
            txtSellingPrice.Text = "";
            txtSellingPrice.Focus();
        }

        private void txtStock_Click(object sender, EventArgs e)
        {
            txtStock.Text = "";
            txtStock.Focus();
        }

        private void txtCategory_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
