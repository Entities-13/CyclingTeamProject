using Cycling.Web.Contracts;
using Cycling.Web.DataProviders;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycling.App.Tests.DataProviders.Tests.CreateCyclistTest
{
    [TestFixture]
    public class CreateMethodsTests
    {
        [Test]
        public void CreateOneMethod_WhenPassedValuesAreValid_ShouldCallCorrectly()
        {
            // Arrange
            var createCyclistMock = new Mock<ICreateCyclist>();

            // Act
            createCyclistMock.Object.CreateOne();
            createCyclistMock.Object.CreateOne();

            // Assert
            createCyclistMock.Verify(x => x.CreateOne(), Times.Exactly(2));
        }

        [Test]
        public void CreateManyMethod_WhenPassedValuesAreValid_ShouldCallCorrectly()
        {
            // Arrange
            var createCyclistMock = new Mock<ICreateCyclist>();

            // Act
            createCyclistMock.Object.CreateMany();
            createCyclistMock.Object.CreateMany();
            
            // Assert
            createCyclistMock.Verify(x => x.CreateMany(), Times.Exactly(2));
        }
    }
}
