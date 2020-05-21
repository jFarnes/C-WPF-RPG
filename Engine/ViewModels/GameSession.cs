using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession{
        public Player CurrentPlayer { set; get; }
        public Location CurrentLocation { get; set; }
        public GameSession(){
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Rangus";
            CurrentPlayer.Gold = 100000;
            CurrentPlayer.CharacterClass = "Hunter";
            CurrentPlayer.HitPoints = 250;
            CurrentPlayer.ExperienceLevel = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "Welcome Home";
            CurrentLocation.ImageName = "";

        }
    }
}
