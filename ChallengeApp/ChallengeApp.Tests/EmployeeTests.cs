namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetScore_ThenCheckCorrectResult()
        {
            // arrange
            var employee = new Employee("Piotr", "Kleks", 41);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(-15);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(-4, result);
        }
    }
}