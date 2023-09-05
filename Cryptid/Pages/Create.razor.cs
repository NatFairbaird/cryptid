using Cryptid.Models.Enums;

namespace Cryptid.Pages
{
    public partial class Create
    {
        public const string Path = "create";

        private CreateState State { get; set; }

        private Player Player { get; set; }

        public Create()
        {
            State = CreateState.SelectDifficulty;
        }

        private void SubmitDifficulty(Difficulty difficulty, Player player, List<Player> otherPlayers)
        {
            Player = player;
            State = CreateState.SelectRule;
            StateHasChanged();
        }

        private enum CreateState
        {
            Default,
            SelectDifficulty,
            SelectRule
        }
    }
}
