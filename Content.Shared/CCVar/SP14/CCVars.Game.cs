﻿using Content.Shared.Roles;
using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
        /// <summary>
        ///     The prototype to use for lockdown weights.
        /// </summary>
        public static readonly CVarDef<string> LockdownWeightPrototype =
            CVarDef.Create("game.lockdown_weight_prototype", "Lockdown", CVar.SERVERONLY);

        /// <summary>
        ///     The default loaded preset.
        /// </summary>
                public static readonly CVarDef<string>
            GameLobbyDefaultPreset = CVarDef.Create("game.defaultpreset", "lockdown", CVar.ARCHIVE);
}