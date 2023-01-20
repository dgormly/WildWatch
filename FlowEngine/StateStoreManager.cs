using System;
using System.Collections.Generic;
using System.Text;

namespace Flows
{
    public class StateStoreManager : Manager
    {
        public FlowManager FlowManager
        {
            get => default;
            set
            {
            }
        }

        public Dictionary<Namespace, int> StateStore
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Takes a namespace with wildcards ('+') and returns all channels that fit.
        /// </summary>
        public void GetAllChannels(Namespace channel)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Loads statestore from a given csv file.
        /// </summary>
        public void Load(string fileName)
        {
            throw new System.NotImplementedException();
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