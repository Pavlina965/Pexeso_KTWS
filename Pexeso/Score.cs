using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pexeso
{
   public class Score
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Jmeno { get; set; }
        public int PocetKliku { get; set; }
        public string Cas { get; set; }

    }
}
