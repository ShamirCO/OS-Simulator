using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_09
{
    public class Process
    {
        // ATTRIBUTES
        public int ID { get; set; }
        public int Size { get; set; }
        public int EstimatedTime { get; set; }
        public int ArrivalTime { get; set; }
        public int CompletionTime { get; set; }
        public int TurnAroundTime { get; set; }
        public int ResponseTime { get; set; }
        public int WaitingTime { get; set; }
        public int BurstTime { get; set; }
        public string Operation { get; set; }
        public string Result { get; set; }

        // METHODS
        public Process(int newID)
        {
            ID = newID;
            Size = -1;
            EstimatedTime = -1;
            ArrivalTime = -1;
            CompletionTime = -1;
            TurnAroundTime = -1;
            ResponseTime = -1;
            WaitingTime = -1;
            BurstTime = 0;
            Operation = string.Empty;
            Result = string.Empty;
        }
    }
}
