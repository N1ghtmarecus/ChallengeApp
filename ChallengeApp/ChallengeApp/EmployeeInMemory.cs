namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private readonly List<float> grades = new();
        public EmployeeInMemory(string name, string surname, int age, char gender) 
            : base(name, surname, age, gender)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                Console.WriteLine($"Succesfull added grade: {grade:N2}");
            }

            else if (grade < 0)
                throw new Exception("Your grade is too low! Please enter the grade from 0 to 100.");
            else
                throw new Exception("Your grade is too high! Please enter the grade from 0 to 100.");
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
                this.AddGrade(result);

            else if (char.TryParse(grade, out char cResult))
                this.AddGrade(cResult);

            else
                throw new Exception("String is not float!");
        }

        public override void AddGrade(char grade)
        {
            switch (char.ToUpper(grade))
            {
                case 'A':
                    this.AddGrade(100);
                    break;
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'C':
                    this.AddGrade(60);
                    break;
                case 'D':
                    this.AddGrade(40);
                    break;
                case 'E':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter!");
            }
        }

        public override void AddGrade(int grade)
        {
            float gradeAsInt = grade;
            this.AddGrade(gradeAsInt);
        }

        public override void AddGrade(double grade)
        {
            float gradeAsDouble = (float)grade;
            this.AddGrade(gradeAsDouble);
        }

        public override void AddGrade(long grade)
        {
            float gradeAsLong = (float)grade;
            this.AddGrade(gradeAsLong);
        }

        public override Statistics GetStatistics()
        {
                        var statistics = new Statistics();
            statistics.Total = this.grades.Count;
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;

            }
            return statistics;
        }
    }
}
