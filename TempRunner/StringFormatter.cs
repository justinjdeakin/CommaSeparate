using System;
using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {

        //Code to improve

        // Changed mehtod name from ToCommaSepatatedList to ToCommaSeparatedList -  Fix spelling 
        public static string ToCommaSeparatedList(string[] items, string quote)
        {   
            // Changed variable name from qry to query -> intrinsic variable names
            StringBuilder query = new StringBuilder(string.Format("{0}{1}{0}", quote, items[0]));

            if (items.Length > 1)
            {
                for (int i = 1; i < items.Length; i++)
                {
                    query.Append(string.Format(", {0}{1}{0}", quote, items[i]));
                }
            }

            return query.ToString();
        }

        public static void Main(string[] args)
        {
            var result = ToCommaSeparatedList(new string[] { "test", "test2" }, "\"");
            Console.WriteLine(result);
        }
    }
}
