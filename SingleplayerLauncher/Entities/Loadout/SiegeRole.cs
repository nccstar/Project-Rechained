﻿using System.Collections.Generic;
using static SingleplayerLauncher.Names.SiegeRole;

namespace SingleplayerLauncher.Model
{
    public class SiegeRole : Trait
    {
        // private constructor
        SiegeRole() { }
        public string Effect { get; private set; }

        // static members
        public static SiegeRole RoleDefender = new SiegeRole()
        {
            Id = 1,
            Name = DEFENDER,
            Effect = "+10% XP from minion kills. Starts match with coin.",
            SiegeDescription = "Defends the rift by building traps and killing minions.",
            CodeName = "SpitfireGame.RWeaverRoleDefense"
        };
        public static SiegeRole RoleAttacker = new SiegeRole()
        {
            Id = 2,
            Name = ATTACKER,
            Effect = "+8% leadership aura and XP when escorting minions.",
            SiegeDescription = "Leads minions through enemy defenses to attack enemy rifts.",
            CodeName = "SpitfireGame.RWeaverRoleOffense"
        };
        public static SiegeRole RolePillager = new SiegeRole()
        {
            Id = 3,
            Name = PILLAGER,
            Effect = "+18% XP from cache drops.",
            SiegeDescription = "Finds and loots caches. Assists defenders and attackers.",
            CodeName = "SpitfireGame.RWeaverRolePillaging"
        };

        public static Dictionary<string, SiegeRole> Roles = new Dictionary<string, SiegeRole>
        {
            { DEFENDER, RoleDefender },
            { ATTACKER, RoleAttacker },
            { PILLAGER, RolePillager }
        };

        public static Dictionary<int, SiegeRole> RolesById = new Dictionary<int, SiegeRole>
        {
            { RoleDefender.Id, RoleDefender },
            { RoleAttacker.Id, RoleAttacker },
            { RolePillager.Id, RolePillager }
        };

        public static SiegeRole GetById(int id)
        {
            if (RolesById.TryGetValue(id, out var trait))
            {
                return trait;
            }
            return new SiegeRole { Id = 0, Name = "Unknown" };
        }
    }
}