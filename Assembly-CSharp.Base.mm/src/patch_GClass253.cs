﻿#pragma warning disable 0626
#pragma warning disable 0649

using UnityEngine;
using System.Collections.Generic;
using MonoMod;

/// <summary>
/// Character cache?
/// </summary>
public static class patch_GClass235 {
    public static extern Object orig_smethod_0(string name);
    public static Object smethod_0(string name) {
        if (ETGMod.CoopReplacement != null && name == "PlayerCoopCultist") {
            return orig_smethod_0(ETGMod.CoopReplacement);
        }
        return orig_smethod_0(name);
    }

}
