namespace ProjektBD2
{
    partial class ShowProduct
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bD2DataSet7 = new ProjektBD2.BD2DataSet7();
            this.productSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSetTableAdapter = new ProjektBD2.BD2DataSet7TableAdapters.ProductSetTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antiDiseaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyPerCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIngredientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.antiDiseaseDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.qtyPerCaseDataGridViewTextBoxColumn,
            this.mIngredientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bD2DataSet7
            // 
            this.bD2DataSet7.DataSetName = "BD2DataSet7";
            this.bD2DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productSetBindingSource
            // 
            this.productSetBindingSource.DataMember = "ProductSet";
            this.productSetBindingSource.DataSource = this.bD2DataSet7;
            // 
            // productSetTableAdapter
            // 
            this.productSetTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // antiDiseaseDataGridViewTextBoxColumn
            // 
            this.antiDiseaseDataGridViewTextBoxColumn.DataPropertyName = "AntiDisease";
            this.antiDiseaseDataGridViewTextBoxColumn.HeaderText = "AntiDisease";
            this.antiDiseaseDataGridViewTextBoxColumn.Name = "antiDiseaseDataGridViewTextBoxColumn";
            this.antiDiseaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyPerCaseDataGridViewTextBoxColumn
            // 
            this.qtyPerCaseDataGridViewTextBoxColumn.DataPropertyName = "QtyPerCase";
            this.qtyPerCaseDataGridViewTextBoxColumn.HeaderText = "QtyPerCase";
            this.qtyPerCaseDataGridViewTextBoxColumn.Name = "qtyPerCaseDataGridViewTextBoxColumn";
            this.qtyPerCaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mIngredientDataGridViewTextBoxColumn
            // 
            this.mIngredientDataGridViewTextBoxColumn.DataPropertyName = "MIngredient";
            this.mIngredientDataGridViewTextBoxColumn.HeaderText = "MIngredient";
            this.mIngredientDataGridViewTextBoxColumn.Name = "mIngredientDataGridViewTextBoxColumn";
            this.mIngredientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowProduct";
            this.Text = "ShowProduct";
            this.Load += new System.EventHandler(this.ShowProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BD2DataSet7 bD2DataSet7;
        private System.Windows.Forms.BindingSource productSetBindingSource;
        private BD2DataSet7TableAdapters.ProductSetTableAdapter productSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antiDiseaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyPerCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIngredientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}