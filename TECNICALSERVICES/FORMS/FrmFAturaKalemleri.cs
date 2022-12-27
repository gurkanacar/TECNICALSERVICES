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
    public partial class FrmFAturaKalemleri : Form
    {
        public FrmFAturaKalemleri()
        {
            InitializeComponent();
        }

        public int id;
        private void FrmFAturaKalemleri_Load(object sender, EventArgs e)
        {
            // label1.Text = id.ToString();
            DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
            gridControl1.DataSource = db.TBL_BILLDETAIL.Where(x => x.BILLID == id).ToList();
            gridControl2.DataSource = db.TBL_BILLINFORMATION.Where(x => x.ID == id).ToList();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            string path = "dosya1.Pdf";
            gridControl1.ExportToPdf(path);
        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            string path = "dosya1.Xls";
            gridControl1.ExportToXls(path);
        }
    }
}
