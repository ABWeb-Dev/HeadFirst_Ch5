using System;
using System.Collections.Generic;
using System.Text;

namespace LockAndKey
{
    /// <summary>
    /// <Class Name = "Safe"> 
    /// The purpose of this class is to demonstrate inheritance principles and 
    /// the proper usage of the keywords "virtual" and "override"
    /// </Class>
    /// </summary>
    class Safe
    {
        /// <summary>
        /// <Field name = "contents" type = "string" accessor = "private">Contents of the safe</Field>
        /// <Field name = "safeCombination" type = "string" accessor = "private">Combination to access the safe</Field>
        /// </summary>
        private string contents = "precious jewels";
        private string safeCombination = "12345";

        /// <summary>
        /// Open takes a string argument and passes it to the conditional statement. If that argument matches the safeCombination field then
        /// the contents of the safe are returned to the method caller. 
        /// </summary>
        /// <param name="combinations"></param>
        /// <returns>contents if combinations == safeCombination, else returns an empty string.</returns>
        public string Open(string combinations)
        {
            if (combinations == safeCombination) return contents;
            return "";
        }

        /// <summary>
        /// Method PickLock takes a Locksmith object as an argument, and sets it's Combination value to this objects safeCombination value;
        /// </summary>
        /// <param name="lockpicker"></param>
        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.Combination = safeCombination;
        }

    }
}
