using System;
using System.Collections.Generic;
using System.Text;

namespace Flows
{
    public struct Packet
    {
        /// <summary>
        /// Queue of nodes in which  the packet should be processed with a string mapping to the function to be run, and any settings configured in the UI.
        /// </summary>
        public Queue<Tuple<Flows.FlowNode, string, Dictionary<string, string>>> Path
        {
            get => default;
            set
            {
            }
        }

        public int Value
        {
            get => default;
            set
            {
            }
        }

        public GraphManager GraphManager
        {
            get => default;
            set
            {
            }
        }
    }
}