using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Core.Config
{
    public class ConfigReader
    {
        public List<Host> Hosts
        {
            get
            {
                var appSettings = ConfigurationManager.AppSettings;
                return appSettings
                    .AllKeys
                    .Select(k => new Host {Hostname = k, PlaylistHome = appSettings.Get(k)})
                    .ToList();
            }
        } 
    }
}
