namespace kronometre
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            btnBasla = new Button();
            lblClock = new Label();
            btnStop = new Button();
            btnReset = new Button();
            btnLap = new Button();
            listBox1 = new ListBox();
            lapTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // btnBasla
            // 
            btnBasla.BackgroundImage = Properties.Resources.play1;
            btnBasla.BackgroundImageLayout = ImageLayout.Stretch;
            btnBasla.Location = new Point(134, 193);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(50, 50);
            btnBasla.TabIndex = 0;
            btnBasla.UseVisualStyleBackColor = true;
            btnBasla.Click += btnBasla_Click;
            // 
            // lblClock
            // 
            lblClock.Font = new Font("Segoe UI", 34F);
            lblClock.Location = new Point(12, 66);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(524, 68);
            lblClock.TabIndex = 1;
            lblClock.Text = "00.00.00.00";
            lblClock.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnStop
            // 
            btnStop.BackgroundImage = Properties.Resources.pause11;
            btnStop.BackgroundImageLayout = ImageLayout.Stretch;
            btnStop.Enabled = false;
            btnStop.Location = new Point(211, 193);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(50, 50);
            btnStop.TabIndex = 2;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnReset
            // 
            btnReset.BackgroundImage = Properties.Resources.reset;
            btnReset.BackgroundImageLayout = ImageLayout.Stretch;
            btnReset.Enabled = false;
            btnReset.Location = new Point(289, 193);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(50, 50);
            btnReset.TabIndex = 3;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnLap
            // 
            btnLap.BackgroundImage = Properties.Resources.lap;
            btnLap.BackgroundImageLayout = ImageLayout.Stretch;
            btnLap.Enabled = false;
            btnLap.Location = new Point(367, 193);
            btnLap.Name = "btnLap";
            btnLap.Size = new Size(50, 50);
            btnLap.TabIndex = 4;
            btnLap.UseVisualStyleBackColor = true;
            btnLap.Click += btnLap_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(134, 294);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(283, 144);
            listBox1.TabIndex = 5;
            // 
            // lapTimer
            // 
            lapTimer.Interval = 1;
            lapTimer.Tick += lapTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 246);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 6;
            label1.Text = "Start";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 246);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 7;
            label2.Text = "Stop";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 246);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 8;
            label3.Text = "Reset";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(376, 246);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 9;
            label4.Text = "Lap";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(548, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(btnLap);
            Controls.Add(btnStop);
            Controls.Add(lblClock);
            Controls.Add(btnBasla);
            Controls.Add(btnReset);
            Name = "Form1";
            Text = "Chronometer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button btnBasla;
        private Label lblClock;
        private Button btnStop;
        private Button btnReset;
        private Button btnLap;
        private ListBox listBox1;
        private System.Windows.Forms.Timer lapTimer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
