# HUB - Graffiti (community fork)

MelonLoader (IL2CPP) mod for **Schedule I** that lets you put your own PNG images ("stickers") on graffiti
spray surfaces instead of drawing by hand. It plugs into the game's graffiti menu (a **STICKER** button next to
UNDO / RESTART / DONE) and into the ModHub menu.

This is a cleaned-up rewrite of the decompiled HUB - Graffiti v1.2.2 by Trippzad. The decompiled source could
not be compiled as-is; every file was rewritten into buildable C#.

## What changed in 1.3.0

- **Per-save placements.** Stickers are stored per game save slot instead of one shared list that leaked into
  every save. Files live under
  `UserData/HUB_Graffiti/Saves/<steamid>/SaveGame_<n>/sticker_placements.json`, mirroring the game's own
  `AppData/LocalLow/TVGS/Schedule I/Saves/<steamid>/SaveGame_<n>` layout. The game's save folder is only ever
  *read* (to identify the slot), never written.
  - If a slot is deleted and a new game is started in it, the old game's stickers are detected (via the save's
    `Metadata.json` creation date) and moved aside instead of being painted onto the new game.
  - The old shared `UserData/HUB_Graffiti/sticker_placements.json` from 1.2.x is not applied automatically.
    The ModHub page offers **Import Into This Save** or **Discard** for it.
- **Higher resolution.** Stickers used to be squashed into the game's low-res drawing texture with
  nearest-neighbour sampling. The projector now gets its own texture sized so the sticker is rendered at up to
  the PNG's native resolution (default cap 2048 px on the long side, switchable to 1024 / 4096 in the ModHub
  page or `03_StickerResolution` in `MelonPreferences.cfg`). Scaling is filtered (bilinear up, supersampled
  down, premultiplied alpha), with mipmaps for distance.
- **Remove stickers.** The ModHub page lists every sticker in the current save with a thumbnail and a
  **Remove** button (click twice to confirm), plus **Remove All**. Removing restores the surface's original
  look and clears it through the game's own `SpraySurface.ClearDrawing` (the server RPC behind the graffiti
  menu's clear button), so the spot can be sprayed again and the clear replicates to other players.
- **STICKER button aligned** in the same row as UNDO / RESTART / DONE, using the game's button shape, with
  the row re-centred.
- **Bug fixes**, among others:
  - Sticker picker labels were invisible on Unity 2022.2+ (`Arial.ttf` no longer exists as a built-in font).
  - Textures and materials leaked on every placement, restore and multiplayer update.
  - Spray rewards could be farmed again after a reload; now paid once per surface, like hand-spraying.
  - "Spots tagged" also counted replacing a sticker on an already-stickered surface.
  - The rewarded-surface list was never cleared between saves, so switching saves could withhold rewards.
  - Multiplayer sync was dead on the current game version: the game moved lobby chat from
    `Lobby.OnLobbyChatMessage` into `SteamLobbyService`, so the Harmony patch never fired. Sync now uses the
    game's `ILobbyService` (`GetLobbyData` / `SetLobbyData` / `OnLobbyMessage`) and needs no Harmony patch.
  - Multiplayer clients wrote the host's placements into their own local file.
  - Clients polled Steam lobby data every frame; now once a second, and the host only republishes on change.
  - Placements removed by the host stayed visible on clients.
  - Atomic save writes (no truncated JSON after a crash); unreadable files are kept aside, not overwritten.
  - The generated default "Crown" sticker rendered as a solid block.
  - Rebuilding the ModHub page from inside a button click handler.

## Building

Requirements: .NET SDK 6+ and a Schedule I install with MelonLoader (IL2CPP, 0.6+) and ModHub.Core, started
at least once so MelonLoader has generated `MelonLoader/Il2CppAssemblies`.

```
cd hubgraffiti-melonloader-il2cpp
dotnet build -c Release -p:GamePath="D:\Steam\steamapps\common\Schedule I"
```

Add `-p:CopyToMods=true` to copy `HUB.Graffiti.dll` into the game's `Mods` folder after building.

## Using

1. Put PNG files in `UserData/HUB_Graffiti/` (five defaults are generated if the folder is empty).
2. In game, equip the spray can, interact with a graffiti spot and click **STICKER**, then pick an image.
3. Manage the current save's stickers from the **HUB - Graffiti** page in ModHub.

In multiplayer, everyone needs the same PNG files (matched by file name). The Steam lobby sync can carry
roughly 100 placements.

Logs for bug reports: `UserData/HUB_Graffiti/logs/` (the ModHub page has a button to open it).

## Reference source

`Assembly-Csharp/` and `Unity-Core/` hold MelonLoader's decompiled interop assemblies of the game, used to
verify the game API the mod calls. They are not part of the build.
