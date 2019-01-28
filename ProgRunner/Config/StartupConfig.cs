using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace ProgRunner.Config
{
    internal static class StartupConfig
    {
        public static IEnumerable<ProcessConfigurationElement> GetStartupProcesses()
        {
            var section = ConfigurationManager.GetSection("custom/startupProcesses") as ProcessesConfigurationSection;
            return section?.Processes ?? Enumerable.Empty<ProcessConfigurationElement>();
        }
    }
}
