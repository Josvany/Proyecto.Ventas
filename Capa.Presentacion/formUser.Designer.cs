namespace Capa.Presentacion
{
    partial class formUser
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textUser = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.dgAllUser = new System.Windows.Forms.DataGridView();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.textConfirmPass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconPictureBox();
            this.TimeSumulate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(155, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(237, 1);
            this.panel7.TabIndex = 609;
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.SystemColors.Control;
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.Location = new System.Drawing.Point(155, 24);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(237, 13);
            this.textUser.TabIndex = 2;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(35, 28);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(46, 13);
            this.Label5.TabIndex = 607;
            this.Label5.Text = "Usuario:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(155, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 1);
            this.panel1.TabIndex = 611;
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.SystemColors.Control;
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombre.Location = new System.Drawing.Point(155, 49);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(237, 13);
            this.textNombre.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(155, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 1);
            this.panel2.TabIndex = 611;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 610;
            this.label2.Text = "Contraseña:";
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.SystemColors.Control;
            this.textPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPass.Location = new System.Drawing.Point(155, 73);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(237, 13);
            this.textPass.TabIndex = 3;
            this.textPass.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 613;
            this.label3.Text = "Rol:";
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.SystemColors.Control;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(155, 125);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(237, 21);
            this.cmbRol.TabIndex = 4;
            // 
            // dgAllUser
            // 
            this.dgAllUser.AllowUserToAddRows = false;
            this.dgAllUser.AllowUserToOrderColumns = true;
            this.dgAllUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllUser.Location = new System.Drawing.Point(12, 164);
            this.dgAllUser.MultiSelect = false;
            this.dgAllUser.Name = "dgAllUser";
            this.dgAllUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgAllUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAllUser.ShowRowErrors = false;
            this.dgAllUser.Size = new System.Drawing.Size(423, 133);
            this.dgAllUser.TabIndex = 616;
            this.dgAllUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAllUser_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAdd.IconColor = System.Drawing.Color.Blue;
            this.btnAdd.IconSize = 20;
            this.btnAdd.Location = new System.Drawing.Point(186, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Rotation = 0D;
            this.btnAdd.Size = new System.Drawing.Size(76, 24);
            this.btnAdd.TabIndex = 617;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNew.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNew.IconColor = System.Drawing.Color.Green;
            this.btnNew.IconSize = 20;
            this.btnNew.Location = new System.Drawing.Point(104, 303);
            this.btnNew.Name = "btnNew";
            this.btnNew.Rotation = 0D;
            this.btnNew.Size = new System.Drawing.Size(76, 24);
            this.btnNew.TabIndex = 619;
            this.btnNew.Text = "Nuevo";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconSize = 19;
            this.btnCancel.Location = new System.Drawing.Point(268, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(76, 24);
            this.btnCancel.TabIndex = 620;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textConfirmPass
            // 
            this.textConfirmPass.BackColor = System.Drawing.SystemColors.Control;
            this.textConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textConfirmPass.Location = new System.Drawing.Point(155, 97);
            this.textConfirmPass.Name = "textConfirmPass";
            this.textConfirmPass.PasswordChar = '*';
            this.textConfirmPass.Size = new System.Drawing.Size(237, 13);
            this.textConfirmPass.TabIndex = 621;
            this.textConfirmPass.Tag = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(155, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 1);
            this.panel3.TabIndex = 623;
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.labelConfirmPass.Location = new System.Drawing.Point(35, 100);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(111, 13);
            this.labelConfirmPass.TabIndex = 622;
            this.labelConfirmPass.Text = "Confirmar Contraseña:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ForeColor = System.Drawing.Color.Green;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Green;
            this.btnSearch.IconSize = 22;
            this.btnSearch.Location = new System.Drawing.Point(398, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.btnSearch.Size = new System.Drawing.Size(22, 22);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 627;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TimeSumulate
            // 
            this.TimeSumulate.Tick += new System.EventHandler(this.TimeSumulate_Tick);
            // 
            // formUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(449, 352);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textConfirmPass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelConfirmPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgAllUser);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "formUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textUser;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPass;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.DataGridView dgAllUser;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnNew;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.TextBox textConfirmPass;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label labelConfirmPass;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private System.Windows.Forms.Timer TimeSumulate;
    }
}

