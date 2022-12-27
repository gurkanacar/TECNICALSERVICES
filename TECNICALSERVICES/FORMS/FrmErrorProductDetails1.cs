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
    public partial class FrmErrorProductDetails1 : Form
    {
        public FrmErrorProductDetails1()
        {
            InitializeComponent();
        }

        private void FrmErrorProductDetails1_Load(object sender, EventArgs e)
        {
            DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
            gridControl1.DataSource =(from x in db.TBL_PRODUCTFOLLOWING
                                      select new
                                      {
                                          x.FOLLOWINGID,
                                          x.SERIALNO,
                                          x.DATE,
                                          x.EXPLANATION
                                      }).ToList();
        }
    }
}
