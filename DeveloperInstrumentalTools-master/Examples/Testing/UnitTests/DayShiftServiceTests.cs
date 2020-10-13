using System;
using FluentAssertions;
using NUnit.Framework;
using UnitTestsTarget;

namespace UnitTests
{
    class DayShiftServiceTests
    {
        [Test]
        public void GetTomorrow()
        {
            // Arrange
            var today = new DateTime(2020, 10, 06);
            var tomorrow = new DateTime(2020, 10, 07);

            var service = new DayShiftService(new DayOfWeekService());

            // Act
            var result = service.GetShiftBusinessDay(today, 1);

            // Assert
            result.Should().Be(tomorrow);
        }

        [Test]
        public void GetMonday()
        {
            // Arrange
            var friday = new DateTime(2020, 10, 09);
            var monday = new DateTime(2020, 10, 12);

            var service = new DayShiftService(new DayOfWeekService());

            // Act
            var result = service.GetShiftBusinessDay(friday, 1);

            // Assert
            result.Should().Be(monday);
        }
    }
}
