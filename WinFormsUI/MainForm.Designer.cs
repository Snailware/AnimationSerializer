
namespace WinFormsUI
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.FrameInput0 = new System.Windows.Forms.TextBox();
			this.FrameInput1 = new System.Windows.Forms.TextBox();
			this.FrameInput2 = new System.Windows.Forms.TextBox();
			this.FrameInput3 = new System.Windows.Forms.TextBox();
			this.LabelFrame0 = new System.Windows.Forms.Label();
			this.LabelFrame1 = new System.Windows.Forms.Label();
			this.LabelFrame2 = new System.Windows.Forms.Label();
			this.LabelFrame3 = new System.Windows.Forms.Label();
			this.GroupboxStateControls = new System.Windows.Forms.GroupBox();
			this.DanceEntryButton = new System.Windows.Forms.RadioButton();
			this.PlayEntryButton = new System.Windows.Forms.RadioButton();
			this.EatEntryButton = new System.Windows.Forms.RadioButton();
			this.IdleEntryButton = new System.Windows.Forms.RadioButton();
			this.IdleProgressBar = new System.Windows.Forms.ProgressBar();
			this.EatProgressBar = new System.Windows.Forms.ProgressBar();
			this.PlayProgressBar = new System.Windows.Forms.ProgressBar();
			this.DanceProgressBar = new System.Windows.Forms.ProgressBar();
			this.SaveEntryButton = new System.Windows.Forms.Button();
			this.groupboxAnimationControls = new System.Windows.Forms.GroupBox();
			this.SerializeAnimationButton = new System.Windows.Forms.Button();
			this.ClearDataButton = new System.Windows.Forms.Button();
			this.OutputTextBox = new System.Windows.Forms.TextBox();
			this.CopyButton = new System.Windows.Forms.Button();
			this.GroupboxStateControls.SuspendLayout();
			this.groupboxAnimationControls.SuspendLayout();
			this.SuspendLayout();
			// 
			// FrameInput0
			// 
			this.FrameInput0.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FrameInput0.Location = new System.Drawing.Point(11, 166);
			this.FrameInput0.Multiline = true;
			this.FrameInput0.Name = "FrameInput0";
			this.FrameInput0.Size = new System.Drawing.Size(345, 248);
			this.FrameInput0.TabIndex = 0;
			// 
			// FrameInput1
			// 
			this.FrameInput1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FrameInput1.Location = new System.Drawing.Point(362, 166);
			this.FrameInput1.Multiline = true;
			this.FrameInput1.Name = "FrameInput1";
			this.FrameInput1.Size = new System.Drawing.Size(345, 248);
			this.FrameInput1.TabIndex = 1;
			// 
			// FrameInput2
			// 
			this.FrameInput2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FrameInput2.Location = new System.Drawing.Point(11, 437);
			this.FrameInput2.Multiline = true;
			this.FrameInput2.Name = "FrameInput2";
			this.FrameInput2.Size = new System.Drawing.Size(345, 248);
			this.FrameInput2.TabIndex = 2;
			// 
			// FrameInput3
			// 
			this.FrameInput3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FrameInput3.Location = new System.Drawing.Point(362, 437);
			this.FrameInput3.Multiline = true;
			this.FrameInput3.Name = "FrameInput3";
			this.FrameInput3.Size = new System.Drawing.Size(345, 248);
			this.FrameInput3.TabIndex = 3;
			// 
			// LabelFrame0
			// 
			this.LabelFrame0.AutoSize = true;
			this.LabelFrame0.Location = new System.Drawing.Point(162, 146);
			this.LabelFrame0.Name = "LabelFrame0";
			this.LabelFrame0.Size = new System.Drawing.Size(60, 17);
			this.LabelFrame0.TabIndex = 4;
			this.LabelFrame0.Text = "Frame 0";
			// 
			// LabelFrame1
			// 
			this.LabelFrame1.AutoSize = true;
			this.LabelFrame1.Location = new System.Drawing.Point(512, 146);
			this.LabelFrame1.Name = "LabelFrame1";
			this.LabelFrame1.Size = new System.Drawing.Size(60, 17);
			this.LabelFrame1.TabIndex = 5;
			this.LabelFrame1.Text = "Frame 1";
			// 
			// LabelFrame2
			// 
			this.LabelFrame2.AutoSize = true;
			this.LabelFrame2.Location = new System.Drawing.Point(162, 417);
			this.LabelFrame2.Name = "LabelFrame2";
			this.LabelFrame2.Size = new System.Drawing.Size(60, 17);
			this.LabelFrame2.TabIndex = 6;
			this.LabelFrame2.Text = "Frame 2";
			// 
			// LabelFrame3
			// 
			this.LabelFrame3.AutoSize = true;
			this.LabelFrame3.Location = new System.Drawing.Point(512, 417);
			this.LabelFrame3.Name = "LabelFrame3";
			this.LabelFrame3.Size = new System.Drawing.Size(60, 17);
			this.LabelFrame3.TabIndex = 7;
			this.LabelFrame3.Text = "Frame 3";
			// 
			// GroupboxStateControls
			// 
			this.GroupboxStateControls.Controls.Add(this.SaveEntryButton);
			this.GroupboxStateControls.Controls.Add(this.DanceProgressBar);
			this.GroupboxStateControls.Controls.Add(this.PlayProgressBar);
			this.GroupboxStateControls.Controls.Add(this.EatProgressBar);
			this.GroupboxStateControls.Controls.Add(this.IdleProgressBar);
			this.GroupboxStateControls.Controls.Add(this.DanceEntryButton);
			this.GroupboxStateControls.Controls.Add(this.PlayEntryButton);
			this.GroupboxStateControls.Controls.Add(this.EatEntryButton);
			this.GroupboxStateControls.Controls.Add(this.IdleEntryButton);
			this.GroupboxStateControls.Location = new System.Drawing.Point(12, 12);
			this.GroupboxStateControls.Name = "GroupboxStateControls";
			this.GroupboxStateControls.Size = new System.Drawing.Size(344, 131);
			this.GroupboxStateControls.TabIndex = 0;
			this.GroupboxStateControls.TabStop = false;
			this.GroupboxStateControls.Text = "State Information";
			// 
			// DanceEntryButton
			// 
			this.DanceEntryButton.AutoSize = true;
			this.DanceEntryButton.Location = new System.Drawing.Point(6, 102);
			this.DanceEntryButton.Name = "DanceEntryButton";
			this.DanceEntryButton.Size = new System.Drawing.Size(107, 21);
			this.DanceEntryButton.TabIndex = 3;
			this.DanceEntryButton.TabStop = true;
			this.DanceEntryButton.Text = "Dance Entry";
			this.DanceEntryButton.UseVisualStyleBackColor = true;
			// 
			// PlayEntryButton
			// 
			this.PlayEntryButton.AutoSize = true;
			this.PlayEntryButton.Location = new System.Drawing.Point(6, 75);
			this.PlayEntryButton.Name = "PlayEntryButton";
			this.PlayEntryButton.Size = new System.Drawing.Size(93, 21);
			this.PlayEntryButton.TabIndex = 2;
			this.PlayEntryButton.TabStop = true;
			this.PlayEntryButton.Text = "Play Entry";
			this.PlayEntryButton.UseVisualStyleBackColor = true;
			// 
			// EatEntryButton
			// 
			this.EatEntryButton.AutoSize = true;
			this.EatEntryButton.Location = new System.Drawing.Point(6, 48);
			this.EatEntryButton.Name = "EatEntryButton";
			this.EatEntryButton.Size = new System.Drawing.Size(87, 21);
			this.EatEntryButton.TabIndex = 1;
			this.EatEntryButton.TabStop = true;
			this.EatEntryButton.Text = "Eat Entry";
			this.EatEntryButton.UseVisualStyleBackColor = true;
			// 
			// IdleEntryButton
			// 
			this.IdleEntryButton.AutoSize = true;
			this.IdleEntryButton.Location = new System.Drawing.Point(6, 21);
			this.IdleEntryButton.Name = "IdleEntryButton";
			this.IdleEntryButton.Size = new System.Drawing.Size(88, 21);
			this.IdleEntryButton.TabIndex = 0;
			this.IdleEntryButton.TabStop = true;
			this.IdleEntryButton.Text = "Idle Entry";
			this.IdleEntryButton.UseVisualStyleBackColor = true;
			// 
			// IdleProgressBar
			// 
			this.IdleProgressBar.ForeColor = System.Drawing.Color.LightGreen;
			this.IdleProgressBar.Location = new System.Drawing.Point(119, 21);
			this.IdleProgressBar.Name = "IdleProgressBar";
			this.IdleProgressBar.Size = new System.Drawing.Size(100, 21);
			this.IdleProgressBar.Step = 25;
			this.IdleProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.IdleProgressBar.TabIndex = 4;
			// 
			// EatProgressBar
			// 
			this.EatProgressBar.ForeColor = System.Drawing.Color.LightGreen;
			this.EatProgressBar.Location = new System.Drawing.Point(119, 48);
			this.EatProgressBar.Name = "EatProgressBar";
			this.EatProgressBar.Size = new System.Drawing.Size(100, 21);
			this.EatProgressBar.Step = 25;
			this.EatProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.EatProgressBar.TabIndex = 5;
			// 
			// PlayProgressBar
			// 
			this.PlayProgressBar.ForeColor = System.Drawing.Color.LightGreen;
			this.PlayProgressBar.Location = new System.Drawing.Point(119, 75);
			this.PlayProgressBar.Name = "PlayProgressBar";
			this.PlayProgressBar.Size = new System.Drawing.Size(100, 21);
			this.PlayProgressBar.Step = 25;
			this.PlayProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.PlayProgressBar.TabIndex = 6;
			// 
			// DanceProgressBar
			// 
			this.DanceProgressBar.ForeColor = System.Drawing.Color.LightGreen;
			this.DanceProgressBar.Location = new System.Drawing.Point(119, 102);
			this.DanceProgressBar.Name = "DanceProgressBar";
			this.DanceProgressBar.Size = new System.Drawing.Size(100, 21);
			this.DanceProgressBar.Step = 25;
			this.DanceProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.DanceProgressBar.TabIndex = 7;
			// 
			// SaveEntryButton
			// 
			this.SaveEntryButton.BackColor = System.Drawing.Color.LightSkyBlue;
			this.SaveEntryButton.Location = new System.Drawing.Point(225, 21);
			this.SaveEntryButton.Name = "SaveEntryButton";
			this.SaveEntryButton.Size = new System.Drawing.Size(113, 102);
			this.SaveEntryButton.TabIndex = 8;
			this.SaveEntryButton.Text = "Save Entry";
			this.SaveEntryButton.UseVisualStyleBackColor = false;
			this.SaveEntryButton.Click += new System.EventHandler(this.SaveEntryButton_Click);
			// 
			// groupboxAnimationControls
			// 
			this.groupboxAnimationControls.Controls.Add(this.ClearDataButton);
			this.groupboxAnimationControls.Controls.Add(this.SerializeAnimationButton);
			this.groupboxAnimationControls.Location = new System.Drawing.Point(362, 12);
			this.groupboxAnimationControls.Name = "groupboxAnimationControls";
			this.groupboxAnimationControls.Size = new System.Drawing.Size(345, 131);
			this.groupboxAnimationControls.TabIndex = 8;
			this.groupboxAnimationControls.TabStop = false;
			this.groupboxAnimationControls.Text = "Animation Object Controls";
			// 
			// SerializeAnimationButton
			// 
			this.SerializeAnimationButton.BackColor = System.Drawing.Color.LightGreen;
			this.SerializeAnimationButton.Location = new System.Drawing.Point(6, 21);
			this.SerializeAnimationButton.Name = "SerializeAnimationButton";
			this.SerializeAnimationButton.Size = new System.Drawing.Size(333, 48);
			this.SerializeAnimationButton.TabIndex = 0;
			this.SerializeAnimationButton.Text = "Serialize Animation";
			this.SerializeAnimationButton.UseVisualStyleBackColor = false;
			this.SerializeAnimationButton.Click += new System.EventHandler(this.SerializeAnimationButton_Click);
			// 
			// ClearDataButton
			// 
			this.ClearDataButton.BackColor = System.Drawing.Color.Salmon;
			this.ClearDataButton.Location = new System.Drawing.Point(6, 75);
			this.ClearDataButton.Name = "ClearDataButton";
			this.ClearDataButton.Size = new System.Drawing.Size(333, 48);
			this.ClearDataButton.TabIndex = 1;
			this.ClearDataButton.Text = "Clear ALL Data";
			this.ClearDataButton.UseVisualStyleBackColor = false;
			this.ClearDataButton.Click += new System.EventHandler(this.ClearDataButton_Click);
			// 
			// OutputTextBox
			// 
			this.OutputTextBox.Enabled = false;
			this.OutputTextBox.Location = new System.Drawing.Point(11, 691);
			this.OutputTextBox.Multiline = true;
			this.OutputTextBox.Name = "OutputTextBox";
			this.OutputTextBox.Size = new System.Drawing.Size(526, 23);
			this.OutputTextBox.TabIndex = 9;
			this.OutputTextBox.Text = "Serialized Output";
			this.OutputTextBox.WordWrap = false;
			// 
			// CopyButton
			// 
			this.CopyButton.BackColor = System.Drawing.Color.LightSkyBlue;
			this.CopyButton.Location = new System.Drawing.Point(543, 689);
			this.CopyButton.Name = "CopyButton";
			this.CopyButton.Size = new System.Drawing.Size(168, 26);
			this.CopyButton.TabIndex = 11;
			this.CopyButton.Text = "Copy to Clipboard";
			this.CopyButton.UseVisualStyleBackColor = false;
			this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 721);
			this.Controls.Add(this.CopyButton);
			this.Controls.Add(this.OutputTextBox);
			this.Controls.Add(this.groupboxAnimationControls);
			this.Controls.Add(this.GroupboxStateControls);
			this.Controls.Add(this.LabelFrame3);
			this.Controls.Add(this.LabelFrame2);
			this.Controls.Add(this.LabelFrame1);
			this.Controls.Add(this.LabelFrame0);
			this.Controls.Add(this.FrameInput3);
			this.Controls.Add(this.FrameInput2);
			this.Controls.Add(this.FrameInput1);
			this.Controls.Add(this.FrameInput0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Digivice Animation Serializer";
			this.GroupboxStateControls.ResumeLayout(false);
			this.GroupboxStateControls.PerformLayout();
			this.groupboxAnimationControls.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox FrameInput0;
		private System.Windows.Forms.TextBox FrameInput1;
		private System.Windows.Forms.TextBox FrameInput2;
		private System.Windows.Forms.TextBox FrameInput3;
		private System.Windows.Forms.Label LabelFrame0;
		private System.Windows.Forms.Label LabelFrame1;
		private System.Windows.Forms.Label LabelFrame2;
		private System.Windows.Forms.Label LabelFrame3;
		private System.Windows.Forms.GroupBox GroupboxStateControls;
		private System.Windows.Forms.RadioButton DanceEntryButton;
		private System.Windows.Forms.RadioButton PlayEntryButton;
		private System.Windows.Forms.RadioButton EatEntryButton;
		private System.Windows.Forms.RadioButton IdleEntryButton;
		private System.Windows.Forms.ProgressBar DanceProgressBar;
		private System.Windows.Forms.ProgressBar PlayProgressBar;
		private System.Windows.Forms.ProgressBar EatProgressBar;
		private System.Windows.Forms.ProgressBar IdleProgressBar;
		private System.Windows.Forms.Button SaveEntryButton;
		private System.Windows.Forms.GroupBox groupboxAnimationControls;
		private System.Windows.Forms.Button ClearDataButton;
		private System.Windows.Forms.Button SerializeAnimationButton;
		private System.Windows.Forms.TextBox OutputTextBox;
		private System.Windows.Forms.Button CopyButton;
	}
}

