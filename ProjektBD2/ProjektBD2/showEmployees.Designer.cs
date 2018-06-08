using System.ComponentModel;

namespace ProjektBD2
{
    partial class showEmployees
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
            this.hCPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOLDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCPSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD2DataSet2 = new ProjektBD2.BD2DataSet2();
            this.hCPSetTableAdapter = new ProjektBD2.BD2DataSet2TableAdapters.HCPSetTableAdapter();
            this.filtrujToolStrip = new System.Windows.Forms.ToolStrip();
            this.paramToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.paramToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.filtrujToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCPSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet2)).BeginInit();
            this.filtrujToolStrip.SuspendLayout();
            this.SuspendLayout();
            // Window close button
            this.Closing += new CancelEventHandler(this.windowClosing);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hCPIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.academicTitleDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kOLDataGridViewCheckBoxColumn,
            this.specialtyDataGridViewTextBoxColumn,
            this.addressIDDataGridViewTextBoxColumn,
            this.hCOIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hCPSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1343, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hCPIDDataGridViewTextBoxColumn
            // 
            this.hCPIDDataGridViewTextBoxColumn.DataPropertyName = "HCPID";
            this.hCPIDDataGridViewTextBoxColumn.HeaderText = "HCPID";
            this.hCPIDDataGridViewTextBoxColumn.Name = "hCPIDDataGridViewTextBoxColumn";
            this.hCPIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // academicTitleDataGridViewTextBoxColumn
            // 
            this.academicTitleDataGridViewTextBoxColumn.DataPropertyName = "AcademicTitle";
            this.academicTitleDataGridViewTextBoxColumn.HeaderText = "AcademicTitle";
            this.academicTitleDataGridViewTextBoxColumn.Name = "academicTitleDataGridViewTextBoxColumn";
            this.academicTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kOLDataGridViewCheckBoxColumn
            // 
            this.kOLDataGridViewCheckBoxColumn.DataPropertyName = "KOL";
            this.kOLDataGridViewCheckBoxColumn.HeaderText = "KOL";
            this.kOLDataGridViewCheckBoxColumn.Name = "kOLDataGridViewCheckBoxColumn";
            this.kOLDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            this.specialtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressIDDataGridViewTextBoxColumn
            // 
            this.addressIDDataGridViewTextBoxColumn.DataPropertyName = "AddressID";
            this.addressIDDataGridViewTextBoxColumn.HeaderText = "AddressID";
            this.addressIDDataGridViewTextBoxColumn.Name = "addressIDDataGridViewTextBoxColumn";
            this.addressIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hCOIDDataGridViewTextBoxColumn
            // 
            this.hCOIDDataGridViewTextBoxColumn.DataPropertyName = "HCOID";
            this.hCOIDDataGridViewTextBoxColumn.HeaderText = "HCOID";
            this.hCOIDDataGridViewTextBoxColumn.Name = "hCOIDDataGridViewTextBoxColumn";
            this.hCOIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hCPSetBindingSource
            // 
            this.hCPSetBindingSource.DataMember = "HCPSet";
            this.hCPSetBindingSource.DataSource = this.bD2DataSet2;
            // 
            // bD2DataSet2
            // 
            this.bD2DataSet2.DataSetName = "BD2DataSet2";
            this.bD2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hCPSetTableAdapter
            // 
            this.hCPSetTableAdapter.ClearBeforeFill = true;
            // 
            // filtrujToolStrip
            // 
            this.filtrujToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.filtrujToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramToolStripLabel,
            this.paramToolStripTextBox,
            this.filtrujToolStripButton});
            this.filtrujToolStrip.Location = new System.Drawing.Point(0, 0);
            this.filtrujToolStrip.Name = "filtrujToolStrip";
            this.filtrujToolStrip.Size = new System.Drawing.Size(1426, 27);
            this.filtrujToolStrip.TabIndex = 2;
            this.filtrujToolStrip.Text = "filtrujToolStrip";
            // 
            // paramToolStripLabel
            // 
            this.paramToolStripLabel.Name = "paramToolStripLabel";
            this.paramToolStripLabel.Size = new System.Drawing.Size(55, 22);
            this.paramToolStripLabel.Text = "param:";
            // 
            // paramToolStripTextBox
            // 
            this.paramToolStripTextBox.Name = "paramToolStripTextBox";
            this.paramToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // filtrujToolStripButton
            // 
            this.filtrujToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filtrujToolStripButton.Name = "filtrujToolStripButton";
            this.filtrujToolStripButton.Size = new System.Drawing.Size(50, 24);
            this.filtrujToolStripButton.Text = "Filtruj";
            this.filtrujToolStripButton.Click += new System.EventHandler(this.filtrujToolStripButton_Click);
            // 
            // showEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 487);
            this.Controls.Add(this.filtrujToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "showEmployees";
            this.Text = "showEmployees";
            this.Load += new System.EventHandler(this.showEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hCPSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet2)).EndInit();
            this.filtrujToolStrip.ResumeLayout(false);
            this.filtrujToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
        #endregion
        
        private System.Windows.Forms.DataGridView dataGridView1;
        private BD2DataSet2 bD2DataSet2;
        private System.Windows.Forms.BindingSource hCPSetBindingSource;
        private BD2DataSet2TableAdapters.HCPSetTableAdapter hCPSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kOLDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip filtrujToolStrip;
        private System.Windows.Forms.ToolStripLabel paramToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox paramToolStripTextBox;
        private System.Windows.Forms.ToolStripButton filtrujToolStripButton;
    }
}
