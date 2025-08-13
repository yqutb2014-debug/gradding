using System;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using TechnicianGrading.Models;
using TechnicianGrading.Services;

namespace TechnicianGrading
{
    public partial class Form1 : Form
    {
        private readonly ScoringService _service = new();
        private readonly BindingList<EmployeeRecord> _records = new();
        private EmployeeRecord? _currentRecord;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _records;
        }

        /// <summary>
        /// Validates input controls and builds an EmployeeRecord.
        /// </summary>
        private bool TryBuildRecord(out EmployeeRecord record)
        {
            record = new EmployeeRecord();
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم الموظف");
                return false;
            }

            if (cmbQualification.SelectedItem == null ||
                cmbExperience.SelectedItem == null ||
                cmbSkill.SelectedItem == null ||
                cmbCert.SelectedItem == null ||
                cmbEvaluation.SelectedItem == null)
            {
                MessageBox.Show("يرجى اختيار جميع الحقول");
                return false;
            }

            record.Name = txtName.Text.Trim();
            record.Qualification = cmbQualification.SelectedItem!.ToString()!;
            record.Experience = cmbExperience.SelectedItem!.ToString()!;
            record.TechnicalSkill = cmbSkill.SelectedItem!.ToString()!;
            record.Certifications = cmbCert.SelectedItem!.ToString()!;
            record.AnnualEvaluation = cmbEvaluation.SelectedItem!.ToString()!;
            return true;
        }

        /// <summary>
        /// Handles calculate button click.
        /// </summary>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!TryBuildRecord(out var record))
                return;

            record.TotalPoints = _service.ComputeTotalPoints(record);
            record.RecommendedGrade = _service.ComputeRecommendedGrade(record.TotalPoints);

            lblTotalPoints.Text = record.TotalPoints.ToString();
            lblRecommended.Text = record.RecommendedGrade;
            _currentRecord = record;
        }

        /// <summary>
        /// Adds the current record to the grid.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_currentRecord == null)
            {
                MessageBox.Show("يرجى حساب النقاط أولاً");
                return;
            }
            _records.Add(_currentRecord);
            _currentRecord = null;
        }

        /// <summary>
        /// Saves records list to JSON file.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            var json = JsonSerializer.Serialize(_records);
            File.WriteAllText("employees.json", json);
            MessageBox.Show("تم الحفظ");
        }

        /// <summary>
        /// Loads records from JSON file.
        /// </summary>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists("employees.json"))
            {
                MessageBox.Show("الملف غير موجود");
                return;
            }
            var json = File.ReadAllText("employees.json");
            var list = JsonSerializer.Deserialize<BindingList<EmployeeRecord>>(json);
            if (list == null) return;
            _records.Clear();
            foreach (var r in list)
                _records.Add(r);
        }
    }
}
