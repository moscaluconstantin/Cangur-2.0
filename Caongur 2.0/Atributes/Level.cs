using System.Collections.Generic;
using System.Drawing;

namespace Caongur_2._0.Atributes
{
     class Level
     {
          public Line[] Lines;
          int _Commands;
          public Level(Line[] lines, int commands)
          {
               _Commands = commands;
               Lines = AditionalTools.SplitLines(lines);
          }
          public void Draw(Graphics Gr)
          {
               Pen p = new Pen(Color.Red, 3);
               foreach(Line line in Lines)
               {
                    Gr.DrawLine(p, line.Start, line.End);
               }    
          }
          public int Commands { get { return _Commands; }}
     }
}
