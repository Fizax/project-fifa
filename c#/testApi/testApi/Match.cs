﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApi
{
    public class Match
    {
        public string team1 { get; set; }
        public string team2 { get; set; }

        public override string ToString()
        {
            return string.Format(" {0} - {1})", this.team1, this.team2);
        }
    }
}
