namespace TechnicianGrading
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbQualification = new System.Windows.Forms.ComboBox();
            this.cmbExperience = new System.Windows.Forms.ComboBox();
            this.cmbSkill = new System.Windows.Forms.ComboBox();
            this.cmbCert = new System.Windows.Forms.ComboBox();
            this.cmbEvaluation = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.lblRecommended = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSkill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecommended = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 23);
            this.txtName.TabIndex = 0;
            // 
            // cmbQualification
            // 
            this.cmbQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQualification.FormattingEnabled = true;
            this.cmbQualification.Items.AddRange(new object[] {
            "بكالوريوس",
            "دبلوم",
            "ثانوي أو أقل"});
            this.cmbQualification.Location = new System.Drawing.Point(12, 71);
            this.cmbQualification.Name = "cmbQualification";
            this.cmbQualification.Size = new System.Drawing.Size(180, 23);
            this.cmbQualification.TabIndex = 1;
            // 
            // cmbExperience
            // 
            this.cmbExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExperience.FormattingEnabled = true;
            this.cmbExperience.Items.AddRange(new object[] {
            "< 10 سنوات",
            "5 – 9.99 سنوات",
            "2 – 4.99 سنوات",
            "0 – 1.99 سنوات"});
            this.cmbExperience.Location = new System.Drawing.Point(12, 117);
            this.cmbExperience.Name = "cmbExperience";
            this.cmbExperience.Size = new System.Drawing.Size(180, 23);
            this.cmbExperience.TabIndex = 2;
            // 
            // cmbSkill
            // 
            this.cmbSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkill.FormattingEnabled = true;
            this.cmbSkill.Items.AddRange(new object[] {
            "عالي",
            "متوسط",
            "مبتدئ"});
            this.cmbSkill.Location = new System.Drawing.Point(12, 163);
            this.cmbSkill.Name = "cmbSkill";
            this.cmbSkill.Size = new System.Drawing.Size(180, 23);
            this.cmbSkill.TabIndex = 3;
            // 
            // cmbCert
            // 
            this.cmbCert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCert.FormattingEnabled = true;
            this.cmbCert.Items.AddRange(new object[] {
            "أكثر من شهادة",
            "شهادة واحدة",
            "لا يوجد"});
            this.cmbCert.Location = new System.Drawing.Point(12, 209);
            this.cmbCert.Name = "cmbCert";
            this.cmbCert.Size = new System.Drawing.Size(180, 23);
            this.cmbCert.TabIndex = 4;
            // 
            // cmbEvaluation
            // 
            this.cmbEvaluation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvaluation.FormattingEnabled = true;
            this.cmbEvaluation.Items.AddRange(new object[] {
            "94 – 100",
            "85 – 93",
            "60 – 84",
            "20 – 39"});
            this.cmbEvaluation.Location = new System.Drawing.Point(12, 255);
            this.cmbEvaluation.Name = "cmbEvaluation";
            this.cmbEvaluation.Size = new System.Drawing.Size(180, 23);
            this.cmbEvaluation.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(210, 25);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 30);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "حساب";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(210, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(210, 163);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 30);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "تحميل";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPoints.Location = new System.Drawing.Point(210, 225);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(90, 23);
            this.lblTotalPoints.TabIndex = 10;
            this.lblTotalPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecommended
            // 
            this.lblRecommended.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecommended.Location = new System.Drawing.Point(210, 271);
            this.lblRecommended.Name = "lblRecommended";
            this.lblRecommended.Size = new System.Drawing.Size(90, 23);
            this.lblRecommended.TabIndex = 11;
            this.lblRecommended.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "اسم الموظف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "المؤهل العلمي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "سنوات الخبرة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "المهارات الفنية";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "الشهادات الاحترافية";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "التقييم السنوي";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "إجمالي النقاط";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "الدرجة الموصى بها";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colQualification,
            this.colExperience,
            this.colSkill,
            this.colCert,
            this.colEvaluation,
            this.colTotalPoints,
            this.colRecommended});
            this.dataGridView1.Location = new System.Drawing.Point(12, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(760, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "الاسم";
            this.colName.Name = "colName";
            // 
            // colQualification
            // 
            this.colQualification.DataPropertyName = "Qualification";
            this.colQualification.HeaderText = "المؤهل";
            this.colQualification.Name = "colQualification";
            // 
            // colExperience
            // 
            this.colExperience.DataPropertyName = "Experience";
            this.colExperience.HeaderText = "الخبرة";
            this.colExperience.Name = "colExperience";
            // 
            // colSkill
            // 
            this.colSkill.DataPropertyName = "TechnicalSkill";
            this.colSkill.HeaderText = "المهارة";
            this.colSkill.Name = "colSkill";
            // 
            // colCert
            // 
            this.colCert.DataPropertyName = "Certifications";
            this.colCert.HeaderText = "الشهادات";
            this.colCert.Name = "colCert";
            // 
            // colEvaluation
            // 
            this.colEvaluation.DataPropertyName = "AnnualEvaluation";
            this.colEvaluation.HeaderText = "التقييم";
            this.colEvaluation.Name = "colEvaluation";
            // 
            // colTotalPoints
            // 
            this.colTotalPoints.DataPropertyName = "TotalPoints";
            this.colTotalPoints.HeaderText = "النقاط";
            this.colTotalPoints.Name = "colTotalPoints";
            // 
            // colRecommended
            // 
            this.colRecommended.DataPropertyName = "RecommendedGrade";
            this.colRecommended.HeaderText = "الدرجة الموصى بها";
            this.colRecommended.Name = "colRecommended";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecommended);
            this.Controls.Add(this.lblTotalPoints);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbEvaluation);
            this.Controls.Add(this.cmbCert);
            this.Controls.Add(this.cmbSkill);
            this.Controls.Add(this.cmbExperience);
            this.Controls.Add(this.cmbQualification);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "تقويم الفني";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbQualification;
        private System.Windows.Forms.ComboBox cmbExperience;
        private System.Windows.Forms.ComboBox cmbSkill;
        private System.Windows.Forms.ComboBox cmbCert;
        private System.Windows.Forms.ComboBox cmbEvaluation;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.Label lblRecommended;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSkill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCert;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvaluation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecommended;
    }
}
