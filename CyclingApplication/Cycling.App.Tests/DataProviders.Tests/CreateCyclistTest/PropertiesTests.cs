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
    public class PropertiesTests
    {
        [Test]
        public void PropertyFirstName_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var createCyclist = new CreateCyclist("Dragan", "Draganov", 13, 0, 1, 2, "Segafredo");

            // Act & Assert
            StringAssert.Contains("Dragan", createCyclist.FirstName);
        }

        [Test]
        public void PropertyFirstName_WhenPassedValueIsLongerThanMaxLengthAllowed_ShouldThrowIndexOutOfRangeException()
        {
            // Arrange
            var invalidFirstName = "this name is way to long, so it is not goinig to be a valid name and a exception should be trown!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => new CreateCyclist(invalidFirstName, "Draganov", 13, 0, 1, 2, "Segafredo"));
        }

        [TestCase("")]
        [TestCase(null)]
        public void PropertyFirstName_WhenPassedValueIsNullOrEmpty_ShouldThrowNullReferenceExceptionException(string invalidFirstName)
        {
            // Arrange& Act & Assert
            Assert.Throws<NullReferenceException>(() => new CreateCyclist(invalidFirstName, "Draganov", 13, 0, 1, 2, "Segafredo"));
        }
    }
}
