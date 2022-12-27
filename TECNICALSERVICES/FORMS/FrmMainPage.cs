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
    public partial class FrmMainPage : Form
    {
        public FrmMainPage()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void FrmMainPage_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBL_PRODUCTS
                                       select new
                                       {
                                           x.NAME,
                                           x.STOCK

                                       }).Where(x=>x.STOCK<30).ToList();

            gridControl2.DataSource = (from y in db.TBL_CURRENT
                                       select new
                                       {
                                           y.NAME,
                                           y.SURNAME,
                                           y.PROVINCE,
                                       }).ToList();
            gridControl3.DataSource = db.urunkategori().ToList();

            DateTime today = DateTime.Today;
            var deger = (from x in db.TBL_NOTES.OrderBy(y => y.ID)
                         where (x.DATE == today)
                         select new
                         {
                             x.HEADING,x.CONTENT1
                         });
            gridControl4.DataSource = deger.ToList();

            String konu1, ad1, konu2, ad2, konu3, ad3, konu4, ad4, konu5, ad5;
            konu1 = db.TBL_CONNECTTION.First(x => x.ID == 1).SUBJECT;
            ad1 = db.TBL_CONNECTTION.First(x => x.ID == 1).NAMESURNAME;
            labelControl1.Text = konu1 +  " - " + ad1;

            konu2 = db.TBL_CONNECTTION.First(x => x.ID == 2).SUBJECT;
            ad2 = db.TBL_CONNECTTION.First(x => x.ID == 2).NAMESURNAME;
            labelControl2.Text = konu2 + " - " + ad2;

            konu3 = db.TBL_CONNECTTION.First(x => x.ID == 3).SUBJECT;
            ad3 = db.TBL_CONNECTTION.First(x => x.ID == 3).NAMESURNAME;
            labelControl3.Text = konu3 + " - " + ad3;

            konu4 = db.TBL_CONNECTTION.First(x => x.ID == 4).SUBJECT;
            ad4 = db.TBL_CONNECTTION.First(x => x.ID == 4).NAMESURNAME;
            labelControl4.Text = konu4 + " - " + ad4;

            konu5 = db.TBL_CONNECTTION.First(x => x.ID == 5).SUBJECT;
            ad5 = db.TBL_CONNECTTION.First(x => x.ID == 5).NAMESURNAME;
            labelControl5.Text = konu5 + " - " + ad5;

        }
    }
}
