using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECNICALSERVICES.FORMS
{
    public partial class FrmArizaList : Form
    {
        public FrmArizaList()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void FrmArizaList_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBL_PRODUCTACCEPTENCE
                           select new
                           {
                               x.OPERATIONID,
                               CARI = x.TBL_CURRENT.NAME  + x.TBL_CURRENT.SURNAME,
                               Personel = x.TBL_PERSON.AD +" "+ x.TBL_PERSON.SOYAD,
                               x.ARRIVEDATE,
                               x.ENDINGDATE,     
                               x.PROSERNUM,
                               x.PRODUCTSTATUSDETAIL
                           };
            gridControl1.DataSource = degerler.ToList();

            labelControl5.Text = db.TBL_PRODUCTACCEPTENCE.Count().ToString();
            labelControl3.Text = db.TBL_PRODUCTACCEPTENCE.Count(x => x.PRODUCTSTATUS == true).ToString();
            labelControl7.Text = db.TBL_PRODUCTACCEPTENCE.Count(x => x.PRODUCTSTATUS == false).ToString();
            labelControl14.Text = db.TBL_PRODUCTS.Count().ToString();
            labelControl7.Text = db.TBL_PRODUCTACCEPTENCE.Count(x => x.PRODUCTSTATUSDETAIL == "parca bekliyor").ToString();
            labelControl12.Text = db.TBL_PRODUCTACCEPTENCE.Count(x => x.PRODUCTSTATUSDETAIL == "message bekliyor").ToString();
            labelControl10.Text = db.TBL_PRODUCTACCEPTENCE.Count(x => x.PRODUCTSTATUSDETAIL == "iptal bekliyor").ToString();


            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7AP9EA1;Initial Catalog=DBtecnicalservices;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT PRODUCTSTATUSDETAIL,COUNT(*) FROM TBL_PRODUCTACCEPTENCE GROUP BY PRODUCTSTATUSDETAIL", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmErrorProdExplanition fr = new FrmErrorProdExplanition();
            fr.id = gridView1.GetFocusedRowCellValue("OPERATIONID").ToString();
            fr.seriNo = gridView1.GetFocusedRowCellValue("PROSERNUM").ToString();
            fr.Show();
        }
    }
}
