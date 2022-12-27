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
    public partial class FRMFORMPENS : Form
    {
        public FRMFORMPENS()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void btnsearch_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtbillid.Text);

            var degerler = (from u in db.TBL_BILLDETAIL
                           select new
                           {
                               u.BILLDETAILID,
                               u.PRODUCT,
                               u.NUMBER,
                               u.PRICE,
                               u.TOTALPRICE,
                               u.BILLID
                           }).Where(x=>x.BILLID==id);

            gridControl1.DataSource = degerler.ToList();
        }
    }
}
