﻿using Cryptid.Domain.Enums;

namespace Cryptid.Domain.PlayerRules
{
    public static class DeltaRules
    {
        public static Dictionary<int, Rule> Get() => new()
        {
            { 1, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Swamp, IconTwo = RuleIcon.Mountain } },
            { 2, new Rule { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.BearTerritory } },
            { 3, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.CougarTerritory } },
            { 4, new Rule { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Mountain } },
            { 5, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Mountain } },
            { 6, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlackStandingStone, IconTwo = RuleIcon.BlackAbandonedShack } },
            { 7, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Desert } },
            { 8, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Water } },
            { 9, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.BearTerritory } },
            { 10, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Water } },
            { 11, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Water } },
            { 12, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Swamp } },
            { 13, new Rule { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.BearTerritory } },
            { 14, new Rule { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Swamp } },
            { 15, new Rule { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.GreenStandingStone, IconTwo = RuleIcon.GreenAbandonedShack } },
            { 16, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.StandingStone } },
            { 17, new Rule { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.AbandonedShack } },
            { 18, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.StandingStone } },
            { 19, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Mountain } },
            { 20, new Rule { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Water } },
            { 21, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Desert } },
            { 22, new Rule { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlackStandingStone, IconTwo = RuleIcon.BlackAbandonedShack } },
            { 23, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Mountain } },
            { 24, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Mountain } },
            { 25, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Swamp, IconTwo = RuleIcon.Mountain } },
            { 26, new Rule { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Desert } },
            { 27, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Swamp } },
            { 28, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Desert } },
            { 29, new Rule { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlackStandingStone, IconTwo = RuleIcon.BlackAbandonedShack } },
            { 30, new Rule { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Forest } },
            { 31, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Swamp, IconTwo = RuleIcon.Mountain } },
            { 32, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlueStandingStone, IconTwo = RuleIcon.BlueAbandonedShack } },
            { 33, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Water } },
            { 34, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Mountain } },
            { 35, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Swamp } },
            { 36, new Rule { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.WhiteStandingStone, IconTwo = RuleIcon.WhiteAbandonedShack } },
            { 37, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Mountain } },
            { 38, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.AbandonedShack } },
            { 39, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Swamp } },
            { 40, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Swamp, IconTwo = RuleIcon.Mountain } },
            { 41, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Swamp } },
            { 42, new Rule { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Swamp } },
            { 43, new Rule { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlueStandingStone, IconTwo = RuleIcon.BlueAbandonedShack } },
            { 44, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Mountain } },
            { 45, new Rule { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.StandingStone } },
            { 46, new Rule { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Desert } },
            { 47, new Rule { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Mountain } },
            { 48, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.WhiteStandingStone, IconTwo = RuleIcon.WhiteAbandonedShack } },
            { 49, new Rule { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.StandingStone } },
            { 50, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Water } },
            { 51, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Swamp } },
            { 52, new Rule { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.AbandonedShack } },
            { 53, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Mountain } },
            { 54, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Mountain } },
            { 55, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlueStandingStone, IconTwo = RuleIcon.BlueAbandonedShack } },
            { 56, new Rule { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.WhiteStandingStone, IconTwo = RuleIcon.WhiteAbandonedShack } },
            { 57, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Swamp } },
            { 58, new Rule { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.AnimalTerritory } },
            { 59, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Swamp } },
            { 60, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Swamp } },
            { 61, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Water } },
            { 62, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.AnimalTerritory } },
            { 63, new Rule { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.CougarTerritory } },
            { 64, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.BearTerritory } },
            { 65, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Water } },
            { 66, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlackStandingStone, IconTwo = RuleIcon.BlackAbandonedShack } },
            { 67, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Desert } },
            { 68, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.AbandonedShack } },
            { 69, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Swamp } },
            { 70, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.GreenStandingStone, IconTwo = RuleIcon.GreenAbandonedShack } },
            { 71, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Swamp } },
            { 72, new Rule { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.CougarTerritory } },
            { 73, new Rule { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlueStandingStone, IconTwo = RuleIcon.BlueAbandonedShack } },
            { 74, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Mountain } },
            { 75, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Mountain } },
            { 76, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Water } },
            { 77, new Rule { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Forest } },
            { 78, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Water } },
            { 79, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Forest } },
            { 80, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Desert } },
            { 81, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Mountain } },
            { 82, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.AnimalTerritory } },
            { 83, new Rule { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.AnimalTerritory } },
            { 84, new Rule { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Water } },
            { 85, new Rule { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.GreenStandingStone, IconTwo = RuleIcon.GreenAbandonedShack } },
            { 86, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Water } },
            { 87, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Swamp } },
            { 88, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Mountain } },
            { 89, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.GreenStandingStone, IconTwo = RuleIcon.GreenAbandonedShack } },
            { 90, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.WhiteStandingStone, IconTwo = RuleIcon.WhiteAbandonedShack } },
            { 91, new Rule { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Desert } },
            { 92, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Forest } },
            { 93, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Mountain } },
            { 94, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Swamp } },
            { 95, new Rule { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.CougarTerritory } },
            { 96, new Rule { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Swamp } },
        };
    }
}