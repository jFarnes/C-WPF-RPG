using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession{
        public Player CurrentPlayer { set; get; }

        public GameSession(){
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Rangus";
            CurrentPlayer.Gold = 100000;
            CurrentPlayer.CharacterClass = "Hunter";
            CurrentPlayer.HitPoints = 250;
            CurrentPlayer.ExperienceLevel = 0;
            CurrentPlayer.Level = 1;
        }
    }
}
