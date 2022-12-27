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
    public partial class FrmCurrentProvince : Form
    {
        public FrmCurrentProvince()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7AP9EA1;Initial Catalog=DBtecnicalservices;Integrated Security=True");

        private void FrmCurrentProvince_Load(object sender, EventArgs e)
        {
            
            gridControl1.DataSource = db.TBL_CURRENT.OrderBy(x => x.PROVINCE).GroupBy(y => y.PROVINCE).Select(z=>new {province=z.Key,ops=z.Count() }).ToList();

                //
            con.Open();
            SqlCommand comment = new SqlCommand("SELECT PROVINCE,COUNT(*) FROM TBL_CURRENT GROUP BY PROVINCE", con);
            SqlDataReader dr = comment.ExecuteReader();
            while(dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
            con.Close();

        }
    }
}
