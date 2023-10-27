using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCaptcha
{
    internal class Letter
    {

        public int Angle { get; set; }

        public string Value { get; set; }

        public SKColor ForeColor { get; set; }

        public string Family { get; set; }

    }
}
