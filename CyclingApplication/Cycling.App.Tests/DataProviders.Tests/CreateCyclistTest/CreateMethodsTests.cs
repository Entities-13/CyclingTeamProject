using Cycling.Models.MSSQL;
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
            createCyclistMock.Object.CreateOne("Ivan", "Ivanov", 22, 1, 1, 1, "Segafredo");
            createCyclistMock.Object.CreateOne("Ivan", "Ivanov", 22, 1, 1, 1, "Segafredo");

            // Assert
            createCyclistMock.Verify(x => x.CreateOne("Ivan", "Ivanov", 22, 1, 1, 1, "Segafredo"), Times.Exactly(2));
        }

        [Test]
        public void CreateManyMethod_WhenPassedValuesAreValid_ShouldCallCorrectly()
        {
            // Arrange
            var createCyclistMock = new Mock<ICreateCyclist>();
            var cyclist = new Cyclist()
            {
                FirstName = "Ivan",
                LastName = "Ivanov",
                Age=22,
                TourDeFranceWins=1,
                GiroDItaliaWins=1,
                VueltaEspanaWins=1,
                CurrentTeam="Segafredo"
            };

            var listOfCyclists = new List<Cyclist>() { cyclist };

            // Act
            createCyclistMock.Object.CreateMany(listOfCyclists);
            createCyclistMock.Object.CreateMany(listOfCyclists);

            // Assert
            createCyclistMock.Verify(x => x.CreateMany(listOfCyclists), Times.Exactly(2));
        }
    }
}
