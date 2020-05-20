using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Player{
        public String Name { get; set; }
        public String CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int ExperienceLevel { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
    }
}
