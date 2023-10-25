namespace ChallengeApp
{
    public class Employee : Person
    {
        private readonly List<float> grades = new();
        public Employee(string name, string surname, int age, char gender)
            : base (name, surname, age, gender)
        {
        }

        public void AddGrade(float grade)
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

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
                this.AddGrade(result);

            else if (char.TryParse(grade, out char cResult))
                this.AddGrade(cResult);

            else
                throw new Exception("String is not float!");
        }

        public void AddGrade(char grade)
        {
            switch(grade) 
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter!");
            }
        }

        public void AddGrade(int grade)
        {
            float gradeAsInt = grade;
            this.AddGrade(gradeAsInt);
        }

        public void AddGrade(double grade)
        {
            float gradeAsDouble = (float)grade;
            this.AddGrade(gradeAsDouble);
        }

        public void AddGrade(long grade)
        {
            float gradeAsLong = (float)grade;
            this.AddGrade(gradeAsLong);
        }

        public Statistics GetStatistics()
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

            switch(statistics.Average)
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