namespace POS.App.Forms
{
    partial class frmQuantityUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuantityUpdate));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblTotal = new DevComponents.DotNetBar.LabelX();
            this.lblPrice = new DevComponents.DotNetBar.LabelX();
            this.lblAvailableQuantity = new DevComponents.DotNetBar.LabelX();
            this.lblProductName = new DevComponents.DotNetBar.LabelX();
            this.txtQuantity = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSubtract = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubtract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
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
            this.panel4.Size = new System.Drawing.Size(351, 42);
            this.panel4.TabIndex = 22;
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
            this.lblTitle.Size = new System.Drawing.Size(244, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Update Product Quantity";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnSubtract);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblAvailableQuantity);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 379);
            this.panel1.TabIndex = 44;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.DimGray;
            this.labelX5.Location = new System.Drawing.Point(17, 205);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(174, 31);
            this.labelX5.TabIndex = 55;
            this.labelX5.Text = "Quantity to Update";
            this.labelX5.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelX5.WordWrap = true;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.DimGray;
            this.labelX4.Location = new System.Drawing.Point(17, 277);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(134, 31);
            this.labelX4.TabIndex = 54;
            this.labelX4.Text = "Total Amount:";
            this.labelX4.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelX4.WordWrap = true;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.DimGray;
            this.labelX3.Location = new System.Drawing.Point(16, 158);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(110, 31);
            this.labelX3.TabIndex = 53;
            this.labelX3.Text = "Unit Price:";
            this.labelX3.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelX3.WordWrap = true;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.DimGray;
            this.labelX2.Location = new System.Drawing.Point(16, 121);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(181, 31);
            this.labelX2.TabIndex = 52;
            this.labelX2.Text = "Available Quantity:";
            this.labelX2.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelX2.WordWrap = true;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.DimGray;
            this.labelX1.Location = new System.Drawing.Point(17, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(144, 29);
            this.labelX1.TabIndex = 51;
            this.labelX1.Text = "Product Name:";
            this.labelX1.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelX1.WordWrap = true;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotal.Location = new System.Drawing.Point(157, 276);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(179, 31);
            this.lblTotal.TabIndex = 50;
            this.lblTotal.Text = "0";
            this.lblTotal.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.lblTotal.WordWrap = true;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrice.Location = new System.Drawing.Point(143, 152);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(161, 31);
            this.lblPrice.TabIndex = 49;
            this.lblPrice.Text = "0";
            this.lblPrice.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.lblPrice.WordWrap = true;
            // 
            // lblAvailableQuantity
            // 
            this.lblAvailableQuantity.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblAvailableQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAvailableQuantity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.lblAvailableQuantity.Location = new System.Drawing.Point(203, 117);
            this.lblAvailableQuantity.Name = "lblAvailableQuantity";
            this.lblAvailableQuantity.Size = new System.Drawing.Size(101, 31);
            this.lblAvailableQuantity.TabIndex = 45;
            this.lblAvailableQuantity.Text = "0";
            this.lblAvailableQuantity.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.lblAvailableQuantity.WordWrap = true;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblProductName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.DimGray;
            this.lblProductName.Location = new System.Drawing.Point(17, 63);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(312, 52);
            this.lblProductName.TabIndex = 44;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.lblProductName.WordWrap = true;
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
            this.txtQuantity.Location = new System.Drawing.Point(20, 235);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtQuantity.Modified = false;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            stateProperties7.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQuantity.OnActiveState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Empty;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtQuantity.OnDisabledState = stateProperties8;
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQuantity.OnHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Silver;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQuantity.OnIdleState = stateProperties10;
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.ReadOnly = false;
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(254, 35);
            this.txtQuantity.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtQuantity.TabIndex = 56;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantity.TextMarginBottom = 0;
            this.txtQuantity.TextMarginLeft = 5;
            this.txtQuantity.TextMarginTop = 0;
            this.txtQuantity.TextPlaceholder = "";
            this.txtQuantity.UseSystemPasswordChar = false;
            this.txtQuantity.WordWrap = true;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged_1);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges2;
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
            this.btnSave.Location = new System.Drawing.Point(226, 322);
            this.btnSave.Name = "btnSave";
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.BorderRadius = 5;
            stateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties11.BorderThickness = 1;
            stateProperties11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.ForeColor = System.Drawing.Color.White;
            stateProperties11.IconLeftImage = null;
            stateProperties11.IconRightImage = null;
            this.btnSave.onHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties12.BorderRadius = 5;
            stateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties12.BorderThickness = 1;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.IconLeftImage = null;
            stateProperties12.IconRightImage = null;
            this.btnSave.OnPressedState = stateProperties12;
            this.btnSave.Size = new System.Drawing.Size(110, 41);
            this.btnSave.TabIndex = 48;
            this.btnSave.TabStop = false;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextMarginLeft = 10;
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Image = global::POS.App.Properties.Resources.minus_4_256__1_;
            this.btnSubtract.ImageActive = null;
            this.btnSubtract.Location = new System.Drawing.Point(308, 239);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(24, 24);
            this.btnSubtract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSubtract.TabIndex = 47;
            this.btnSubtract.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSubtract, "Delete");
            this.btnSubtract.Zoom = 10;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::POS.App.Properties.Resources.plus_4_256;
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(280, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 46;
            this.btnAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAdd, "Add");
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::POS.App.Properties.Resources.close_window_32__1_;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(321, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmQuantityUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuantityUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChatPanel";
            this.Load += new System.EventHandler(this.frm_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSubtract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblTotal;
        private DevComponents.DotNetBar.LabelX lblPrice;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private Bunifu.Framework.UI.BunifuImageButton btnSubtract;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private DevComponents.DotNetBar.LabelX lblAvailableQuantity;
        private DevComponents.DotNetBar.LabelX lblProductName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtQuantity;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}