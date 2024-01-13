
namespace Minesweeper_GUI
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.list_LegendScores = new System.Windows.Forms.ListBox();
            this.btn_SaveHighScores = new System.Windows.Forms.Button();
            this.btn_ReturnToGame = new System.Windows.Forms.Button();
            this.list_TodayScores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(729, 458);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Time High Scores";
            // 
            // list_LegendScores
            // 
            this.list_LegendScores.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.list_LegendScores.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_LegendScores.ForeColor = System.Drawing.Color.Gold;
            this.list_LegendScores.FormattingEnabled = true;
            this.list_LegendScores.ItemHeight = 29;
            this.list_LegendScores.Location = new System.Drawing.Point(187, 529);
            this.list_LegendScores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_LegendScores.Name = "list_LegendScores";
            this.list_LegendScores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list_LegendScores.Size = new System.Drawing.Size(1530, 381);
            this.list_LegendScores.TabIndex = 1;
            // 
            // btn_SaveHighScores
            // 
            this.btn_SaveHighScores.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_SaveHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveHighScores.Location = new System.Drawing.Point(633, 922);
            this.btn_SaveHighScores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SaveHighScores.Name = "btn_SaveHighScores";
            this.btn_SaveHighScores.Size = new System.Drawing.Size(294, 65);
            this.btn_SaveHighScores.TabIndex = 3;
            this.btn_SaveHighScores.Text = "Save High Scores";
            this.btn_SaveHighScores.UseVisualStyleBackColor = false;
            this.btn_SaveHighScores.Click += new System.EventHandler(this.btn_SaveHighScores_Click);
            // 
            // btn_ReturnToGame
            // 
            this.btn_ReturnToGame.BackColor = System.Drawing.Color.IndianRed;
            this.btn_ReturnToGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReturnToGame.Location = new System.Drawing.Point(936, 922);
            this.btn_ReturnToGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ReturnToGame.Name = "btn_ReturnToGame";
            this.btn_ReturnToGame.Size = new System.Drawing.Size(294, 65);
            this.btn_ReturnToGame.TabIndex = 2;
            this.btn_ReturnToGame.Text = "Return to Game";
            this.btn_ReturnToGame.UseVisualStyleBackColor = false;
            this.btn_ReturnToGame.Click += new System.EventHandler(this.btn_ReturnToGame_Click);
            // 
            // list_TodayScores
            // 
            this.list_TodayScores.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.list_TodayScores.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_TodayScores.ForeColor = System.Drawing.Color.Lime;
            this.list_TodayScores.FormattingEnabled = true;
            this.list_TodayScores.ItemHeight = 29;
            this.list_TodayScores.Location = new System.Drawing.Point(187, 78);
            this.list_TodayScores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_TodayScores.Name = "list_TodayScores";
            this.list_TodayScores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list_TodayScores.Size = new System.Drawing.Size(1530, 381);
            this.list_TodayScores.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(734, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 65);
            this.label2.TabIndex = 5;
            this.label2.Text = "Today\'s High Scores";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minesweeper_GUI.Properties.Resources.galaxy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1880, 1005);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_TodayScores);
            this.Controls.Add(this.btn_SaveHighScores);
            this.Controls.Add(this.btn_ReturnToGame);
            this.Controls.Add(this.list_LegendScores);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineSweeper - High Scores";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_LegendScores;
        private System.Windows.Forms.Button btn_SaveHighScores;
        private System.Windows.Forms.Button btn_ReturnToGame;
        private System.Windows.Forms.ListBox list_TodayScores;
        private System.Windows.Forms.Label label2;
    }
}