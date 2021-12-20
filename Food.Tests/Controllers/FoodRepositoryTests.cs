using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Food.Controllers;
using Food.Models;
using Food.Models.Repository;
using NUnit.Framework;

namespace Food.Tests.Controllers
{

    public class A
    {
        public void walk()
        {
            
        }

    }

    public class B:A
    {
        public void run()
        {

        }
    }

    public class C : B
    {
        
    }

    public class D
    {
        public D()
        {
            C c = new C();
            c.walk();
        }
    }

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
        //[Ignore("Just learning it!")]
        public void addPositiveNumbers_PassNegative_ThrowERROR()
        {

            //Act
            var result = this._foodRepository.addPositiveUnmbers(-1, -2);

            //Assert
            Assert.That(result, Is.EqualTo(typeof(System.Exception)));

        }

        [Test]
        public void GetFood_WhenIsBiggerThanZero_ReturnFood()
        {
            var result = _foodRepository.GetFood(1);

            //Assert

            Assert.That(result, Is.InstanceOf<FoodModel>());

        }

        [Test]
            public void GetFood_WhenIDisLessThanZero_ThrowsException()
            {
              

                Assert.That(()=> _foodRepository.GetFood(-1), Throws.Exception);
            }

            [Test]
            public void GetFood_WhenIdIsBiggerThanZero_ReturnsFoodModel()
            {
                Assert.That(()=>_foodRepository.GetFood(1), Is.InstanceOf<FoodModel>());
            }


           
        }
}
