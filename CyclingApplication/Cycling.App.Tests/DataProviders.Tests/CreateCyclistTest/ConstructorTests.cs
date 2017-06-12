using Cycling.Models.MSSQL;
using Cycling.Web.DataProviders;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycling.App.Tests.DataProviders.Tests.CreateCyclistTest
{
    [TestFixture]
    public class ConstructorTests
    {
        [Test]
        public void Constructor_WhenPassedValuesAreValid_ShouldInstantiateCorrectly()
        {
            // Arrange
            var createCyclist = new CreateCyclist("Dragan", "Draganov", 13, 0, 1, 2, "Segafredo");

            // Act & Assert
            Assert.IsInstanceOf<CreateCyclist>(createCyclist);
        }

        [Test]
        public void Constructor_WhenPassedValuesInACollectionAndValid_ShouldInstantiateCorrectly()
        {
            // Arrange"Dragan"
            var cyclist = new Cyclist()
            {
                FirstName = "Dragan",
                LastName = "Draganov",
                Age = 13,
                TourDeFranceWins = 2,
                GiroDItaliaWins = 1,
                VueltaEspanaWins = 1,
                CurrentTeam = "segafredo"
            };

            var collection = new List<Cyclist>() { cyclist};

            // Act 
            var createCyclist = new CreateCyclist(collection);

            // Assert
            Assert.IsInstanceOf<CreateCyclist>(createCyclist);
        }
    }
}
