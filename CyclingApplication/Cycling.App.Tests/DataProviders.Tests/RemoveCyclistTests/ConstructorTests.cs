using Cycling.Web.DataProviders;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycling.App.Tests.DataProviders.Tests.RemoveCyclistTests
{
    [TestFixture]
    public class ConstructorTests
    {
        [Test]
        public void Constructor_WhenPassedValuesAreValid_ShouldSetFirstAndLastNameCorrectly()
        {
            // Arrange
            var removeCyclist = new RemoveCyclist("Dragan", "Draganov");

            // Act & Assert
            StringAssert.Contains("Dragan", removeCyclist.FirstName);
            StringAssert.Contains("Draganov", removeCyclist.LastName);
        }
    }
}