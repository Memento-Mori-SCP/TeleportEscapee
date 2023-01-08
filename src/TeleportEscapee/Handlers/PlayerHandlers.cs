using System;
using MEC;
using PlayerRoles;
using PlayerRoles.FirstPersonControl;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using UnityEngine;

namespace TeleportEscapee.Handlers
{
    internal sealed class PlayerHandlers
    {
        public PlayerHandlers(bool debug)
        {
            Delayed += TeleportPlayer;

            if (!debug)
            {
                return;
            }

            Delayed += (player, pos, _) => WriteDebug(player.Nickname, pos);
        }

        private static event Action<Player, Vector3, Vector3> Delayed;

        [PluginEvent(ServerEventType.PlayerEscape)]
        public void OnPlayerEscape(Player player, RoleTypeId newRole)
            => DelayCall(player, player.Position, player.Rotation);

        private static void DelayCall(Player player, Vector3 position, Vector3 rotation)
            => Timing.CallDelayed(0.000003f, () => Delayed?.Invoke(player, position, rotation));

        private static void TeleportPlayer(Player player, Vector3 position, Vector3 rotation)
            => player.ReferenceHub.TryOverridePosition(position, rotation);

        private static void WriteDebug(string nickname, Vector3 position)
            => Log.Info($"Teleported player {nickname} back to their previous position ({position}).", nameof(TeleportEscapee));
    }
}