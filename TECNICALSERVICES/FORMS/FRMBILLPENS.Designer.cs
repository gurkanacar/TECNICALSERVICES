
namespace TECNICALSERVICES.FORMS
{
    partial class FRMFORMPENS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMFORMPENS));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtserino = new DevExpress.XtraEditors.TextEdit();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtqueueno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtbillid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqueueno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbillid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 102);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1900, 919);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(430, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(193, 29);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "SERIAL NUMBER :";
            // 
            // txtserino
            // 
            this.txtserino.Location = new System.Drawing.Point(629, 20);
            this.txtserino.Name = "txtserino";
            this.txtserino.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserino.Properties.Appearance.Options.UseFont = true;
            this.txtserino.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtserino.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtserino.Properties.MaskSettings.Set("mask", "A");
            this.txtserino.Size = new System.Drawing.Size(234, 34);
            this.txtserino.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.ImageOptions.Image")));
            this.btnsearch.Location = new System.Drawing.Point(1343, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(234, 41);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtqueueno
            // 
            this.txtqueueno.Location = new System.Drawing.Point(1085, 17);
            this.txtqueueno.Name = "txtqueueno";
            this.txtqueueno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqueueno.Properties.Appearance.Options.UseFont = true;
            this.txtqueueno.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtqueueno.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtqueueno.Properties.MaskSettings.Set("mask", "000000");
            this.txtqueueno.Size = new System.Drawing.Size(234, 34);
            this.txtqueueno.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(887, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(192, 29);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "QUEUE NUMBER :";
            // 
            // txtbillid
            // 
            this.txtbillid.Location = new System.Drawing.Point(170, 20);
            this.txtbillid.Name = "txtbillid";
            this.txtbillid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillid.Properties.Appearance.Options.UseFont = true;
            this.txtbillid.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtbillid.Size = new System.Drawing.Size(234, 34);
            this.txtbillid.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(68, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 29);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "BILL ID :";
            // 
            // FRMFORMPENS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.txtbillid);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtqueueno);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtserino);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FRMFORMPENS";
            this.Text = "FRMBILLPENS";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqueueno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbillid.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtserino;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private DevExpress.XtraEditors.TextEdit txtqueueno;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtbillid;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}