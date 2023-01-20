using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flows
{
    public class AgentSettings : Settings
    {
        public List<string> EnabledNodes
        {
            get => default;
            set
            {
            }
        }

        public AgentSettings(string filePath) : base(filePath)
        {
            var EnabledNodes = this.AllSettings["FlowNodes"].Where(kvp => bool.Parse(kvp.Value) == true).ToList();
            //_logger.Debug(EnabledNodes);
        }
    }
}