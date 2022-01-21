using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    interface IWorker
    {
        string job { get; }

        void WorkNextShift();
    }
}
