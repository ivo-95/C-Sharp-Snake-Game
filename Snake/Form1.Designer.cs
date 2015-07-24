namespace Snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.game_canvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.high_score_label = new System.Windows.Forms.ToolStripTextBox();
            this.reset_highscore = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_score = new System.Windows.Forms.Label();
            this.label_points = new System.Windows.Forms.Label();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.label_gameOver = new System.Windows.Forms.Label();
            this.label_pause = new System.Windows.Forms.Label();
            this.controls_box = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.game_canvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // game_canvas
            // 
            this.game_canvas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.game_canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game_canvas.Location = new System.Drawing.Point(13, 73);
            this.game_canvas.Margin = new System.Windows.Forms.Padding(4, 64, 4, 4);
            this.game_canvas.Name = "game_canvas";
            this.game_canvas.Size = new System.Drawing.Size(563, 483);
            this.game_canvas.TabIndex = 0;
            this.game_canvas.TabStop = false;
            this.game_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.game_canvas_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.highScoreToolStripMenuItem,
            this.controlsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.info_click);
            // 
            // highScoreToolStripMenuItem
            // 
            this.highScoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.high_score_label,
            this.reset_highscore});
            this.highScoreToolStripMenuItem.Name = "highScoreToolStripMenuItem";
            this.highScoreToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.highScoreToolStripMenuItem.Text = "High Score";
            // 
            // high_score_label
            // 
            this.high_score_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.high_score_label.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.high_score_label.Name = "high_score_label";
            this.high_score_label.ReadOnly = true;
            this.high_score_label.ShortcutsEnabled = false;
            this.high_score_label.Size = new System.Drawing.Size(120, 16);
            // 
            // reset_highscore
            // 
            this.reset_highscore.Name = "reset_highscore";
            this.reset_highscore.Size = new System.Drawing.Size(180, 22);
            this.reset_highscore.Text = "Reset";
            this.reset_highscore.Click += new System.EventHandler(this.reset_click);
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.controlsToolStripMenuItem.Text = "Controls";
            this.controlsToolStripMenuItem.Click += new System.EventHandler(this.controls_click);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_score.Location = new System.Drawing.Point(12, 34);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(81, 30);
            this.label_score.TabIndex = 2;
            this.label_score.Text = "Score:";
            // 
            // label_points
            // 
            this.label_points.AutoSize = true;
            this.label_points.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_points.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_points.Location = new System.Drawing.Point(88, 34);
            this.label_points.Name = "label_points";
            this.label_points.Size = new System.Drawing.Size(26, 30);
            this.label_points.TabIndex = 3;
            this.label_points.Text = "0";
            // 
            // label_gameOver
            // 
            this.label_gameOver.AutoSize = true;
            this.label_gameOver.BackColor = System.Drawing.Color.White;
            this.label_gameOver.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gameOver.ForeColor = System.Drawing.Color.Tomato;
            this.label_gameOver.Location = new System.Drawing.Point(35, 93);
            this.label_gameOver.Name = "label_gameOver";
            this.label_gameOver.Size = new System.Drawing.Size(79, 33);
            this.label_gameOver.TabIndex = 4;
            this.label_gameOver.Text = "label1";
            this.label_gameOver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_gameOver.Visible = false;
            // 
            // label_pause
            // 
            this.label_pause.AutoSize = true;
            this.label_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pause.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_pause.Location = new System.Drawing.Point(201, 38);
            this.label_pause.Name = "label_pause";
            this.label_pause.Size = new System.Drawing.Size(371, 24);
            this.label_pause.TabIndex = 5;
            this.label_pause.Text = "Game is paused. Press Esc to resume.";
            this.label_pause.Visible = false;
            // 
            // controls_box
            // 
            this.controls_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.controls_box.Enabled = false;
            this.controls_box.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controls_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controls_box.Location = new System.Drawing.Point(120, 27);
            this.controls_box.Multiline = true;
            this.controls_box.Name = "controls_box";
            this.controls_box.ReadOnly = true;
            this.controls_box.Size = new System.Drawing.Size(248, 146);
            this.controls_box.TabIndex = 6;
            this.controls_box.Text = "Up - up arrow\r\nDown - down arrow\r\nLeft - left arrow\r\nRight - right arrow\r\nRestart" +
    " - r\r\nPause - Esc";
            this.controls_box.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(590, 567);
            this.Controls.Add(this.controls_box);
            this.Controls.Add(this.label_gameOver);
            this.Controls.Add(this.label_points);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.game_canvas);
            this.Controls.Add(this.label_pause);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form1_keyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pause_key);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.form1_keyUP);
            ((System.ComponentModel.ISupportInitialize)(this.game_canvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox game_canvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoreToolStripMenuItem;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_points;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Label label_gameOver;
        private System.Windows.Forms.ToolStripTextBox high_score_label;
        private System.Windows.Forms.Label label_pause;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.TextBox controls_box;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem reset_highscore;
    }
}

