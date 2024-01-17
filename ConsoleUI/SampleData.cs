using ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class SampleData
    {
        public static List<MemberModel> GetMemberData()
        {
            List<MemberModel> members = new List<MemberModel>
            {
                new MemberModel{Name = "Mike", Level = 10, Games = new List<string>{ "Mario Bros", "Tetris"}},
                new MemberModel{Name = "David", Level = 5, Games = new List<string>{ "Mario Bros"} },
                new MemberModel{Name = "Franklin", Level = 3, Games = new List<string>{ "Mario Bros", "Tetris", "Candy Crush"} }
            };

            return members;
        }
    }
}
