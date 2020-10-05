﻿namespace Engine.Models
{
    /// <summary>
    /// This class handles the player information.
    /// </summary>
    public class Player
    {
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
    }
}