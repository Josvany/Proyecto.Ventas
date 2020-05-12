namespace Capa.Presentacion
{
    partial class FormSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelSarch = new System.Windows.Forms.Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.PanelInformation = new System.Windows.Forms.Panel();
            this.buttonProcess = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonClear = new FontAwesome.Sharp.IconButton();
            this.buttonAddProduct = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PaneProduct = new System.Windows.Forms.Panel();
            this.panelSourseProducts = new System.Windows.Forms.Panel();
            this.dgallProduct = new System.Windows.Forms.DataGridView();
            this.dtListProductToSales = new System.Windows.Forms.DataGridView();
            this.EL = new System.Windows.Forms.DataGridViewImageColumn();
            this.S = new System.Windows.Forms.DataGridViewButtonColumn();
            this.R = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PanelSarch.SuspendLayout();
            this.PanelInformation.SuspendLayout();
            this.PaneProduct.SuspendLayout();
            this.panelSourseProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgallProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtListProductToSales)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSarch
            // 
            this.PanelSarch.Controls.Add(this.btnSearch);
            this.PanelSarch.Controls.Add(this.panel2);
            this.PanelSarch.Controls.Add(this.textSearch);
            this.PanelSarch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSarch.Location = new System.Drawing.Point(0, 0);
            this.PanelSarch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelSarch.Name = "PanelSarch";
            this.PanelSarch.Size = new System.Drawing.Size(943, 43);
            this.PanelSarch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Green;
            this.btnSearch.IconSize = 20;
            this.btnSearch.Location = new System.Drawing.Point(356, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(27, 27);
            this.btnSearch.TabIndex = 621;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(45, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 1);
            this.panel2.TabIndex = 620;
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.White;
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Location = new System.Drawing.Point(45, 22);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(305, 19);
            this.textSearch.TabIndex = 618;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // PanelInformation
            // 
            this.PanelInformation.Controls.Add(this.buttonProcess);
            this.PanelInformation.Controls.Add(this.label2);
            this.PanelInformation.Controls.Add(this.panel5);
            this.PanelInformation.Controls.Add(this.textTotal);
            this.PanelInformation.Controls.Add(this.label3);
            this.PanelInformation.Controls.Add(this.panel6);
            this.PanelInformation.Controls.Add(this.textBox4);
            this.PanelInformation.Controls.Add(this.buttonClear);
            this.PanelInformation.Controls.Add(this.buttonAddProduct);
            this.PanelInformation.Controls.Add(this.label1);
            this.PanelInformation.Controls.Add(this.panel4);
            this.PanelInformation.Controls.Add(this.textCantidad);
            this.PanelInformation.Controls.Add(this.labelName);
            this.PanelInformation.Controls.Add(this.panel3);
            this.PanelInformation.Controls.Add(this.textProductName);
            this.PanelInformation.Controls.Add(this.panel1);
            this.PanelInformation.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelInformation.Location = new System.Drawing.Point(719, 43);
            this.PanelInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelInformation.Name = "PanelInformation";
            this.PanelInformation.Size = new System.Drawing.Size(224, 433);
            this.PanelInformation.TabIndex = 1;
            // 
            // buttonProcess
            // 
            this.buttonProcess.FlatAppearance.BorderSize = 0;
            this.buttonProcess.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonProcess.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonProcess.IconColor = System.Drawing.Color.Green;
            this.buttonProcess.IconSize = 20;
            this.buttonProcess.Location = new System.Drawing.Point(62, 336);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.buttonProcess.Rotation = 0D;
            this.buttonProcess.Size = new System.Drawing.Size(105, 34);
            this.buttonProcess.TabIndex = 636;
            this.buttonProcess.Text = "Pagar";
            this.buttonProcess.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProcess.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 635;
            this.label2.Text = "Total";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(0, 298);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 1);
            this.panel5.TabIndex = 634;
            // 
            // textTotal
            // 
            this.textTotal.BackColor = System.Drawing.Color.White;
            this.textTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTotal.Location = new System.Drawing.Point(0, 282);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(224, 19);
            this.textTotal.TabIndex = 633;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 632;
            this.label3.Text = "Numero Factura";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(0, 239);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(224, 1);
            this.panel6.TabIndex = 631;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(0, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(224, 19);
            this.textBox4.TabIndex = 630;
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonClear.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.buttonClear.IconColor = System.Drawing.Color.Green;
            this.buttonClear.IconSize = 25;
            this.buttonClear.Location = new System.Drawing.Point(112, 115);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.buttonClear.Rotation = 0D;
            this.buttonClear.Size = new System.Drawing.Size(44, 36);
            this.buttonClear.TabIndex = 629;
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.FlatAppearance.BorderSize = 0;
            this.buttonAddProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonAddProduct.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.buttonAddProduct.IconColor = System.Drawing.Color.Green;
            this.buttonAddProduct.IconSize = 20;
            this.buttonAddProduct.Location = new System.Drawing.Point(62, 115);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.buttonAddProduct.Rotation = 0D;
            this.buttonAddProduct.Size = new System.Drawing.Size(44, 36);
            this.buttonAddProduct.TabIndex = 628;
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 627;
            this.label1.Text = "Cantidad";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(0, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 1);
            this.panel4.TabIndex = 626;
            // 
            // textCantidad
            // 
            this.textCantidad.BackColor = System.Drawing.Color.White;
            this.textCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCantidad.Location = new System.Drawing.Point(0, 90);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(224, 19);
            this.textCantidad.TabIndex = 625;
            this.textCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCantidad_KeyPress);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(71, 5);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 20);
            this.labelName.TabIndex = 624;
            this.labelName.Text = "Nombre";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 1);
            this.panel3.TabIndex = 623;
            // 
            // textProductName
            // 
            this.textProductName.BackColor = System.Drawing.Color.White;
            this.textProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProductName.Location = new System.Drawing.Point(0, 31);
            this.textProductName.Name = "textProductName";
            this.textProductName.ReadOnly = true;
            this.textProductName.Size = new System.Drawing.Size(224, 19);
            this.textProductName.TabIndex = 622;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 1);
            this.panel1.TabIndex = 621;
            // 
            // PaneProduct
            // 
            this.PaneProduct.Controls.Add(this.panelSourseProducts);
            this.PaneProduct.Controls.Add(this.dtListProductToSales);
            this.PaneProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaneProduct.Location = new System.Drawing.Point(0, 43);
            this.PaneProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PaneProduct.Name = "PaneProduct";
            this.PaneProduct.Size = new System.Drawing.Size(719, 433);
            this.PaneProduct.TabIndex = 2;
            // 
            // panelSourseProducts
            // 
            this.panelSourseProducts.BackColor = System.Drawing.Color.White;
            this.panelSourseProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSourseProducts.BackgroundImage")));
            this.panelSourseProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSourseProducts.Controls.Add(this.dgallProduct);
            this.panelSourseProducts.Location = new System.Drawing.Point(45, 4);
            this.panelSourseProducts.Name = "panelSourseProducts";
            this.panelSourseProducts.Size = new System.Drawing.Size(325, 185);
            this.panelSourseProducts.TabIndex = 665;
            this.panelSourseProducts.Visible = false;
            this.panelSourseProducts.Leave += new System.EventHandler(this.panelSourseProducts_Leave);
            // 
            // dgallProduct
            // 
            this.dgallProduct.AllowUserToAddRows = false;
            this.dgallProduct.AllowUserToOrderColumns = true;
            this.dgallProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgallProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgallProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgallProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgallProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgallProduct.GridColor = System.Drawing.Color.White;
            this.dgallProduct.Location = new System.Drawing.Point(16, 12);
            this.dgallProduct.MultiSelect = false;
            this.dgallProduct.Name = "dgallProduct";
            this.dgallProduct.ReadOnly = true;
            this.dgallProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgallProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgallProduct.RowHeadersVisible = false;
            this.dgallProduct.RowTemplate.ReadOnly = true;
            this.dgallProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgallProduct.ShowRowErrors = false;
            this.dgallProduct.Size = new System.Drawing.Size(289, 160);
            this.dgallProduct.TabIndex = 636;
            this.dgallProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgallProduct_CellClick);
            this.dgallProduct.MouseLeave += new System.EventHandler(this.dgallProduct_MouseLeave);
            // 
            // dtListProductToSales
            // 
            this.dtListProductToSales.AllowUserToAddRows = false;
            this.dtListProductToSales.AllowUserToDeleteRows = false;
            this.dtListProductToSales.AllowUserToResizeRows = false;
            this.dtListProductToSales.BackgroundColor = System.Drawing.Color.White;
            this.dtListProductToSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtListProductToSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtListProductToSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtListProductToSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtListProductToSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListProductToSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EL,
            this.S,
            this.R});
            this.dtListProductToSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListProductToSales.EnableHeadersVisualStyles = false;
            this.dtListProductToSales.GridColor = System.Drawing.Color.Gainsboro;
            this.dtListProductToSales.Location = new System.Drawing.Point(0, 0);
            this.dtListProductToSales.MultiSelect = false;
            this.dtListProductToSales.Name = "dtListProductToSales";
            this.dtListProductToSales.ReadOnly = true;
            this.dtListProductToSales.RowHeadersVisible = false;
            this.dtListProductToSales.RowHeadersWidth = 9;
            this.dtListProductToSales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtListProductToSales.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtListProductToSales.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtListProductToSales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dtListProductToSales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtListProductToSales.RowTemplate.Height = 36;
            this.dtListProductToSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListProductToSales.Size = new System.Drawing.Size(719, 433);
            this.dtListProductToSales.TabIndex = 666;
            this.dtListProductToSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListProductToSales_CellClick);
            this.dtListProductToSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListProductToSales_CellDoubleClick);
            // 
            // EL
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.EL.DefaultCellStyle = dataGridViewCellStyle4;
            this.EL.HeaderText = "";
            this.EL.Image = ((System.Drawing.Image)(resources.GetObject("EL.Image")));
            this.EL.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EL.Name = "EL";
            this.EL.ReadOnly = true;
            this.EL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EL.ToolTipText = "Opcional \"Supr\" para Eliminar";
            this.EL.Width = 30;
            // 
            // S
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.S.DefaultCellStyle = dataGridViewCellStyle5;
            this.S.HeaderText = "";
            this.S.Name = "S";
            this.S.ReadOnly = true;
            this.S.Text = "+";
            this.S.UseColumnTextForButtonValue = true;
            this.S.Width = 30;
            // 
            // R
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.R.DefaultCellStyle = dataGridViewCellStyle6;
            this.R.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.R.HeaderText = "";
            this.R.Name = "R";
            this.R.ReadOnly = true;
            this.R.Text = "-";
            this.R.UseColumnTextForButtonValue = true;
            this.R.Width = 30;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 476);
            this.Controls.Add(this.PaneProduct);
            this.Controls.Add(this.PanelInformation);
            this.Controls.Add(this.PanelSarch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.FormSales_Load);
            this.PanelSarch.ResumeLayout(false);
            this.PanelSarch.PerformLayout();
            this.PanelInformation.ResumeLayout(false);
            this.PanelInformation.PerformLayout();
            this.PaneProduct.ResumeLayout(false);
            this.panelSourseProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgallProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtListProductToSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSarch;
        private System.Windows.Forms.Panel PanelInformation;
        private System.Windows.Forms.Panel PaneProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.Label labelName;
        private FontAwesome.Sharp.IconButton buttonAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textCantidad;
        private FontAwesome.Sharp.IconButton buttonClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panelSourseProducts;
        private System.Windows.Forms.DataGridView dgallProduct;
        internal System.Windows.Forms.DataGridView dtListProductToSales;
        private System.Windows.Forms.DataGridViewImageColumn EL;
        private System.Windows.Forms.DataGridViewButtonColumn S;
        private System.Windows.Forms.DataGridViewButtonColumn R;
        private FontAwesome.Sharp.IconButton buttonProcess;
    }
}