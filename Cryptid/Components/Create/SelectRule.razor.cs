using Cryptid.Domain;
using Cryptid.Domain.Enums;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace Cryptid.Components.Create
{
    public partial class SelectRule
    {
        [Parameter]
        public Player Player { get; set; }

        private Game GameToCreate { get; set; } = new Game();

        private Dictionary<int, Rule> PlayerRules => Player.GetRules();

        private Rule SelectedRule => PlayerRules[GameToCreate.RuleNumber];

        private class Game
        {
            [Required, Range(1, 96, ErrorMessage = "Rule Number must be between 1 and 96")]
            public int RuleNumber { get; set; }
        }
    }
}
