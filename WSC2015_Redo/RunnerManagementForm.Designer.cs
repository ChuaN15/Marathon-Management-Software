namespace WSC2015_Redo
{
    partial class RunnerManagementForm
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
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.registrationStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wSC2015_RedoDataSet = new WSC2015_Redo.WSC2015_RedoDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.eventTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.registrationStatusTableAdapter = new WSC2015_Redo.WSC2015_RedoDataSetTableAdapters.RegistrationStatusTableAdapter();
            this.eventTypeTableAdapter = new WSC2015_Redo.WSC2015_RedoDataSetTableAdapters.EventTypeTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registrationStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSC2015_RedoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(700, 15);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 34);
            this.button7.TabIndex = 52;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 32);
            this.label2.TabIndex = 51;
            this.label2.Text = "MARATHON SKILLS 2015";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 34);
            this.button6.TabIndex = 50;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(861, 39);
            this.label1.TabIndex = 53;
            this.label1.Text = "Runner management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Status:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.registrationStatusBindingSource;
            this.comboBox1.DisplayMember = "RegistrationStatus";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 32);
            this.comboBox1.TabIndex = 55;
            this.comboBox1.ValueMember = "RegistrationStatusId";
            // 
            // registrationStatusBindingSource
            // 
            this.registrationStatusBindingSource.DataMember = "RegistrationStatus";
            this.registrationStatusBindingSource.DataSource = this.wSC2015_RedoDataSet;
            // 
            // wSC2015_RedoDataSet
            // 
            this.wSC2015_RedoDataSet.DataSetName = "WSC2015_RedoDataSet";
            this.wSC2015_RedoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.eventTypeBindingSource;
            this.comboBox2.DisplayMember = "EventTypeName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(140, 155);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 32);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.ValueMember = "EventTypeId";
            // 
            // eventTypeBindingSource
            // 
            this.eventTypeBindingSource.DataMember = "EventType";
            this.eventTypeBindingSource.DataSource = this.wSC2015_RedoDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Race event:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Email",
            "Status"});
            this.comboBox3.Location = new System.Drawing.Point(140, 193);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(228, 32);
            this.comboBox3.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "Sort by:";
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
            this.Column4,
            this.Column6,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 317);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Edit";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Text = "Edit";
            this.Column5.ToolTipText = "Edit";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(861, 39);
            this.label6.TabIndex = 61;
            this.label6.Text = "Runner management";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 34);
            this.button1.TabIndex = 62;
            this.button1.Text = "Runner details (CSV)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 34);
            this.button2.TabIndex = 63;
            this.button2.Text = "Email address list";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // registrationStatusTableAdapter
            // 
            this.registrationStatusTableAdapter.ClearBeforeFill = true;
            // 
            // eventTypeTableAdapter
            // 
            this.eventTypeTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 32);
            this.button3.TabIndex = 64;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RunnerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 604);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RunnerManagementForm";
            this.Text = "RunnerManagementForm";
            this.Load += new System.EventHandler(this.RunnerManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSC2015_RedoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private WSC2015_RedoDataSet wSC2015_RedoDataSet;
        private System.Windows.Forms.BindingSource registrationStatusBindingSource;
        private WSC2015_RedoDataSetTableAdapters.RegistrationStatusTableAdapter registrationStatusTableAdapter;
        private System.Windows.Forms.BindingSource eventTypeBindingSource;
        private WSC2015_RedoDataSetTableAdapters.EventTypeTableAdapter eventTypeTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}