using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class userCreator
    {
        public void random()
        {
            Random random = new Random();
            int User = random.Next(1, 3);
            if(User == 1)
            {
                Program.username = "Feyza";
            }
            if (User == 2)
            {
                Program.username = "Lorenzo";
            }
            if (User == 3)
            {
                Program.username = "Elton";
            }
        }
    }
}
