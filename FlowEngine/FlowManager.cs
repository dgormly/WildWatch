using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Flows
{
    public abstract class FlowManager : Manager
    {

        private string _settingsPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + ".." +
                   Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "settings" + Path.DirectorySeparatorChar + "FlowManager.ini";

        public FlowManager()
        {
            FlowManagerSettings = new FlowManagerSettings(_settingsPath);
            // Create agent node
            var managerType = Type.GetType("Flows." + FlowManagerSettings.Agent + ", FlowEngine");
            Agent = Activator.CreateInstance(managerType) as FlowAgent;
        }

        private List<Flows.Settings> Settings
        {
            get;
            set;
        }

        public Queue<Packet> MessageQueue
        {
            get;
            set;
        }

        /// <summary>
        /// Graph to be used for processing.
        /// </summary>
        private int Network
        {
            get;
            set;
        }

        public FlowManagerSettings FlowManagerSettings
        {
            get;
            set;
        }

        public FlowAgent Agent
        {
            get;
            set;
        }

        public FlowAgent FlowAgent
        {
            get;
            set;
        }

        /// <summary>
        /// Node Dictionary containing all nodes used for processing.
        /// </summary>
        public Dictionary<string, FlowNode> NodeDict
        {
            get;
            set;
        }

        public int NodeFactory
        {
            get;
            set;
        }

        public FlowNodeFactory FlowNodeFactory
        {
            get;
            set;
        }

        /// <summary>
        /// Start the Flow Manager extension.
        /// </summary>
        public void Start()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Run the Flow Manager extension. Start() already been run.
        /// </summary>
        public void Run()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Stop the Flow Manager extension.
        /// </summary>
        public void Stop()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Loads the network for processing from  a file.
        /// </summary>
        private void LoadGraph()
        {
            throw new System.NotImplementedException();
        }

        private void LoadNodes()
        {
            throw new System.NotImplementedException();
        }
    }
}