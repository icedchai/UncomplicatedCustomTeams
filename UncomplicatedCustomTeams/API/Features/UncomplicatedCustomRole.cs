using Exiled.API.Features;
using PlayerRoles;
using System.ComponentModel;
using UncomplicatedCustomRoles.Extensions;
using UncomplicatedCustomTeams.API.Enums;
using UncomplicatedCustomTeams.Interfaces;
using YamlDotNet.Serialization;

namespace UncomplicatedCustomTeams.API.Features
{
    public class UncomplicatedCustomRole : UncomplicatedCustomRoles.API.Features.CustomRole, IUCTCustomRole
    {
        [YamlIgnore]
        public uint RoleNumericalId => (uint)this.Id;

        /// <summary>
        /// The maximum number of players that can have this role in this wave
        /// </summary>
        [Description("The maximum number of players that can have this role in this wave")]
        public int MaxPlayers { get; set; }

        /// <inheritdoc/>
        public override RoleTypeId Role => base.Role;

        /// <summary>
        /// The priority of assigning this role in the wave (First -> Fourth).
        /// The lower the value, the higher the priority.
        /// </summary>
        [Description("Priority of assigning custom role in Team (First -> Fourth). The lower the value, the higher the priority.")]
        public RolePriority Priority { get; set; } = RolePriority.First;

        /// <summary>
        /// Spawns a <see cref="Player"/> as this CustomRole.
        /// </summary>
        /// <param name="player"></param>
        public void Spawn(Player player)
        {
            player.SetCustomRole(this);
        }
    }
}
