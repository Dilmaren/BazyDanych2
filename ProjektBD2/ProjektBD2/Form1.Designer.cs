﻿namespace ProjektBD2
{
    partial class Form1
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
            this.hCOSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD2DataSet = new ProjektBD2.BD2DataSet();
            this.hCOSetTableAdapter = new ProjektBD2.BD2DataSetTableAdapters.HCOSetTableAdapter();
            this.btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hCOSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // hCOSetBindingSource
            // 
            this.hCOSetBindingSource.DataMember = "HCOSet";
            this.hCOSetBindingSource.DataSource = this.bD2DataSet;
            // 
            // bD2DataSet
            // 
            this.bD2DataSet.DataSetName = "BD2DataSet";
            this.bD2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hCOSetTableAdapter
            // 
            this.hCOSetTableAdapter.ClearBeforeFill = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 71);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(106, 55);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Create HCO";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Database monitor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tworzenie Adresu za pomocą EF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 434);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hCOSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BD2DataSet bD2DataSet;
        private System.Windows.Forms.BindingSource hCOSetBindingSource;
        private BD2DataSetTableAdapters.HCOSetTableAdapter hCOSetTableAdapter;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

