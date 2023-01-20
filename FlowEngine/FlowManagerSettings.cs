using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flows
{
    public class FlowManagerSettings : Settings
    {

        public List<string> EnabledNodes;
        public string Agent;
        public string FlowManager;

        public FlowManagerSettings(string filePath) : base(filePath)
        {
            // Get enabled nodes
            var EnabledNodesKvp = this.AllSettings["FlowNodes"].Where(kvp => bool.Parse(kvp.Value) == true).ToList();
            EnabledNodes = EnabledNodesKvp.Select(x => x.KeyName).ToList();

            // Get Agent
            Agent = AllSettings["General"]["Agent"];

            // Get Flow Manager
            FlowManager = AllSettings["General"]["FlowManager"];
        }
    }
}