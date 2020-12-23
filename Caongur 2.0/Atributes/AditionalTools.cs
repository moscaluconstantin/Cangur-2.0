using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Caongur_2._0.Atributes
{
     class AditionalTools
     {
          private static int Dim = 10;
          public static Line[] GetLinesByPath(List<string> Path)
          {
               List<Line> lines = new List<Line>();
               Point Location = new Point(0, 0);

               int Step = 10;
               int Orientation = 0;
               int XDep = 1;
               int YDep = 0;
               foreach (string step in Path)
               {
                    switch (step)
                    {
                         case "Step":
                              Point temp = Location;
                              Location.X += XDep * Step;
                              Location.Y += YDep * Step;
                              lines.Add(new Line(temp, Location));
                              break;
                         case "Jump":
                              Location.X += XDep * Step;
                              Location.Y += YDep * Step;
                              break;
                         case "Rotate":
                              Orientation = (Orientation + 1) % 4;
                              switch (Orientation)
                              {
                                   case 0:
                                        XDep = 1;
                                        YDep = 0;
                                        break;
                                   case 1:
                                        XDep = 0;
                                        YDep = 1;
                                        break;
                                   case 2:
                                        XDep = -1;
                                        YDep = 0;
                                        break;
                                   case 3:
                                        XDep = 0;
                                        YDep = -1;
                                        break;
                                   default: break;
                              }
                              break;
                         default: break;
                    }
               }
               return lines.ToArray();
          }
          public static Line[] SplitLines(Line[] LinesToSplit)
          {
               List<Line> lines = new List<Line>();
               foreach(Line line in LinesToSplit)
               {
                    lines.AddRange(SplitLine(line));
               }
               return lines.ToArray();
          }
          public static bool SameLines(Line line1, Line line2)
          {
               if(SamePoints(line1.Start,line2.Start) && SamePoints(line1.End, line2.End))
               {
                    return true;
               }else if(SamePoints(line1.Start, line2.End) && SamePoints(line1.End, line2.Start))
               {
                    return true;
               }

               return false;
          }
          private static bool SamePoints(Point point1, Point point2)
          {
               if (point1.X == point2.X && point1.Y == point2.Y)
                    return true;
               return false;
          }
          private static Line[] SplitLine(Line LineToSplit)
          {
               Line[] lines;
               int[] SplitedRange;
               if( Math.Abs(LineToSplit.End.X-LineToSplit.Start.X)/Dim > 1)
               {
                    SplitedRange = SplitRange(LineToSplit.Start.X, LineToSplit.End.X);
                    lines = new Line[SplitedRange.Length-1];
                    for (int i = 0; i < lines.Length; i++)
                    {
                         lines[i] = new Line(new Point(SplitedRange[i], LineToSplit.Start.Y), 
                              new Point(SplitedRange[i + 1], LineToSplit.Start.Y));
                    }
               }else if(Math.Abs(LineToSplit.End.Y - LineToSplit.Start.Y) / Dim > 1)
               {
                    SplitedRange = SplitRange(LineToSplit.Start.Y, LineToSplit.End.Y);
                    lines = new Line[SplitedRange.Length - 1];
                    for (int i = 0; i < lines.Length; i++)
                    {
                         lines[i] = new Line(new Point(LineToSplit.Start.X, SplitedRange[i]), 
                              new Point(LineToSplit.Start.X, SplitedRange[i + 1]));
                    }
               }
               else
               {
                    lines = new Line[1];
                    lines[0] = LineToSplit;
               }
               return lines;
          }
          private static int[] SplitRange(int Begin, int End)
          {
               int RangeLength = Math.Abs(End - Begin) / Dim;
               int[] newRange = new int[RangeLength + 1];
               int temp = Math.Min(Begin, End);
               for (int i = 0; i < newRange.Length; i++)
               {
                    newRange[i] = temp;
                    temp += Dim;
               }
               return newRange;
          }
     }
}
