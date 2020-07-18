namespace WSC2015_Redo
{
    partial class EditProfileForm
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.wSC2015_RedoDataSet = new WSC2015_Redo.WSC2015_RedoDataSet();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderTableAdapter = new WSC2015_Redo.WSC2015_RedoDataSetTableAdapters.GenderTableAdapter();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new WSC2015_Redo.WSC2015_RedoDataSetTableAdapters.CountryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wSC2015_RedoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.countryBindingSource;
            this.comboBox2.DisplayMember = "CountryName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(199, 307);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(271, 31);
            this.comboBox2.TabIndex = 66;
            this.comboBox2.ValueMember = "CountryCode";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 30);
            this.dateTimePicker1.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 23);
            this.label10.TabIndex = 64;
            this.label10.Text = "Country:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 23);
            this.label9.TabIndex = 63;
            this.label9.Text = "Date of Birth:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.genderBindingSource;
            this.comboBox1.DisplayMember = "Gender";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 31);
            this.comboBox1.TabIndex = 62;
            this.comboBox1.ValueMember = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 23);
            this.label8.TabIndex = 61;
            this.label8.Text = "Gender:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(199, 420);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(248, 30);
            this.textBox5.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 59;
            this.label7.Text = "Last Name:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(199, 363);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(248, 30);
            this.textBox4.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 57;
            this.label6.Text = "First Name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(705, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 30);
            this.textBox3.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "Password Again:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 44);
            this.button3.TabIndex = 54;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 44);
            this.button2.TabIndex = 53;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(705, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 30);
            this.textBox2.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 51;
            this.label4.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 30);
            this.textBox1.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(924, 45);
            this.label2.TabIndex = 49;
            this.label2.Text = "Edit your profile";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "MARATHON SKILLS 2015";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 34);
            this.button1.TabIndex = 47;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(809, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 34);
            this.button4.TabIndex = 67;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Email:";
            // 
            // wSC2015_RedoDataSet
            // 
            this.wSC2015_RedoDataSet.DataSetName = "WSC2015_RedoDataSet";
            this.wSC2015_RedoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.wSC2015_RedoDataSet;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.wSC2015_RedoDataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // EditProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditProfileForm";
            this.Text = "EditProfileForm";
            this.Load += new System.EventHandler(this.EditProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wSC2015_RedoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private WSC2015_RedoDataSet wSC2015_RedoDataSet;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private WSC2015_RedoDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private WSC2015_RedoDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
    }
}