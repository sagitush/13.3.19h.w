using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3._19
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProtectedUniqeList vs = new MyProtectedUniqeList("alma");
            vs.Add("gold");
            vs.Add("silver");
            vs.Add("black");
            
            Console.WriteLine(vs);
            try
            {
                vs.Add("");
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
