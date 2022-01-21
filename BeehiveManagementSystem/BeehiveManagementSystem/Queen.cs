using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BeehiveManagementSystem
{
    class Queen : Bee, INotifyPropertyChanged
    {
        public override float CostPerShift { get { return 2.15f; } }

        private const float EGGS_PER_SHIFT = .45f;
        private const float HONEY_PER_UNASSIGNED_WORKER = .5f;

        private IWorker[] workers = new IWorker[0];
        private float eggs = 0;
        private float unassignedWorkers = 3;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public string StatusReport { get; private set; }
        public Queen() : base("Queen")
        {
            AssignBee("Egg Care");
            AssignBee("Collect Nectar");
            AssignBee("Make Honey");
        }

        private void AddWorker(IWorker worker)
        {
            if(unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;
            }
        }
        protected override void DoJob()
        {
            eggs += EGGS_PER_SHIFT;

            foreach(IWorker worker in workers)
            {
                worker.WorkNextShift();
            }

            HoneyVault.ConsumeHoney(HONEY_PER_UNASSIGNED_WORKER * unassignedWorkers);

            UpdateStatusReport();
        }
        public void AssignBee(string job)
        {
            switch (job)
            {
                case "Collect Nectar":
                    AddWorker(new NectarCollector());
                    break;
                case "Make Honey":
                    AddWorker(new HoneyManufacturer());
                    break;
                case "Egg Care":
                    AddWorker(new EggCare(this));
                    break;
            }

            UpdateStatusReport();
        }

        public void CareForEggs(float eggsToConvert)
        {
            if (eggs >= eggsToConvert)
            {
                eggs -= eggsToConvert;
                unassignedWorkers += eggsToConvert;
            }
        }

        private string WorkerStatus(string job)
        {
            int count = 0;
            foreach (Bee worker in workers)
            {
                if (worker.job == job) count++;
            }
            string s = "s";
            if (count == 1) s = "";
            return $"{count} {job} bee{s}";
        }

        private void UpdateStatusReport()
        {
            StatusReport = $"Vault report:\n{HoneyVault.StatusReport}\n" +
                $"\nEgg count: {eggs:0.0}\nUnassigned workers: {unassignedWorkers: 0.0}\n" +
                $"{WorkerStatus("Nectar Collector")}\n{WorkerStatus("Honey Manufacturer")}" +
                $"\n{WorkerStatus("Egg Care")}\nTOTAL WORKERS: {workers.Length}";
                OnPropertyChanged("StatusReport");
        }
    }
}
