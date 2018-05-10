﻿// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2018 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using UnityEngine;
using DaggerfallConnect;
using DaggerfallWorkshop.Game.Entity;

namespace DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects
{
    /// <summary>
    /// Drain - Strength
    /// </summary>
    public class DrainStrength : DrainEffect
    {
        public override void SetProperties()
        {
            properties.Key = "Drain-Strength";
            properties.ClassicKey = MakeClassicKey(7, 0);
            properties.GroupName = TextManager.Instance.GetText("ClassicEffects", "drain");
            properties.SubGroupName = TextManager.Instance.GetText("ClassicEffects", "strength");
            properties.SpellMakerDescription = DaggerfallUnity.Instance.TextProvider.GetRSCTokens(1519);
            properties.SpellBookDescription = DaggerfallUnity.Instance.TextProvider.GetRSCTokens(1219);
            properties.SupportMagnitude = true;
            properties.ShowSpellIcon = false;
            properties.AllowedTargets = EntityEffectBroker.TargetFlags_Other;
            properties.AllowedElements = EntityEffectBroker.ElementFlags_All;
            properties.AllowedCraftingStations = MagicCraftingStations.SpellMaker;
            properties.MagicSkill = DFCareer.MagicSkills.Destruction;
            properties.MagnitudeCosts = MakeEffectCosts(8, 100, 116);
            drainStat = DFCareer.Stats.Strength;
        }
    }
}