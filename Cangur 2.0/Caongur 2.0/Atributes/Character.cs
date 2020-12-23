using System.Drawing;

namespace Caongur_2._0.Atributes
{
     class Character
     {
          Point Location;
          Point OrLocation;
          Point Dep;
          int Orientation;
          int Dim;
          public Character(int newDim)
          {
               Dim = newDim / 2;
               Location = new Point(0, 0);
               OrLocation = new Point(Location.X + Dim, Location.Y);
               Orientation = 0;
               Dep = new Point(1, 0);
          }
          public void Rotate()
          {
               Orientation++;
               Orientation = Orientation % 4;
               switch (Orientation)
               {
                    case 0:
                         Dep = new Point(1, 0);
                         OrLocation = Location;
                         OrLocation.X += Dim;
                         break;
                    case 1:
                         Dep = new Point(0, 1);
                         OrLocation = Location;
                         OrLocation.Y += Dim;
                         break;
                    case 2:
                         Dep = new Point(-1, 0);
                         OrLocation = Location;
                         OrLocation.X -= Dim;
                         break;
                    case 3:
                         Dep = new Point(0, -1);
                         OrLocation = Location;
                         OrLocation.Y -= Dim;
                         break;
                    default:
                         Dep = new Point(1, 0);
                         OrLocation = Location;
                         OrLocation.X += Dim;
                         break;
               }
          }
          public Line Step()
          {
               Point temp = Location;
               Jump();
               return new Line(temp, Location);
          }
          public void Jump()
          {
               if(Location.X + Dep.X * Dim * 2<= 553 && Location.Y + Dep.Y * Dim * 2<= 253 &&
                    Location.X + Dep.X * Dim * 2 >= 0 && Location.Y + Dep.Y * Dim * 2 >= 0)
               {
                    Point diff = new Point(OrLocation.X - Location.X, OrLocation.Y - Location.Y);
                    Location.X += Dep.X * Dim * 2;
                    Location.Y += Dep.Y * Dim * 2;
                    OrLocation = new Point(Location.X + diff.X, Location.Y + diff.Y);
               }
          }
          
          public void Draw(Graphics Gr)
          {
               Brush brush = new SolidBrush(Color.Blue);
               Gr.FillEllipse(brush, Location.X - Dim, Location.Y - Dim, Dim * 2, Dim * 2);
               Gr.DrawLine(Pens.Black, Location, OrLocation);
          }
     }
}