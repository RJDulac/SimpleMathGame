using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class Q
    {
        public static Random random = new Random();

        public int N1 { get; private set; }
        public int N2 { get; private set; }
        public string Op { get; private set; }

        public Q(bool add)
        {
            if (add) Op = "+";
            else Op = "*";
            N1 = random.Next(1, 10);
            N2 = random.Next(1, 10);
        }

        public bool Check(int num)
        {
            if (Op == "+") return (num == N1 + N2);
            else return num == N1 * N2;
        }
    }
}
