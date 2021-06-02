
namespace contact_tracing_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.detail_groupbox = new System.Windows.Forms.GroupBox();
            this.temp_txtbox = new System.Windows.Forms.TextBox();
            this.temp_label = new System.Windows.Forms.Label();
            this.number_txtbox = new System.Windows.Forms.TextBox();
            this.Number_label = new System.Windows.Forms.Label();
            this.address_txtbox = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.age_txtbox = new System.Windows.Forms.TextBox();
            this.Age_label = new System.Windows.Forms.Label();
            this.Lname_txtbox = new System.Windows.Forms.TextBox();
            this.Lname_label = new System.Windows.Forms.Label();
            this.Fname_txtbox = new System.Windows.Forms.TextBox();
            this.fname_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.View_btn = new System.Windows.Forms.Button();
            this.label_calendar = new System.Windows.Forms.Label();
            this.select_calendar = new System.Windows.Forms.DateTimePicker();
            this.detail_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "James Handles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(204, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Store";
            // 
            // detail_groupbox
            // 
            this.detail_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.detail_groupbox.Controls.Add(this.temp_txtbox);
            this.detail_groupbox.Controls.Add(this.Save_btn);
            this.detail_groupbox.Controls.Add(this.temp_label);
            this.detail_groupbox.Controls.Add(this.number_txtbox);
            this.detail_groupbox.Controls.Add(this.Number_label);
            this.detail_groupbox.Controls.Add(this.address_txtbox);
            this.detail_groupbox.Controls.Add(this.Address_label);
            this.detail_groupbox.Controls.Add(this.age_txtbox);
            this.detail_groupbox.Controls.Add(this.Age_label);
            this.detail_groupbox.Controls.Add(this.Lname_txtbox);
            this.detail_groupbox.Controls.Add(this.Lname_label);
            this.detail_groupbox.Controls.Add(this.Fname_txtbox);
            this.detail_groupbox.Controls.Add(this.fname_label);
            this.detail_groupbox.Controls.Add(this.label3);
            this.detail_groupbox.Controls.Add(this.label_Name);
            this.detail_groupbox.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_groupbox.Location = new System.Drawing.Point(12, 66);
            this.detail_groupbox.Name = "detail_groupbox";
            this.detail_groupbox.Size = new System.Drawing.Size(428, 333);
            this.detail_groupbox.TabIndex = 2;
            this.detail_groupbox.TabStop = false;
            this.detail_groupbox.Enter += new System.EventHandler(this.detail_groupbox_Enter);
            // 
            // temp_txtbox
            // 
            this.temp_txtbox.Location = new System.Drawing.Point(119, 261);
            this.temp_txtbox.Name = "temp_txtbox";
            this.temp_txtbox.Size = new System.Drawing.Size(163, 28);
            this.temp_txtbox.TabIndex = 13;
            // 
            // temp_label
            // 
            this.temp_label.AutoSize = true;
            this.temp_label.BackColor = System.Drawing.Color.White;
            this.temp_label.Location = new System.Drawing.Point(0, 264);
            this.temp_label.Name = "temp_label";
            this.temp_label.Size = new System.Drawing.Size(117, 21);
            this.temp_label.TabIndex = 12;
            this.temp_label.Text = "Temperature: ";
            // 
            // number_txtbox
            // 
            this.number_txtbox.Location = new System.Drawing.Point(119, 220);
            this.number_txtbox.Name = "number_txtbox";
            this.number_txtbox.Size = new System.Drawing.Size(163, 28);
            this.number_txtbox.TabIndex = 11;
            // 
            // Number_label
            // 
            this.Number_label.AutoSize = true;
            this.Number_label.BackColor = System.Drawing.Color.White;
            this.Number_label.Location = new System.Drawing.Point(0, 227);
            this.Number_label.Name = "Number_label";
            this.Number_label.Size = new System.Drawing.Size(80, 21);
            this.Number_label.TabIndex = 10;
            this.Number_label.Text = "Number: ";
            // 
            // address_txtbox
            // 
            this.address_txtbox.Location = new System.Drawing.Point(119, 190);
            this.address_txtbox.Name = "address_txtbox";
            this.address_txtbox.Size = new System.Drawing.Size(291, 28);
            this.address_txtbox.TabIndex = 9;
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.BackColor = System.Drawing.Color.White;
            this.Address_label.Location = new System.Drawing.Point(0, 189);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(74, 21);
            this.Address_label.TabIndex = 8;
            this.Address_label.Text = "Address:";
            // 
            // age_txtbox
            // 
            this.age_txtbox.Location = new System.Drawing.Point(119, 156);
            this.age_txtbox.Name = "age_txtbox";
            this.age_txtbox.Size = new System.Drawing.Size(163, 28);
            this.age_txtbox.TabIndex = 7;
            // 
            // Age_label
            // 
            this.Age_label.AutoSize = true;
            this.Age_label.BackColor = System.Drawing.Color.White;
            this.Age_label.Location = new System.Drawing.Point(0, 151);
            this.Age_label.Name = "Age_label";
            this.Age_label.Size = new System.Drawing.Size(43, 21);
            this.Age_label.TabIndex = 6;
            this.Age_label.Text = "Age:";
            // 
            // Lname_txtbox
            // 
            this.Lname_txtbox.Location = new System.Drawing.Point(144, 117);
            this.Lname_txtbox.Name = "Lname_txtbox";
            this.Lname_txtbox.Size = new System.Drawing.Size(257, 28);
            this.Lname_txtbox.TabIndex = 5;
            // 
            // Lname_label
            // 
            this.Lname_label.AutoSize = true;
            this.Lname_label.BackColor = System.Drawing.Color.White;
            this.Lname_label.Location = new System.Drawing.Point(24, 117);
            this.Lname_label.Name = "Lname_label";
            this.Lname_label.Size = new System.Drawing.Size(98, 21);
            this.Lname_label.TabIndex = 4;
            this.Lname_label.Text = "Last Name:";
            // 
            // Fname_txtbox
            // 
            this.Fname_txtbox.Location = new System.Drawing.Point(144, 77);
            this.Fname_txtbox.Name = "Fname_txtbox";
            this.Fname_txtbox.Size = new System.Drawing.Size(257, 28);
            this.Fname_txtbox.TabIndex = 3;
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.BackColor = System.Drawing.Color.White;
            this.fname_label.Location = new System.Drawing.Point(24, 84);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(101, 21);
            this.fname_label.TabIndex = 2;
            this.fname_label.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(0, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "CUSTOMER DETAILS";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(0, 47);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(63, 21);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name: ";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(177, 295);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(62, 37);
            this.Save_btn.TabIndex = 3;
            this.Save_btn.Text = "Save Details";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // View_btn
            // 
            this.View_btn.Location = new System.Drawing.Point(295, 424);
            this.View_btn.Name = "View_btn";
            this.View_btn.Size = new System.Drawing.Size(92, 26);
            this.View_btn.TabIndex = 4;
            this.View_btn.Text = "View Lists";
            this.View_btn.UseVisualStyleBackColor = true;
            this.View_btn.Click += new System.EventHandler(this.View_btn_Click);
            // 
            // label_calendar
            // 
            this.label_calendar.AutoSize = true;
            this.label_calendar.BackColor = System.Drawing.Color.White;
            this.label_calendar.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_calendar.ForeColor = System.Drawing.Color.BlueViolet;
            this.label_calendar.Location = new System.Drawing.Point(12, 402);
            this.label_calendar.Name = "label_calendar";
            this.label_calendar.Size = new System.Drawing.Size(130, 22);
            this.label_calendar.TabIndex = 5;
            this.label_calendar.Text = "Select Date: ";
            // 
            // select_calendar
            // 
            this.select_calendar.CustomFormat = "dddd, MMMM dd, yyyy";
            this.select_calendar.Location = new System.Drawing.Point(55, 427);
            this.select_calendar.Name = "select_calendar";
            this.select_calendar.Size = new System.Drawing.Size(229, 23);
            this.select_calendar.TabIndex = 6;
            this.select_calendar.Value = new System.DateTime(2021, 6, 2, 13, 41, 53, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 473);
            this.Controls.Add(this.select_calendar);
            this.Controls.Add(this.label_calendar);
            this.Controls.Add(this.View_btn);
            this.Controls.Add(this.detail_groupbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Contact Tracing Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.detail_groupbox.ResumeLayout(false);
            this.detail_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox detail_groupbox;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox age_txtbox;
        private System.Windows.Forms.Label Age_label;
        private System.Windows.Forms.TextBox Lname_txtbox;
        private System.Windows.Forms.Label Lname_label;
        private System.Windows.Forms.TextBox Fname_txtbox;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox temp_txtbox;
        private System.Windows.Forms.Label temp_label;
        private System.Windows.Forms.TextBox number_txtbox;
        private System.Windows.Forms.Label Number_label;
        private System.Windows.Forms.TextBox address_txtbox;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button View_btn;
        private System.Windows.Forms.Label label_calendar;
        private System.Windows.Forms.DateTimePicker select_calendar;
    }
}

