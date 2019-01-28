using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgRunner.Config
{
    [ConfigurationCollection(typeof(ProcessConfigurationElement), AddItemName = "process")]
    public class ProcessConfigurationCollection : ConfigurationElementCollection, IEnumerable<ProcessConfigurationElement>
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ProcessConfigurationElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            if (element is ProcessConfigurationElement p)
            {
                return p.Name;
            }

            return null;
        }

        public ProcessConfigurationElement this[int index]
        {
            get
            {
                return BaseGet(index) as ProcessConfigurationElement;
            }
        }

        IEnumerator<ProcessConfigurationElement> IEnumerable<ProcessConfigurationElement>.GetEnumerator()
        {
            return (from i in Enumerable.Range(0, this.Count)
                    select this[i]).GetEnumerator();
        }
    }
}
