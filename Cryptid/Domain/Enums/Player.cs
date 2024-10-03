using Cryptid.Domain.PlayerRules;
using System.Globalization;

namespace Cryptid.Domain.Enums
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

        public static Dictionary<int, Rule> GetRules(this Player player) => player switch
        {
            Player.Alpha => AlphaRules.Get(),
            Player.Beta => BetaRules.Get(),
            Player.Gamma => GammaRules.Get(),
            Player.Delta => DeltaRules.Get(),
            Player.Epsilon => EpsilonRules.Get(),
            _ => throw new ArgumentOutOfRangeException(player.ToString())
        };
    }
}
