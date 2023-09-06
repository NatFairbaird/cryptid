namespace Cryptid.Domain.Enums
{
    public enum RuleIcon
    {
        Forest,
        Desert,
        Water,
        Swamp,
        Mountain,
        AnimalTerritory,
        StandingStone,
        AbandonedShack,
        CougarTerritory,
        BearTerritory,
        BlueStandingStone,
        BlueAbandonedShack,
        WhiteStandingStone,
        WhiteAbandonedShack,
        GreenStandingStone,
        GreenAbandonedShack,
        BlackStandingStone,
        BlackAbandonedShack
    }

    public static class RuleIconExtensions
    {
        public static string ToFancyString(this RuleIcon icon) => icon switch
        {
            RuleIcon.Forest or RuleIcon.Desert or RuleIcon.Water or RuleIcon.Swamp or RuleIcon.Mountain => icon.ToString().ToLower(),
            RuleIcon.AnimalTerritory => "either animal territory",
            RuleIcon.StandingStone => "a standing stone",
            RuleIcon.AbandonedShack => "an abandoned shack",
            RuleIcon.CougarTerritory or RuleIcon.BearTerritory => $"{icon.GetFirstWordToLower()} territory",
            _ => $"a {icon.GetFirstWordToLower()} structure"
        };

        public static string GetFirstWordToLower(this RuleIcon icon)
        {
            var iconAsString = icon.ToString();
            var iconMinusFirstLetter = iconAsString.Skip(1).ToList();
            var secondWordInitial = iconMinusFirstLetter.First(character => char.IsUpper(character));
            var secondWordIndex = iconMinusFirstLetter.IndexOf(secondWordInitial) + 1;
            return iconAsString.Substring(0, secondWordIndex).ToLower();
        }
    }
}
