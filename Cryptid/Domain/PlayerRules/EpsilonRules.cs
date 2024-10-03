﻿using Cryptid.Domain.Enums;

namespace Cryptid.Domain.PlayerRules
{
    public static class EpsilonRules
    {
        public static Dictionary<int, Rule> Get() => new()
        {
            { 1, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Swamp } },
            { 2, new() { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Forest } },
            { 3, new() { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.AnimalTerritory } },
            { 4, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Mountain } },
            { 5, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Swamp } },
            { 6, new() { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlueStandingStone, IconTwo = RuleIcon.BlueAbandonedShack } },
            { 7, new() { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlackStandingStone, IconTwo = RuleIcon.BlackAbandonedShack } },
            { 8, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Water } },
            { 9, new() { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.GreenStandingStone, IconTwo = RuleIcon.GreenAbandonedShack } },
            { 10, new() { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.AbandonedShack } },
            { 11, new() { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Desert } },
            { 12, new() { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.BearTerritory } },
            { 13, new() { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.AnimalTerritory } },
            { 14, new() { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Mountain } },
            { 15, new() { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.AnimalTerritory } },
            { 16, new() { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.WhiteStandingStone, IconTwo = RuleIcon.WhiteAbandonedShack } },
            { 17, new() { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Water } },
            { 18, new() { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Desert } },
            { 19, new() { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlackStandingStone, IconTwo = RuleIcon.BlackAbandonedShack } },
            { 20, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Desert } },
            { 21, new() { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.CougarTerritory } },
            { 22, new() { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Water } },
            { 23, new() { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.CougarTerritory } },
            { 24, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Swamp } },
            { 25, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Desert } },
            { 26, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Mountain } },
            { 27, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Water } },
            { 28, new() { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.GreenStandingStone, IconTwo = RuleIcon.GreenAbandonedShack } },
            { 29, new() { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Swamp } },
            { 30, new() { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.StandingStone } },
            { 31, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Swamp } },
            { 32, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Mountain } },
            { 33, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Swamp, IconTwo = RuleIcon.Mountain } },
            { 34, new() { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Mountain } },
            { 35, new() { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.CougarTerritory } },
            { 36, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Water } },
            { 37, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Water } },
            { 38, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Swamp, IconTwo = RuleIcon.Mountain } },
            { 39, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Swamp } },
            { 40, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Mountain } },
            { 41, new() { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlueStandingStone, IconTwo = RuleIcon.BlueAbandonedShack } },
            { 42, new() { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Forest } },
            { 43, new() { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.WhiteStandingStone, IconTwo = RuleIcon.WhiteAbandonedShack } },
            { 44, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Mountain } },
            { 45, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Mountain } },
            { 46, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Water } },
            { 47, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Swamp } },
            { 48, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Swamp } },
            { 49, new() { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Mountain } },
            { 50, new() { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlueStandingStone, IconTwo = RuleIcon.BlueAbandonedShack } },
            { 51, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Mountain } },
            { 52, new() { RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.WhiteStandingStone, IconTwo = RuleIcon.WhiteAbandonedShack } },
            { 53, new() { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Swamp } },
            { 54, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Swamp, IconTwo = RuleIcon.Mountain } },
            { 55, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Swamp } },
            { 56, new() { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.BearTerritory } },
            { 57, new() { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Swamp } },
            { 58, new() { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Water } },
            { 59, new() { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.AbandonedShack } },
            { 60, new() { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.StandingStone } },
            { 61, new() { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.AbandonedShack } },
            { 62, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Mountain } },
            { 63, new() { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.WhiteStandingStone, IconTwo = RuleIcon.WhiteAbandonedShack } },
            { 64, new() { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Water } },
            { 65, new() { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.GreenStandingStone, IconTwo = RuleIcon.GreenAbandonedShack } },
            { 66, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Swamp } },
            { 67, new() { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Desert } },
            { 68, new() { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Mountain } },
            { 69, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Swamp, IconTwo = RuleIcon.Mountain } },
            { 70, new() { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlackStandingStone, IconTwo = RuleIcon.BlackAbandonedShack } },
            { 71, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Water } },
            { 72, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Desert } },
            { 73, new() { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlackStandingStone, IconTwo = RuleIcon.BlackAbandonedShack } },
            { 74, new() { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.GreenStandingStone, IconTwo = RuleIcon.GreenAbandonedShack } },
            { 75, new() { IsInverse = true, RuleGroup = RuleGroup.WithinThreeSpaces, IconOne = RuleIcon.BlueStandingStone, IconTwo = RuleIcon.BlueAbandonedShack } },
            { 76, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Swamp } },
            { 77, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Swamp } },
            { 78, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Water } },
            { 79, new() { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Swamp } },
            { 80, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Mountain } },
            { 81, new() { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Forest } },
            { 82, new() { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.AbandonedShack } },
            { 83, new() { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.StandingStone } },
            { 84, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Mountain } },
            { 85, new() { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.CougarTerritory } },
            { 86, new() { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.BearTerritory } },
            { 87, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Desert } },
            { 88, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Mountain } },
            { 89, new() { RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.BearTerritory } },
            { 90, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Desert, IconTwo = RuleIcon.Mountain } },
            { 91, new() { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Forest } },
            { 92, new() { RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.AnimalTerritory } },
            { 93, new() { IsInverse = true, RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Forest, IconTwo = RuleIcon.Water } },
            { 94, new() { IsInverse = true, RuleGroup = RuleGroup.WithinTwoSpaces, IconOne = RuleIcon.StandingStone } },
            { 95, new() { RuleGroup = RuleGroup.OneOfTwo, IconOne = RuleIcon.Water, IconTwo = RuleIcon.Swamp } },
            { 96, new() { IsInverse = true, RuleGroup = RuleGroup.WithinOneSpace, IconOne = RuleIcon.Desert } },
        };
    }
}