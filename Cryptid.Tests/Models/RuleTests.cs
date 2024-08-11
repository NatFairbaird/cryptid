using Cryptid.Domain;
using Cryptid.Domain.Enums;
using FluentAssertions;

namespace Cryptid.Tests.Models
{
    internal class RuleTests
    {
        [Test]
        [TestCase(false, RuleGroup.OneOfTwo, RuleIcon.Forest, RuleIcon.Desert, "The habitat is on forest or desert.")]
        [TestCase(false, RuleGroup.WithinOneSpace, RuleIcon.Swamp, null, "The habitat is within one space of swamp.")]
        [TestCase(false, RuleGroup.WithinTwoSpaces, RuleIcon.StandingStone, null, "The habitat is within two spaces of a standing stone.")]
        [TestCase(false, RuleGroup.WithinThreeSpaces, RuleIcon.BlueStandingStone, RuleIcon.BlueAbandonedShack, "The habitat is within three spaces of a blue structure.")]
        [TestCase(true, RuleGroup.OneOfTwo, RuleIcon.Water, RuleIcon.Mountain, "The habitat is not on water or mountain.")]
        [TestCase(true, RuleGroup.WithinOneSpace, RuleIcon.AnimalTerritory, null, "The habitat is not within one space of either animal territory.")]
        [TestCase(true, RuleGroup.WithinTwoSpaces, RuleIcon.CougarTerritory, null, "The habitat is not within two spaces of cougar territory.")]
        [TestCase(true, RuleGroup.WithinThreeSpaces, RuleIcon.WhiteStandingStone, RuleIcon.WhiteAbandonedShack, "The habitat is not within three spaces of a white structure.")]
        public void Text(bool isInverse, RuleGroup ruleGroup, RuleIcon iconOne, RuleIcon? iconTwo, string expectedText)
        {
            var uut = new Rule
            {
                IsInverse = isInverse,
                RuleGroup = ruleGroup,
                IconOne = iconOne,
                IconTwo = iconTwo
            };

            uut.Text.Should().Be(expectedText);
        }
    }
}
