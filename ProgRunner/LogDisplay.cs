using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgRunner
{
    public partial class LogDisplay : UserControl
    {
        public LogDisplay()
        {
            InitializeComponent();
        }

        public const int MaxItems = 10000;

        public void AddItem(string text)
        {
            while (InnerList.Items.Count >= MaxItems)
            {
                InnerList.Items.RemoveAt(0);
            }

            InnerList.Items.Add(text);
            InnerList.SelectedIndex = InnerList.Items.Count - 1;
        }

        public void Clear()
        {
            InnerList.Items.Clear();
        }

        public string GetText()
        {
            var sb = new StringBuilder();
            foreach (var item in InnerList.Items)
            {
                sb.AppendLine(item as string);
            }

            return sb.ToString();
        }
    }
}
