using Cryptid.Models.Enums;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace Cryptid.Components.Create
{
    public partial class SelectRule
    {
        [Parameter]
        public Player Player { get; set; }

        private Game GameToCreate { get; set; } = new Game();


        public void HandleRuleNumberChanged(int ruleNumber)
        {
            Console.Out.WriteLine(ruleNumber);
        }

        private class Game
        {
            [Required, Range(1, 96, ErrorMessage = "Rule Number must be between 1 and 96")]
            public int RuleNumber { get; set; }
        }
    }
}
