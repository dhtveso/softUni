﻿using System;

public interface IInventory
{
    long TotalStrengthBonus { get; }

    long TotalAgilityBonus { get; }

    long TotalIntelligenceBonus { get; }

    long TotalHitPointsBonus { get; }

    long TotalDamageBonus { get; }

    void AddRecipeItem(IRecipe recipe);

    void AddCommonItem(IItem item);
}
