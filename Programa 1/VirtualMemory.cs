using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_09
{
    class VirtualMemory
    {
        // CONSTANTS
        public const int NumberOfFrames = 36;

        // ATTRIBUTES
        public Frame[] Frames;

        // METHODS
        public VirtualMemory()
        {
            Frames = new Frame[NumberOfFrames];

            for (int i = 0; i < NumberOfFrames; i++)
            {
                Frames[i] = new Frame();
            }
        }

        public int AddFrame(Frame newFrame)
        {
            for (int i = 0; i < NumberOfFrames; i++)
            {
                if (Frames[i].IsEmpty())
                {
                    Frames[i] = newFrame;

                    return i;
                }
            }

            return -1;
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
    }
}
