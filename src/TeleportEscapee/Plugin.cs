using PluginAPI.Core.Attributes;
using PluginAPI.Events;
using TeleportEscapee.Configs;
using TeleportEscapee.Handlers;

namespace TeleportEscapee
{
    public sealed class Plugin
    {
        private EventHandlers _handlers;

        [PluginConfig] public Config Config;

        [PluginEntryPoint("TeleportEscapee", "1.1.0", "Teleports players who escape to their previous position.", "Memento Mori ~ Dev")]
        public void Run()
        {
            if (!Config.IsEnabled)
            {
                return;
            }

            _handlers = new (Config.DebugMessages);

            EventManager.RegisterEvents(this, _handlers);
        }

        [PluginUnload]
        public void Unload()
        {
            EventManager.UnregisterEvents(this, _handlers);

            _handlers = null;
        }
    }
}