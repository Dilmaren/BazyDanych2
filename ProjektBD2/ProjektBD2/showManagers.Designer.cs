namespace ProjektBD2
{
    partial class showManagers
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
            this.button1 = new System.Windows.Forms.Button();
            this.bD2DataSet1 = new ProjektBD2.BD2DataSet1();
            this.bD2DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressSetTableAdapter = new ProjektBD2.BD2DataSet1TableAdapters.AddressSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "SET AND CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bD2DataSet1
            // 
            this.bD2DataSet1.DataSetName = "BD2DataSet1";
            this.bD2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bD2DataSet1BindingSource
            // 
            this.bD2DataSet1BindingSource.DataSource = this.bD2DataSet1;
            this.bD2DataSet1BindingSource.Position = 0;
            // 
            // addressSetBindingSource
            // 
            this.addressSetBindingSource.DataMember = "AddressSet";
            this.addressSetBindingSource.DataSource = this.bD2DataSet1BindingSource;
            // 
            // addressSetTableAdapter
            // 
            this.addressSetTableAdapter.ClearBeforeFill = true;
            // 
            // showManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 285);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "showManagers";
            this.Text = "showManagers";
            this.Load += new System.EventHandler(this.showManagers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bD2DataSet1BindingSource;
        private BD2DataSet1 bD2DataSet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource addressSetBindingSource;
        private BD2DataSet1TableAdapters.AddressSetTableAdapter addressSetTableAdapter;
    }
}