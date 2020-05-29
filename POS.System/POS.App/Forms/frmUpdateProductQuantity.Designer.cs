namespace POS.App.Forms
{
    partial class frmUpdateProductQuantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateProductQuantity));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.pnlContents = new System.Windows.Forms.Panel();
            this.page = new Bunifu.UI.WinForms.BunifuPages();
            this.tabProductDetail = new System.Windows.Forms.TabPage();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtQuantity = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtRemarks = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.pnlContents.SuspendLayout();
            this.page.SuspendLayout();
            this.tabProductDetail.SuspendLayout();
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
            this.pnlContents.Size = new System.Drawing.Size(346, 398);
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
            this.page.Controls.Add(this.tabProductDetail);
            this.page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page.Location = new System.Drawing.Point(0, 42);
            this.page.Multiline = true;
            this.page.Name = "page";
            this.page.Page = this.tabProductDetail;
            this.page.PageIndex = 0;
            this.page.PageName = "tabProductDetail";
            this.page.PageTitle = "tabProductDetail";
            this.page.SelectedIndex = 0;
            this.page.Size = new System.Drawing.Size(344, 354);
            this.page.TabIndex = 37;
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
            // tabProductDetail
            // 
            this.tabProductDetail.BackColor = System.Drawing.Color.White;
            this.tabProductDetail.Controls.Add(this.bunifuCustomLabel1);
            this.tabProductDetail.Controls.Add(this.dtDate);
            this.tabProductDetail.Controls.Add(this.bunifuCustomLabel8);
            this.tabProductDetail.Controls.Add(this.bunifuCustomLabel4);
            this.tabProductDetail.Controls.Add(this.txtQuantity);
            this.tabProductDetail.Controls.Add(this.txtRemarks);
            this.tabProductDetail.Controls.Add(this.btnSave);
            this.tabProductDetail.Location = new System.Drawing.Point(4, 4);
            this.tabProductDetail.Margin = new System.Windows.Forms.Padding(5);
            this.tabProductDetail.Name = "tabProductDetail";
            this.tabProductDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductDetail.Size = new System.Drawing.Size(336, 328);
            this.tabProductDetail.TabIndex = 1;
            this.tabProductDetail.Text = "tabProductDetail";
            this.bunifuToolTip1.SetToolTip(this.tabProductDetail, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabProductDetail, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabProductDetail, "");
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(10, 21);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(38, 19);
            this.bunifuCustomLabel1.TabIndex = 56;
            this.bunifuCustomLabel1.Text = "Date";
            this.bunifuToolTip1.SetToolTip(this.bunifuCustomLabel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCustomLabel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCustomLabel1, "");
            // 
            // dtDate
            // 
            this.dtDate.BorderRadius = 1;
            this.dtDate.Color = System.Drawing.Color.ForestGreen;
            this.dtDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dtDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtDate.DisabledColor = System.Drawing.Color.Gray;
            this.dtDate.DisplayWeekNumbers = false;
            this.dtDate.DPHeight = 0;
            this.dtDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtDate.FillDatePicker = false;
            this.dtDate.ForeColor = System.Drawing.Color.DimGray;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Icon = ((System.Drawing.Image)(resources.GetObject("dtDate.Icon")));
            this.dtDate.IconColor = System.Drawing.Color.ForestGreen;
            this.dtDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtDate.Location = new System.Drawing.Point(14, 43);
            this.dtDate.MinimumSize = new System.Drawing.Size(308, 32);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(308, 32);
            this.dtDate.TabIndex = 55;
            this.bunifuToolTip1.SetToolTip(this.dtDate, "");
            this.bunifuToolTip1.SetToolTipIcon(this.dtDate, null);
            this.bunifuToolTip1.SetToolTipTitle(this.dtDate, "");
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(10, 144);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(61, 19);
            this.bunifuCustomLabel8.TabIndex = 52;
            this.bunifuCustomLabel8.Text = "Remarks";
            this.bunifuToolTip1.SetToolTip(this.bunifuCustomLabel8, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCustomLabel8, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCustomLabel8, "");
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(10, 82);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(63, 19);
            this.bunifuCustomLabel4.TabIndex = 48;
            this.bunifuCustomLabel4.Text = "Quantity";
            this.bunifuToolTip1.SetToolTip(this.bunifuCustomLabel4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCustomLabel4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCustomLabel4, "");
            // 
            // txtQuantity
            // 
            this.txtQuantity.AcceptsReturn = false;
            this.txtQuantity.AcceptsTab = false;
            this.txtQuantity.AnimationSpeed = 200;
            this.txtQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtQuantity.BackgroundImage")));
            this.txtQuantity.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtQuantity.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtQuantity.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtQuantity.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtQuantity.BorderRadius = 1;
            this.txtQuantity.BorderThickness = 1;
            this.txtQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.FillColor = System.Drawing.Color.White;
            this.txtQuantity.HideSelection = true;
            this.txtQuantity.IconLeft = null;
            this.txtQuantity.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.IconPadding = 10;
            this.txtQuantity.IconRight = null;
            this.txtQuantity.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(14, 104);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtQuantity.Modified = false;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQuantity.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtQuantity.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQuantity.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQuantity.OnIdleState = stateProperties4;
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.ReadOnly = false;
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(308, 35);
            this.txtQuantity.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtQuantity.TabIndex = 44;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantity.TextMarginBottom = 0;
            this.txtQuantity.TextMarginLeft = 5;
            this.txtQuantity.TextMarginTop = 0;
            this.txtQuantity.TextPlaceholder = "";
            this.bunifuToolTip1.SetToolTip(this.txtQuantity, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtQuantity, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtQuantity, "");
            this.txtQuantity.UseSystemPasswordChar = false;
            this.txtQuantity.WordWrap = true;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.AcceptsReturn = false;
            this.txtRemarks.AcceptsTab = false;
            this.txtRemarks.AnimationSpeed = 200;
            this.txtRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRemarks.BackColor = System.Drawing.Color.Transparent;
            this.txtRemarks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtRemarks.BackgroundImage")));
            this.txtRemarks.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtRemarks.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtRemarks.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtRemarks.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtRemarks.BorderRadius = 1;
            this.txtRemarks.BorderThickness = 1;
            this.txtRemarks.CausesValidation = false;
            this.txtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRemarks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemarks.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtRemarks.DefaultText = "";
            this.txtRemarks.FillColor = System.Drawing.Color.White;
            this.txtRemarks.HideSelection = true;
            this.txtRemarks.IconLeft = null;
            this.txtRemarks.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemarks.IconPadding = 10;
            this.txtRemarks.IconRight = null;
            this.txtRemarks.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemarks.Lines = new string[0];
            this.txtRemarks.Location = new System.Drawing.Point(14, 166);
            this.txtRemarks.MaxLength = 32767;
            this.txtRemarks.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtRemarks.Modified = false;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRemarks.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtRemarks.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRemarks.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtRemarks.OnIdleState = stateProperties8;
            this.txtRemarks.PasswordChar = '\0';
            this.txtRemarks.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtRemarks.PlaceholderText = "";
            this.txtRemarks.ReadOnly = false;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.SelectionLength = 0;
            this.txtRemarks.SelectionStart = 0;
            this.txtRemarks.ShortcutsEnabled = true;
            this.txtRemarks.Size = new System.Drawing.Size(308, 91);
            this.txtRemarks.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtRemarks.TabIndex = 42;
            this.txtRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRemarks.TextMarginBottom = 0;
            this.txtRemarks.TextMarginLeft = 5;
            this.txtRemarks.TextMarginTop = 0;
            this.txtRemarks.TextPlaceholder = "";
            this.bunifuToolTip1.SetToolTip(this.txtRemarks, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtRemarks, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtRemarks, "");
            this.txtRemarks.UseSystemPasswordChar = false;
            this.txtRemarks.WordWrap = true;
            // 
            // btnSave
            // 
            this.btnSave.AllowToggling = false;
            this.btnSave.AnimationSpeed = 200;
            this.btnSave.AutoGenerateColors = false;
            this.btnSave.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.ButtonText = "Save";
            this.btnSave.ButtonTextMarginLeft = 10;
            this.btnSave.ColorContrastOnClick = 45;
            this.btnSave.ColorContrastOnHover = 45;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.IconMarginLeft = 11;
            this.btnSave.IconPadding = 7;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.IdleBorderRadius = 5;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.IdleIconLeftImage = global::POS.App.Properties.Resources.save_128;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.IndicateFocus = false;
            this.btnSave.Location = new System.Drawing.Point(212, 281);
            this.btnSave.Name = "btnSave";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties9.BorderRadius = 5;
            stateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties9.BorderThickness = 1;
            stateProperties9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties9.ForeColor = System.Drawing.Color.White;
            stateProperties9.IconLeftImage = null;
            stateProperties9.IconRightImage = null;
            this.btnSave.onHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties10.BorderRadius = 5;
            stateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties10.BorderThickness = 1;
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties10.ForeColor = System.Drawing.Color.White;
            stateProperties10.IconLeftImage = null;
            stateProperties10.IconRightImage = null;
            this.btnSave.OnPressedState = stateProperties10;
            this.btnSave.Size = new System.Drawing.Size(110, 41);
            this.btnSave.TabIndex = 7;
            this.btnSave.TabStop = false;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextMarginLeft = 10;
            this.bunifuToolTip1.SetToolTip(this.btnSave, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnSave, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnSave, "");
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGreen;
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.lblTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(344, 42);
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
            this.btnClose.Location = new System.Drawing.Point(317, 9);
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
            this.lblTitle.Size = new System.Drawing.Size(230, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Update Product Quantity";
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
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // frmUpdateProductQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 398);
            this.Controls.Add(this.pnlContents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateProductQuantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditUser";
            this.Load += new System.EventHandler(this.frmAddEditsSupplier_Load);
            this.pnlContents.ResumeLayout(false);
            this.page.ResumeLayout(false);
            this.tabProductDetail.ResumeLayout(false);
            this.tabProductDetail.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContents;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private Bunifu.UI.WinForms.BunifuPages page;
        private System.Windows.Forms.TabPage tabProductDetail;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtRemarks;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtQuantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.UI.WinForms.BunifuDatePicker dtDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}