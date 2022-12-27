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
    public partial class FrmProductSales : Form
    {
        public FrmProductSales()
        {
            InitializeComponent();
        }

        private void FrmProductSales_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBL_PRODUCTS
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.NAME,
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBL_CURRENT
                                                 select new
                                                 {
                                                     x.ID,
                                                    AD1 = x.NAME +" "+x.SURNAME,
                                                 }).ToList();

            lookUpEdit3.Properties.DataSource = (from x in db.TBL_PERSON
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD2 = x.AD + " " + x.SOYAD,
                                                 }).ToList();
        }
        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void btnSell_Click(object sender, EventArgs e)
        {
            TBL_PRODUCTMOVEMENT t = new TBL_PRODUCTMOVEMENT();
            t.PRODUCT = int.Parse(lookUpEdit1.EditValue.ToString());
            t.COSTUMER = int.Parse(lookUpEdit2.EditValue.ToString());
            t.PERSON = short.Parse(lookUpEdit3.EditValue.ToString());
            t.DATE = DateTime.Parse(txtDate.Text);
            t.NUMBER = short.Parse(txtNumber.Text);
            t.PRICE = decimal.Parse(txtCost.Text);
            t.PRODUCTSERIALNUMBER = textSerialNum.Text;
            db.TBL_PRODUCTMOVEMENT.Add(t);
            db.SaveChanges();
            MessageBox.Show("item has been sold", "information", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void pictureEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
