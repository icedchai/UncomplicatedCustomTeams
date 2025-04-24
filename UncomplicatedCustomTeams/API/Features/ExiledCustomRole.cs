using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomTeams.API.Enums;
using UncomplicatedCustomTeams.Interfaces;
using YamlDotNet.Serialization;

namespace UncomplicatedCustomTeams.API.Features
{
    public class ExiledCustomRole : IUCTCustomRole
    {
        [YamlIgnore]
        public CustomRole BaseCustomRole => CustomRole.Get(ExiledId);

        [YamlIgnore]
        public string Name { get => BaseCustomRole.Name; set => BaseCustomRole.Name = value; }

        /// <summary>
        /// The maximum number of players that can have this role in this wave
        /// </summary>
        [Description("The maximum number of players that can have this role in this wave")]
        public int MaxPlayers { get; set; }

        [YamlIgnore]
        /// <inheritdoc/>
        public RoleTypeId Role => BaseCustomRole.Role;

        /// <summary>
        /// The priority of assigning this role in the wave (First -> Fourth).
        /// The lower the value, the higher the priority.
        /// </summary>
        [Description("Priority of assigning custom role in Team (First -> Fourth). The lower the value, the higher the priority.")]
        public RolePriority Priority { get; set; } = RolePriority.First;

        [Description("The numerical ID of the Exiled CustomRole you are trying to put here. If this does not refer to an existing custom role, it won't work.")]
        public uint ExiledId { get; set; }

        [YamlIgnore]
        public uint RoleNumericalId => BaseCustomRole.Id;

        public void Spawn(Player player)
        {
            BaseCustomRole.AddRole(player);
        }
    }
}
