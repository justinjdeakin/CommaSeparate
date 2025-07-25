﻿using System;
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

            // return if input is not valid to save computation
            if (items == null || items.Length == 0) 
            {
                return string.Empty;
            }

            // Changed variable name from qry to query -> intrinsic variable names
            StringBuilder query = new StringBuilder();
            query.Append(quote).Append(items[0]).Append(quote);

            for (int i = 1; i < items.Length; i++)
            {
                query.Append(", ").Append(quote).Append(items[i]).Append(quote);
            }

            return query.ToString();
        }

        public static void Main(string[] args)
        {
            var result = ToCommaSeparatedList(new string[] { "test", "test2" }, "\'");
            Console.WriteLine(result);
        }
    }
}
