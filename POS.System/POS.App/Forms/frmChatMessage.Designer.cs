namespace POS.App.Forms
{
    partial class frmChatMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChatMessage));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtMessageInput = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnSend = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtConverstation = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tmrTimeRefresh = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.ForestGreen;
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.lblTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 42);
            this.panel4.TabIndex = 22;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(429, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Chat";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "conference-256_dogder.png");
            this.imageList1.Images.SetKeyName(1, "conference-256.png");
            // 
            // txtMessageInput
            // 
            this.txtMessageInput.AcceptsReturn = false;
            this.txtMessageInput.AcceptsTab = false;
            this.txtMessageInput.AnimationSpeed = 200;
            this.txtMessageInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMessageInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMessageInput.BackColor = System.Drawing.Color.White;
            this.txtMessageInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMessageInput.BackgroundImage")));
            this.txtMessageInput.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtMessageInput.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtMessageInput.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtMessageInput.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMessageInput.BorderRadius = 1;
            this.txtMessageInput.BorderThickness = 1;
            this.txtMessageInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMessageInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessageInput.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtMessageInput.DefaultText = "";
            this.txtMessageInput.FillColor = System.Drawing.Color.White;
            this.txtMessageInput.HideSelection = true;
            this.txtMessageInput.IconLeft = null;
            this.txtMessageInput.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessageInput.IconPadding = 10;
            this.txtMessageInput.IconRight = null;
            this.txtMessageInput.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessageInput.Lines = new string[0];
            this.txtMessageInput.Location = new System.Drawing.Point(12, 322);
            this.txtMessageInput.MaxLength = 32767;
            this.txtMessageInput.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtMessageInput.Modified = false;
            this.txtMessageInput.Multiline = true;
            this.txtMessageInput.Name = "txtMessageInput";
            stateProperties7.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMessageInput.OnActiveState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Empty;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMessageInput.OnDisabledState = stateProperties8;
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMessageInput.OnHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Silver;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMessageInput.OnIdleState = stateProperties10;
            this.txtMessageInput.PasswordChar = '\0';
            this.txtMessageInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMessageInput.PlaceholderText = "Enter text";
            this.txtMessageInput.ReadOnly = false;
            this.txtMessageInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMessageInput.SelectedText = "";
            this.txtMessageInput.SelectionLength = 0;
            this.txtMessageInput.SelectionStart = 0;
            this.txtMessageInput.ShortcutsEnabled = true;
            this.txtMessageInput.Size = new System.Drawing.Size(375, 47);
            this.txtMessageInput.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtMessageInput.TabIndex = 23;
            this.txtMessageInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMessageInput.TextMarginBottom = 0;
            this.txtMessageInput.TextMarginLeft = 5;
            this.txtMessageInput.TextMarginTop = 0;
            this.txtMessageInput.TextPlaceholder = "Enter text";
            this.txtMessageInput.UseSystemPasswordChar = false;
            this.txtMessageInput.WordWrap = true;
            this.txtMessageInput.Enter += new System.EventHandler(this.txtMessageInput_Enter);
            // 
            // btnSend
            // 
            this.btnSend.AllowToggling = false;
            this.btnSend.AnimationSpeed = 200;
            this.btnSend.AutoGenerateColors = false;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSend.ButtonText = "Send";
            this.btnSend.ButtonTextMarginLeft = 0;
            this.btnSend.ColorContrastOnClick = 45;
            this.btnSend.ColorContrastOnHover = 45;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSend.CustomizableEdges = borderEdges1;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSend.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSend.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSend.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.IconMarginLeft = 11;
            this.btnSend.IconPadding = 10;
            this.btnSend.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.IdleBorderRadius = 3;
            this.btnSend.IdleBorderThickness = 1;
            this.btnSend.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.IdleIconLeftImage = null;
            this.btnSend.IdleIconRightImage = null;
            this.btnSend.IndicateFocus = false;
            this.btnSend.Location = new System.Drawing.Point(393, 322);
            this.btnSend.Name = "btnSend";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btnSend.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btnSend.OnPressedState = stateProperties6;
            this.btnSend.Size = new System.Drawing.Size(60, 45);
            this.btnSend.TabIndex = 24;
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSend.TextMarginLeft = 0;
            this.btnSend.UseDefaultRadiusAndThickness = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtConverstation
            // 
            this.txtConverstation.AcceptsReturn = false;
            this.txtConverstation.AcceptsTab = false;
            this.txtConverstation.AnimationSpeed = 200;
            this.txtConverstation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtConverstation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtConverstation.BackColor = System.Drawing.Color.White;
            this.txtConverstation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtConverstation.BackgroundImage")));
            this.txtConverstation.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtConverstation.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtConverstation.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtConverstation.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtConverstation.BorderRadius = 1;
            this.txtConverstation.BorderThickness = 1;
            this.txtConverstation.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConverstation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConverstation.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtConverstation.DefaultText = "";
            this.txtConverstation.FillColor = System.Drawing.Color.White;
            this.txtConverstation.HideSelection = true;
            this.txtConverstation.IconLeft = null;
            this.txtConverstation.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConverstation.IconPadding = 10;
            this.txtConverstation.IconRight = null;
            this.txtConverstation.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConverstation.Lines = new string[0];
            this.txtConverstation.Location = new System.Drawing.Point(12, 60);
            this.txtConverstation.MaxLength = 32767;
            this.txtConverstation.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtConverstation.Modified = false;
            this.txtConverstation.Multiline = true;
            this.txtConverstation.Name = "txtConverstation";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtConverstation.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtConverstation.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtConverstation.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtConverstation.OnIdleState = stateProperties4;
            this.txtConverstation.PasswordChar = '\0';
            this.txtConverstation.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtConverstation.PlaceholderText = "";
            this.txtConverstation.ReadOnly = false;
            this.txtConverstation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConverstation.SelectedText = "";
            this.txtConverstation.SelectionLength = 0;
            this.txtConverstation.SelectionStart = 0;
            this.txtConverstation.ShortcutsEnabled = true;
            this.txtConverstation.Size = new System.Drawing.Size(435, 256);
            this.txtConverstation.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtConverstation.TabIndex = 25;
            this.txtConverstation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConverstation.TextMarginBottom = 0;
            this.txtConverstation.TextMarginLeft = 5;
            this.txtConverstation.TextMarginTop = 0;
            this.txtConverstation.TextPlaceholder = "";
            this.txtConverstation.UseSystemPasswordChar = false;
            this.txtConverstation.WordWrap = true;
            // 
            // tmrTimeRefresh
            // 
            this.tmrTimeRefresh.Enabled = true;
            this.tmrTimeRefresh.Interval = 3000;
            this.tmrTimeRefresh.Tick += new System.EventHandler(this.tmrTimeRefresh_Tick);
            // 
            // frmChatMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 381);
            this.Controls.Add(this.txtConverstation);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessageInput);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChatMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChatPanel";
            this.Load += new System.EventHandler(this.frmChatPanel_Load);
            this.Shown += new System.EventHandler(this.frmChatMessage_Shown);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtMessageInput;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtConverstation;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSend;
        private System.Windows.Forms.Timer tmrTimeRefresh;
    }
}