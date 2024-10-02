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

        private Rule? SelectedRule => IsInRange ? PlayerRules[GameToCreate.RuleNumber!.Value] : null;

        private bool IsInRange => GameToCreate.RuleNumber is >= 1 and <= 96;

        private class Game
        {
            public int? RuleNumber { get; set; }
        }
    }
}
