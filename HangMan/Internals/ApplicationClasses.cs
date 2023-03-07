using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Internals
{
    internal class HangmanAnatomy
    {
        internal int AnatomyLineNumber { get; set; }
        internal string AnatomyName { get; set; }
        internal Point LineStartPoint { get; set; }
        internal Point LineEndPoint { get; set; }
    }
}
