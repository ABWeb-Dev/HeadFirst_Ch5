using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    class NectarCollector : Bee
    {
        public NectarCollector() : base("Nectar Collector"){ }

        private const float NECTAR_COLLECTED_PER_SHIFT = 33.25f;
        public override float CostPerShift { get { return 1.95f; } }
        protected override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
