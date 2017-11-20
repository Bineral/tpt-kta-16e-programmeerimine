using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class RollCommandParser
    {
        public List<Dice> Parse(string command)
        {
            var list = new List<Dice>();

            // /roll 1d8 2d6
            var dices = command.Split(' ').Skip(1).ToArray();

            foreach (var dice in dices)
            {
                // 1d6
                var parts = dice.Split('d');

                for (int i = 0; i < int.Parse(parts[0]); i++)
                {
                    list.Add(Dice.FromString($"d{parts[1]}"));
                }

            }

            return list;
        }
    }
}
