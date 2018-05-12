namespace ProjektBD2
{
    partial class showAddresses
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
            this.bD2DataSet1 = new ProjektBD2.BD2DataSet1();
            this.addressSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressSetTableAdapter = new ProjektBD2.BD2DataSet1TableAdapters.AddressSetTableAdapter();
            this.bD2DataSet = new ProjektBD2.BD2DataSet();
            this.hCOSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hCOSetTableAdapter = new ProjektBD2.BD2DataSetTableAdapters.HCOSetTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCOSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bD2DataSet1
            // 
            this.bD2DataSet1.DataSetName = "BD2DataSet1";
            this.bD2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressSetBindingSource
            // 
            this.addressSetBindingSource.DataMember = "AddressSet";
            this.addressSetBindingSource.DataSource = this.bD2DataSet1;
            // 
            // addressSetTableAdapter
            // 
            this.addressSetTableAdapter.ClearBeforeFill = true;
            // 
            // bD2DataSet
            // 
            this.bD2DataSet.DataSetName = "BD2DataSet";
            this.bD2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hCOSetBindingSource
            // 
            this.hCOSetBindingSource.DataMember = "HCOSet";
            this.hCOSetBindingSource.DataSource = this.bD2DataSet;
            // 
            // hCOSetTableAdapter
            // 
            this.hCOSetTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "SET AND CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "showAddresses";
            this.Text = "showAddresses";
            this.Load += new System.EventHandler(this.showAddresses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCOSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BD2DataSet1 bD2DataSet1;
        private System.Windows.Forms.BindingSource addressSetBindingSource;
        private BD2DataSet1TableAdapters.AddressSetTableAdapter addressSetTableAdapter;
        private BD2DataSet bD2DataSet;
        private System.Windows.Forms.BindingSource hCOSetBindingSource;
        private BD2DataSetTableAdapters.HCOSetTableAdapter hCOSetTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}