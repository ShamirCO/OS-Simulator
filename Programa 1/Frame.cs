using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_09
{
    class Frame
    {
        // CONSTANTS
        public const int NumberOfSlots = 5;

        // ATTRIBUTES
        public Process CurrentProcess { get; set; }
        public int[] Slots { get; set; }
        public int SlotsOccupied { get; set; }

        // METHODS
        public Frame()
        {
            Slots = new int[NumberOfSlots];
            SlotsOccupied = 0;
        }

        public Frame(Frame newFrame)
        {
            CurrentProcess = newFrame.CurrentProcess;
            Slots = newFrame.Slots;
            SlotsOccupied = newFrame.SlotsOccupied;
        }

        public bool IsEmpty()
        {
            return SlotsOccupied == 0;
        }

        public void Add(Process newCurrentProcess, int slotsToOccupy)
        {
            CurrentProcess = newCurrentProcess;
            SlotsOccupied = slotsToOccupy;

            for (int i = 0; i < slotsToOccupy; i++)
            {
                Slots[i] = newCurrentProcess.ID;
            }
        }

        public void Clear()
        {
            CurrentProcess = null;

            for (int i = 0; i < SlotsOccupied; i++)
            {
                Slots[i] = 0;
            }

            SlotsOccupied = 0;
        }
    }
}
