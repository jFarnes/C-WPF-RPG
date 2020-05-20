using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.ViewModels
{
    class GameSession{
        Player CurrentPlayer { set; get; }

        public GameSession(){
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Rangus";
            CurrentPlayer.Gold = 100000;
        }
    }
}
