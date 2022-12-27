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
    public partial class FrmPerson : Form
    {
        public FrmPerson()
        {
            InitializeComponent();
        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }
        void metod1()
        {
            // istenilen degerleri getirme
            var degerler = from u in db.TBL_PERSON
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.PHONE,
                           };
            gridControl1.DataSource = degerler.ToList();


            // lookUpEdit1.Properties.DataSource = db.TBL_DEPARTMAN.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBL_DEPARTMAN
                                                select new
                                                {
                                                    x.ID,
                                                    x.NAME ,
                                                }).ToList();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void FrmPerson_Load(object sender, EventArgs e)
        {
            metod1();
            //1.person
            string ad1, soyad1;
            ad1 = db.TBL_PERSON.First(x => x.ID == 1).AD;
            soyad1 = db.TBL_PERSON.First(x => x.ID == 1).SOYAD;
            txtDepartman.Text = db.TBL_PERSON.First(x => x.ID == 1).TBL_DEPARTMAN.NAME;
            txtMail.Text= db.TBL_PERSON.First(x => x.ID == 1).MAIL;
            txtName1.Text = ad1 + " " + soyad1;
            //2.person
            string ad2, soyad2;
            ad2 = db.TBL_PERSON.First(x => x.ID == 2).AD;
            soyad2 = db.TBL_PERSON.First(x => x.ID == 2).SOYAD;
            labelControl5.Text = db.TBL_PERSON.First(x => x.ID == 2).TBL_DEPARTMAN.NAME;
            labelControl2.Text = db.TBL_PERSON.First(x => x.ID == 2).MAIL;
            labelControl9.Text = ad2 + " " + soyad2;
            //3.person
            string ad3, soyad3;
            ad3 = db.TBL_PERSON.First(x => x.ID == 3).AD;
            soyad3 = db.TBL_PERSON.First(x => x.ID == 3).SOYAD;
            labelControl15.Text = db.TBL_PERSON.First(x => x.ID == 3).TBL_DEPARTMAN.NAME;
            labelControl11.Text = db.TBL_PERSON.First(x => x.ID == 3).MAIL;
            labelControl17.Text = ad3 + " " + soyad3;
            //4.person
            string ad4, soyad4;
            ad4 = db.TBL_PERSON.First(x => x.ID == 4).AD;
            soyad4 = db.TBL_PERSON.First(x => x.ID == 4).SOYAD;
            labelControl21.Text = db.TBL_PERSON.First(x => x.ID == 4).TBL_DEPARTMAN.NAME;
            labelControl19.Text = db.TBL_PERSON.First(x => x.ID == 4).MAIL;
            labelControl23.Text = ad4 + " " + soyad4;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBL_PERSON t = new TBL_PERSON();
            t.AD = txtName.Text;
            t.SOYAD = txtSurname.Text;
            t.DEPARTMENT = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBL_PERSON.Add(t);
            db.SaveChanges();
            MessageBox.Show("personel sisteme basari ile eklendi");
            metod1();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtName.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtSurname.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            txtMaill.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            txtPhone.Text = gridView1.GetFocusedRowCellValue("PHONE").ToString();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            metod1();
        }
    }
}
