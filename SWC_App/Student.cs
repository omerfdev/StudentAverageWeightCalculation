using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC_App
{
    internal class Student
    {

        public string Name { get; set; }
        public int Weight { get; }
        public string Gender { get; }

        public Student(string name, int weight, string gender)
        {
            Name = name;
            Weight = weight;
            Gender = gender;
        }

        public class WeightCalculator
        {
            public static double CalculateAverageWeight(List<Student> students, string gender)
            {
                double totalWeight = 0;
                int count = 0;

                foreach (Student student in students)
                {
                    if (student.Gender == gender)
                    {
                        totalWeight += student.Weight;
                        count++;
                    }
                }

                return count > 0 ? totalWeight / count : 0;
            }
        }
    }
}
