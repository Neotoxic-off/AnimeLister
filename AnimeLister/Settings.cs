using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeLister
{
    class Settings
    {

        public class Rootobject
        {
            public List<Anime> anime { get; set; }
        }

        public class Anime
        {
            public string name { get; set; }
            public string grade { get; set; }
        }

    }
}
