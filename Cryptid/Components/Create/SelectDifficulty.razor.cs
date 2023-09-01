using Cryptid.Models.Enums;
using Microsoft.AspNetCore.Components;

namespace Cryptid.Components.Create
{
    public partial class SelectDifficulty
    {
        [Parameter]
        public Action<Difficulty, Player, List<Player>> Submit { get; set; }

        private List<SelectItem> Difficulties = new()
        {
            new() { Text = Difficulty.Normal.ToString(), Selected = true },
            new() { Text = Difficulty.Advanced.ToString(), Selected = false }
        };

        private List<SelectItem> PlayerOptions = new()
        {
            new() { Text = Player.Alpha.ToHtmlString(), Selected = false },
            new() { Text = Player.Beta.ToHtmlString(), Selected = false },
            new() { Text = Player.Gamma.ToHtmlString(), Selected = false },
            new() { Text = Player.Delta.ToHtmlString(), Selected = false },
            new() { Text = Player.Epsilon.ToHtmlString(), Selected = false }
        };

        private List<SelectItem> OtherPlayerOptions = new()
        {
            new() { Text = Player.Alpha.ToHtmlString(), Selected = false, Disabled = true },
            new() { Text = Player.Beta.ToHtmlString(), Selected = false, Disabled = true },
            new() { Text = Player.Gamma.ToHtmlString(), Selected = false, Disabled = true },
            new() { Text = Player.Delta.ToHtmlString(), Selected = false, Disabled = true },
            new() { Text = Player.Epsilon.ToHtmlString(), Selected = false, Disabled = true }
        };

        private bool ValidForm =>
            PlayerOptions.Any(player => player.Selected) &&
            OtherPlayerOptions.Count(player => player.Selected) >= 2;

        private void HandleDifficultyClick(string selectedDifficulty)
        {
            var selected = Difficulties.Where(difficulty => difficulty.Text == selectedDifficulty);
            selected.Single().Selected = true;

            Difficulties.Except(selected).Single().Selected = false;
        }

        private void HandlePlayerClick(string selectedPlayer)
        {
            var selected = PlayerOptions.Where(player => player.Text == selectedPlayer);
            selected.Single().Selected = true;

            foreach(var unselectedPlayer in PlayerOptions.Except(selected))
                unselectedPlayer.Selected = false;

            EnableOtherPlayerOptionsExcept(selectedPlayer);
        }

        private void HandleOtherPlayerClick(string selectedPlayer)
        {
            var selected = OtherPlayerOptions.Single(player => player.Text == selectedPlayer);
            if(selected.Disabled)
                return;

            selected.Selected = !selected.Selected;
        }

        private void HandleButtonClick()
        {
            if (!ValidForm)
                return;

            var selectedDifficulty = Enum.Parse<Difficulty>(Difficulties.Single(difficulty => difficulty.Selected).Text);
            var selectedPlayer = PlayerOptions.Single(player => player.Selected).Text.ToPlayer();
            var otherPlayers = OtherPlayerOptions.Where(player => player.Selected).Select(player => player.Text.ToPlayer()).ToList();

            Submit(selectedDifficulty, selectedPlayer, otherPlayers);
        }

        private void EnableOtherPlayerOptionsExcept(string selectedPlayer)
        {
            foreach(var otherPlayer in OtherPlayerOptions)
            {
                otherPlayer.Selected = false;
                otherPlayer.Disabled = otherPlayer.Text == selectedPlayer;
            }
        }

        public class SelectItem
        {
            public string Text { get; set; }

            public bool Selected { get; set; }

            public bool Disabled { get; set; }
        }
    }
}
