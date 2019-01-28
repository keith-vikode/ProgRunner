using System.Configuration;

namespace ProgRunner.Config
{
    public class ProcessConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get => this["name"] as string;
            set => this["name"] = value;
        }

        [ConfigurationProperty("file", IsRequired = true)]
        public string FileName
        {
            get => this["file"] as string;
            set => this["file"] = value;
        }

        [ConfigurationProperty("args", IsRequired = false)]
        public string Arguments
        {
            get => this["args"] as string;
            set => this["args"] = value;
        }
    }
}
