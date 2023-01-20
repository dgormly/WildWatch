using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Flows
{
    public class FlowNode : Manager
    {
        public BlockingCollection<Flows.Packet> PacketQueue
        {
            get => default;
            set
            {
            }
        }

//        private Dictionary<string, System.Func<Void>> FunctionMap
//        {
//            get => default;
//            set
//            {
//            }
//        }

        public int MaxQueueSize
        {
            get => default;
            set
            {
            }
        }

        public NodeSettings ConfigSettings
        {
            get => default;
            set
            {
            }
        }

        public int Name
        {
            get => default;
            set
            {
            }
        }

        public NodeSettings NodeSettings
        {
            get => default;
            set
            {
            }
        }

        public bool Enabled
        {
            get => default;
            set
            {
            }
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}