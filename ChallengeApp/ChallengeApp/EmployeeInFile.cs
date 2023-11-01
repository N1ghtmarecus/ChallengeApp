namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase

    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname, int age, char gender)
            : base(name, surname, age, gender)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);

                    if (GradeAdded != null)
                        GradeAdded(this, new EventArgs());
                }
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
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Total = grades.Count;
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= grades.Count;

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
