namespace Capa.Presentacion
{
    partial class formProduct
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
            this.btnSearch = new FontAwesome.Sharp.IconPictureBox();
            this.textMinimalStock = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.dgAllProduct = new System.Windows.Forms.DataGridView();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPriceBuy = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textName = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.textStock = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textPriceSales = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TimeSumulate = new System.Windows.Forms.Timer(this.components);
            this.panelSourseProducts = new System.Windows.Forms.Panel();
            this.dgProductExist = new System.Windows.Forms.DataGridView();
            this.btnAcept = new FontAwesome.Sharp.IconButton();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtExpirationProduct = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllProduct)).BeginInit();
            this.panelSourseProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductExist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ForeColor = System.Drawing.Color.Green;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Green;
            this.btnSearch.IconSize = 22;
            this.btnSearch.Location = new System.Drawing.Point(398, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.btnSearch.Size = new System.Drawing.Size(22, 22);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 646;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textMinimalStock
            // 
            this.textMinimalStock.BackColor = System.Drawing.SystemColors.Control;
            this.textMinimalStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMinimalStock.Location = new System.Drawing.Point(155, 81);
            this.textMinimalStock.Name = "textMinimalStock";
            this.textMinimalStock.Size = new System.Drawing.Size(237, 13);
            this.textMinimalStock.TabIndex = 643;
            this.textMinimalStock.Tag = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(155, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 1);
            this.panel3.TabIndex = 645;
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.labelConfirmPass.Location = new System.Drawing.Point(35, 84);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(85, 13);
            this.labelConfirmPass.TabIndex = 644;
            this.labelConfirmPass.Text = "Cantidad Minima";
            // 
            // btnCancel
            // 
            this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconSize = 19;
            this.btnCancel.Location = new System.Drawing.Point(398, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(76, 24);
            this.btnCancel.TabIndex = 642;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNew.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNew.IconColor = System.Drawing.Color.Green;
            this.btnNew.IconSize = 20;
            this.btnNew.Location = new System.Drawing.Point(234, 318);
            this.btnNew.Name = "btnNew";
            this.btnNew.Rotation = 0D;
            this.btnNew.Size = new System.Drawing.Size(76, 24);
            this.btnNew.TabIndex = 641;
            this.btnNew.Text = "Nuevo";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAdd.IconColor = System.Drawing.Color.Blue;
            this.btnAdd.IconSize = 20;
            this.btnAdd.Location = new System.Drawing.Point(316, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Rotation = 0D;
            this.btnAdd.Size = new System.Drawing.Size(76, 24);
            this.btnAdd.TabIndex = 640;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgAllProduct
            // 
            this.dgAllProduct.AllowUserToAddRows = false;
            this.dgAllProduct.AllowUserToOrderColumns = true;
            this.dgAllProduct.Location = new System.Drawing.Point(142, 155);
            this.dgAllProduct.MultiSelect = false;
            this.dgAllProduct.Name = "dgAllProduct";
            this.dgAllProduct.ReadOnly = true;
            this.dgAllProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgAllProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAllProduct.ShowRowErrors = false;
            this.dgAllProduct.Size = new System.Drawing.Size(545, 157);
            this.dgAllProduct.TabIndex = 639;
            this.dgAllProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAllProduct_CellDoubleClick);
            // 
            // cmbCategories
            // 
            this.cmbCategories.BackColor = System.Drawing.SystemColors.Control;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(155, 103);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(237, 21);
            this.cmbCategories.TabIndex = 632;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 638;
            this.label3.Text = "Categoria";
            // 
            // textPriceBuy
            // 
            this.textPriceBuy.BackColor = System.Drawing.SystemColors.Control;
            this.textPriceBuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPriceBuy.Location = new System.Drawing.Point(155, 57);
            this.textPriceBuy.Name = "textPriceBuy";
            this.textPriceBuy.Size = new System.Drawing.Size(237, 13);
            this.textPriceBuy.TabIndex = 631;
            this.textPriceBuy.Tag = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(155, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 1);
            this.panel2.TabIndex = 637;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 635;
            this.label2.Text = "Precio Compra";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(155, 49);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(237, 1);
            this.panel7.TabIndex = 634;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.Control;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textName.Location = new System.Drawing.Point(155, 33);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(237, 13);
            this.textName.TabIndex = 630;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(35, 37);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(44, 13);
            this.Label5.TabIndex = 633;
            this.Label5.Text = "Nombre";
            // 
            // textStock
            // 
            this.textStock.BackColor = System.Drawing.SystemColors.Control;
            this.textStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStock.Location = new System.Drawing.Point(518, 81);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(237, 13);
            this.textStock.TabIndex = 656;
            this.textStock.Tag = "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(518, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 1);
            this.panel4.TabIndex = 658;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(437, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 657;
            this.label4.Text = "Cantidad";
            // 
            // textPriceSales
            // 
            this.textPriceSales.BackColor = System.Drawing.SystemColors.Control;
            this.textPriceSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPriceSales.Location = new System.Drawing.Point(518, 57);
            this.textPriceSales.Name = "textPriceSales";
            this.textPriceSales.Size = new System.Drawing.Size(237, 13);
            this.textPriceSales.TabIndex = 650;
            this.textPriceSales.Tag = "";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(518, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 1);
            this.panel5.TabIndex = 655;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(438, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 653;
            this.label6.Text = "Precio Venta";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(518, 49);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(237, 1);
            this.panel8.TabIndex = 652;
            // 
            // textCode
            // 
            this.textCode.BackColor = System.Drawing.SystemColors.Control;
            this.textCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCode.Location = new System.Drawing.Point(518, 33);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(237, 13);
            this.textCode.TabIndex = 649;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(437, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 651;
            this.label7.Text = "Código";
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Checked = true;
            this.ckbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbStatus.Location = new System.Drawing.Point(518, 110);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(15, 14);
            this.ckbStatus.TabIndex = 660;
            this.ckbStatus.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(437, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 659;
            this.label9.Text = "Estado";
            // 
            // TimeSumulate
            // 
            this.TimeSumulate.Tick += new System.EventHandler(this.TimeSumulate_Tick);
            // 
            // panelSourseProducts
            // 
            this.panelSourseProducts.Controls.Add(this.dgProductExist);
            this.panelSourseProducts.Controls.Add(this.btnAcept);
            this.panelSourseProducts.Location = new System.Drawing.Point(30, 12);
            this.panelSourseProducts.Name = "panelSourseProducts";
            this.panelSourseProducts.Size = new System.Drawing.Size(748, 300);
            this.panelSourseProducts.TabIndex = 661;
            this.panelSourseProducts.Visible = false;
            // 
            // dgProductExist
            // 
            this.dgProductExist.AllowUserToAddRows = false;
            this.dgProductExist.AllowUserToOrderColumns = true;
            this.dgProductExist.Location = new System.Drawing.Point(112, 67);
            this.dgProductExist.MultiSelect = false;
            this.dgProductExist.Name = "dgProductExist";
            this.dgProductExist.ReadOnly = true;
            this.dgProductExist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgProductExist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductExist.ShowRowErrors = false;
            this.dgProductExist.Size = new System.Drawing.Size(539, 157);
            this.dgProductExist.TabIndex = 642;
            this.dgProductExist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductExist_CellClick);
            // 
            // btnAcept
            // 
            this.btnAcept.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAcept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAcept.IconColor = System.Drawing.Color.Blue;
            this.btnAcept.IconSize = 20;
            this.btnAcept.Location = new System.Drawing.Point(336, 251);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Rotation = 0D;
            this.btnAcept.Size = new System.Drawing.Size(76, 24);
            this.btnAcept.TabIndex = 641;
            this.btnAcept.Text = "Guardar";
            this.btnAcept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcept.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClean.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btnClean.IconColor = System.Drawing.Color.DarkGreen;
            this.btnClean.IconSize = 19;
            this.btnClean.Location = new System.Drawing.Point(480, 318);
            this.btnClean.Name = "btnClean";
            this.btnClean.Rotation = 0D;
            this.btnClean.Size = new System.Drawing.Size(76, 24);
            this.btnClean.TabIndex = 662;
            this.btnClean.Text = "Limpiar";
            this.btnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Visible = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(155, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 1);
            this.panel1.TabIndex = 637;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 636;
            this.label1.Text = "Fecha de vencimiento";
            // 
            // dtExpirationProduct
            // 
            this.dtExpirationProduct.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtExpirationProduct.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtExpirationProduct.CustomFormat = "dd-MM-yyyy";
            this.dtExpirationProduct.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExpirationProduct.Location = new System.Drawing.Point(155, 126);
            this.dtExpirationProduct.Name = "dtExpirationProduct";
            this.dtExpirationProduct.Size = new System.Drawing.Size(237, 20);
            this.dtExpirationProduct.TabIndex = 663;
            this.dtExpirationProduct.Value = new System.DateTime(2020, 4, 21, 0, 0, 0, 0);
            // 
            // formProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.panelSourseProducts);
            this.Controls.Add(this.dtExpirationProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPriceSales);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textMinimalStock);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelConfirmPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgAllProduct);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPriceBuy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.Label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "formProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.formProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllProduct)).EndInit();
            this.panelSourseProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductExist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private System.Windows.Forms.TextBox textMinimalStock;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label labelConfirmPass;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnNew;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.DataGridView dgAllProduct;
        private System.Windows.Forms.ComboBox cmbCategories;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPriceBuy;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textName;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPriceSales;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textCode;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbStatus;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer TimeSumulate;
        private System.Windows.Forms.Panel panelSourseProducts;
        private FontAwesome.Sharp.IconButton btnClean;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtExpirationProduct;
        private System.Windows.Forms.DataGridView dgProductExist;
        private FontAwesome.Sharp.IconButton btnAcept;
    }
}