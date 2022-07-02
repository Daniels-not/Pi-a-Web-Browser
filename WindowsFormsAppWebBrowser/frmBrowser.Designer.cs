namespace WindowsFormsAppWebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.gpnl_topbar = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_settings = new Guna.UI2.WinForms.Guna2Button();
            this.btn_download = new Guna.UI2.WinForms.Guna2Button();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.btn_home = new Guna.UI2.WinForms.Guna2Button();
            this.btn_forward = new Guna.UI2.WinForms.Guna2Button();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.wbr_main = new System.Windows.Forms.WebBrowser();
            this.gpnl_topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpnl_topbar
            // 
            this.gpnl_topbar.BackColor = System.Drawing.Color.White;
            this.gpnl_topbar.Controls.Add(this.btn_settings);
            this.gpnl_topbar.Controls.Add(this.btn_download);
            this.gpnl_topbar.Controls.Add(this.txt_search);
            this.gpnl_topbar.Controls.Add(this.btn_reset);
            this.gpnl_topbar.Controls.Add(this.btn_home);
            this.gpnl_topbar.Controls.Add(this.btn_forward);
            this.gpnl_topbar.Controls.Add(this.btn_back);
            this.gpnl_topbar.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gpnl_topbar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gpnl_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpnl_topbar.Location = new System.Drawing.Point(0, 0);
            this.gpnl_topbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpnl_topbar.Name = "gpnl_topbar";
            this.gpnl_topbar.ShadowDecoration.Parent = this.gpnl_topbar;
            this.gpnl_topbar.Size = new System.Drawing.Size(900, 78);
            this.gpnl_topbar.TabIndex = 0;
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settings.BorderRadius = 3;
            this.btn_settings.CheckedState.Parent = this.btn_settings;
            this.btn_settings.CustomImages.Parent = this.btn_settings;
            this.btn_settings.FillColor = System.Drawing.Color.Transparent;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_settings.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_settings.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_settings.HoverState.Parent = this.btn_settings;
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.ImageSize = new System.Drawing.Size(33, 33);
            this.btn_settings.Location = new System.Drawing.Point(845, 11);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.ShadowDecoration.Parent = this.btn_settings;
            this.btn_settings.Size = new System.Drawing.Size(52, 54);
            this.btn_settings.TabIndex = 7;
            // 
            // btn_download
            // 
            this.btn_download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_download.BorderRadius = 3;
            this.btn_download.CheckedState.Parent = this.btn_download;
            this.btn_download.CustomImages.Parent = this.btn_download;
            this.btn_download.FillColor = System.Drawing.Color.Transparent;
            this.btn_download.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_download.ForeColor = System.Drawing.Color.White;
            this.btn_download.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_download.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_download.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_download.HoverState.Parent = this.btn_download;
            this.btn_download.Image = ((System.Drawing.Image)(resources.GetObject("btn_download.Image")));
            this.btn_download.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_download.Location = new System.Drawing.Point(786, 11);
            this.btn_download.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_download.Name = "btn_download";
            this.btn_download.ShadowDecoration.Parent = this.btn_download;
            this.btn_download.Size = new System.Drawing.Size(52, 54);
            this.btn_download.TabIndex = 6;
            this.btn_download.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BorderRadius = 3;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.Parent = this.txt_search;
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.FocusedState.Parent = this.txt_search;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.HoverState.Parent = this.txt_search;
            this.txt_search.Location = new System.Drawing.Point(243, 11);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "";
            this.txt_search.SelectedText = "";
            this.txt_search.ShadowDecoration.Parent = this.txt_search;
            this.txt_search.Size = new System.Drawing.Size(536, 54);
            this.txt_search.TabIndex = 5;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // btn_reset
            // 
            this.btn_reset.BorderRadius = 3;
            this.btn_reset.CheckedState.Parent = this.btn_reset;
            this.btn_reset.CustomImages.Parent = this.btn_reset;
            this.btn_reset.FillColor = System.Drawing.Color.Transparent;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_reset.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_reset.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_reset.HoverState.Parent = this.btn_reset;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_reset.Location = new System.Drawing.Point(183, 11);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.ShadowDecoration.Parent = this.btn_reset;
            this.btn_reset.Size = new System.Drawing.Size(52, 54);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_home
            // 
            this.btn_home.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_home.BorderRadius = 3;
            this.btn_home.CheckedState.Parent = this.btn_home;
            this.btn_home.CustomImages.Parent = this.btn_home;
            this.btn_home.FillColor = System.Drawing.Color.Transparent;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_home.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_home.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_home.HoverState.Parent = this.btn_home;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_home.Location = new System.Drawing.Point(125, 11);
            this.btn_home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_home.Name = "btn_home";
            this.btn_home.ShadowDecoration.Parent = this.btn_home;
            this.btn_home.Size = new System.Drawing.Size(52, 54);
            this.btn_home.TabIndex = 3;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_forward.BorderRadius = 3;
            this.btn_forward.CheckedState.Parent = this.btn_forward;
            this.btn_forward.CustomImages.Parent = this.btn_forward;
            this.btn_forward.FillColor = System.Drawing.Color.Transparent;
            this.btn_forward.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_forward.ForeColor = System.Drawing.Color.White;
            this.btn_forward.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_forward.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_forward.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_forward.HoverState.Parent = this.btn_forward;
            this.btn_forward.Image = ((System.Drawing.Image)(resources.GetObject("btn_forward.Image")));
            this.btn_forward.Location = new System.Drawing.Point(66, 11);
            this.btn_forward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.ShadowDecoration.Parent = this.btn_forward;
            this.btn_forward.Size = new System.Drawing.Size(52, 54);
            this.btn_forward.TabIndex = 2;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_back
            // 
            this.btn_back.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.BorderRadius = 3;
            this.btn_back.CheckedState.Parent = this.btn_back;
            this.btn_back.CustomImages.Parent = this.btn_back;
            this.btn_back.FillColor = System.Drawing.Color.Transparent;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_back.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_back.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(8, 11);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(52, 54);
            this.btn_back.TabIndex = 1;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // wbr_main
            // 
            this.wbr_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbr_main.Location = new System.Drawing.Point(0, 78);
            this.wbr_main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wbr_main.MinimumSize = new System.Drawing.Size(22, 25);
            this.wbr_main.Name = "wbr_main";
            this.wbr_main.Size = new System.Drawing.Size(900, 484);
            this.wbr_main.TabIndex = 2;
            this.wbr_main.Tag = "";
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.wbr_main);
            this.Controls.Add(this.gpnl_topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBrowser";
            this.Text = "frmBrowser";
            this.gpnl_topbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gpnl_topbar;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
        private Guna.UI2.WinForms.Guna2Button btn_home;
        private Guna.UI2.WinForms.Guna2Button btn_forward;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2Button btn_settings;
        private Guna.UI2.WinForms.Guna2Button btn_download;
        private System.Windows.Forms.WebBrowser wbr_main;
    }
}