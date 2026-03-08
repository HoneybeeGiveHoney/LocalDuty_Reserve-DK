// SPDX-FileCopyrightText: 2025 LocalDuty <https://github.com/Bebranot/LocalDuty_Reserve>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

[CVarDefs]
public sealed class DutyCCVars
{
    /// <summary>
    /// Включена ли динамическая фоновая музыка.
    /// </summary>
    public static readonly CVarDef<bool> DynamicAmbientMusicEnabled =
        CVarDef.Create("duty.ambient_music_enabled", true, CVar.ARCHIVE | CVar.CLIENTONLY);

    /// <summary>
    /// Громкость динамической фоновой музыки (0.0–1.0).
    /// </summary>
    public static readonly CVarDef<float> DynamicAmbientMusicVolume =
        CVarDef.Create("duty.ambient_music_volume", 0.15f, CVar.ARCHIVE | CVar.CLIENTONLY);
}
