using System.Collections.Generic;
using TechnicianGrading.Models;

namespace TechnicianGrading.Services
{
    /// <summary>
    /// Provides methods for computing scores and recommended grades.
    /// </summary>
    public class ScoringService
    {
        private readonly Dictionary<string, int> _qualificationPoints = new()
        {
            { "بكالوريوس", 30 },
            { "دبلوم", 20 },
            { "ثانوي أو أقل", 10 }
        };

        private readonly Dictionary<string, int> _experiencePoints = new()
        {
            { "< 10 سنوات", 25 },
            { "5 – 9.99 سنوات", 20 },
            { "2 – 4.99 سنوات", 15 },
            { "0 – 1.99 سنوات", 10 }
        };

        private readonly Dictionary<string, int> _skillPoints = new()
        {
            { "عالي", 25 },
            { "متوسط", 20 },
            { "مبتدئ", 15 }
        };

        private readonly Dictionary<string, int> _certPoints = new()
        {
            { "أكثر من شهادة", 10 },
            { "شهادة واحدة", 7 },
            { "لا يوجد", 0 }
        };

        private readonly Dictionary<string, int> _evaluationPoints = new()
        {
            { "94 – 100", 10 },
            { "85 – 93", 8 },
            { "60 – 84", 6 },
            { "20 – 39", 4 }
        };

        /// <summary>
        /// Computes the total points for the given record.
        /// </summary>
        public int ComputeTotalPoints(EmployeeRecord record)
        {
            int total = 0;
            total += _qualificationPoints[record.Qualification];
            total += _experiencePoints[record.Experience];
            total += _skillPoints[record.TechnicalSkill];
            total += _certPoints[record.Certifications];
            total += _evaluationPoints[record.AnnualEvaluation];
            return total;
        }

        /// <summary>
        /// Computes the recommended grade based on total points.
        /// </summary>
        public string ComputeRecommendedGrade(int totalPoints) =>
            totalPoints >= 80 ? "درجة أعلى" : "الدرجة الحالية";
    }
}
