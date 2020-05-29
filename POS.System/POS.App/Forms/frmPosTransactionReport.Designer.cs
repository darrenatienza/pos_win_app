namespace POS.App.Forms
{
    partial class frmPosTransactionReport
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosTransactionReport));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnlContents = new System.Windows.Forms.Panel();
            this.page = new Bunifu.UI.WinForms.BunifuPages();
            this.tabSupplierList = new System.Windows.Forms.TabPage();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtDateFrom = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dtDateTo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlContents.SuspendLayout();
            this.page.SuspendLayout();
            this.tabSupplierList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContents
            // 
            this.pnlContents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContents.Controls.Add(this.page);
            this.pnlContents.Controls.Add(this.panel4);
            this.pnlContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContents.Location = new System.Drawing.Point(0, 0);
            this.pnlContents.Name = "pnlContents";
            this.pnlContents.Size = new System.Drawing.Size(802, 592);
            this.pnlContents.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.pnlContents, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlContents, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlContents, "");
            this.pnlContents.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContents_Paint);
            // 
            // page
            // 
            this.page.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.page.AllowTransitions = true;
            this.page.Controls.Add(this.tabSupplierList);
            this.page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page.Location = new System.Drawing.Point(0, 42);
            this.page.Multiline = true;
            this.page.Name = "page";
            this.page.Page = this.tabSupplierList;
            this.page.PageIndex = 0;
            this.page.PageName = "tabSupplierList";
            this.page.PageTitle = "tabPage1";
            this.page.SelectedIndex = 0;
            this.page.Size = new System.Drawing.Size(800, 548);
            this.page.TabIndex = 39;
            this.bunifuToolTip1.SetToolTip(this.page, "");
            this.bunifuToolTip1.SetToolTipIcon(this.page, null);
            this.bunifuToolTip1.SetToolTipTitle(this.page, "");
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.page.Transition = animation1;
            this.page.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabSupplierList
            // 
            this.tabSupplierList.Controls.Add(this.rptViewer);
            this.tabSupplierList.Controls.Add(this.panel2);
            this.tabSupplierList.Location = new System.Drawing.Point(4, 4);
            this.tabSupplierList.Name = "tabSupplierList";
            this.tabSupplierList.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupplierList.Size = new System.Drawing.Size(792, 522);
            this.tabSupplierList.TabIndex = 0;
            this.tabSupplierList.Text = "tabPage1";
            this.bunifuToolTip1.SetToolTip(this.tabSupplierList, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabSupplierList, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabSupplierList, "");
            this.tabSupplierList.UseVisualStyleBackColor = true;
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewer.LocalReport.ReportEmbeddedResource = "POS.App.Reports.rptPosTransaction.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(3, 49);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(786, 470);
            this.rptViewer.TabIndex = 40;
            this.bunifuToolTip1.SetToolTip(this.rptViewer, "");
            this.bunifuToolTip1.SetToolTipIcon(this.rptViewer, null);
            this.bunifuToolTip1.SetToolTipTitle(this.rptViewer, "");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Controls.Add(this.dtDateFrom);
            this.panel2.Controls.Add(this.dtDateTo);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 46);
            this.panel2.TabIndex = 39;
            this.bunifuToolTip1.SetToolTip(this.panel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel2, "");
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.DimGray;
            this.labelX2.Location = new System.Drawing.Point(394, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 23);
            this.labelX2.TabIndex = 35;
            this.labelX2.Text = "Date To:";
            this.bunifuToolTip1.SetToolTip(this.labelX2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.labelX2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.labelX2, "");
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.DimGray;
            this.labelX1.Location = new System.Drawing.Point(161, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(71, 23);
            this.labelX1.TabIndex = 34;
            this.labelX1.Text = "Date From:";
            this.bunifuToolTip1.SetToolTip(this.labelX1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.labelX1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.labelX1, "");
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.BorderRadius = 1;
            this.dtDateFrom.Color = System.Drawing.Color.DimGray;
            this.dtDateFrom.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dtDateFrom.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtDateFrom.DisabledColor = System.Drawing.Color.Gray;
            this.dtDateFrom.DisplayWeekNumbers = false;
            this.dtDateFrom.DPHeight = 0;
            this.dtDateFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtDateFrom.FillDatePicker = false;
            this.dtDateFrom.ForeColor = System.Drawing.Color.DimGray;
            this.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFrom.Icon = ((System.Drawing.Image)(resources.GetObject("dtDateFrom.Icon")));
            this.dtDateFrom.IconColor = System.Drawing.Color.DimGray;
            this.dtDateFrom.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtDateFrom.Location = new System.Drawing.Point(238, 8);
            this.dtDateFrom.MinimumSize = new System.Drawing.Size(150, 32);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(150, 32);
            this.dtDateFrom.TabIndex = 33;
            this.bunifuToolTip1.SetToolTip(this.dtDateFrom, "");
            this.bunifuToolTip1.SetToolTipIcon(this.dtDateFrom, null);
            this.bunifuToolTip1.SetToolTipTitle(this.dtDateFrom, "");
            // 
            // dtDateTo
            // 
            this.dtDateTo.BorderRadius = 1;
            this.dtDateTo.Color = System.Drawing.Color.DimGray;
            this.dtDateTo.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dtDateTo.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtDateTo.DisabledColor = System.Drawing.Color.Gray;
            this.dtDateTo.DisplayWeekNumbers = false;
            this.dtDateTo.DPHeight = 0;
            this.dtDateTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtDateTo.FillDatePicker = false;
            this.dtDateTo.ForeColor = System.Drawing.Color.DimGray;
            this.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateTo.Icon = ((System.Drawing.Image)(resources.GetObject("dtDateTo.Icon")));
            this.dtDateTo.IconColor = System.Drawing.Color.DimGray;
            this.dtDateTo.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtDateTo.Location = new System.Drawing.Point(453, 8);
            this.dtDateTo.MinimumSize = new System.Drawing.Size(150, 32);
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Size = new System.Drawing.Size(150, 32);
            this.dtDateTo.TabIndex = 32;
            this.bunifuToolTip1.SetToolTip(this.dtDateTo, "");
            this.bunifuToolTip1.SetToolTipIcon(this.dtDateTo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.dtDateTo, "");
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DarkGreen;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = global::POS.App.Properties.Resources.search_3_256;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(609, 6);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DarkGreen;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(173, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 5;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Search";
            this.bunifuToolTip1.SetToolTip(this.txtSearch, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtSearch, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtSearch, "");
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.OnIconRightClick += new System.EventHandler(this.txtSearch_OnIconRightClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGreen;
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.lblTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 42);
            this.panel4.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.panel4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel4, "");
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::POS.App.Properties.Resources.close_window_32__1_;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(773, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnClose, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnClose, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnClose, "");
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            // 
            // 
            // 
            this.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(9, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Transactions Report";
            this.bunifuToolTip1.SetToolTip(this.lblTitle, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblTitle, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblTitle, "");
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
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
            this.bunifuDragControl1.TargetControl = this.panel4;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmPosTransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 592);
            this.Controls.Add(this.pnlContents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPosTransactionReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditUser";
            this.Load += new System.EventHandler(this.frmAddEditsSupplier_Load);
            this.pnlContents.ResumeLayout(false);
            this.page.ResumeLayout(false);
            this.tabSupplierList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContents;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuPages page;
        private System.Windows.Forms.TabPage tabSupplierList;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearch;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private Bunifu.UI.WinForms.BunifuDatePicker dtDateFrom;
        private Bunifu.UI.WinForms.BunifuDatePicker dtDateTo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
    }
}