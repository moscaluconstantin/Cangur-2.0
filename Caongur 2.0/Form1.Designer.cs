namespace Caongur_2._0
{
     partial class Form1
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               this.Main = new System.Windows.Forms.ListBox();
               this.Proc1 = new System.Windows.Forms.ListBox();
               this.Proc2 = new System.Windows.Forms.ListBox();
               this.DrawingArea = new System.Windows.Forms.Panel();
               this.StepButton = new System.Windows.Forms.Button();
               this.JumpButton = new System.Windows.Forms.Button();
               this.RotationButton = new System.Windows.Forms.Button();
               this.Proc1Button = new System.Windows.Forms.Button();
               this.Proc2Button = new System.Windows.Forms.Button();
               this.MainRadBut = new System.Windows.Forms.RadioButton();
               this.Proc1RadBut = new System.Windows.Forms.RadioButton();
               this.Proc2RadBut = new System.Windows.Forms.RadioButton();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.DeleteButton = new System.Windows.Forms.Button();
               this.StopButton = new System.Windows.Forms.Button();
               this.PlayButton = new System.Windows.Forms.Button();
               this.ClearButton = new System.Windows.Forms.Button();
               this.GameMoveTimer = new System.Windows.Forms.Timer(this.components);
               this.PlayAnimated = new System.Windows.Forms.CheckBox();
               this.SuspendLayout();
               // 
               // Main
               // 
               this.Main.FormattingEnabled = true;
               this.Main.Location = new System.Drawing.Point(12, 38);
               this.Main.Name = "Main";
               this.Main.Size = new System.Drawing.Size(76, 251);
               this.Main.TabIndex = 0;
               this.Main.Click += new System.EventHandler(this.Main_Click);
               // 
               // Proc1
               // 
               this.Proc1.FormattingEnabled = true;
               this.Proc1.Location = new System.Drawing.Point(94, 38);
               this.Proc1.Name = "Proc1";
               this.Proc1.Size = new System.Drawing.Size(76, 251);
               this.Proc1.TabIndex = 1;
               this.Proc1.Click += new System.EventHandler(this.Proc1_Click);
               // 
               // Proc2
               // 
               this.Proc2.FormattingEnabled = true;
               this.Proc2.Location = new System.Drawing.Point(176, 38);
               this.Proc2.Name = "Proc2";
               this.Proc2.Size = new System.Drawing.Size(76, 251);
               this.Proc2.TabIndex = 2;
               this.Proc2.Click += new System.EventHandler(this.Proc2_Click);
               // 
               // DrawingArea
               // 
               this.DrawingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.DrawingArea.Location = new System.Drawing.Point(258, 38);
               this.DrawingArea.Name = "DrawingArea";
               this.DrawingArea.Size = new System.Drawing.Size(553, 253);
               this.DrawingArea.TabIndex = 3;
               this.DrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingArea_Paint);
               // 
               // StepButton
               // 
               this.StepButton.Location = new System.Drawing.Point(260, 297);
               this.StepButton.Name = "StepButton";
               this.StepButton.Size = new System.Drawing.Size(75, 23);
               this.StepButton.TabIndex = 4;
               this.StepButton.Text = "Step";
               this.StepButton.UseVisualStyleBackColor = true;
               this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
               // 
               // JumpButton
               // 
               this.JumpButton.Location = new System.Drawing.Point(341, 297);
               this.JumpButton.Name = "JumpButton";
               this.JumpButton.Size = new System.Drawing.Size(75, 23);
               this.JumpButton.TabIndex = 5;
               this.JumpButton.Text = "Jump";
               this.JumpButton.UseVisualStyleBackColor = true;
               this.JumpButton.Click += new System.EventHandler(this.JumpButton_Click);
               // 
               // RotationButton
               // 
               this.RotationButton.Location = new System.Drawing.Point(422, 297);
               this.RotationButton.Name = "RotationButton";
               this.RotationButton.Size = new System.Drawing.Size(75, 23);
               this.RotationButton.TabIndex = 6;
               this.RotationButton.Text = "Rotate";
               this.RotationButton.UseVisualStyleBackColor = true;
               this.RotationButton.Click += new System.EventHandler(this.RotationButton_Click);
               // 
               // Proc1Button
               // 
               this.Proc1Button.Location = new System.Drawing.Point(503, 297);
               this.Proc1Button.Name = "Proc1Button";
               this.Proc1Button.Size = new System.Drawing.Size(75, 23);
               this.Proc1Button.TabIndex = 7;
               this.Proc1Button.Text = "Proc1";
               this.Proc1Button.UseVisualStyleBackColor = true;
               this.Proc1Button.Click += new System.EventHandler(this.Proc1Button_Click);
               // 
               // Proc2Button
               // 
               this.Proc2Button.Location = new System.Drawing.Point(584, 297);
               this.Proc2Button.Name = "Proc2Button";
               this.Proc2Button.Size = new System.Drawing.Size(75, 23);
               this.Proc2Button.TabIndex = 8;
               this.Proc2Button.Text = "Proc2";
               this.Proc2Button.UseVisualStyleBackColor = true;
               this.Proc2Button.Click += new System.EventHandler(this.Proc2Button_Click);
               // 
               // MainRadBut
               // 
               this.MainRadBut.AutoSize = true;
               this.MainRadBut.Location = new System.Drawing.Point(41, 302);
               this.MainRadBut.Name = "MainRadBut";
               this.MainRadBut.Size = new System.Drawing.Size(14, 13);
               this.MainRadBut.TabIndex = 9;
               this.MainRadBut.TabStop = true;
               this.MainRadBut.UseVisualStyleBackColor = true;
               // 
               // Proc1RadBut
               // 
               this.Proc1RadBut.AutoSize = true;
               this.Proc1RadBut.Location = new System.Drawing.Point(123, 302);
               this.Proc1RadBut.Name = "Proc1RadBut";
               this.Proc1RadBut.Size = new System.Drawing.Size(14, 13);
               this.Proc1RadBut.TabIndex = 10;
               this.Proc1RadBut.TabStop = true;
               this.Proc1RadBut.UseVisualStyleBackColor = true;
               // 
               // Proc2RadBut
               // 
               this.Proc2RadBut.AutoSize = true;
               this.Proc2RadBut.Location = new System.Drawing.Point(204, 302);
               this.Proc2RadBut.Name = "Proc2RadBut";
               this.Proc2RadBut.Size = new System.Drawing.Size(14, 13);
               this.Proc2RadBut.TabIndex = 11;
               this.Proc2RadBut.TabStop = true;
               this.Proc2RadBut.UseVisualStyleBackColor = true;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(25, 12);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(30, 13);
               this.label1.TabIndex = 12;
               this.label1.Text = "Main";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(111, 12);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(35, 13);
               this.label2.TabIndex = 13;
               this.label2.Text = "Proc1";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(192, 12);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(35, 13);
               this.label3.TabIndex = 14;
               this.label3.Text = "Proc2";
               // 
               // DeleteButton
               // 
               this.DeleteButton.Location = new System.Drawing.Point(665, 297);
               this.DeleteButton.Name = "DeleteButton";
               this.DeleteButton.Size = new System.Drawing.Size(75, 23);
               this.DeleteButton.TabIndex = 15;
               this.DeleteButton.Text = "Delete";
               this.DeleteButton.UseVisualStyleBackColor = true;
               this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
               // 
               // StopButton
               // 
               this.StopButton.Location = new System.Drawing.Point(416, 12);
               this.StopButton.Name = "StopButton";
               this.StopButton.Size = new System.Drawing.Size(75, 23);
               this.StopButton.TabIndex = 20;
               this.StopButton.Text = "Stop";
               this.StopButton.UseVisualStyleBackColor = true;
               this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
               // 
               // PlayButton
               // 
               this.PlayButton.Location = new System.Drawing.Point(258, 12);
               this.PlayButton.Name = "PlayButton";
               this.PlayButton.Size = new System.Drawing.Size(75, 23);
               this.PlayButton.TabIndex = 16;
               this.PlayButton.Text = "Play";
               this.PlayButton.UseVisualStyleBackColor = true;
               this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
               // 
               // ClearButton
               // 
               this.ClearButton.Location = new System.Drawing.Point(746, 297);
               this.ClearButton.Name = "ClearButton";
               this.ClearButton.Size = new System.Drawing.Size(75, 23);
               this.ClearButton.TabIndex = 21;
               this.ClearButton.Text = "Clear";
               this.ClearButton.UseVisualStyleBackColor = true;
               this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
               // 
               // GameMoveTimer
               // 
               this.GameMoveTimer.Interval = 300;
               this.GameMoveTimer.Tick += new System.EventHandler(this.GameMoveTimer_Tick);
               // 
               // PlayAnimated
               // 
               this.PlayAnimated.AutoSize = true;
               this.PlayAnimated.Location = new System.Drawing.Point(340, 15);
               this.PlayAnimated.Name = "PlayAnimated";
               this.PlayAnimated.Size = new System.Drawing.Size(70, 17);
               this.PlayAnimated.TabIndex = 22;
               this.PlayAnimated.Text = "Animated";
               this.PlayAnimated.UseVisualStyleBackColor = true;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(833, 332);
               this.Controls.Add(this.PlayAnimated);
               this.Controls.Add(this.ClearButton);
               this.Controls.Add(this.StopButton);
               this.Controls.Add(this.DeleteButton);
               this.Controls.Add(this.PlayButton);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.Proc2RadBut);
               this.Controls.Add(this.Proc1RadBut);
               this.Controls.Add(this.MainRadBut);
               this.Controls.Add(this.Proc2Button);
               this.Controls.Add(this.Proc1Button);
               this.Controls.Add(this.RotationButton);
               this.Controls.Add(this.JumpButton);
               this.Controls.Add(this.StepButton);
               this.Controls.Add(this.DrawingArea);
               this.Controls.Add(this.Proc2);
               this.Controls.Add(this.Proc1);
               this.Controls.Add(this.Main);
               this.Name = "Form1";
               this.Text = "Form1";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ListBox Main;
          private System.Windows.Forms.ListBox Proc1;
          private System.Windows.Forms.ListBox Proc2;
          private System.Windows.Forms.Panel DrawingArea;
          private System.Windows.Forms.Button StepButton;
          private System.Windows.Forms.Button JumpButton;
          private System.Windows.Forms.Button RotationButton;
          private System.Windows.Forms.Button Proc1Button;
          private System.Windows.Forms.Button Proc2Button;
          private System.Windows.Forms.RadioButton MainRadBut;
          private System.Windows.Forms.RadioButton Proc1RadBut;
          private System.Windows.Forms.RadioButton Proc2RadBut;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Button DeleteButton;
          private System.Windows.Forms.Button StopButton;
          private System.Windows.Forms.Button PlayButton;
          private System.Windows.Forms.Button ClearButton;
          private System.Windows.Forms.Timer GameMoveTimer;
          private System.Windows.Forms.CheckBox PlayAnimated;
     }
}

