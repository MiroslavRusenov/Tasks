using System;
using System.Text;

namespace MMTask
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write(PrintLogo(9));
        }

        static string PrintLogo(int n)
        {
            string patternA = new string('-', n);
            string patternB = new string('*', n);
            string sectionA = patternA;
            string sectionB = patternB;
            string sectionC = patternA;

            int rows = n + 1;
            StringBuilder sb = new StringBuilder();

            for (int r = 1; r <= rows; r++)
            {
                if (r <= rows / 2)
                {
                    sb.AppendLine(sectionA + sectionB + sectionC + sectionB + sectionA + sectionA + sectionB + sectionC + sectionB + sectionA);
                    if (sectionA.Length > 1) sectionA = sectionA.Remove(sectionA.Length - 1);
                    if (sectionC.Length > 2) sectionC = sectionC.Remove(sectionC.Length - 2);
                    if (r != rows / 2) sectionB += "**";
                }
                else
                {
                    sb.AppendLine(sectionA + patternB + sectionC + sectionB + sectionC + patternB + sectionA + sectionA + patternB + sectionC + sectionB + sectionC + patternB + sectionA);
                    if (sectionA.Length > 0) sectionA = sectionA.Remove(sectionA.Length - 1);
                    if (sectionB.Length > 2) sectionB = sectionB.Remove(sectionB.Length - 2);
                    sectionC += "--";
                }
            }

            return sb.ToString();
        }
    }
}
