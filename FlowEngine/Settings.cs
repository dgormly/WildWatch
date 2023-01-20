using System;
using System.Collections.Generic;
using System.Text;
using IniParser;
using IniParser.Model;

namespace Flows
{

    public abstract class Settings
    {

        protected static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        public Settings(string filePath)
        {
            var parser = new FileIniDataParser();
            try
            {
                this.FilePath = filePath;
                this.AllSettings = parser.ReadFile(filePath);
            }
            catch (Exception ex) 
            {
                // Failed to read file.
                _logger.Error(ex,"Failed to read settings from file: " + FilePath);
            }
        }


        public string FilePath;
        protected IniData AllSettings;
    }
}