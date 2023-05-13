using static SWC_App.Student;

namespace SWC_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            bool addMoreStudents = true;

            while (addMoreStudents)
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                Console.Write("Enter student weight: ");
                int weight = int.Parse(Console.ReadLine());

                Console.Write("Enter student gender (Male/Female): ");
                string gender = Console.ReadLine();

                if (gender.ToLower() == "male")
                {
                    students.Add(new MenStudent(name, weight));
                }
                else if (gender.ToLower() == "female")
                {
                    students.Add(new GirlStudent(name, weight));
                }
                else
                {
                    Console.WriteLine("Invalid gender. Please try again.");
                    continue;
                }

                Console.Write("Do you want to add another student? (Y/N): ");
                string answer = Console.ReadLine();

                if (answer.ToLower() != "y")
                {
                    addMoreStudents = false;
                }
            }

            double girlAverageWeight = WeightCalculator.CalculateAverageWeight(students, "Female");
            Console.WriteLine("The average weight for girl students is: " + girlAverageWeight);

            double menAverageWeight = WeightCalculator.CalculateAverageWeight(students, "Male");
            Console.WriteLine("The average weight for men students is: " + menAverageWeight);

            Console.ReadKey();
        }
    }
}