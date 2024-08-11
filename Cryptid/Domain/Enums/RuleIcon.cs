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

        public static bool IsTerrain(this RuleIcon icon) =>
            icon is RuleIcon.Forest or RuleIcon.Desert or RuleIcon.Water or RuleIcon.Swamp or RuleIcon.Mountain;

        public static IconColor GetColour(this RuleIcon icon) => icon switch
        {
            RuleIcon.Forest => IconColor.Green,
            RuleIcon.Desert => IconColor.Yellow,
            RuleIcon.Water => IconColor.Blue,
            RuleIcon.Swamp => IconColor.Purple,
            RuleIcon.Mountain => IconColor.Grey,
            RuleIcon.BlueAbandonedShack or RuleIcon.BlueStandingStone => IconColor.Blue,
            RuleIcon.GreenAbandonedShack or RuleIcon.GreenStandingStone => IconColor.Green,
            RuleIcon.WhiteAbandonedShack or RuleIcon.WhiteStandingStone => IconColor.White,
            RuleIcon.BlackAbandonedShack or RuleIcon.BlackStandingStone => IconColor.Black,
            _ => IconColor.White
        };

        public static Border? GetBorder(this RuleIcon icon) => icon switch
        {
            RuleIcon.CougarTerritory => new(LineType.Solid, IconColor.Red),
            RuleIcon.BearTerritory => new(LineType.Dashed, IconColor.Black),
            RuleIcon.AnimalTerritory => RuleIcon.BearTerritory.GetBorder(),
            _ => null
        };

        public static string GetInitial(this RuleIcon icon) =>
            icon.IsTerrain() ? icon.ToString()[..1] : string.Empty;
    }
}
