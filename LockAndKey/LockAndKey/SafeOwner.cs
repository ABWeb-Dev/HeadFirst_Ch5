using System;
using System.Collections.Generic;
using System.Text;

namespace LockAndKey
{
    /// <summary>
    /// Class SafeOwner -- Has a single private field of type string called valuables and a single method called ReceiveContents.
    /// </summary>
    class SafeOwner
    {
        /// <summary>
        /// private string field named "valuables" initialized to an empty string.
        /// </summary>
        private string valuables = "";

        /// <summary>
        /// method ReceiveContents accepts a string argument and assigns that value to valuables
        /// method also outputs the interpolated line "Thank you for returning my {valuables}! 
        /// </summary>
        /// <param name="safeContents"></param>
        public void ReceiveContents(string safeContents)
        {
            valuables = safeContents;
            Console.WriteLine($"Thank you for returning my {valuables}!");
        }
    }
}
