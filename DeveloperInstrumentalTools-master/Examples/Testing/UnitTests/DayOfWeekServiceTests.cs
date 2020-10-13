using System;
using FluentAssertions;
using NUnit.Framework;
using UnitTestsTarget;

namespace UnitTests
{
    class DayOfWeekServiceTests
    {
        [Test]
        public void GetWeekend()
        {
            // Arrange
            var thisSunday = new DateTime(2020, 10, 04);

            var service = new DayOfWeekService();

            // Act
            var result = service.IsWeekend(thisSunday);

            // Assert
            result.Should().Be(true);
        }
        [Test]
        public void GetNotWeekend()
        {
            // Arrange
            var thisSunday = new DateTime(2020, 10, 05);

            var service = new DayOfWeekService();

            // Act
            var result = service.IsWeekend(thisSunday);

            // Assert
            result.Should().Be(false);
        }
    }
}
