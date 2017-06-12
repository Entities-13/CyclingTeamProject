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
        public void PropertyFirstName_WhenPassedValueIsLongerThan40Chars_ShouldThrowIndexOutOfRangeException()
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

        [Test]
        public void PropertyLastName_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var createCyclist = new CreateCyclist("Dragan", "Draganov", 13, 0, 1, 2, "Segafredo");

            // Act & Assert
            StringAssert.Contains("Dragan", createCyclist.FirstName);
        }

        [Test]
        public void PropertyLastName_WhenPassedValueIsLongerThan40Chars_ShouldThrowIndexOutOfRangeException()
        {
            // Arrange
            var invalidLastName = "this name is way to long, so it is not goinig to be a valid name and a exception should be trown!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => new CreateCyclist("Dragan", invalidLastName, 13, 0, 1, 2, "Segafredo"));
        }

        [TestCase("")]
        [TestCase(null)]
        public void PropertyLastName_WhenPassedValueIsNullOrEmpty_ShouldThrowNullReferenceExceptionException(string invalidLastName)
        {
            // Arrange& Act & Assert
            Assert.Throws<NullReferenceException>(() => new CreateCyclist("Dragan", invalidLastName, 13, 0, 1, 2, "Segafredo"));
        }

        [Test]
        public void PropertyAge_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var createCyclist = new CreateCyclist("Dragan", "Draganov", 30, 0, 1, 2, "Segafredo");

            // Act & Assert
            Assert.AreEqual(30, createCyclist.Age);
        }

        [Test]
        public void PropertyTourDeFranceWins_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var createCyclist = new CreateCyclist("Dragan", "Draganov", 30, 3, 0, 0, "Segafredo");

            // Act & Assert
            Assert.AreEqual(3, createCyclist.TourDeFranceWins);
        }

        [Test]
        public void PropertyGiroDItaliaWins_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var createCyclist = new CreateCyclist("Dragan", "Draganov", 30, 0, 3, 0, "Segafredo");

            // Act & Assert
            Assert.AreEqual(3, createCyclist.GiroDItaliaWins);
        }

        [Test]
        public void PropertyVueltaWins_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var createCyclist = new CreateCyclist("Dragan", "Draganov", 30, 0, 0, 3, "Segafredo");

            // Act & Assert
            Assert.AreEqual(3, createCyclist.VueltaWins);
        }

        [Test]
        public void PropertyCurrentTeam_WhenPassedValueIsValid_ShouldSetCorrectly()
        {
            // Arrange
            var createCyclist = new CreateCyclist("Dragan", "Draganov", 30, 0, 0, 3, "Segafredo");

            // Act & Assert
            StringAssert.Contains("Segafredo", createCyclist.CurrentTeam);
        }

        [Test]
        public void PropertyCurrentTeam_WhenPassedValueIsLongerThan40Chars_ShouldThrowIndexOutOfRangeException()
        {
            // Arrange
            var invalidCurrentTeam = "this name is way to long, so it is not goinig to be a valid name and a exception should be trown!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => new CreateCyclist("Dragan", "Draganov", 13, 0, 1, 2, invalidCurrentTeam));
        }

        [TestCase("")]
        [TestCase(null)]
        public void PropertyCurrentTeam_WhenPassedValueIsNullOrEmpty_ShouldThrowNullReferenceExceptionException(string invalidCurrentTeam)
        {
            // Arrange& Act & Assert
            Assert.Throws<NullReferenceException>(() => new CreateCyclist("Dragan", "Draganov", 13, 0, 1, 2, invalidCurrentTeam));
        }
    }
}
