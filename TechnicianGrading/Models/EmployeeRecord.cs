using System;

namespace TechnicianGrading.Models
{
    /// <summary>
    /// Represents a single employee grading record.
    /// </summary>
    public class EmployeeRecord
    {
        public string Name { get; set; } = string.Empty;
        public string Qualification { get; set; } = string.Empty;
        public string Experience { get; set; } = string.Empty;
        public string TechnicalSkill { get; set; } = string.Empty;
        public string Certifications { get; set; } = string.Empty;
        public string AnnualEvaluation { get; set; } = string.Empty;
        public int TotalPoints { get; set; }
        public string RecommendedGrade { get; set; } = string.Empty;
    }
}
