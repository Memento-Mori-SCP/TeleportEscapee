# TeleportEscapee
## Description
[**SCP:SL**](https://scpslgame.com/)[^scpsl] plugin using [**NwAPI**](https://github.com/northwood-studios/NwPluginAPI)[^nwapi] that teleports players who escape to their previous position.

## Installation
1. **Download the [latest release](https://github.com/Memento-Mori-SCP/TeleportEscapee/releases/latest) from the [releases page](https://github.com/Memento-Mori-SCP/TeleportEscapee/releases).**
2. **Copy the TeleportEscapee.dll file into your **Plugins** folder[^linux][^win10].**
3. **Restart your game server to load plugin.**

## Configuration
**The configuration file is located in _~/.config/SCP Secret Laboratory/PluginAPI/plugins/global/TeleportEscapee_ on Linux or _%AppData%/SCP Secret Laboratory/PluginAPI/plugins/global/TeleportEscapee_ on Windows 10.**

Property | Type | Default | Description
----- | :--: | :--: | :-----:
**`IsEnabled`** | `Boolean` | `true` | **`Enable or disable plugin.`**
**`DebugMessages`** | `Boolean` | `false` | **`Enables or disables debugging messages in the console.`**

## Credits
**Plugin By [Memento Mori ~ Dev](https://github.com/Memento-Mori-SCP).**

**SCP:SL[^scpsl] and NwAPI[^nwapi] By [Northwood Studios](https://github.com/northwood-studios).**

**MEC[^mec] By [Trinary Software](http://trinary.tech/).**

## License
This project is licensed under the GPL-3.0 License - see the [LICENSE](LICENSE) file for details.

[^scpsl]: SCP: Secret Laboratory.
[^nwapi]: Northwood Plugin API.
[^mec]: More Effective Coroutines.
[^linux]: ~/.config/SCP Secret Laboratory/PluginAPI/plugins/(global or your server port) on Linux.
[^win10]: %AppData%/SCP Secret Laboratory/PluginAPI/plugins/(global or your server port) on Windows 10.
