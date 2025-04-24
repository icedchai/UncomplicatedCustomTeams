using Exiled.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UncomplicatedCustomTeams.API.Enums;
using YamlDotNet.Serialization;

namespace UncomplicatedCustomTeams.Interfaces
{
    public interface IUCTCustomRole
    {
        /// <summary>
        /// Gets the ID of this role.
        /// </summary>
        public uint RoleNumericalId { get; }

        /// <summary>
        /// Gets the name of this role.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the <see cref="RoleTypeId"/> to spawn this role as.
        /// </summary>
        [YamlIgnore]
        public RoleTypeId Role { get; }

        public void Spawn(Player player);

        /// <summary>
        /// The maximum number of players that can have this role in this wave
        /// </summary>
        [Description("The maximum number of players that can have this role in this wave")]
        public int MaxPlayers { get; set; }

        /// <summary>
        /// The priority of assigning this role in the wave (First -> Fourth).
        /// The lower the value, the higher the priority.
        /// </summary>
        [Description("Priority of assigning custom role in Team (First -> Fourth). The lower the value, the higher the priority.")]
        public RolePriority Priority { get; set; }
    }
}
