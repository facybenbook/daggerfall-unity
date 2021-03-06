// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2019 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using System;

namespace DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects
{
    /// <summary>
    /// Stage one disease effect for werewolf variant of lycanthropy.
    /// This disease can be cured in the usual way up until it completes.
    /// Note: This disease should only be assigned to player entity.
    /// </summary>
    public class WerewolfInfection : LycanthropyInfection
    {
        public const string WerewolfInfectionKey = "Werewolf-Infection";

        public override void SetProperties()
        {
            base.SetProperties();
            properties.Key = WerewolfInfectionKey;
            InfectionType = LycanthropyTypes.Werewolf;
        }

        protected override void DeployFullBlownLycanthropy()
        {
            // TODO: Deploy werewolf variant of lycanthropy
        }
    }
}