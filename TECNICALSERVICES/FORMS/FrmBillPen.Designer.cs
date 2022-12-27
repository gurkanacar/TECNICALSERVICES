
namespace TECNICALSERVICES.FORMS
{
    partial class FrmBillPen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBillPen));
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtbillid = new DevExpress.XtraEditors.TextEdit();
            this.txttotalprice = new DevExpress.XtraEditors.TextEdit();
            this.txtprice = new DevExpress.XtraEditors.TextEdit();
            this.txtnumber = new DevExpress.XtraEditors.TextEdit();
            this.txtproduct = new DevExpress.XtraEditors.TextEdit();
            this.txtBillDetailid = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbillid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotalprice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtproduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillDetailid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(107, 313);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 29);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "BILL ID :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(44, 261);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(159, 29);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "TOTAL PRICE :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(123, 203);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 29);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "PRICE :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(94, 145);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 29);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "NUMBER :";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Silver;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-2, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1349, 1025);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(21, 47);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(182, 29);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "BILL DETAIL ID :";
            // 
            // btnList
            // 
            this.btnList.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Appearance.Options.UseFont = true;
            this.btnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnList.ImageOptions.Image")));
            this.btnList.Location = new System.Drawing.Point(221, 602);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(303, 57);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "LIST";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(221, 539);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(303, 57);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(221, 476);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(303, 57);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(221, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(303, 57);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(82, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 29);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "PRODUCT :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtbillid);
            this.groupControl1.Controls.Add(this.txttotalprice);
            this.groupControl1.Controls.Add(this.txtprice);
            this.groupControl1.Controls.Add(this.txtnumber);
            this.groupControl1.Controls.Add(this.txtproduct);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtBillDetailid);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnList);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1347, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(554, 1025);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "BILL PEN OPS.";
            // 
            // txtbillid
            // 
            this.txtbillid.Location = new System.Drawing.Point(221, 310);
            this.txtbillid.Name = "txtbillid";
            this.txtbillid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillid.Properties.Appearance.Options.UseFont = true;
            this.txtbillid.Size = new System.Drawing.Size(303, 36);
            this.txtbillid.TabIndex = 5;
            // 
            // txttotalprice
            // 
            this.txttotalprice.Location = new System.Drawing.Point(221, 254);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalprice.Properties.Appearance.Options.UseFont = true;
            this.txttotalprice.Size = new System.Drawing.Size(303, 36);
            this.txttotalprice.TabIndex = 4;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(221, 200);
            this.txtprice.Name = "txtprice";
            this.txtprice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Properties.Appearance.Options.UseFont = true;
            this.txtprice.Size = new System.Drawing.Size(303, 36);
            this.txtprice.TabIndex = 3;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(221, 142);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.Properties.Appearance.Options.UseFont = true;
            this.txtnumber.Size = new System.Drawing.Size(303, 36);
            this.txtnumber.TabIndex = 2;
            // 
            // txtproduct
            // 
            this.txtproduct.Location = new System.Drawing.Point(221, 90);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproduct.Properties.Appearance.Options.UseFont = true;
            this.txtproduct.Size = new System.Drawing.Size(303, 36);
            this.txtproduct.TabIndex = 1;
            // 
            // txtBillDetailid
            // 
            this.txtBillDetailid.Enabled = false;
            this.txtBillDetailid.Location = new System.Drawing.Point(221, 40);
            this.txtBillDetailid.Name = "txtBillDetailid";
            this.txtBillDetailid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillDetailid.Properties.Appearance.Options.UseFont = true;
            this.txtBillDetailid.Size = new System.Drawing.Size(303, 36);
            this.txtBillDetailid.TabIndex = 0;
            // 
            // FrmBillPen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmBillPen";
            this.Text = "FrmBillPen";
            this.Load += new System.EventHandler(this.FrmBillPen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbillid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotalprice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtproduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillDetailid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtBillDetailid;
        private DevExpress.XtraEditors.TextEdit txtbillid;
        private DevExpress.XtraEditors.TextEdit txttotalprice;
        private DevExpress.XtraEditors.TextEdit txtprice;
        private DevExpress.XtraEditors.TextEdit txtnumber;
        private DevExpress.XtraEditors.TextEdit txtproduct;
    }
}