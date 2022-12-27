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
    public partial class FrmProductStatistic : Form
    {
        public FrmProductStatistic()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();

        private void FrmProductStatistic_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBL_PRODUCTS.Count().ToString();
            labelControl3.Text = db.TBL_CATEGORIES.Count().ToString();
            labelControl5.Text = db.TBL_PRODUCTS.Sum(x=>x.STOCK).ToString();  ///Imp
            labelControl7.Text = "10";
            //imp
            labelControl16.Text = (from x in db.TBL_PRODUCTS
                                   orderby x.STOCK descending
                                   select x.NAME).FirstOrDefault();
            labelControl14.Text = (from x in db.TBL_PRODUCTS
                                   orderby x.STOCK ascending
                                   select x.NAME).FirstOrDefault();

            labelControl13.Text = (from x in db.TBL_PRODUCTS
                                   orderby x.SELLINGPRICE descending
                                   select x.NAME).FirstOrDefault();

            labelControl19.Text = (from x in db.TBL_PRODUCTS
                                   orderby x.SELLINGPRICE ascending
                                   select x.NAME).FirstOrDefault();

            labelControl23.Text = db.TBL_PRODUCTS.Count(x => x.CATEGORIES==4).ToString();
            labelControl27.Text = db.TBL_PRODUCTS.Count(x => x.CATEGORIES == 1).ToString();
            labelControl21.Text = db.TBL_PRODUCTS.Count(x => x.CATEGORIES == 3).ToString();

            labelControl35.Text = (from x in db.TBL_PRODUCTS
                                   orderby x.STOCK descending
                                   select x.BRAND).FirstOrDefault();

            labelControl39.Text = (from x in db.TBL_PRODUCTS                                  
                                   select x.BRAND).Distinct().Count().ToString();


            labelControl33.Text = db.TBL_PRODUCTACCEPTENCE.Count().ToString();
            labelControl11.Text = db.maxkategory().FirstOrDefault();

        }

        private void labelControl35_Click(object sender, EventArgs e)
        {

        }
    }
}
