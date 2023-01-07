using PluginAPI.Core.Attributes;
using PluginAPI.Events;
using TeleportEscapee.Configs;
using TeleportEscapee.Handlers;

namespace TeleportEscapee
{
    public sealed class Plugin
    {
        [PluginConfig] public static Config Config;

        [PluginEntryPoint("TeleportEscapee", "1.0.0", "Teleports players who escape to their previous position.", "Memento Mori ~ Dev")]
        public void Run()
        {
            if (!Config.IsEnabled)
            {
                return;
            }

            EventManager.RegisterEvents<EventHandlers>(this);
        }
    }
}