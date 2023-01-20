using System;
using System.Collections.Generic;
using System.Text;

namespace Flows
{
    public abstract class FlowAgent : Manager
    {
        public int Network
        {
            get => default;
            set
            {
            }
        }

        public FlowManager Manager
        {
            get => default;
            set
            {
            }
        }

        public int Settings
        {
            get => default;
            set
            {
            }
        }

        public AgentSettings AgentManagerSettings
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

        public abstract void Run();
        public abstract void Start();
        public abstract void Stop();
    }
}