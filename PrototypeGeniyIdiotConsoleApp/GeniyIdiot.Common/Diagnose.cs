using System;
using System.Collections.Generic;



namespace GeniyIdiot.Common
{
    public class Diagnose
    {
        public string Name;

        public Diagnose(string text)
        {
            Name = text;
        }

        public static Diagnose CalculateDiagnose(User user, int countQuestions)
        {
            var percentRightAnswers = user.RightAnswers * 100.0 / countQuestions;
            var result = Convert.ToInt32(percentRightAnswers / 20);
            return GetDiagnoses()[result];
        }

        public static List<Diagnose> GetDiagnoses()
        {
            var diagnoses = new List<Diagnose>
            {
                new Diagnose("Идиот"),
                new Diagnose("Кретин"),
                new Diagnose("Дурак"),
                new Diagnose("Нормальный"),
                new Diagnose("Талант"),
                new Diagnose("Гений")
            };
            return diagnoses;
        }
    }
}
