
namespace AirLineSystem
{
    partial class AdminForm
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
            this.shadowpannel = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.tasker_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.CurrentIcon = new FontAwesome.Sharp.IconPictureBox();
            this.sidemenupanel = new System.Windows.Forms.Panel();
            this.goback_btn = new FontAwesome.Sharp.IconButton();
            this.discount_btn = new FontAwesome.Sharp.IconButton();
            this.pilots_btn = new FontAwesome.Sharp.IconButton();
            this.aircrafts_btn = new FontAwesome.Sharp.IconButton();
            this.flights_btn = new FontAwesome.Sharp.IconButton();
            this.routes_btn = new FontAwesome.Sharp.IconButton();
            this.home_btn = new FontAwesome.Sharp.IconButton();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentIcon)).BeginInit();
            this.sidemenupanel.SuspendLayout();
            this.logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shadowpannel
            // 
            this.shadowpannel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.shadowpannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shadowpannel.ForeColor = System.Drawing.Color.Coral;
            this.shadowpannel.Location = new System.Drawing.Point(266, 78);
            this.shadowpannel.Margin = new System.Windows.Forms.Padding(4);
            this.shadowpannel.Name = "shadowpannel";
            this.shadowpannel.Size = new System.Drawing.Size(1134, 10);
            this.shadowpannel.TabIndex = 7;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelDesktop.Location = new System.Drawing.Point(266, 78);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1134, 721);
            this.panelDesktop.TabIndex = 6;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(115)))));
            this.panelTitleBar.Controls.Add(this.minimize_btn);
            this.panelTitleBar.Controls.Add(this.tasker_btn);
            this.panelTitleBar.Controls.Add(this.exit_btn);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.CurrentIcon);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(266, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1134, 78);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minimize_btn.BackgroundImage = global::AirLineSystem.Properties.Resources._13470516741553239385_24;
            this.minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minimize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.ForeColor = System.Drawing.Color.Black;
            this.minimize_btn.Location = new System.Drawing.Point(1020, 15);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(4);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(52, 41);
            this.minimize_btn.TabIndex = 4;
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // tasker_btn
            // 
            this.tasker_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tasker_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tasker_btn.BackgroundImage = global::AirLineSystem.Properties.Resources._11557596051556258258_20__1_;
            this.tasker_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tasker_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.tasker_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tasker_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tasker_btn.Location = new System.Drawing.Point(966, 15);
            this.tasker_btn.Margin = new System.Windows.Forms.Padding(4);
            this.tasker_btn.Name = "tasker_btn";
            this.tasker_btn.Size = new System.Drawing.Size(46, 41);
            this.tasker_btn.TabIndex = 3;
            this.tasker_btn.UseVisualStyleBackColor = false;
            this.tasker_btn.Click += new System.EventHandler(this.tasker_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(1080, 15);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(50, 41);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTitleChildForm.Location = new System.Drawing.Point(66, 24);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(54, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // CurrentIcon
            // 
            this.CurrentIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(115)))));
            this.CurrentIcon.ForeColor = System.Drawing.Color.MintCream;
            this.CurrentIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.CurrentIcon.IconColor = System.Drawing.Color.MintCream;
            this.CurrentIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CurrentIcon.IconSize = 41;
            this.CurrentIcon.Location = new System.Drawing.Point(8, 15);
            this.CurrentIcon.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentIcon.Name = "CurrentIcon";
            this.CurrentIcon.Size = new System.Drawing.Size(58, 41);
            this.CurrentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CurrentIcon.TabIndex = 0;
            this.CurrentIcon.TabStop = false;
            // 
            // sidemenupanel
            // 
            this.sidemenupanel.AutoScroll = true;
            this.sidemenupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.sidemenupanel.Controls.Add(this.goback_btn);
            this.sidemenupanel.Controls.Add(this.discount_btn);
            this.sidemenupanel.Controls.Add(this.pilots_btn);
            this.sidemenupanel.Controls.Add(this.aircrafts_btn);
            this.sidemenupanel.Controls.Add(this.flights_btn);
            this.sidemenupanel.Controls.Add(this.routes_btn);
            this.sidemenupanel.Controls.Add(this.home_btn);
            this.sidemenupanel.Controls.Add(this.logo_panel);
            this.sidemenupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenupanel.Location = new System.Drawing.Point(0, 0);
            this.sidemenupanel.Margin = new System.Windows.Forms.Padding(4);
            this.sidemenupanel.Name = "sidemenupanel";
            this.sidemenupanel.Size = new System.Drawing.Size(266, 799);
            this.sidemenupanel.TabIndex = 4;
            // 
            // goback_btn
            // 
            this.goback_btn.FlatAppearance.BorderSize = 0;
            this.goback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback_btn.Font = new System.Drawing.Font("MS Outlook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback_btn.ForeColor = System.Drawing.Color.Honeydew;
            this.goback_btn.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.goback_btn.IconColor = System.Drawing.Color.DarkCyan;
            this.goback_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goback_btn.IconSize = 35;
            this.goback_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goback_btn.Location = new System.Drawing.Point(0, 687);
            this.goback_btn.Margin = new System.Windows.Forms.Padding(4);
            this.goback_btn.Name = "goback_btn";
            this.goback_btn.Padding = new System.Windows.Forms.Padding(19, 0, 25, 0);
            this.goback_btn.Size = new System.Drawing.Size(266, 88);
            this.goback_btn.TabIndex = 7;
            this.goback_btn.Text = "Go Back";
            this.goback_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goback_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goback_btn.UseVisualStyleBackColor = true;
            this.goback_btn.Click += new System.EventHandler(this.goback_btn_Click);
            // 
            // discount_btn
            // 
            this.discount_btn.FlatAppearance.BorderSize = 0;
            this.discount_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discount_btn.Font = new System.Drawing.Font("MS Outlook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_btn.ForeColor = System.Drawing.Color.Honeydew;
            this.discount_btn.IconChar = FontAwesome.Sharp.IconChar.Dollar;
            this.discount_btn.IconColor = System.Drawing.Color.DarkCyan;
            this.discount_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.discount_btn.IconSize = 35;
            this.discount_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discount_btn.Location = new System.Drawing.Point(0, 599);
            this.discount_btn.Margin = new System.Windows.Forms.Padding(4);
            this.discount_btn.Name = "discount_btn";
            this.discount_btn.Padding = new System.Windows.Forms.Padding(19, 0, 25, 0);
            this.discount_btn.Size = new System.Drawing.Size(266, 88);
            this.discount_btn.TabIndex = 6;
            this.discount_btn.Text = "Discount";
            this.discount_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discount_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.discount_btn.UseVisualStyleBackColor = true;
            this.discount_btn.Click += new System.EventHandler(this.discount_btn_Click);
            // 
            // pilots_btn
            // 
            this.pilots_btn.FlatAppearance.BorderSize = 0;
            this.pilots_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pilots_btn.Font = new System.Drawing.Font("MS Outlook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilots_btn.ForeColor = System.Drawing.Color.Honeydew;
            this.pilots_btn.IconChar = FontAwesome.Sharp.IconChar.DriversLicense;
            this.pilots_btn.IconColor = System.Drawing.Color.DarkCyan;
            this.pilots_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pilots_btn.IconSize = 35;
            this.pilots_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pilots_btn.Location = new System.Drawing.Point(0, 511);
            this.pilots_btn.Margin = new System.Windows.Forms.Padding(4);
            this.pilots_btn.Name = "pilots_btn";
            this.pilots_btn.Padding = new System.Windows.Forms.Padding(19, 0, 25, 0);
            this.pilots_btn.Size = new System.Drawing.Size(266, 88);
            this.pilots_btn.TabIndex = 5;
            this.pilots_btn.Text = "Pilots";
            this.pilots_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pilots_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pilots_btn.UseVisualStyleBackColor = true;
            this.pilots_btn.Click += new System.EventHandler(this.pilots_btn_Click);
            // 
            // aircrafts_btn
            // 
            this.aircrafts_btn.FlatAppearance.BorderSize = 0;
            this.aircrafts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aircrafts_btn.Font = new System.Drawing.Font("MS Outlook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aircrafts_btn.ForeColor = System.Drawing.Color.Honeydew;
            this.aircrafts_btn.IconChar = FontAwesome.Sharp.IconChar.Plane;
            this.aircrafts_btn.IconColor = System.Drawing.Color.DarkCyan;
            this.aircrafts_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.aircrafts_btn.IconSize = 35;
            this.aircrafts_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aircrafts_btn.Location = new System.Drawing.Point(0, 423);
            this.aircrafts_btn.Margin = new System.Windows.Forms.Padding(4);
            this.aircrafts_btn.Name = "aircrafts_btn";
            this.aircrafts_btn.Padding = new System.Windows.Forms.Padding(19, 0, 25, 0);
            this.aircrafts_btn.Size = new System.Drawing.Size(266, 88);
            this.aircrafts_btn.TabIndex = 4;
            this.aircrafts_btn.Text = "AirCrafts";
            this.aircrafts_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aircrafts_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aircrafts_btn.UseVisualStyleBackColor = true;
            this.aircrafts_btn.Click += new System.EventHandler(this.aircrafts_btn_Click);
            // 
            // flights_btn
            // 
            this.flights_btn.FlatAppearance.BorderSize = 0;
            this.flights_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flights_btn.Font = new System.Drawing.Font("MS Outlook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flights_btn.ForeColor = System.Drawing.Color.Honeydew;
            this.flights_btn.IconChar = FontAwesome.Sharp.IconChar.PlaneDeparture;
            this.flights_btn.IconColor = System.Drawing.Color.DarkCyan;
            this.flights_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.flights_btn.IconSize = 35;
            this.flights_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flights_btn.Location = new System.Drawing.Point(0, 335);
            this.flights_btn.Margin = new System.Windows.Forms.Padding(4);
            this.flights_btn.Name = "flights_btn";
            this.flights_btn.Padding = new System.Windows.Forms.Padding(19, 0, 25, 0);
            this.flights_btn.Size = new System.Drawing.Size(266, 88);
            this.flights_btn.TabIndex = 3;
            this.flights_btn.Text = "Flights";
            this.flights_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flights_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.flights_btn.UseVisualStyleBackColor = true;
            this.flights_btn.Click += new System.EventHandler(this.flights_btn_Click);
            // 
            // routes_btn
            // 
            this.routes_btn.FlatAppearance.BorderSize = 0;
            this.routes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.routes_btn.Font = new System.Drawing.Font("MS Outlook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routes_btn.ForeColor = System.Drawing.Color.Honeydew;
            this.routes_btn.IconChar = FontAwesome.Sharp.IconChar.Confluence;
            this.routes_btn.IconColor = System.Drawing.Color.DarkCyan;
            this.routes_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.routes_btn.IconSize = 35;
            this.routes_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.routes_btn.Location = new System.Drawing.Point(0, 247);
            this.routes_btn.Margin = new System.Windows.Forms.Padding(4);
            this.routes_btn.Name = "routes_btn";
            this.routes_btn.Padding = new System.Windows.Forms.Padding(19, 0, 25, 0);
            this.routes_btn.Size = new System.Drawing.Size(266, 88);
            this.routes_btn.TabIndex = 2;
            this.routes_btn.Text = "Routes";
            this.routes_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.routes_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.routes_btn.UseVisualStyleBackColor = true;
            this.routes_btn.Click += new System.EventHandler(this.routes_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("MS Outlook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.Color.Honeydew;
            this.home_btn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.home_btn.IconColor = System.Drawing.Color.DarkCyan;
            this.home_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home_btn.IconSize = 35;
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(0, 159);
            this.home_btn.Margin = new System.Windows.Forms.Padding(4);
            this.home_btn.Name = "home_btn";
            this.home_btn.Padding = new System.Windows.Forms.Padding(19, 0, 25, 0);
            this.home_btn.Size = new System.Drawing.Size(266, 88);
            this.home_btn.TabIndex = 1;
            this.home_btn.Text = "Home";
            this.home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click_1);
            // 
            // logo_panel
            // 
            this.logo_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(10)))), ((int)(((byte)(90)))));
            this.logo_panel.Controls.Add(this.iconPictureBox1);
            this.logo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_panel.Location = new System.Drawing.Point(0, 0);
            this.logo_panel.Margin = new System.Windows.Forms.Padding(4);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Padding = new System.Windows.Forms.Padding(12, 0, 25, 0);
            this.logo_panel.Size = new System.Drawing.Size(266, 159);
            this.logo_panel.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconPictureBox1.BackgroundImage = global::AirLineSystem.Properties.Resources.admin;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 118;
            this.iconPictureBox1.Location = new System.Drawing.Point(76, 15);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(129, 118);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1400, 799);
            this.Controls.Add(this.shadowpannel);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.sidemenupanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentIcon)).EndInit();
            this.sidemenupanel.ResumeLayout(false);
            this.logo_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel shadowpannel;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button tasker_btn;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox CurrentIcon;
        private System.Windows.Forms.Panel sidemenupanel;
        private FontAwesome.Sharp.IconButton discount_btn;
        private FontAwesome.Sharp.IconButton pilots_btn;
        private FontAwesome.Sharp.IconButton aircrafts_btn;
        private FontAwesome.Sharp.IconButton flights_btn;
        private FontAwesome.Sharp.IconButton routes_btn;
        private FontAwesome.Sharp.IconButton home_btn;
        private System.Windows.Forms.Panel logo_panel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton goback_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}