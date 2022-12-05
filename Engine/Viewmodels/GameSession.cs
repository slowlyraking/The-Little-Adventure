using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Viewmodels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Will";
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 100000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            

        }
    }
}
