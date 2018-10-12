using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "18fdas99dsfadf88sfsdg9gffd11dfsgsd11fda6";
            int count = 0;
            string s = "";
            for (int i = 0; i < txt.Length; ++i)
            {
                if (Char.IsDigit(txt[i]))
                {
                    s += Convert.ToString(txt[i]);
                    count++;
                }
                else
                    if (count > 0)
                {
                    s += " ";
                    count = 0;
                }
            }
            count = 0;
            if (s == "")
                Console.WriteLine("No numbers");
            else
            {
                string[] result = s.Split(' ');
                for (int i = 0; i < result.Length; ++i)
                {
                    count += int.Parse(result[i]);
                }
                Console.WriteLine("Sum Of Numbers = {0}", count);
            }
            Console.ReadLine();

        }
    }
}
    

