using Cycling.Web.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycling.App.Tests.DataProviders.Tests.RemoveCyclistTests
{
    [TestFixture]
   public class RemoveMethodsTests
    {
        [Test]
        public void RemoveMethod_WhenPassedValuesAreValid_ShouldCallCorrectly()
        {
            // Arrange
            var removeCyclistMock = new Mock<IRemoveCyclist>();

            // Act
            removeCyclistMock.Object.Remove();
            removeCyclistMock.Object.Remove();

            // Assert
            removeCyclistMock.Verify(x => x.Remove(), Times.Exactly(2));
        }
    }
}
