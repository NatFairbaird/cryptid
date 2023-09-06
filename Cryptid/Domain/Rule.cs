using Cryptid.Domain.Enums;

namespace Cryptid.Domain
{
    public record Rule
    {
        public bool IsInverse { get; set; }

        public RuleGroup RuleGroup { get; set; }

        public RuleIcon IconOne { get; set; }

        public RuleIcon? IconTwo { get; set; }

        public string Text => $"The habitat is {(IsInverse ? "not " : "")}{RuleGroupToText}.";

        private string RuleGroupToText => RuleGroup switch
        {
            RuleGroup.OneOfTwo => $"on {IconOne.ToFancyString()} or {IconTwo!.Value.ToFancyString()}",
            RuleGroup.WithinOneSpace => $"within one space of {IconOne.ToFancyString()}",
            RuleGroup.WithinTwoSpaces => $"within two spaces of {IconOne.ToFancyString()}",
            RuleGroup.WithinThreeSpaces => $"within three spaces of {IconOne.ToFancyString()}",
            _ => throw new ArgumentOutOfRangeException(RuleGroup.ToString())
        };
    }
}
