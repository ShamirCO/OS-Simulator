using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_09
{
    class Memory
    {
        // CONSTANTS
        public const int NumberOfFrames = 36, NumberOfFramesOccupiedByOS = 2;

        // ATTRIBUTES
        public Frame[] Frames;

        // METHODS
        public Memory()
        {
            Frames = new Frame[NumberOfFrames];

            for(int i = 0; i < NumberOfFrames; i++)
            {
                Frames[i] = new Frame();
            }

            for (int i = 0; i < NumberOfFramesOccupiedByOS; i++)
            {
                Frames[i].Add(new Process(0), Frame.NumberOfSlots);
            }
        }

        public bool Add(Process newProcess)
        {
            List<int> emptyFramesIndices = new List<int>();

            for (int i = NumberOfFramesOccupiedByOS; i < NumberOfFrames; i++)
            {
                if (Frames[i].IsEmpty())
                {
                    emptyFramesIndices.Add(i);

                    if (newProcess.Size - (emptyFramesIndices.Count * Frame.NumberOfSlots) <= 0)
                    {
                        Add(newProcess, emptyFramesIndices);

                        return true;
                    }
                }
            }

            return false;
        }

        private void Add(Process processToAdd, List<int> emptyFramesIndices)
        {
            int i;

            for (i = 0; i < emptyFramesIndices.Count - 1; i++)
            {
                Frames[emptyFramesIndices[i]].Add(processToAdd, Frame.NumberOfSlots);
            }

            Frames[emptyFramesIndices[i]].Add(processToAdd, processToAdd.Size - ((emptyFramesIndices.Count - 1) * Frame.NumberOfSlots));
        }

        public void Remove(Process processToRemove)
        {
            List<int> processToRemoveFramesIndices = FindIndices(processToRemove);

            foreach (int frameIndex in processToRemoveFramesIndices)
            {
                Frames[frameIndex].Clear();
            }
        }

        public void RemoveFrame(int frameIndex)
        {
            Frames[frameIndex].Clear();
        }

        public List<int> FindIndices(Process processToFind)
        {
            List<int> processToFindFramesIndices = new List<int>();

            for (int i = 0; i < NumberOfFrames; i++)
            {
                if (Frames[i].CurrentProcess == processToFind)
                {
                    processToFindFramesIndices.Add(i);
                }
            }

            return processToFindFramesIndices;
        }

        public List<int> FindIndicesToSwap(int virtualMemoryFrames)
        {
            List<int> framesToSwapIndices = new List<int>();
            List<Process> processesChecked = new List<Process>();
            Process currentProcess;

            for (int i = NumberOfFramesOccupiedByOS; i < NumberOfFrames; i++)
            {
                if (Frames[i].IsEmpty())
                {
                    framesToSwapIndices.Add(i);

                    if (framesToSwapIndices.Count == virtualMemoryFrames)
                    {
                        return framesToSwapIndices;
                    }
                }
            }

            for (int i = NumberOfFramesOccupiedByOS; i < NumberOfFrames; i++)
            {
                currentProcess = Frames[i].CurrentProcess;

                if (processesChecked.Contains(currentProcess))
                {
                    framesToSwapIndices.Add(i);

                    if (framesToSwapIndices.Count == virtualMemoryFrames)
                    {
                        return framesToSwapIndices;
                    }
                }
                else
                {
                    processesChecked.Add(currentProcess);
                }
            }

            framesToSwapIndices.Clear();

            return framesToSwapIndices;
        }
    }
}
