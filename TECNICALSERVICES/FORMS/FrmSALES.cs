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
    public partial class FrmSALES : Form
    {
        public FrmSALES()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void FrmSALES_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBL_PRODUCTMOVEMENT
                           select new
                           {
                               x.MOVEMENTID,
                               x.TBL_PRODUCTS.NAME,
                               musteri = x.TBL_CURRENT.NAME+" " + x.TBL_CURRENT.SURNAME,
                               personel = x.TBL_PERSON.AD + " " + x.TBL_PERSON.SOYAD,
                               x.DATE ,
                               x.NUMBER,
                               x.PRICE,
                               x.PRODUCTSERIALNUMBER,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
