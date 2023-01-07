using MEC;
using PlayerRoles;
using PlayerRoles.FirstPersonControl;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using UnityEngine;

namespace TeleportEscapee.Handlers
{
    internal sealed class EventHandlers
    {
        [PluginEvent(ServerEventType.PlayerEscape)]
        public void OnPlayerEscape(Player player, RoleTypeId newRole)
        {
            Vector3 previousPosition = player.Position;
            Vector3 previousRotation = player.Rotation;

            Timing.CallDelayed(0.000003f, delegate
            {
                player.ReferenceHub.TryOverridePosition(previousPosition, previousRotation);

                if (Plugin.Config.DebugMessages)
                {
                    Log.Info($"Teleported player {player.Nickname} back to their last position ({previousPosition}).", nameof(TeleportEscapee));
                }
            });
        }
    }
}