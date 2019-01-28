using System.Configuration;

namespace ProgRunner.Config
{
    public class ProcessesConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("processes")]
        public ProcessConfigurationCollection Processes
        {
            get
            {
                return base["processes"] as ProcessConfigurationCollection;
            }
        }
    }
}
