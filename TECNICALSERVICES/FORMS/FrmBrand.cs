using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TECNICALSERVICES.FORMS
{
    public partial class FrmBrand : Form
    {
        public FrmBrand()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void FrmBrand_Load(object sender, EventArgs e)
        {
            //IMP
            var degerler = db.TBL_PRODUCTS.OrderBy(x => x.BRAND).GroupBy(y => y.BRAND).Select(z => new
            {
                Brand=z.Key,
                Total=z.Count()
            });
            gridControl1.DataSource = degerler.ToList();

            


            labelControl2.Text = db.TBL_PRODUCTS.Count().ToString();
            labelControl3.Text = (from x in db.TBL_PRODUCTS
                                  select x.BRAND).Distinct().Count().ToString();


            labelControl7.Text = (from x in db.TBL_PRODUCTS
                                  orderby x.SELLINGPRICE descending
                                  select x.BRAND).FirstOrDefault();


            //chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Arcelik",6);
            //chartControl1.Series["Series 1"].Points.AddPoint("Beko",2);
            //chartControl1.Series["Series 1"].Points.AddPoint("Toshiba",1);
            //chartControl1.Series["Series 1"].Points.AddPoint("Lenova",1);

            //1.CHART
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7AP9EA1;Initial Catalog=DBtecnicalservices;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT BRAND,COUNT(*) FROM TBL_PRODUCTS GROUP BY BRAND", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
            baglanti.Close();


            //chartControl2.Series["Kategoriler"].Points.AddPoint("Beyaz Esya", 4);
            //chartControl2.Series["Kategoriler"].Points.AddPoint("Bilgisayar", 3);
            //chartControl2.Series["Kategoriler"].Points.AddPoint("Tv", 6);
            //chartControl2.Series["Kategoriler"].Points.AddPoint("Telefon", 2);
            //chartControl2.Series["Kategoriler"].Points.AddPoint("Diger", 2);

            //2CHART

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT TBL_CATEGORIES.NAME,COUNT(*) FROM TBL_PRODUCTS INNER JOIN TBL_CATEGORIES ON TBL_CATEGORIES.ID=TBL_PRODUCTS.CATEGORIES GROUP BY TBL_CATEGORIES.NAME", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Kategoriler"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            baglanti.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
