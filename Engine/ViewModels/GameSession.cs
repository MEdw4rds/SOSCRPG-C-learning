using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer {  get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Scot";
            CurrentPlayer.Gold = 1000000;
        }
    }
}
