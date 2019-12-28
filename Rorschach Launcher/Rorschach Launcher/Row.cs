using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Rorschach_Launcher
{
    class Row
    {
        public Image Image { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Frame { get; set; }
        [Browsable(false)] public string AudioTime { get; set; }
    }
}
