namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            Player1_score = new TextBox();
            Player2_score = new TextBox();
            Player1_label = new Label();
            Player2_label = new Label();
            Turn_label = new Label();
            Turn_box = new TextBox();
            Reset_button = new Button();
            Play_again_button = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 32);
            button1.Name = "button1";
            button1.Size = new Size(89, 79);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(107, 32);
            button2.Name = "button2";
            button2.Size = new Size(89, 79);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(202, 32);
            button3.Name = "button3";
            button3.Size = new Size(89, 79);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 117);
            button4.Name = "button4";
            button4.Size = new Size(89, 79);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(107, 117);
            button5.Name = "button5";
            button5.Size = new Size(89, 79);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(202, 117);
            button6.Name = "button6";
            button6.Size = new Size(89, 79);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 202);
            button7.Name = "button7";
            button7.Size = new Size(89, 79);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(107, 202);
            button8.Name = "button8";
            button8.Size = new Size(89, 79);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(202, 202);
            button9.Name = "button9";
            button9.Size = new Size(89, 79);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button_Click;
            // 
            // Player1_score
            // 
            Player1_score.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Player1_score.Location = new Point(337, 117);
            Player1_score.Multiline = true;
            Player1_score.Name = "Player1_score";
            Player1_score.ReadOnly = true;
            Player1_score.Size = new Size(89, 49);
            Player1_score.TabIndex = 9;
            Player1_score.TextAlign = HorizontalAlignment.Center;
            // 
            // Player2_score
            // 
            Player2_score.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Player2_score.Location = new Point(491, 117);
            Player2_score.Multiline = true;
            Player2_score.Name = "Player2_score";
            Player2_score.ReadOnly = true;
            Player2_score.Size = new Size(89, 49);
            Player2_score.TabIndex = 10;
            Player2_score.TextAlign = HorizontalAlignment.Center;
            // 
            // Player1_label
            // 
            Player1_label.AutoSize = true;
            Player1_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Player1_label.Location = new Point(337, 89);
            Player1_label.Name = "Player1_label";
            Player1_label.Size = new Size(83, 25);
            Player1_label.TabIndex = 11;
            Player1_label.Text = "Player 1";
            // 
            // Player2_label
            // 
            Player2_label.AutoSize = true;
            Player2_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Player2_label.Location = new Point(491, 89);
            Player2_label.Name = "Player2_label";
            Player2_label.Size = new Size(83, 25);
            Player2_label.TabIndex = 12;
            Player2_label.Text = "Player 2";
            // 
            // Turn_label
            // 
            Turn_label.AutoSize = true;
            Turn_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Turn_label.Location = new Point(347, 32);
            Turn_label.Name = "Turn_label";
            Turn_label.Size = new Size(54, 25);
            Turn_label.TabIndex = 13;
            Turn_label.Text = "Turn";
            // 
            // Turn_box
            // 
            Turn_box.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Turn_box.Location = new Point(407, 29);
            Turn_box.Name = "Turn_box";
            Turn_box.ReadOnly = true;
            Turn_box.Size = new Size(144, 33);
            Turn_box.TabIndex = 14;
            Turn_box.Text = "Player One (X)";
            // 
            // Reset_button
            // 
            Reset_button.Location = new Point(470, 193);
            Reset_button.Name = "Reset_button";
            Reset_button.Size = new Size(124, 79);
            Reset_button.TabIndex = 15;
            Reset_button.Text = "Reset";
            Reset_button.UseVisualStyleBackColor = true;
            Reset_button.Click += Reset_button_Click;
            // 
            // Play_again_button
            // 
            Play_again_button.Location = new Point(320, 193);
            Play_again_button.Name = "Play_again_button";
            Play_again_button.Size = new Size(124, 79);
            Play_again_button.TabIndex = 16;
            Play_again_button.Text = "Play again";
            Play_again_button.UseVisualStyleBackColor = true;
            Play_again_button.Click += Play_again_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 317);
            Controls.Add(Play_again_button);
            Controls.Add(Reset_button);
            Controls.Add(Turn_box);
            Controls.Add(Turn_label);
            Controls.Add(Player2_label);
            Controls.Add(Player1_label);
            Controls.Add(Player2_score);
            Controls.Add(Player1_score);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox Player1_score;
        private TextBox Player2_score;
        private Label Player1_label;
        private Label Player2_label;
        private Label Turn_label;
        private TextBox Turn_box;
        private Button Reset_button;
        private Button Play_again_button;
    }
}