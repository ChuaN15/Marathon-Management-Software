namespace WSC2015_Redo
{
    partial class ReviousResultForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.wSC2015_RedoDataSet = new WSC2015_Redo.WSC2015_RedoDataSet();
            this.marathonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathonTableAdapter = new WSC2015_Redo.WSC2015_RedoDataSetTableAdapters.MarathonTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eventTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTypeTableAdapter = new WSC2015_Redo.WSC2015_RedoDataSetTableAdapters.EventTypeTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.wSC2015_RedoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1009, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Previous race results";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "MARATHON SKILLS 2015";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marathon:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.marathonBindingSource;
            this.comboBox1.DisplayMember = "MarathonName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 31);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "MarathonId";
            // 
            // wSC2015_RedoDataSet
            // 
            this.wSC2015_RedoDataSet.DataSetName = "WSC2015_RedoDataSet";
            this.wSC2015_RedoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marathonBindingSource
            // 
            this.marathonBindingSource.DataMember = "Marathon";
            this.marathonBindingSource.DataSource = this.wSC2015_RedoDataSet;
            // 
            // marathonTableAdapter
            // 
            this.marathonTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.eventTypeBindingSource;
            this.comboBox2.DisplayMember = "EventTypeName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(132, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(317, 31);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "EventTypeId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Event:";
            // 
            // eventTypeBindingSource
            // 
            this.eventTypeBindingSource.DataMember = "EventType";
            this.eventTypeBindingSource.DataSource = this.wSC2015_RedoDataSet;
            // 
            // eventTypeTableAdapter
            // 
            this.eventTypeTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Any",
            "Male",
            "Female"});
            this.comboBox3.Location = new System.Drawing.Point(636, 139);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(317, 31);
            this.comboBox3.TabIndex = 11;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Any",
            "Under 18",
            "18 to 29",
            "30 to 39",
            "40 to 55",
            "56 to 70",
            "Over 70"});
            this.comboBox4.Location = new System.Drawing.Point(636, 188);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(317, 31);
            this.comboBox4.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Age:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1009, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Previous race results";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(10, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 368);
            this.dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Rank";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Race time";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Runner Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Country";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ReviousResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 682);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReviousResultForm";
            this.Text = "ReviousResultForm";
            this.Load += new System.EventHandler(this.ReviousResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wSC2015_RedoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private WSC2015_RedoDataSet wSC2015_RedoDataSet;
        private System.Windows.Forms.BindingSource marathonBindingSource;
        private WSC2015_RedoDataSetTableAdapters.MarathonTableAdapter marathonTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource eventTypeBindingSource;
        private WSC2015_RedoDataSetTableAdapters.EventTypeTableAdapter eventTypeTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}