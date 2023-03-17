using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpravTest
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int IdName { get; set; }
        public string Race { get; set; } = null!;
        public string Clas { get; set; } = null!;
        public DateTime Modified { get; set; }
    }
}
