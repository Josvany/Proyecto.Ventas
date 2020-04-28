namespace Capa.Presentacion
{
    partial class formOpenBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcept = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(141, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 2);
            this.panel1.TabIndex = 632;
            // 
            // textAmount
            // 
            this.textAmount.BackColor = System.Drawing.Color.White;
            this.textAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAmount.Location = new System.Drawing.Point(141, 54);
            this.textAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(356, 19);
            this.textAmount.TabIndex = 628;
            this.textAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 630;
            this.label1.Text = "Monto Inicial";
            // 
            // cmbCategories
            // 
            this.cmbCategories.BackColor = System.Drawing.Color.White;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(141, 16);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(356, 28);
            this.cmbCategories.TabIndex = 639;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 640;
            this.label3.Text = "Caja";
            // 
            // btnAcept
            // 
            this.btnAcept.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAcept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAcept.IconColor = System.Drawing.Color.Blue;
            this.btnAcept.IconSize = 25;
            this.btnAcept.Location = new System.Drawing.Point(232, 108);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Rotation = 0D;
            this.btnAcept.Size = new System.Drawing.Size(128, 35);
            this.btnAcept.TabIndex = 641;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // formOpenBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 173);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formOpenBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Apertura de Caja";
            this.Load += new System.EventHandler(this.formOpenBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategories;
        internal System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnAcept;
    }
}