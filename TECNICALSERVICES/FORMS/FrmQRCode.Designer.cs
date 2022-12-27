
namespace TECNICALSERVICES.FORMS
{
    partial class FrmQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQRCode));
            this.btnQRCreat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtSerialNum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQRCreat
            // 
            this.btnQRCreat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCreat.Appearance.Options.UseFont = true;
            this.btnQRCreat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQRCreat.ImageOptions.Image")));
            this.btnQRCreat.Location = new System.Drawing.Point(194, 189);
            this.btnQRCreat.Name = "btnQRCreat";
            this.btnQRCreat.Size = new System.Drawing.Size(272, 78);
            this.btnQRCreat.TabIndex = 0;
            this.btnQRCreat.Text = "QR CREATING";
            this.btnQRCreat.Click += new System.EventHandler(this.btnQRCreat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(79, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(597, 34);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "QR CODE CREATING FOR SERIAL NUMBER";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(194, 391);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(272, 251);
            this.pictureEdit1.TabIndex = 2;
            // 
            // txtSerialNum
            // 
            this.txtSerialNum.Location = new System.Drawing.Point(194, 144);
            this.txtSerialNum.Name = "txtSerialNum";
            this.txtSerialNum.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSerialNum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNum.Properties.Appearance.Options.UseBackColor = true;
            this.txtSerialNum.Properties.Appearance.Options.UseFont = true;
            this.txtSerialNum.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSerialNum.Size = new System.Drawing.Size(334, 28);
            this.txtSerialNum.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 148);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(158, 24);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "SERIAL NUMBER :";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(194, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 3);
            this.panel1.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(194, 285);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(272, 78);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "CANCEL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(734, 654);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSerialNum);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnQRCreat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQRCode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNum.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnQRCreat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txtSerialNum;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}