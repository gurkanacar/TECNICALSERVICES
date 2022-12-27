
namespace TECNICALSERVICES.FORMS
{
    partial class FrmNewDepartman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewDepartman));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.picExit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(339, 425);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(238, 70);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "CANCEL";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(58, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(238, 70);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textEdit7
            // 
            this.textEdit7.EditValue = "NEW DEPARTMAN ENTRY";
            this.textEdit7.Location = new System.Drawing.Point(197, 204);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textEdit7.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit7.Properties.Appearance.Options.UseFont = true;
            this.textEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit7.Size = new System.Drawing.Size(278, 34);
            this.textEdit7.TabIndex = 48;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(58, 30);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit7.Size = new System.Drawing.Size(538, 195);
            this.pictureEdit7.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(141, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 2);
            this.panel1.TabIndex = 46;
            // 
            // txtName
            // 
            this.txtName.EditValue = "DEPARTMAN NAME";
            this.txtName.Location = new System.Drawing.Point(141, 332);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.Appearance.Options.UseForeColor = true;
            this.txtName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtName.Size = new System.Drawing.Size(416, 34);
            this.txtName.TabIndex = 45;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(58, 305);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(70, 70);
            this.pictureEdit1.TabIndex = 44;
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.EditValue = ((object)(resources.GetObject("picExit.EditValue")));
            this.picExit.Location = new System.Drawing.Point(601, 12);
            this.picExit.Name = "picExit";
            this.picExit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Properties.Appearance.Options.UseBackColor = true;
            this.picExit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picExit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picExit.Size = new System.Drawing.Size(41, 43);
            this.picExit.TabIndex = 51;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // FrmNewDepartman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(654, 524);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.pictureEdit7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewDepartman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewDepartman";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit picExit;
    }
}