namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetGrade_ThenCheckMinGrade()
        {
            // arrange
            var employee = new Employee("Piotr", "Kleks", 41);
            employee.AddGrade(56.23424f);
            employee.AddGrade(-15.345345f);
            employee.AddGrade(25.567567f);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(-15.345345f, statistics.Min);
        }

        [Test]
        public void WhenEmployeeGetGrade_ThenCheckMaxGrade()
        {
            // arrange
            var employee = new Employee("Piotr", "Kleks", 41);
            employee.AddGrade(56.23424f);
            employee.AddGrade(-15.345345f);
            employee.AddGrade(25.567567f);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(56.23424f, statistics.Max);
        }

        [Test]
        public void WhenEmployeeGetGrades_ThenCheckAverageOfTheseGrades()
        {
            // arrange
            var employee = new Employee("Piotr", "Kleks", 41);
            employee.AddGrade(56.23424f);
            employee.AddGrade(-15.345345f);
            employee.AddGrade(25.567567f);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(22.152154f, statistics.Average);
        }
    }
}