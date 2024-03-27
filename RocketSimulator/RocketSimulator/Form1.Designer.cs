namespace RocketSimulator
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
            pictureBox1 = new PictureBox();
            backgroundPictureBox = new PictureBox();
            doorPictureBox = new PictureBox();
            tempButton = new PictureBox();
            oxygenButton = new PictureBox();
            doorButton = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            enginePictureBox = new PictureBox();
            oxygenPictureBox = new PictureBox();
            oxygenSensorValue = new ProgressBar();
            heaterPictureBox = new PictureBox();
            temperatureValueBar = new ProgressBar();
            label6 = new Label();
            powerOnBox = new PictureBox();
            powerLevelBar = new ProgressBar();
            label8 = new Label();
            powerLever = new PictureBox();
            label7 = new Label();
            enginePowerSlider = new VScrollBar();
            enginePowerLabel = new Label();
            gameOverLabel = new Label();
            gameOverReasonLabel = new Label();
            newGameButton = new Button();
            missionCompletionProgressBar = new ProgressBar();
            label2 = new Label();
            missionCompletionLabel = new Label();
            speedLabel = new Label();
            label10 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tempButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oxygenButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enginePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oxygenPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heaterPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)powerOnBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)powerLever).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.cockpit;
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(783, 552);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // backgroundPictureBox
            // 
            backgroundPictureBox.Image = Properties.Resources.spaceship;
            backgroundPictureBox.Location = new Point(779, 2);
            backgroundPictureBox.Name = "backgroundPictureBox";
            backgroundPictureBox.Size = new Size(784, 552);
            backgroundPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            backgroundPictureBox.TabIndex = 1;
            backgroundPictureBox.TabStop = false;
            // 
            // doorPictureBox
            // 
            doorPictureBox.BackColor = Color.FromArgb(44, 44, 44);
            doorPictureBox.Image = Properties.Resources.door_closed;
            doorPictureBox.Location = new Point(1016, 200);
            doorPictureBox.Name = "doorPictureBox";
            doorPictureBox.Size = new Size(113, 126);
            doorPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            doorPictureBox.TabIndex = 2;
            doorPictureBox.TabStop = false;
            // 
            // tempButton
            // 
            tempButton.Image = Properties.Resources.button_red;
            tempButton.Location = new Point(305, 294);
            tempButton.Name = "tempButton";
            tempButton.Size = new Size(64, 64);
            tempButton.SizeMode = PictureBoxSizeMode.StretchImage;
            tempButton.TabIndex = 5;
            tempButton.TabStop = false;
            tempButton.Click += tempButton_Click;
            // 
            // oxygenButton
            // 
            oxygenButton.Image = Properties.Resources.button_red;
            oxygenButton.Location = new Point(415, 294);
            oxygenButton.Name = "oxygenButton";
            oxygenButton.Size = new Size(64, 64);
            oxygenButton.SizeMode = PictureBoxSizeMode.StretchImage;
            oxygenButton.TabIndex = 6;
            oxygenButton.TabStop = false;
            oxygenButton.Click += oxygenButton_Click;
            // 
            // doorButton
            // 
            doorButton.Image = Properties.Resources.button_red;
            doorButton.Location = new Point(525, 294);
            doorButton.Name = "doorButton";
            doorButton.Size = new Size(64, 64);
            doorButton.SizeMode = PictureBoxSizeMode.StretchImage;
            doorButton.TabIndex = 7;
            doorButton.TabStop = false;
            doorButton.Click += doorButton_Click;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.MenuBar;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(107, 107, 107);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(197, 271);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 8;
            label1.Text = "Engine";
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.MenuBar;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(107, 107, 107);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(308, 270);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 10;
            label3.Text = "Heater";
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.MenuBar;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(107, 107, 107);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(415, 270);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 11;
            label4.Text = "Oxygen";
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.MenuBar;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(107, 107, 107);
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(535, 270);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 12;
            label5.Text = "Door";
            // 
            // enginePictureBox
            // 
            enginePictureBox.Image = Properties.Resources.engine_off;
            enginePictureBox.Location = new Point(781, 170);
            enginePictureBox.Name = "enginePictureBox";
            enginePictureBox.Size = new Size(99, 191);
            enginePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            enginePictureBox.TabIndex = 13;
            enginePictureBox.TabStop = false;
            // 
            // oxygenPictureBox
            // 
            oxygenPictureBox.Image = Properties.Resources.o2_off;
            oxygenPictureBox.Location = new Point(1305, 200);
            oxygenPictureBox.Name = "oxygenPictureBox";
            oxygenPictureBox.Size = new Size(68, 121);
            oxygenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            oxygenPictureBox.TabIndex = 14;
            oxygenPictureBox.TabStop = false;
            // 
            // oxygenSensorValue
            // 
            oxygenSensorValue.Location = new Point(1365, 232);
            oxygenSensorValue.Name = "oxygenSensorValue";
            oxygenSensorValue.Size = new Size(81, 18);
            oxygenSensorValue.TabIndex = 15;
            // 
            // heaterPictureBox
            // 
            heaterPictureBox.Image = Properties.Resources.heater_off;
            heaterPictureBox.Location = new Point(1193, 257);
            heaterPictureBox.Name = "heaterPictureBox";
            heaterPictureBox.Size = new Size(64, 64);
            heaterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            heaterPictureBox.TabIndex = 16;
            heaterPictureBox.TabStop = false;
            // 
            // temperatureValueBar
            // 
            temperatureValueBar.Location = new Point(1184, 232);
            temperatureValueBar.Name = "temperatureValueBar";
            temperatureValueBar.Size = new Size(88, 23);
            temperatureValueBar.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DimGray;
            label6.Location = new Point(1184, 214);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 18;
            label6.Text = "Temperature";
            // 
            // powerOnBox
            // 
            powerOnBox.Image = Properties.Resources.power_off;
            powerOnBox.Location = new Point(578, 510);
            powerOnBox.Name = "powerOnBox";
            powerOnBox.Size = new Size(23, 23);
            powerOnBox.SizeMode = PictureBoxSizeMode.StretchImage;
            powerOnBox.TabIndex = 19;
            powerOnBox.TabStop = false;
            // 
            // powerLevelBar
            // 
            powerLevelBar.Location = new Point(183, 510);
            powerLevelBar.Name = "powerLevelBar";
            powerLevelBar.Size = new Size(389, 23);
            powerLevelBar.TabIndex = 20;
            // 
            // label8
            // 
            label8.AccessibleRole = AccessibleRole.MenuBar;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(107, 107, 107);
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(183, 477);
            label8.Name = "label8";
            label8.Size = new Size(111, 21);
            label8.TabIndex = 22;
            label8.Text = "Current power";
            // 
            // powerLever
            // 
            powerLever.BackColor = Color.FromArgb(107, 107, 107);
            powerLever.Image = Properties.Resources.power_lever_off;
            powerLever.Location = new Point(332, 376);
            powerLever.Name = "powerLever";
            powerLever.Size = new Size(128, 128);
            powerLever.SizeMode = PictureBoxSizeMode.Zoom;
            powerLever.TabIndex = 23;
            powerLever.TabStop = false;
            powerLever.Click += powerLever_Click;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.MenuBar;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(107, 107, 107);
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(332, 361);
            label7.Name = "label7";
            label7.Size = new Size(92, 21);
            label7.TabIndex = 24;
            label7.Text = "Main Power";
            // 
            // enginePowerSlider
            // 
            enginePowerSlider.LargeChange = 1;
            enginePowerSlider.Location = new Point(213, 304);
            enginePowerSlider.Name = "enginePowerSlider";
            enginePowerSlider.Size = new Size(20, 147);
            enginePowerSlider.TabIndex = 25;
            enginePowerSlider.Value = 100;
            enginePowerSlider.ValueChanged += enginePowerSlider_Scroll;
            // 
            // enginePowerLabel
            // 
            enginePowerLabel.AutoSize = true;
            enginePowerLabel.Location = new Point(236, 436);
            enginePowerLabel.Name = "enginePowerLabel";
            enginePowerLabel.Size = new Size(23, 15);
            enginePowerLabel.TabIndex = 26;
            enginePowerLabel.Text = "0%";
            // 
            // gameOverLabel
            // 
            gameOverLabel.BackColor = Color.Black;
            gameOverLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            gameOverLabel.ForeColor = Color.Red;
            gameOverLabel.Location = new Point(236, 48);
            gameOverLabel.Name = "gameOverLabel";
            gameOverLabel.Size = new Size(306, 65);
            gameOverLabel.TabIndex = 27;
            gameOverLabel.Text = "Spac#hip";
            gameOverLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameOverReasonLabel
            // 
            gameOverReasonLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gameOverReasonLabel.Location = new Point(236, 128);
            gameOverReasonLabel.Name = "gameOverReasonLabel";
            gameOverReasonLabel.Size = new Size(306, 21);
            gameOverReasonLabel.TabIndex = 28;
            gameOverReasonLabel.TextAlign = ContentAlignment.MiddleCenter;
            gameOverReasonLabel.Visible = false;
            // 
            // newGameButton
            // 
            newGameButton.Location = new Point(341, 160);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(92, 23);
            newGameButton.TabIndex = 29;
            newGameButton.Text = "NEW GAME";
            newGameButton.UseVisualStyleBackColor = true;
            newGameButton.Click += newGameButton_Click;
            // 
            // missionCompletionProgressBar
            // 
            missionCompletionProgressBar.Location = new Point(175, 232);
            missionCompletionProgressBar.Maximum = 500;
            missionCompletionProgressBar.Name = "missionCompletionProgressBar";
            missionCompletionProgressBar.Size = new Size(426, 23);
            missionCompletionProgressBar.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 214);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 31;
            label2.Text = "Completed planets";
            // 
            // missionCompletionLabel
            // 
            missionCompletionLabel.AutoSize = true;
            missionCompletionLabel.Location = new Point(288, 214);
            missionCompletionLabel.Name = "missionCompletionLabel";
            missionCompletionLabel.Size = new Size(16, 15);
            missionCompletionLabel.TabIndex = 32;
            missionCompletionLabel.Text = "   ";
            // 
            // speedLabel
            // 
            speedLabel.BackColor = Color.FromArgb(107, 107, 107);
            speedLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            speedLabel.ForeColor = Color.Lime;
            speedLabel.Location = new Point(471, 423);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(100, 23);
            speedLabel.TabIndex = 33;
            speedLabel.Text = "0km/h";
            speedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(107, 107, 107);
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(490, 402);
            label10.Name = "label10";
            label10.Size = new Size(61, 21);
            label10.TabIndex = 34;
            label10.Text = "Speed:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DimGray;
            label9.Location = new Point(1365, 214);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 35;
            label9.Text = "Ship oxygen level";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1565, 555);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(speedLabel);
            Controls.Add(missionCompletionLabel);
            Controls.Add(label2);
            Controls.Add(missionCompletionProgressBar);
            Controls.Add(newGameButton);
            Controls.Add(gameOverReasonLabel);
            Controls.Add(gameOverLabel);
            Controls.Add(enginePowerLabel);
            Controls.Add(enginePowerSlider);
            Controls.Add(label7);
            Controls.Add(powerLever);
            Controls.Add(label8);
            Controls.Add(powerLevelBar);
            Controls.Add(powerOnBox);
            Controls.Add(label6);
            Controls.Add(temperatureValueBar);
            Controls.Add(heaterPictureBox);
            Controls.Add(oxygenSensorValue);
            Controls.Add(oxygenPictureBox);
            Controls.Add(enginePictureBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(doorButton);
            Controls.Add(oxygenButton);
            Controls.Add(tempButton);
            Controls.Add(doorPictureBox);
            Controls.Add(backgroundPictureBox);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tempButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)oxygenButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)enginePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)oxygenPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)heaterPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)powerOnBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)powerLever).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox backgroundPictureBox;
        private PictureBox doorPictureBox;
        private PictureBox tempButton;
        private PictureBox oxygenButton;
        private PictureBox doorButton;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox enginePictureBox;
        private PictureBox oxygenPictureBox;
        private ProgressBar oxygenSensorValue;
        private PictureBox heaterPictureBox;
        private ProgressBar temperatureValueBar;
        private Label label6;
        private PictureBox powerOnBox;
        private ProgressBar powerLevelBar;
        private Label label8;
        private PictureBox powerLever;
        private Label label7;
        private VScrollBar enginePowerSlider;
        private Label enginePowerLabel;
        private Label gameOverLabel;
        private Label gameOverReasonLabel;
        private Button newGameButton;
        private ProgressBar missionCompletionProgressBar;
        private Label label2;
        private Label missionCompletionLabel;
        private Label speedLabel;
        private Label label10;
        private Label label9;
    }
}