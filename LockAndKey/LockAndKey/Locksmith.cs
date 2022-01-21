using System;
using System.Collections.Generic;
using System.Text;

namespace LockAndKey
{
    /// <summary>
    /// Class locksmith has a string property called Combination that allows it to obtain the safe combination and set it as well.
    /// Locksmith class also has methods OpenSafe (which incidentally opens the safe) and ReturnContents (gives back contents to the owner).
    /// </summary>
    class Locksmith
    {
        /// <summary>
        /// Combination property, Locksmith may get or set the safe combination
        /// </summary>
        public string Combination { private get; set; }

        /// <summary>
        /// Method OpenSafe takes a Safe object and SafeOwner object as arguments. 
        /// The Safe object's Picklock method is called and this Lockesmith object is passed to it as an argument.
        /// safe.Open returns the contants in the safe after taking a correct combination passed as an argument to that method
        /// this method then calls the ReturnContents and passes safeContents and owner as arguments.
        /// </summary>
        /// <param name="safe">Safe object as argument</param>
        /// <param name="owner">SafeOwner object as argument</param>
        public void OpenSafe(Safe safe, SafeOwner owner)
        {
            safe.PickLock(this); 
            string safeContents = safe.Open(Combination);
            ReturnContents(safeContents, owner);
        }

        /// <summary>
        /// ReturnContents takes a string argument for the safeContents and a SafeOnwer argument. This methods "returns" the safeContents to the owner object.
        /// </summary>
        /// <param name="safeContents"> contents to be given back to the owner</param>
        /// <param name="owner">Owner object receiving the safeContents</param>
        protected virtual void ReturnContents(string safeContents, SafeOwner owner)
        {
            owner.ReceiveContents(safeContents);
        }


    }
}
