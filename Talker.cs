using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3WinFormsApp1
{
    class Talker
    {
        //text box is thing to say parameter & keeps a str.
        // numUpDown keeps num of times param.
        public static int Talk(string thingToSay, int numOfTimes)
        {
            string finalStr = "";
            // looping through numeric updown
            // if greater then 0 - 
            for (int c = 0; c < numOfTimes; c++)
            {
                // final string takes things to say,
                // and duplicates it by following req's
                // from numOfTimes.
                finalStr = finalStr + thingToSay + "\n";
            }
            MessageBox.Show(finalStr);
            return finalStr.Length; // returning final result.
            // then len var takes this return value.
        }
    }
}
