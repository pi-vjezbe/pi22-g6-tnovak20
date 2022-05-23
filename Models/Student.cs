using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models
{
    public class Student : Person
    {
        public int Grade { get; set; }

        public List<Evaluation> GetEvaluations()
        {
            return EvaluationRepository.GetEvaluation(this);
        }

        public int CalculateTotalPoints()
        {
            int totalPoints = 0;
            foreach (var evaluation in GetEvaluations())
            {
                totalPoints += evaluation.Points;
            }
            return totalPoints;
        }



        public bool HasSignature()
        {
            bool hasSignature = true;
            if (IsEvaluationComlete() == true)
	        {
                foreach (var evaluation in GetEvaluation())
	            {
                    if (evaluation.IsSufficientForSignature() == false)
                    {
                        hasSignature = false;
                        break;
                    }
	            }
	        }
            else
            {
                hasSignature = false:
            }
	    }
        return hasSignature;
        
        public bool HasGrade()
        {
            bool hasGrade = true;
            if (IsEvaluationComlete() == true)
	        {
                foreach (var evaluation in GetEvaluation())
	            {
                    if (evaluation.IsSufficientForGrade() == false)
                    {
                        hasGrade = false;
                        break;
                    }
	            }
	        }
            else
            {
                hasGrade = false:
            }
	    }
        return hasGrade;

        private bool IsEvaluationComlete()
        {
            var evaluations = GetEvaluations();
            var activities = ActivityRepository.GetActivities();
            return evaluations.Count == activities.Count;
        }

        public int CalculateGrade()
        {
            int grade = 0;
            if (HasGrade() == true)
            {
                int totalPoints = CalculateTotalPoints();
                if (totalPoints >= 91)
                {
                    grade = 5;
                }
                else if (totalPoints >= 76)
                {
                    grade = 4;
                }
                else if (totalPoints >= 61)
                {
                    grade = 3;
                }
                else if (totalPoints >= 50)
                {
                    grade = 2;
                }
                else
                {
                    grade = 1;
                }
            }
            return grade;
        }
    }
}
