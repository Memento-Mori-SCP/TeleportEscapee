#TeleportEscapee
## Description
[**SCP:SL**](https://scpslgame.com/)[^1] plugin using [**NwAPI**](https://github.com/northwood-studios/NwPluginAPI)[^2] that teleports players who escape to their previous position.

## Installation
Download the [latest release](https://github.com/Memento-Mori-SCP/TeleportEscapee/releases/latest) from the [releases page](https://github.com/Memento-Mori-SCP/TeleportEscapee/releases).
Copy the TeleportEscapee.dll file into your **Plugins** folder[^linux][^win10].
Restart your game server to load plugin.

##Configuration
The configuration file is located in **~/.config/SCP Secret Laboratory/PluginAPI/plugins/global/TeleportEscapee** on Linux or **%AppData%/SCP Secret Laboratory/PluginAPI/plugins/global/TeleportEscapee** on Windows 10.

Property | Type | Default | Description
----- | :---: | :---: | :------:
**`IsEnabled`** | `Boolean` | `true` | **`Enable or disable plugin.`**
**`DebugMessages`** | `Boolean` | `false` | **`Enables or disables debugging messages in the console.`**

##Credits
Plugin By [Memento Mori ~ Dev](https://github.com/Memento-Mori-SCP).
NwAPI[^2] and SCP:SL By [Northwood Studios](https://github.com/northwood-studios).
MEC[^3] By [Trinary Software](http://trinary.tech/).

### License
This project is licensed under the GPL-3.0 License - see the [LICENSE](LICENSE) file for details.

[^1]: SCP: Secret Laboratory.
[^2]: Northwood Plugin API.
[^3]: More Effective Coroutines.
[^linux]: ~/.config/SCP Secret Laboratory/PluginAPI/plugins/(global or your server port)
[^win10]: %AppData%/SCP Secret Laboratory/PluginAPI/plugins/(global or your server port)
