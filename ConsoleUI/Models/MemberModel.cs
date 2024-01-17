using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Models
{
    public class MemberModel
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public List<string> Games { get; set; }
    }
}
