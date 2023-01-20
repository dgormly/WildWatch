using System;
using System.Collections.Generic;
using System.Text;

namespace Flows
{
    public interface Manager
    {
        void Start();
        void Run();
        void Stop();
    }
}