namespace ProjektBD2
{
    partial class MeetingHistory
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
            this.bD2DataSet3 = new ProjektBD2.BD2DataSet3();
            this.meetingSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingSetTableAdapter = new ProjektBD2.BD2DataSet3TableAdapters.MeetingSetTableAdapter();
            this.meetingSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD2DataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD2DataSet4 = new ProjektBD2.BD2DataSet4();
            this.productSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingSetTableAdapter1 = new ProjektBD2.BD2DataSet4TableAdapters.MeetingSetTableAdapter();
            this.productSetTableAdapter = new ProjektBD2.BD2DataSet4TableAdapters.ProductSetTableAdapter();
            this.userSetTableAdapter = new ProjektBD2.BD2DataSet4TableAdapters.UserSetTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bD2DataSet3
            // 
            this.bD2DataSet3.DataSetName = "BD2DataSet3";
            this.bD2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meetingSetBindingSource
            // 
            this.meetingSetBindingSource.DataMember = "MeetingSet";
            this.meetingSetBindingSource.DataSource = this.bD2DataSet3;
            // 
            // meetingSetTableAdapter
            // 
            this.meetingSetTableAdapter.ClearBeforeFill = true;
            // 
            // meetingSetBindingSource1
            // 
            this.meetingSetBindingSource1.DataMember = "MeetingSet";
            this.meetingSetBindingSource1.DataSource = this.bD2DataSet4BindingSource;
            // 
            // bD2DataSet4BindingSource
            // 
            this.bD2DataSet4BindingSource.DataSource = this.bD2DataSet4;
            this.bD2DataSet4BindingSource.Position = 0;
            // 
            // bD2DataSet4
            // 
            this.bD2DataSet4.DataSetName = "BD2DataSet4";
            this.bD2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productSetBindingSource
            // 
            this.productSetBindingSource.DataMember = "ProductSet";
            this.productSetBindingSource.DataSource = this.bD2DataSet4BindingSource;
            // 
            // userSetBindingSource
            // 
            this.userSetBindingSource.DataMember = "UserSet";
            this.userSetBindingSource.DataSource = this.bD2DataSet4BindingSource;
            // 
            // meetingSetTableAdapter1
            // 
            this.meetingSetTableAdapter1.ClearBeforeFill = true;
            // 
            // productSetTableAdapter
            // 
            this.productSetTableAdapter.ClearBeforeFill = true;
            // 
            // userSetTableAdapter
            // 
            this.userSetTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.Size = new System.Drawing.Size(901, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // MeetingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 359);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MeetingHistory";
            this.Text = "MeetingHistory";
            this.Load += new System.EventHandler(this.MeetingHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BD2DataSet3 bD2DataSet3;
        private System.Windows.Forms.BindingSource meetingSetBindingSource;
        private BD2DataSet3TableAdapters.MeetingSetTableAdapter meetingSetTableAdapter;
        private System.Windows.Forms.BindingSource bD2DataSet4BindingSource;
        private BD2DataSet4 bD2DataSet4;
        private System.Windows.Forms.BindingSource meetingSetBindingSource1;
        private BD2DataSet4TableAdapters.MeetingSetTableAdapter meetingSetTableAdapter1;
        private System.Windows.Forms.BindingSource productSetBindingSource;
        private BD2DataSet4TableAdapters.ProductSetTableAdapter productSetTableAdapter;
        private System.Windows.Forms.BindingSource userSetBindingSource;
        private BD2DataSet4TableAdapters.UserSetTableAdapter userSetTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}