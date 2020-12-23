using Caongur_2._0.Atributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Caongur_2._0
{
     public partial class Form1 : Form
     {
          Graphics DrawArea;
          //List<string> Path;
          //Point[] CoordinatePath;

          Game game;
          Level Level1;

          public Form1()
          {
               InitializeComponent();
               MainRadBut.Checked = true;
               DrawArea = DrawingArea.CreateGraphics();

               Line[] Level1Lines =
               {
                    new Line(new Point(10,10),new Point(160,10)),
                    new Line(new Point(160,10),new Point(160,160)),
                    new Line(new Point(160,160),new Point(10,160)),
                    new Line(new Point(10,160),new Point(10,10)),
                    new Line(new Point(110,10),new Point(110,60)),
                    new Line(new Point(110,60),new Point(160,60)),
                    new Line(new Point(160,110),new Point(110,110)),
                    new Line(new Point(110,110),new Point(110,160)),
                    new Line(new Point(60,160),new Point(60,110)),
                    new Line(new Point(60,110),new Point(10,110)),
                    new Line(new Point(10,60),new Point(60,60)),
                    new Line(new Point(60,60),new Point(60,10))
               };

               Level1 = new Level(Level1Lines,200);
               game = new Game(Level1);
          }

          private void FillListBox(string field)
          {
               if (MainRadBut.Checked)
               {
                    Main.Items.Add(field);
               }
               else if (Proc1RadBut.Checked)
               {
                    Proc1.Items.Add(field);
               }
               else if (Proc2RadBut.Checked)
               {
                    Proc2.Items.Add(field);
               }
          }

          private List<string> GetPath()
          {
               List<string> temp = new List<string>();
               List<string> temp1;
               string[] t = new string[Main.Items.Count];
               bool crit = true;
               Main.Items.CopyTo(t, 0);
               temp.AddRange(t);
               while(crit)
               {
                    crit = false;
                    temp1 = new List<string>();
                    foreach(string s in temp)
                    {
                         switch (s)
                         {
                              case "Proc1":
                                   t = new string[Proc1.Items.Count];
                                   Proc1.Items.CopyTo(t, 0);
                                   temp1.AddRange(t);
                                   crit = true;
                                   break;
                              case "Proc2":
                                   t = new string[Proc2.Items.Count];
                                   Proc2.Items.CopyTo(t, 0);
                                   temp1.AddRange(t);
                                   crit = true;
                                   break;
                              default:
                                   temp1.Add(s);
                                   break;
                         }
                    }
                    temp = temp1;
               }
               return temp;
          }

          private void StepButton_Click(object sender, EventArgs e)
          {
               FillListBox("Step");
          }

          private void JumpButton_Click(object sender, EventArgs e)
          {
               FillListBox("Jump");
          }

          private void RotationButton_Click(object sender, EventArgs e)
          {
               FillListBox("Rotate");
          }

          private void Proc1Button_Click(object sender, EventArgs e)
          {
               FillListBox("Proc1");
          }

          private void Proc2Button_Click(object sender, EventArgs e)
          {
               FillListBox("Proc2");
          }

          private void DeleteButton_Click(object sender, EventArgs e)
          {
               int indx;
               if (Main.Items.Count > 0 && MainRadBut.Checked)
               {
                    indx = Main.SelectedIndex;
                    if (indx != -1)
                         Main.Items.RemoveAt(indx);
                    else
                         Main.Items.RemoveAt(Main.Items.Count-1);
               }
               else if (Proc1.Items.Count > 0 && Proc1RadBut.Checked)
               {
                    indx = Proc1.SelectedIndex;
                    if (indx != -1)
                         Proc1.Items.RemoveAt(indx);
                    else
                         Proc1.Items.RemoveAt(Proc1.Items.Count - 1);
               }
               else if (Proc2.Items.Count > 0 && Proc2RadBut.Checked)
               {
                    indx = Proc2.SelectedIndex;
                    if (indx != -1)
                         Proc2.Items.RemoveAt(indx);
                    else
                         Proc2.Items.RemoveAt(Proc2.Items.Count - 1);
               }
          }

          private void Main_Click(object sender, EventArgs e)
          {
               MainRadBut.Checked = true;
          }

          private void Proc1_Click(object sender, EventArgs e)
          {
               Proc1RadBut.Checked = true;
          }

          private void Proc2_Click(object sender, EventArgs e)
          {
               Proc2RadBut.Checked = true;
          }

          private void PlayButton_Click(object sender, EventArgs e)
          {
               game.Reload();
               List<string> path = GetPath();
               game.SetPath(path);
               if (path.Count > 0 && PlayAnimated.Checked == true)
                    GameMoveTimer.Enabled = true;
               if(PlayAnimated.Checked == false)
               {
                    for (int i = 0; i < path.Count; i++)
                    {
                         game.Move();
                    }
                    DrawingArea.Invalidate();
                    if (game.LevelCompleted())
                    {
                         MessageBox.Show("Level Completed");
                    }
               }
          }

          private void DrawingArea_Paint(object sender, PaintEventArgs e)
          {
               game.Draw(DrawArea);
          }

          private void ClearButton_Click(object sender, EventArgs e)
          {
               if (MainRadBut.Checked)
               {
                    Main.Items.Clear();
               }
               else if (Proc1RadBut.Checked)
               {
                    Proc1.Items.Clear();
               }
               else if (Proc2RadBut.Checked)
               {
                    Proc2.Items.Clear();
               }
          }

          private void StopButton_Click(object sender, EventArgs e)
          {
               GameMoveTimer.Enabled = false;
               game.Reload();
               DrawingArea.Invalidate();
          }

          private void GameMoveTimer_Tick(object sender, EventArgs e)
          {
               var Continue = game.Move();
               if (Continue)
               {
                    DrawingArea.Invalidate();
               }
               else
               {
                    GameMoveTimer.Enabled = false;
               }
               
               if (game.LevelCompleted())
               {
                    MessageBox.Show("Level Complited");
               }
          }
     }
}
