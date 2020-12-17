using System;
using System.Collections.Generic;
using System.Text;

namespace newClickers
{
    class Upgrade : ICommand
    {
        public void Run()
        {
            if (ClickerGame.points >= 10)
            {
                ClickerGame.points -= 10;
                ClickerGame.pointsPerClick += ClickerGame.pointsPerClickIncrease;
                ClickerGame.UpgradeCounter++;
            }
        }
    }
}
