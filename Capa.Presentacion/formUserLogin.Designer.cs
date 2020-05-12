namespace Capa.Presentacion
{
    partial class formUserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUserLogin));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.textPasword = new ns1.BunifuMaterialTextbox();
            this.textUser = new ns1.BunifuMaterialTextbox();
            this.buttonlogin = new ns1.BunifuThinButton2();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(408, 34);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(387, 12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(12, 13);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(53, 57);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(276, 44);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Iniciar Session";
            // 
            // textPasword
            // 
            this.textPasword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPasword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textPasword.ForeColor = System.Drawing.Color.White;
            this.textPasword.HintForeColor = System.Drawing.Color.White;
            this.textPasword.HintText = "";
            this.textPasword.isPassword = false;
            this.textPasword.LineFocusedColor = System.Drawing.Color.Blue;
            this.textPasword.LineIdleColor = System.Drawing.Color.Gray;
            this.textPasword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textPasword.LineThickness = 3;
            this.textPasword.Location = new System.Drawing.Point(57, 204);
            this.textPasword.Margin = new System.Windows.Forms.Padding(4);
            this.textPasword.Name = "textPasword";
            this.textPasword.Size = new System.Drawing.Size(292, 21);
            this.textPasword.TabIndex = 2;
            this.textPasword.Text = "Contraseña";
            this.textPasword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPasword.OnValueChanged += new System.EventHandler(this.textPasword_OnValueChanged);
            this.textPasword.Click += new System.EventHandler(this.textPasword_Click);
            this.textPasword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPasword_KeyPress);
            // 
            // textUser
            // 
            this.textUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textUser.ForeColor = System.Drawing.Color.White;
            this.textUser.HintForeColor = System.Drawing.Color.Empty;
            this.textUser.HintText = "";
            this.textUser.isPassword = false;
            this.textUser.LineFocusedColor = System.Drawing.Color.Blue;
            this.textUser.LineIdleColor = System.Drawing.Color.Gray;
            this.textUser.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textUser.LineThickness = 3;
            this.textUser.Location = new System.Drawing.Point(57, 125);
            this.textUser.Margin = new System.Windows.Forms.Padding(4);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(292, 37);
            this.textUser.TabIndex = 1;
            this.textUser.Text = "Usuario";
            this.textUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textUser.Click += new System.EventHandler(this.textUser_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.ActiveBorderThickness = 1;
            this.buttonlogin.ActiveCornerRadius = 20;
            this.buttonlogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonlogin.ActiveForecolor = System.Drawing.Color.White;
            this.buttonlogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonlogin.BackgroundImage")));
            this.buttonlogin.ButtonText = "Login";
            this.buttonlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonlogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.Color.White;
            this.buttonlogin.IdleBorderThickness = 1;
            this.buttonlogin.IdleCornerRadius = 20;
            this.buttonlogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonlogin.IdleForecolor = System.Drawing.Color.White;
            this.buttonlogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.buttonlogin.Location = new System.Drawing.Point(73, 247);
            this.buttonlogin.Margin = new System.Windows.Forms.Padding(5);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(256, 60);
            this.buttonlogin.TabIndex = 6;
            this.buttonlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // formUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(408, 383);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textPasword);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formUserLogin";
            this.Load += new System.EventHandler(this.formUserLogin_Load);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox btnExit;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuMaterialTextbox textPasword;
        private ns1.BunifuMaterialTextbox textUser;
        private ns1.BunifuThinButton2 buttonlogin;
    }
}