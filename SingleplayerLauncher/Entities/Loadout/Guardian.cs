﻿using System.Collections.Generic;
using static SingleplayerLauncher.Names.Guardian;

namespace SingleplayerLauncher.Model
{
    public class Guardian
    {
        public string Name { get; private set; }
        public byte[] CodeNameBytes { get; private set; }
        public string CodeName { get; private set; }

        public static Guardian BartenderGuardian = new Guardian()
        {
            Name = BARTENDER_GUARDIAN,
            CodeNameBytes = new byte[] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x62, 0x61, 0x72, 0x6d, 0x61, 0x69, 0x64, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x42, 0x61, 0x72, 0x6d, 0x61, 0x69, 0x64, 0x00 },
            CodeName = "",
        };
        public static Guardian BlacksmithGuardian = new Guardian()
        {
            Name = BLACKSMITH_GUARDIAN,
            CodeNameBytes = new byte[] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x42, 0x65, 0x61, 0x72, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x42, 0x65, 0x61, 0x72, 0x00 },
            CodeName = "",
        };
        public static Guardian CookGuardian = new Guardian()
        {
            Name = COOK_GUARDIAN,
            CodeNameBytes = new byte[] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x43, 0x6f, 0x6f, 0x6b, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x43, 0x6f, 0x6f, 0x6b, 0x00 },
            CodeName = "",
        };
        public static Guardian DeckhandGuardian = new Guardian()
        {
            Name = DECKHAND_GUARDIAN,
            CodeNameBytes = new byte[] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x64, 0x65, 0x63, 0x6b, 0x68, 0x61, 0x6e, 0x64, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x44, 0x65, 0x63, 0x6b, 0x68, 0x61, 0x6e, 0x64, 0x00 },
            CodeName = "",
        };
        public static Guardian DragonGuardian = new Guardian()
        {
            Name = DRAGON_GUARDIAN,
            CodeNameBytes = new byte[] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x44, 0x72, 0x61, 0x67, 0x6f, 0x6e, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x44, 0x72, 0x61, 0x67, 0x6f, 0x6e, 0x00 },
            CodeName = "",
        };
        public static Guardian FriarGuardian = new Guardian()
        {
            Name = FRIAR_GUARDIAN,
            CodeNameBytes = new byte[] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x6f, 0x72, 0x63, 0x70, 0x72, 0x69, 0x65, 0x73, 0x74, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x4f, 0x72, 0x63, 0x50, 0x72, 0x69, 0x65, 0x73, 0x74, 0x00 },
            CodeName = "",
        };
        public static Guardian HeadhunterGuardian = new Guardian()
        {
            Name = HEADHUNTER_GUARDIAN,
            CodeNameBytes = new byte[] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x74, 0x72, 0x6f, 0x6c, 0x6c, 0x63, 0x6f, 0x6d, 0x6d, 0x61, 0x6e, 0x64, 0x65, 0x72, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x54, 0x72, 0x6f, 0x6c, 0x6c, 0x43, 0x6f, 0x6d, 0x6d, 0x61, 0x6e, 0x64, 0x65, 0x72, 0x00 },
            CodeName = "",
        };
        public static Guardian JadeEmpireGuardian = new Guardian()
        {
            Name = JADE_EMPIRE_GUARDIAN,
            CodeNameBytes = new byte[] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x63, 0x68, 0x69, 0x6e, 0x65, 0x73, 0x65, 0x6a, 0x61, 0x69, 0x6c, 0x65, 0x72, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x43, 0x68, 0x69, 0x6e, 0x65, 0x73, 0x65, 0x4a, 0x61, 0x69, 0x6c, 0x65, 0x72, 0x00 },
            CodeName = "",
        };
        public static Guardian JailerGuardian = new Guardian()
        {
            Name = JAILER_GUARDIAN,
            CodeNameBytes = new byte[] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x4a, 0x61, 0x69, 0x6c, 0x65, 0x72, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x4a, 0x61, 0x69, 0x6c, 0x65, 0x72, 0x00 },
            CodeName = "",
        };
        public static Guardian LionGuardian = new Guardian()
        {
            Name = LION_GUARDIAN,
            CodeNameBytes = new byte[] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x4c, 0x69, 0x6f, 0x6e, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x4c, 0x69, 0x6f, 0x6e, 0x00 },
            CodeName = "",
        };
        public static Guardian MoonGuardian = new Guardian()
        {
            Name = MOON_GUARDIAN,
            CodeNameBytes = new byte[] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x4d, 0x6f, 0x6f, 0x6e, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x4d, 0x6f, 0x6f, 0x6e, 0x00 },
            CodeName = "",
        };
        public static Guardian PriestGuardian = new Guardian()
        {
            Name = PRIEST_GUARDIAN,
            CodeNameBytes = new byte[] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x50, 0x72, 0x69, 0x65, 0x73, 0x74, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x50, 0x72, 0x69, 0x65, 0x73, 0x74, 0x00 },
            CodeName = "",
        };
        public static Guardian QuartermasterGuardian = new Guardian()
        {
            Name = QUARTERMASTER_GUARDIAN,
            CodeNameBytes = new byte[] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x63, 0x61, 0x70, 0x74, 0x61, 0x69, 0x6e, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x43, 0x61, 0x70, 0x74, 0x61, 0x69, 0x6e, 0x00 },
            CodeName = "",
        };
        public static Guardian RanchHandGuardian = new Guardian()
        {
            Name = RANCH_HAND_GUARDIAN,
            CodeNameBytes = new byte[] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x73, 0x74, 0x61, 0x62, 0x6c, 0x65, 0x68, 0x61, 0x6e, 0x64, 0x6d, 0x69, 0x6e, 0x6f, 0x74, 0x61, 0x75, 0x72, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x53, 0x74, 0x61, 0x62, 0x6c, 0x65, 0x68, 0x61, 0x6e, 0x64, 0x4d, 0x69, 0x6e, 0x6f, 0x74, 0x61, 0x75, 0x72, 0x00 },
            CodeName = "",
        };
        public static Guardian RumrudderGuardian = new Guardian()
        {
            Name = RUMRUDDER_GUARDIAN,
            CodeNameBytes = new byte[] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x53, 0x63, 0x75, 0x72, 0x76, 0x79, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x53, 0x63, 0x75, 0x72, 0x76, 0x79, 0x00 },
            CodeName = "",
        };
        public static Guardian SerpentGuardian = new Guardian()
        {
            Name = SERPENT_GUARDIAN,
            CodeNameBytes = new byte[] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x52, 0x61, 0x7a, 0x65, 0x72, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x52, 0x61, 0x7a, 0x65, 0x72, 0x00 },
            CodeName = "",
        };
        public static Guardian StablehandGuardian = new Guardian()
        {
            Name = STABLEHAND_GUARDIAN,
            CodeNameBytes = new byte[] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x73, 0x74, 0x61, 0x62, 0x6c, 0x65, 0x68, 0x61, 0x6e, 0x64, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x53, 0x74, 0x61, 0x62, 0x6c, 0x65, 0x68, 0x61, 0x6e, 0x64, 0x00 },
            CodeName = "",
        };
        public static Guardian SunGuardian = new Guardian()
        {
            Name = SUN_GUARDIAN,
            CodeNameBytes = new byte[] { 0x50, 0x61, 0x77, 0x6e, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x53, 0x75, 0x6e, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x53, 0x75, 0x6e, 0x00 },
            CodeName = "",
        };
        public static Guardian WeaponWrightGuardian = new Guardian()
        {
            Name = WEAPONWRIGHT_GUARDIAN,
            CodeNameBytes = new byte[] { 0x70, 0x61, 0x77, 0x6e, 0x5f, 0x67, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x77, 0x65, 0x61, 0x70, 0x6f, 0x6e, 0x77, 0x72, 0x69, 0x67, 0x68, 0x74, 0x2e, 0x50, 0x6c, 0x61, 0x63, 0x65, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x47, 0x75, 0x61, 0x72, 0x64, 0x69, 0x61, 0x6e, 0x57, 0x65, 0x61, 0x70, 0x6f, 0x6e, 0x77, 0x72, 0x69, 0x67, 0x68, 0x74, 0x00 },
            CodeName = "",
        };

        public static Dictionary<string, Guardian> Guardians = new Dictionary<string, Guardian>
        {
            { BARTENDER_GUARDIAN, BartenderGuardian },
            { BLACKSMITH_GUARDIAN, BlacksmithGuardian },
            { COOK_GUARDIAN, CookGuardian },
            { DECKHAND_GUARDIAN, DeckhandGuardian },
            { DRAGON_GUARDIAN, DragonGuardian },
            { FRIAR_GUARDIAN, FriarGuardian },
            { HEADHUNTER_GUARDIAN, HeadhunterGuardian },
            { JADE_EMPIRE_GUARDIAN, JadeEmpireGuardian },
            { JAILER_GUARDIAN, JailerGuardian },
            { LION_GUARDIAN, LionGuardian },
            { MOON_GUARDIAN, MoonGuardian },
            { PRIEST_GUARDIAN, PriestGuardian },
            { QUARTERMASTER_GUARDIAN, QuartermasterGuardian },
            { RANCH_HAND_GUARDIAN, RanchHandGuardian },
            { RUMRUDDER_GUARDIAN, RumrudderGuardian },
            { SERPENT_GUARDIAN, SerpentGuardian },
            { STABLEHAND_GUARDIAN, StablehandGuardian },
            { SUN_GUARDIAN, SunGuardian },
            { WEAPONWRIGHT_GUARDIAN, WeaponWrightGuardian },
        };
    }
}
