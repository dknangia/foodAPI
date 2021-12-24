using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Food.Controllers;
using Food.Models;
using Food.Models.Repository;
using NUnit.Framework;

namespace Food.Tests.Controllers
{

    [TestFixture]
    class FoodRepositoryTests
    {
        private FoodRepository _foodRepository;

        [SetUp]
        public void SetUp()
        {
            this._foodRepository = new FoodRepository();
        }





        [Test]
        [Ignore("Just learning it!")]
        public void addPositiveNumbers_PassNegative_ThrowERROR()
        {

            //Act
            var result = this._foodRepository.AddPositiveNumbers(-1, -2);

            //Assert
            Assert.That(()=>_foodRepository.AddPositiveNumbers(-1, -2), Throws.Exception);

        }

        [Test]
        public void GetFood_WhenIsBiggerThanZero_ReturnFood()
        {
            //Arrange
            var result = _foodRepository.GetFood(1);

            //Assert

            Assert.That(result, Is.InstanceOf<FoodModel>());

        }

        [Test]
        public void GetFood_WhenIDisLessThanZero_ThrowsException()
        {
            Assert.That(() => _foodRepository.GetFood(-1), Throws.Exception);
        }

        [Test]
        public void GetFood_WhenIdIsBiggerThanZero_ReturnsFoodModel()
        {
            Assert.That(() => _foodRepository.GetFood(1), Is.InstanceOf<FoodModel>());
        }

        [Test]
        public void SaveFood_WhenArgumentIsNull_ThrowsNullArgumentException()
        {
            FoodModel foodModel = null;
            Assert.That(() => _foodRepository.SaveFood(foodModel), Throws.ArgumentNullException);
        }

        [Test]
        public void SaveFood_WhenPassedCorrectObject_SavedFoodModel()
        {
            FoodModel foodModel = new FoodModel() { Name = "Tacos", Price = 23.6d}; 
            Assert.That(_foodRepository.SaveFood(foodModel), Is.InstanceOf<FoodModel>());
        }


        [Test]
        public void GetOutput_WhenPassed3_Fizz()
        {
            Assert.That(_foodRepository.GetOutput(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_WhenPassed5_Buzz()
        {
            Assert.That(_foodRepository.GetOutput(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_WhenPassed15_FizzBuss()
        {
            Assert.That(_foodRepository.GetOutput(15), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        [TestCase(2)]
        [TestCase(-1)]
        public void GetOutput_WhenPassedNonFizzBuzzNumber_NumberToString(int number)
        {
            Assert.That(_foodRepository.GetOutput(number), Is.EqualTo(number.ToString()));
        }

    }
}
