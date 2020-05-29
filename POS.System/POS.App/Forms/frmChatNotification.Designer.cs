namespace POS.App.Forms
{
    partial class frmChatNotification
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tmrTimeOut = new System.Windows.Forms.Timer(this.components);
            this.tmrClose = new System.Windows.Forms.Timer(this.components);
            this.tmrShow = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblContent = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(163, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Point of Sale Chat Notification";
            // 
            // tmrTimeOut
            // 
            this.tmrTimeOut.Enabled = true;
            this.tmrTimeOut.Interval = 15000;
            this.tmrTimeOut.Tick += new System.EventHandler(this.tmrTimeOut_Tick);
            // 
            // tmrClose
            // 
            this.tmrClose.Interval = 50;
            this.tmrClose.Tick += new System.EventHandler(this.tmrClose_Tick);
            // 
            // tmrShow
            // 
            this.tmrShow.Interval = 30;
            this.tmrShow.Tick += new System.EventHandler(this.tmrShow_Tick);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::POS.App.Properties.Resources.close_window_32__1_;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(234, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.ForeColor = System.Drawing.Color.White;
            this.lblContent.Location = new System.Drawing.Point(59, 30);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(121, 26);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "You just recieved new \r\nmessage!";
            // 
            // frmChatNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(258, 67);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChatNotification";
            this.Opacity = 0.9D;
            this.Text = "frmChatNotification";
            this.Load += new System.EventHandler(this.frmChatNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer tmrTimeOut;
        private System.Windows.Forms.Timer tmrClose;
        private System.Windows.Forms.Timer tmrShow;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel lblContent;
    }
}