using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApi
{
    public class Gambler
    {

        public string Names { get; set; }
        public int Coin { get; set; }

        public Gambler(string names, int coin)
        {
            this.Names = names;
            this.Coin = coin;
        }
    }
}
