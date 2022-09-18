namespace InfinityBrowser
{
    partial class frmBrowser
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
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges14 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges15 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnGo = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.txtURL = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnHome = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnForward = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.bnBack = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.pContainer = new System.Windows.Forms.Panel();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.Controls.Add(this.btnGo);
            this.bunifuCards1.Controls.Add(this.btnRefresh);
            this.bunifuCards1.Controls.Add(this.txtURL);
            this.bunifuCards1.Controls.Add(this.btnHome);
            this.bunifuCards1.Controls.Add(this.btnForward);
            this.bunifuCards1.Controls.Add(this.bnBack);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-6, -3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1155, 83);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.bunifuCards1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCards1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCards1, "");
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // btnGo
            // 
            this.btnGo.AllowAnimations = true;
            this.btnGo.AllowBorderColorChanges = true;
            this.btnGo.AllowMouseEffects = true;
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.AnimationSpeed = 200;
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnGo.BorderColor = System.Drawing.Color.Transparent;
            this.btnGo.BorderRadius = 1;
            this.btnGo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnGo.BorderThickness = 1;
            this.btnGo.ColorContrastOnClick = 30;
            this.btnGo.ColorContrastOnHover = 30;
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btnGo.CustomizableEdges = borderEdges11;
            this.btnGo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnGo.Location = new System.Drawing.Point(1074, 15);
            this.btnGo.Name = "btnGo";
            this.btnGo.RoundBorders = true;
            this.btnGo.ShowBorders = true;
            this.btnGo.Size = new System.Drawing.Size(56, 56);
            this.btnGo.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnGo.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.btnGo, "Search");
            this.bunifuToolTip1.SetToolTipIcon(this.btnGo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnGo, "");
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AllowAnimations = true;
            this.btnRefresh.AllowBorderColorChanges = true;
            this.btnRefresh.AllowMouseEffects = true;
            this.btnRefresh.AnimationSpeed = 200;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.BorderColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 1;
            this.btnRefresh.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnRefresh.BorderThickness = 1;
            this.btnRefresh.ColorContrastOnClick = 30;
            this.btnRefresh.ColorContrastOnHover = 30;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.btnRefresh.CustomizableEdges = borderEdges12;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Location = new System.Drawing.Point(237, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RoundBorders = true;
            this.btnRefresh.ShowBorders = true;
            this.btnRefresh.Size = new System.Drawing.Size(56, 56);
            this.btnRefresh.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnRefresh.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.btnRefresh, "Refresh");
            this.bunifuToolTip1.SetToolTipIcon(this.btnRefresh, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnRefresh, "");
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtURL
            // 
            this.txtURL.AcceptsReturn = false;
            this.txtURL.AcceptsTab = false;
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.AnimationSpeed = 200;
            this.txtURL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtURL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtURL.AutoSizeHeight = true;
            this.txtURL.BackColor = System.Drawing.Color.Transparent;
            this.txtURL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtURL.BackgroundImage")));
            this.txtURL.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtURL.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtURL.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtURL.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtURL.BorderRadius = 30;
            this.txtURL.BorderThickness = 2;
            this.txtURL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtURL.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtURL.DefaultText = "";
            this.txtURL.FillColor = System.Drawing.Color.White;
            this.txtURL.HideSelection = true;
            this.txtURL.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtURL.IconLeft")));
            this.txtURL.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtURL.IconPadding = 10;
            this.txtURL.IconRight = ((System.Drawing.Image)(resources.GetObject("txtURL.IconRight")));
            this.txtURL.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtURL.Lines = new string[0];
            this.txtURL.Location = new System.Drawing.Point(307, 19);
            this.txtURL.MaxLength = 32767;
            this.txtURL.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtURL.Modified = false;
            this.txtURL.Multiline = false;
            this.txtURL.Name = "txtURL";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtURL.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtURL.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtURL.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtURL.OnIdleState = stateProperties12;
            this.txtURL.Padding = new System.Windows.Forms.Padding(3);
            this.txtURL.PasswordChar = '\0';
            this.txtURL.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtURL.PlaceholderText = "Enter URL";
            this.txtURL.ReadOnly = false;
            this.txtURL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtURL.SelectedText = "";
            this.txtURL.SelectionLength = 0;
            this.txtURL.SelectionStart = 0;
            this.txtURL.ShortcutsEnabled = true;
            this.txtURL.Size = new System.Drawing.Size(758, 51);
            this.txtURL.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtURL.TabIndex = 1;
            this.txtURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtURL.TextMarginBottom = 0;
            this.txtURL.TextMarginLeft = 10;
            this.txtURL.TextMarginTop = 1;
            this.txtURL.TextPlaceholder = "Enter URL";
            this.bunifuToolTip1.SetToolTip(this.txtURL, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtURL, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtURL, "");
            this.txtURL.UseSystemPasswordChar = false;
            this.txtURL.WordWrap = true;
            this.txtURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtURL_KeyPress);
            this.txtURL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyUp);
            // 
            // btnHome
            // 
            this.btnHome.AllowAnimations = true;
            this.btnHome.AllowBorderColorChanges = true;
            this.btnHome.AllowMouseEffects = true;
            this.btnHome.AnimationSpeed = 200;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 1;
            this.btnHome.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnHome.BorderThickness = 1;
            this.btnHome.ColorContrastOnClick = 30;
            this.btnHome.ColorContrastOnHover = 30;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges13.BottomLeft = true;
            borderEdges13.BottomRight = true;
            borderEdges13.TopLeft = true;
            borderEdges13.TopRight = true;
            this.btnHome.CustomizableEdges = borderEdges13;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnHome.Location = new System.Drawing.Point(164, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.RoundBorders = true;
            this.btnHome.ShowBorders = true;
            this.btnHome.Size = new System.Drawing.Size(56, 56);
            this.btnHome.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnHome.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.btnHome, "Home");
            this.bunifuToolTip1.SetToolTipIcon(this.btnHome, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnHome, "");
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnForward
            // 
            this.btnForward.AllowAnimations = true;
            this.btnForward.AllowBorderColorChanges = true;
            this.btnForward.AllowMouseEffects = true;
            this.btnForward.AnimationSpeed = 200;
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnForward.BorderColor = System.Drawing.Color.Transparent;
            this.btnForward.BorderRadius = 1;
            this.btnForward.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnForward.BorderThickness = 1;
            this.btnForward.ColorContrastOnClick = 30;
            this.btnForward.ColorContrastOnHover = 30;
            this.btnForward.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges14.BottomLeft = true;
            borderEdges14.BottomRight = true;
            borderEdges14.TopLeft = true;
            borderEdges14.TopRight = true;
            this.btnForward.CustomizableEdges = borderEdges14;
            this.btnForward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnForward.Location = new System.Drawing.Point(91, 15);
            this.btnForward.Name = "btnForward";
            this.btnForward.RoundBorders = true;
            this.btnForward.ShowBorders = true;
            this.btnForward.Size = new System.Drawing.Size(56, 56);
            this.btnForward.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnForward.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.btnForward, "Forward");
            this.bunifuToolTip1.SetToolTipIcon(this.btnForward, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnForward, "");
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // bnBack
            // 
            this.bnBack.AllowAnimations = true;
            this.bnBack.AllowBorderColorChanges = true;
            this.bnBack.AllowMouseEffects = true;
            this.bnBack.AnimationSpeed = 200;
            this.bnBack.BackColor = System.Drawing.Color.Transparent;
            this.bnBack.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bnBack.BorderColor = System.Drawing.Color.Transparent;
            this.bnBack.BorderRadius = 1;
            this.bnBack.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bnBack.BorderThickness = 1;
            this.bnBack.ColorContrastOnClick = 30;
            this.bnBack.ColorContrastOnHover = 30;
            this.bnBack.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges15.BottomLeft = true;
            borderEdges15.BottomRight = true;
            borderEdges15.TopLeft = true;
            borderEdges15.TopRight = true;
            this.bnBack.CustomizableEdges = borderEdges15;
            this.bnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bnBack.Image = ((System.Drawing.Image)(resources.GetObject("bnBack.Image")));
            this.bnBack.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bnBack.Location = new System.Drawing.Point(18, 15);
            this.bnBack.Name = "bnBack";
            this.bnBack.RoundBorders = true;
            this.bnBack.ShowBorders = true;
            this.bnBack.Size = new System.Drawing.Size(56, 56);
            this.bnBack.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bnBack.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.bnBack, "Back");
            this.bunifuToolTip1.SetToolTipIcon(this.bnBack, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bnBack, "");
            this.bnBack.Click += new System.EventHandler(this.bunifuIconButton1_Click);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pContainer.Location = new System.Drawing.Point(-3, 73);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1149, 569);
            this.pContainer.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.pContainer, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pContainer, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pContainer, "");
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
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1144, 637);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            this.Text = "frmBrowser";
            this.Load += new System.EventHandler(this.frmBrowser_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuTextBox txtURL;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bnBack;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnForward;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnHome;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnGo;
        private System.Windows.Forms.Panel pContainer;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
    }
}