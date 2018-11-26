using System.Linq;

using FluentAssertions;
using FluentAssertions.Common;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KorDevAus.Entities.Tests
{
    [TestClass]
    public class RsvpStatusTypeTests
    {
        [TestMethod]
        public void Given_RsvpStatusType_Should_BePublic()
        {
            typeof(RsvpStatusType)
                .Should().HaveAccessModifier(CSharpAccessModifier.Public)
                    .And.Should().NotBeAbstract()
                .And.Subject.Should().BeDerivedFrom<EnumType>();
        }

        [TestMethod]
        public void Given_RsvpStatusType_Should_NotHaveDefaultConstructor()
        {
            typeof(RsvpStatusType)
                .Should().NotHaveDefaultConstructor()
                    .And.HaveConstructor(new[] { typeof(string), typeof(int) });
        }

        [TestMethod]
        public void Given_RsvpStatusType_When_GetAll_Should_ReturnAllEnums()
        {
            var enums = EnumType.GetAll<RsvpStatusType>().ToList();

            enums.Should().HaveCount(3)
                 .And.Contain(RsvpStatusType.Going)
                 .And.Contain(RsvpStatusType.NotSure)
                 .And.Contain(RsvpStatusType.NotGoing);
        }

        [TestMethod]
        public void Given_RsvpStatusType_When_GetNames_Should_ReturnAllNames()
        {
            var names = EnumType.GetNames<RsvpStatusType>().ToList();

            names.Should().HaveCount(3)
                 .And.Contain(RsvpStatusType.Going)
                 .And.Contain(RsvpStatusType.NotSure)
                 .And.Contain(RsvpStatusType.NotGoing);
        }

        [TestMethod]
        public void Given_RsvpStatusType_When_GetValues_Should_ReturnAllValues()
        {
            var values = EnumType.GetValues<RsvpStatusType>().ToList();

            values.Should().HaveCount(3)
                  .And.Contain(RsvpStatusType.Going)
                  .And.Contain(RsvpStatusType.NotSure)
                  .And.Contain(RsvpStatusType.NotGoing);
        }
    }
}