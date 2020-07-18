namespace WSC2015_Redo
{
    partial class VolunteerManagementFormcs
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
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.wSC2015_RedoDataSet = new WSC2015_Redo.WSC2015_RedoDataSet();
            this.volunteerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.volunteerTableAdapter = new WSC2015_Redo.WSC2015_RedoDataSetTableAdapters.VolunteerTableAdapter();
            this.volunteerViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.volunteer_ViewTableAdapter = new WSC2015_Redo.WSC2015_RedoDataSetTableAdapters.Volunteer_ViewTableAdapter();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSC2015_RedoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(791, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 33);
            this.button5.TabIndex = 85;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(946, 34);
            this.label2.TabIndex = 84;
            this.label2.Text = "Volunteer Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 83;
            this.label1.Text = "MARATHON SKILLS 2015";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 33);
            this.button1.TabIndex = 82;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Country",
            "Gender"});
            this.comboBox1.Location = new System.Drawing.Point(81, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 31);
            this.comboBox1.TabIndex = 86;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.countryNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.volunteerViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 339);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(946, 34);
            this.label3.TabIndex = 88;
            this.label3.Text = "Volunteer Management";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(747, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 33);
            this.button2.TabIndex = 89;
            this.button2.Text = "Import";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wSC2015_RedoDataSet
            // 
            this.wSC2015_RedoDataSet.DataSetName = "WSC2015_RedoDataSet";
            this.wSC2015_RedoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // volunteerBindingSource
            // 
            this.volunteerBindingSource.DataMember = "Volunteer";
            this.volunteerBindingSource.DataSource = this.wSC2015_RedoDataSet;
            // 
            // volunteerTableAdapter
            // 
            this.volunteerTableAdapter.ClearBeforeFill = true;
            // 
            // volunteerViewBindingSource
            // 
            this.volunteerViewBindingSource.DataMember = "Volunteer_View";
            this.volunteerViewBindingSource.DataSource = this.wSC2015_RedoDataSet;
            // 
            // volunteer_ViewTableAdapter
            // 
            this.volunteer_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            this.countryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VolunteerManagementFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 556);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VolunteerManagementFormcs";
            this.Text = "VolunteerManagementFormcs";
            this.Load += new System.EventHandler(this.VolunteerManagementFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSC2015_RedoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private WSC2015_RedoDataSet wSC2015_RedoDataSet;
        private System.Windows.Forms.BindingSource volunteerBindingSource;
        private WSC2015_RedoDataSetTableAdapters.VolunteerTableAdapter volunteerTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource volunteerViewBindingSource;
        private WSC2015_RedoDataSetTableAdapters.Volunteer_ViewTableAdapter volunteer_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
    }
}