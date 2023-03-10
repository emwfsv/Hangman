using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HangMan.Internals
{
    internal class ApplicationSettings
    {
        internal List<HangmanAnatomy> HangmanAnatomies(int centerOffsetWidth, int centerOffsetBottom)
        {
            var returnList = new List<HangmanAnatomy>()
            {
                new HangmanAnatomy() { AnatomyLineNumber = 0, AnatomyName = "Pole", LineStartPoint = new Point(0 + centerOffsetWidth, centerOffsetBottom), LineEndPoint = new Point(0 + centerOffsetWidth, (centerOffsetBottom / 4) * 1) },
                new HangmanAnatomy() { AnatomyLineNumber = 1, AnatomyName = "UpperPole", LineStartPoint = new Point(0 + centerOffsetWidth, (centerOffsetBottom / 4) * 1), LineEndPoint = new Point(centerOffsetWidth + centerOffsetWidth / 2, (centerOffsetBottom / 4) * 1) },
                new HangmanAnatomy() { AnatomyLineNumber = 2, AnatomyName = "Support", LineStartPoint = new Point(0 + centerOffsetWidth, (centerOffsetBottom / 4) * 2), LineEndPoint = new Point(centerOffsetWidth + centerOffsetWidth / 3, (centerOffsetBottom / 4) * 1) },
                new HangmanAnatomy() { AnatomyLineNumber = 3, AnatomyName = "Rope", LineStartPoint = new Point(centerOffsetWidth + centerOffsetWidth / 2, (centerOffsetBottom / 4) * 1), LineEndPoint = new Point(centerOffsetWidth + centerOffsetWidth / 2, (centerOffsetBottom / 4) * 2) },
            };

            return returnList;
        }
    }
}
