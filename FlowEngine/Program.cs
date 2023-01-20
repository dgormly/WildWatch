using System;
using System.IO;
using Flows;

namespace FlowEngine
{
    class Program
    {
        static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            _logger.Info("Initialising FlowEngine.");

            string settingsPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + ".." +
                       Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "settings" + Path.DirectorySeparatorChar + "FlowManager.ini";
            
            // Get FlowManagerSettings
            FlowManagerSettings fmSettings = null;
            try
            {
                fmSettings = new FlowManagerSettings(settingsPath);
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Failed to load FlowManagerSettings.");
                _logger.Info("Shutting down FlowEngine.");
                Environment.Exit(1);
            }

            // Create manager node
            try
            {
                var managerType = Type.GetType("Flows." + fmSettings.FlowManager + ", FlowEngine");
                var manager = Activator.CreateInstance(managerType);
            }
            catch (Exception ex)
            {
                // Shutdown program.
                _logger.Fatal(ex, "Failed to load manager: " + fmSettings.FlowManager + " from FlowManagerSettings.ini. Please make sure this is a valid manager.");
                _logger.Info("Shuting down FlowEngine.");
                Environment.Exit(1);
            }

        }
    }
}
