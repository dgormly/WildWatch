using System;
using System.Collections.Generic;
using System.Text;

namespace Flows
{
    public class NodeSettings : Settings
    {
        public NodeSettings(string fileName) : base(fileName)
        {
            this.Name = this.AllSettings["General"]["Name"];
            this.MaxCapacity = int.Parse(this.AllSettings["General"]["MaxCapacity"]);
        }

        public string Name
        {
            get => default;
            set
            {
            }
        }

        public int MaxCapacity
        {
            get => default;
            set
            {
            }
        }
    }
}