using System;
using System.Collections.Generic;
using System.Text;

namespace newClickers
{
    class Exit : ICommand
    {
        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
