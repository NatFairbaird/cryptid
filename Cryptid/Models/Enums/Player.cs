using System.Globalization;

namespace Cryptid.Models.Enums
{
    public enum Player
    {
        Alpha,
        Beta,
        Gamma,
        Delta,
        Epsilon
    }

    public static class PlayerExtensions
    {
        public static string ToHtmlString(this Player player) => $"&{player.ToString().ToLower()};";

        public static Player ToPlayer(this string player)
        {
            var strippedPlayer = player.Replace("&", "").Replace(";", "");
            var info = CultureInfo.CurrentCulture.TextInfo;
            return Enum.Parse<Player>(info.ToTitleCase(strippedPlayer));
        }
    }
}
