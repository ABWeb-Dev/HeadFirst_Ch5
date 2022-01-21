using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    class Bee : IWorker
    {

        public string job{ get; }
        public virtual float CostPerShift { get; private set; }
        public Bee(string job)
        {
            this.job = job;
        }

        public void WorkNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
                DoJob();
        }

        protected virtual void DoJob() { }
    }
}
