namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetGradeA_ShouldBeAddedHundredPoints()
        {
            // arrange
            var employee = new Employee("Piotr", "Kleks", 41, 'M');
            employee.AddGrade('A');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.That(100, Is.EqualTo(statistics.Max));
        }

        [Test]
        public void WhenEmployeeGetGradesABCDE_ThenAverageLetterShouldBeB()
        {
            // arrange
            var employee = new Employee("Piotr", "Kleks", 41, 'M');
            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('C');
            employee.AddGrade('D');
            employee.AddGrade('E');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.That('B', Is.EqualTo(statistics.AverageLetter));
        }
    }
}