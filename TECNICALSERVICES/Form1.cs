using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECNICALSERVICES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FORMS.FRMPRODUCTLIST fr3;
        private void BtnProductListForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new FORMS.FRMPRODUCTLIST();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }


        FORMS.FrmCategori fr2;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new FORMS.FrmCategori();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }

        private void BtnNewProductEntry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FRMNEWPRODUCT fr = new FORMS.FRMNEWPRODUCT();
           // fr.MdiParent = this;
            fr.Show();
        }

        private void BtnNewCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmNewCategory fr = new FORMS.FrmNewCategory();
            // fr.MdiParent = this;
            fr.Show();
        }

        FORMS.FrmProductStatistic fr4;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr4 == null  || fr4.IsDisposed)
            {
                fr4 = new FORMS.FrmProductStatistic();
                fr4.MdiParent = this;
                fr4.Show();
            }

        }


        private void btnProductStatics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        FORMS.FrmBrand fr5;
        private void btnBrandStatics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new FORMS.FrmBrand();
                fr5.MdiParent = this;
                fr5.Show();
            }
            
        }
        FORMS.FrmCariList fr7;
        private void btnCurrentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr7 == null || fr7.IsDisposed)
            {
                fr7 = new FORMS.FrmCariList();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmCurrentProvince fr = new FORMS.FrmCurrentProvince();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmCurrentAdd fr = new FORMS.FrmCurrentAdd();
            // fr.MdiParent = this;
            fr.Show();
        }

        private void btnDepatmanList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmDepartman fr = new FORMS.FrmDepartman();
             fr.MdiParent = this;
            fr.Show();
        }

        private void btnNewDepart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmNewDepartman fr = new FORMS.FrmNewDepartman();
          //  fr.MdiParent = this;
            fr.Show();
        }

        private void btnPersonList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmPerson fr = new FORMS.FrmPerson();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnCalcu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnexchange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmExchange fr = new FORMS.FrmExchange();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");
        }

        private void btnexcell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel.exe");
        }

        private void btnyoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.Frmyoutube fr = new FORMS.Frmyoutube();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnNoteList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmNotes fr = new FORMS.FrmNotes();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        FORMS.FrmArizaList fr6;
        private void btnErrorProdList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr6 == null ||fr6.IsDisposed)
            {
                fr6 = new FORMS.FrmArizaList();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }

        private void btnNewProductSales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmProductSales fr = new FORMS.FrmProductSales();
           // fr.MdiParent = this;
            fr.Show();
        }

        private void btnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmSALES fr = new FORMS.FrmSALES();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmErrorProductSaves fr = new FORMS.FrmErrorProductSaves();
           // fr.MdiParent = this;
            fr.Show();
        }

        private void btnErrorProdExplanation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmErrorProdExplanition fr = new FORMS.FrmErrorProdExplanition();
            // fr.MdiParent = this;
            fr.Show();
        }

        private void btnErrorproDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmErrorProductDetails1 fr = new FORMS.FrmErrorProductDetails1();
             fr.MdiParent = this;
            fr.Show();
        }

        private void btnQRCreat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmQRCode fr = new FORMS.FrmQRCode();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FRMBillList fr = new FORMS.FRMBillList();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barBillPen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmBillPen fr = new FORMS.FrmBillPen();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BTNBILLSEARCH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FRMFORMPENS fr = new FORMS.FRMFORMPENS();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnAboutus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmGauch fr = new FORMS.FrmGauch();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnMaps_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.Frm_Map fr = new FORMS.Frm_Map();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMS.FrmReport fr = new FORMS.FrmReport();
           // fr.MdiParent = this;
            fr.Show();
        }


        FORMS.FrmMainPage fr;
        private void Form1_Load(object sender, EventArgs e)
        {
            if(fr==null || fr.IsDisposed)
            {
                fr = new FORMS.FrmMainPage();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {

            }
            
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr == null || fr.IsDisposed)
            {
                fr = new FORMS.FrmMainPage();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {

            }
        }
    }
}
