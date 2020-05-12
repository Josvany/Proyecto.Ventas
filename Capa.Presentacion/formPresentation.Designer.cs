namespace Capa.Presentacion
{
    partial class formPresentation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new FontAwesome.Sharp.IconPictureBox();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.dgAllCategory = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllCategory)).BeginInit();
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
            this.btnSearch.Location = new System.Drawing.Point(355, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.btnSearch.Size = new System.Drawing.Size(22, 22);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 639;
            this.btnSearch.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconSize = 19;
            this.btnCancel.Location = new System.Drawing.Point(275, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(76, 24);
            this.btnCancel.TabIndex = 638;
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
            this.btnNew.Location = new System.Drawing.Point(111, 178);
            this.btnNew.Name = "btnNew";
            this.btnNew.Rotation = 0D;
            this.btnNew.Size = new System.Drawing.Size(76, 24);
            this.btnNew.TabIndex = 637;
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
            this.btnAdd.Location = new System.Drawing.Point(193, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Rotation = 0D;
            this.btnAdd.Size = new System.Drawing.Size(76, 24);
            this.btnAdd.TabIndex = 636;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgAllCategory
            // 
            this.dgAllCategory.AllowUserToAddRows = false;
            this.dgAllCategory.AllowUserToOrderColumns = true;
            this.dgAllCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgAllCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAllCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAllCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAllCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllCategory.GridColor = System.Drawing.Color.White;
            this.dgAllCategory.Location = new System.Drawing.Point(167, 39);
            this.dgAllCategory.MultiSelect = false;
            this.dgAllCategory.Name = "dgAllCategory";
            this.dgAllCategory.ReadOnly = true;
            this.dgAllCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAllCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgAllCategory.RowHeadersVisible = false;
            this.dgAllCategory.RowTemplate.ReadOnly = true;
            this.dgAllCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAllCategory.ShowRowErrors = false;
            this.dgAllCategory.Size = new System.Drawing.Size(127, 133);
            this.dgAllCategory.TabIndex = 635;
            this.dgAllCategory.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAllCategory_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(112, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 1);
            this.panel1.TabIndex = 632;
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.SystemColors.Control;
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombre.Location = new System.Drawing.Point(112, 13);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(237, 13);
            this.textNombre.TabIndex = 628;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 630;
            this.label1.Text = "Nombre";
            // 
            // tm
            // 
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // formPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 217);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgAllCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "formPresentation";
            this.Text = "Presentacion";
            this.Load += new System.EventHandler(this.formPresentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnNew;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.DataGridView dgAllCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tm;
    }
}