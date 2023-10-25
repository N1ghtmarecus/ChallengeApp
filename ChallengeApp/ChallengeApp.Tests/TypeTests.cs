namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenComparedTwoIntNumber_ShouldBeNotEqual()
        {
            // arrange
            int number1 = 1;
            int number2 = 2;
            // act
            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenComparedTwoDoubleNumber_ShouldBeEqual()
        {
            // arrange
            double number1 = 3.14;
            double number2 = 3.14;
            // act
            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenComparedTwoStrings_ShouldBeTheSame()
        {
            // arrange
            string name1 = "Katarzyna";
            string name2 = "Katarzyna";
            // act
            // assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void WhenComparedTwoObjects_ShouldNotBeTheSame()
        {
            // arrange
            var employee1 = GetEmployee("Aleksandra", "Kowalska", 23);
            var employee2 = GetEmployee("Aleksandra", "Kowalska", 23);
            // act
            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age, 'F');
        }
    }
}
