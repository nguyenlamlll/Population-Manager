using MediatorBase;
using DataLayer.Model;
using System;
using Xunit;
using Moq;
using System.Threading.Tasks;
using Mediator;
using DataLayer.AbstractService;

namespace MediatorTestPattern.NationalServiceTests
{
    public class UnitTests
    {
        [Fact]
        public async Task IsInNationalServiceAgeRange_AgeLessThanMinAge_False()
        {
            // Setup the variables.
            int minAge = 17, maxAge = 27;
            // This person's age is less then minAge
            Resident resident = new Resident()
            {
                DateOfBirth = new DateTime(DateTime.Now.Year - minAge + 1, 12, 31) 
            };

            // Arrange the test.
            var mockup = new Mock<IResidentDBService>();
            mockup.Setup(method => method.GetAge(It.IsAny<long>()))
                .ReturnsAsync(() => minAge - 5);

            IResidentDBService residentDBService = mockup.Object;
            INationalService mediator = new NationalServiceMediator(residentDBService);

            //// Act
            var result = await mediator.IsInNationalServiceAgeRange(resident, minAge, maxAge);

            // Assert
            Assert.IsType<bool>(result);
            Assert.False((bool)result);

        }
    }

}
