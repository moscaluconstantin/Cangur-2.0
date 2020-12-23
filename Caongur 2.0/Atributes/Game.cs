using System;
using System.Collections.Generic;
using System.Drawing;

namespace Caongur_2._0.Atributes
{
     class Game
     {
          Character character;
          Level level;
          List<string> Path;
          Line[] Lines;
          static int PathIndx;
          int Dim;
          public Game(Level setLevel)
          {
               Dim = 10;
               level = setLevel;
               Reload();
          }
          public void SetPath(List<string> newPath)
          {
               Path = newPath;
          }
          public bool Move()
          {
               bool Mooved = false;
               if (PathIndx < Path.Count)
               {
                    switch (Path[PathIndx])
                    {
                         case "Step":
                              Line newLine = character.Step();
                              var temp = new List<Line>();
                              if (Lines[0] != null)
                                   temp.AddRange(Lines);
                              temp.Add(newLine);
                              Lines = temp.ToArray();
                              break;
                         case "Jump":
                              character.Jump();
                              break;
                         case "Rotate":
                              character.Rotate();
                              break;
                         default: break;
                    }
                    Mooved = true;
                    PathIndx++;
               }
               return Mooved;
          }
          public void Reload()
          {
               PathIndx = 0;
               character = new Character(Dim);
               Lines = new Line[1];
          }
          public bool LevelCompleted()
          {
               bool found;
               if (Path.Count > level.Commands)
                    return false;

               if (Lines.Length != level.Lines.Length)
                    return false;

               foreach (Line PathLine in Lines)
               {
                    found = false;
                    foreach (Line LevelLine in level.Lines)
                    {
                         if (AditionalTools.SameLines(PathLine, LevelLine))
                         {
                              found = true;
                              break;
                         }
                    }
                    if (found == false)
                    {
                         return false;
                    }
               }
               return true;
          }
          public string GameResult()
          {
               return "Result";
          }
          void DrawBackGround(Graphics Gr)
          {
               for (int i = 0; i < 56; i++)
               {
                    if (i < 26)
                    {
                         Gr.DrawLine(Pens.Gray, 0, i * Dim, 553, i * Dim);
                    }
                    if (i < 56)
                    {
                         Gr.DrawLine(Pens.Gray, i * Dim, 0, i * Dim, 253);
                    }
               }
          }
          public void Draw(Graphics Gr)
          {
               DrawBackGround(Gr);
               try
               {
                    level.Draw(Gr);
                    Pen p = new Pen(Color.Black, 2);
                    foreach (Line line in Lines)
                    {
                         if(line != null)
                         {
                              Gr.DrawLine(p, line.Start, line.End);
                         }
                    }
                    character.Draw(Gr);
               }
               catch (Exception ex) { }
          }
     }
}
