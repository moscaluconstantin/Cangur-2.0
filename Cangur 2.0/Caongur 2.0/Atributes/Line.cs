using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Caongur_2._0.Atributes
{
     class Line
     {
          Point _Start;
          Point _End;
          public Line(Point s, Point e)
          {
               _Start = s;
               _End = e;
          }
          public Point Start { get { return _Start; } }
          public Point End { get { return _End; } }
     }
}
