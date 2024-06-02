namespace ProcessManipulations
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
            started_assembliesText = new Label();
            available_assembliesText = new Label();
            started_assemblies = new ListBox();
            available_assemblies = new ListBox();
            start = new Button();
            stop = new Button();
            close_windows = new Button();
            refresh = new Button();
            run_calc = new Button();
            SuspendLayout();
            // 
            // started_assembliesText
            // 
            started_assembliesText.AutoSize = true;
            started_assembliesText.Font = new Font("Segoe UI", 11F);
            started_assembliesText.Location = new Point(31, 38);
            started_assembliesText.Name = "started_assembliesText";
            started_assembliesText.Size = new Size(195, 30);
            started_assembliesText.TabIndex = 0;
            started_assembliesText.Text = "Started Assemblies";
            // 
            // available_assembliesText
            // 
            available_assembliesText.AutoSize = true;
            available_assembliesText.Font = new Font("Segoe UI", 11F);
            available_assembliesText.Location = new Point(569, 38);
            available_assembliesText.Name = "available_assembliesText";
            available_assembliesText.Size = new Size(213, 30);
            available_assembliesText.TabIndex = 1;
            available_assembliesText.Text = "Available Assemblies";
            // 
            // started_assemblies
            // 
            started_assemblies.FormattingEnabled = true;
            started_assemblies.ItemHeight = 25;
            started_assemblies.Location = new Point(31, 90);
            started_assemblies.Name = "started_assemblies";
            started_assemblies.Size = new Size(300, 429);
            started_assemblies.TabIndex = 2;
            // 
            // available_assemblies
            // 
            available_assemblies.FormattingEnabled = true;
            available_assemblies.ItemHeight = 25;
            available_assemblies.Location = new Point(565, 90);
            available_assemblies.Name = "available_assemblies";
            available_assemblies.Size = new Size(300, 429);
            available_assemblies.TabIndex = 3;
            // 
            // start
            // 
            start.Location = new Point(391, 165);
            start.Name = "start";
            start.Size = new Size(112, 34);
            start.TabIndex = 4;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // stop
            // 
            stop.Location = new Point(391, 229);
            stop.Name = "stop";
            stop.Size = new Size(112, 34);
            stop.TabIndex = 5;
            stop.Text = "Stop";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // close_windows
            // 
            close_windows.Font = new Font("Segoe UI", 7F);
            close_windows.Location = new Point(391, 291);
            close_windows.Name = "close_windows";
            close_windows.Size = new Size(112, 34);
            close_windows.TabIndex = 6;
            close_windows.Text = "Close windows";
            close_windows.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            refresh.Location = new Point(391, 359);
            refresh.Name = "refresh";
            refresh.Size = new Size(112, 34);
            refresh.TabIndex = 7;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // run_calc
            // 
            run_calc.Location = new Point(391, 421);
            run_calc.Name = "run_calc";
            run_calc.Size = new Size(112, 34);
            run_calc.TabIndex = 8;
            run_calc.Text = "Run Calc";
            run_calc.UseVisualStyleBackColor = true;
            run_calc.Click += run_calc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 563);
            Controls.Add(run_calc);
            Controls.Add(refresh);
            Controls.Add(close_windows);
            Controls.Add(stop);
            Controls.Add(start);
            Controls.Add(available_assemblies);
            Controls.Add(started_assemblies);
            Controls.Add(available_assembliesText);
            Controls.Add(started_assembliesText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label started_assembliesText;
        private Label available_assembliesText;
        private ListBox started_assemblies;
        private ListBox available_assemblies;
        private Button start;
        private Button stop;
        private Button close_windows;
        private Button refresh;
        private Button run_calc;
    }
}
