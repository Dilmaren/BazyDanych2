namespace ProjektBD2
{
    partial class NewMeeting
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
            this.button1 = new System.Windows.Forms.Button();
            this.newMeetingSelectedHCP = new System.Windows.Forms.Label();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.timePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.newMeetingSelectedProduct = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select HCP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newMeetingSelectedHCP
            // 
            this.newMeetingSelectedHCP.AutoSize = true;
            this.newMeetingSelectedHCP.Location = new System.Drawing.Point(119, 15);
            this.newMeetingSelectedHCP.Name = "newMeetingSelectedHCP";
            this.newMeetingSelectedHCP.Size = new System.Drawing.Size(13, 17);
            this.newMeetingSelectedHCP.TabIndex = 1;
            this.newMeetingSelectedHCP.Text = "-";
            // 
            // datePicker1
            // 
            this.datePicker1.CustomFormat = "";
            this.datePicker1.Location = new System.Drawing.Point(166, 81);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(200, 22);
            this.datePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Date and Time:";
            // 
            // timePicker1
            // 
            this.timePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker1.Location = new System.Drawing.Point(373, 81);
            this.timePicker1.Name = "timePicker1";
            this.timePicker1.ShowUpDown = true;
            this.timePicker1.Size = new System.Drawing.Size(121, 22);
            this.timePicker1.TabIndex = 4;
            this.timePicker1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(68, 109);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(258, 47);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Topic:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Select Product:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newMeetingSelectedProduct
            // 
            this.newMeetingSelectedProduct.AutoSize = true;
            this.newMeetingSelectedProduct.Location = new System.Drawing.Point(139, 46);
            this.newMeetingSelectedProduct.Name = "newMeetingSelectedProduct";
            this.newMeetingSelectedProduct.Size = new System.Drawing.Size(13, 17);
            this.newMeetingSelectedProduct.TabIndex = 8;
            this.newMeetingSelectedProduct.Text = "-";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(122, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Schedule!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NewMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 284);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.newMeetingSelectedProduct);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.timePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePicker1);
            this.Controls.Add(this.newMeetingSelectedHCP);
            this.Controls.Add(this.button1);
            this.Name = "NewMeeting";
            this.Text = "NewMeeting";
            this.Load += new System.EventHandler(this.NewMeeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label newMeetingSelectedHCP;
        private System.Windows.Forms.Label newMeetingSelectedProduct;
    }
}