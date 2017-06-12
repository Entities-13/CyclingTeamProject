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
    public class PropertiesTests
    {
        [Test]
        public void PropertyFirstName_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var removeCyclist = new RemoveCyclist("Dragan", "Draganov");

            // Act & Assert
            StringAssert.Contains("Dragan", removeCyclist.FirstName);
        }

        [Test]
        public void PropertyFirstName_WhenPassedValueIsLongerThan40Chars_ShouldThrowIndexOutOfRangeException()
        {
            // Arrange
            var invalidFirstName = "this name is way to long, so it is not goinig to be a valid name and a exception should be trown!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => new RemoveCyclist(invalidFirstName, "Draganov"));
        }

        [TestCase("")]
        [TestCase(null)]
        public void PropertyFirstName_WhenPassedValueIsNullOrEmpty_ShouldThrowNullReferenceExceptionException(string invalidFirstName)
        {
            // Arrange& Act & Assert
            Assert.Throws<NullReferenceException>(() => new RemoveCyclist(invalidFirstName, "Draganov"));
        }

        [Test]
        public void PropertyLastName_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var removeCyclist = new RemoveCyclist("Dragan", "Draganov");

            // Act & Assert
            StringAssert.Contains("Draganov", removeCyclist.LastName);
        }

        [Test]
        public void PropertyLastName_WhenPassedValueIsLongerThan40Chars_ShouldThrowIndexOutOfRangeException()
        {
            // Arrange
            var invalidLastName = "this name is way to long, so it is not goinig to be a valid name and a exception should be trown!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => new RemoveCyclist("Dragan", invalidLastName));
        }

        [TestCase("")]
        [TestCase(null)]
        public void PropertyLasyName_WhenPassedValueIsNullOrEmpty_ShouldThrowNullReferenceExceptionException(string invalidLastName)
        {
            // Arrange& Act & Assert
            Assert.Throws<NullReferenceException>(() => new RemoveCyclist("Dragan", invalidLastName));
        }
    }
}