using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerializerLib;

namespace WinFormsUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void SaveEntryButton_Click(object sender, EventArgs e)
		{
			if(IdleEntryButton.Checked)
			{
				Model.IdleFrames = new string[] {FrameInput0.Text,
												 FrameInput1.Text,
												 FrameInput2.Text,
												 FrameInput3.Text};
			}
			else if (EatEntryButton.Checked)
			{
				Model.EatFrames = new string[] {FrameInput0.Text,
												FrameInput1.Text,
												FrameInput2.Text,
												FrameInput3.Text};
			}
			else if (PlayEntryButton.Checked)
			{
				Model.PlayFrames = new string[] {FrameInput0.Text,
												 FrameInput1.Text,
												 FrameInput2.Text,
												 FrameInput3.Text};
			}
			else if (DanceEntryButton.Checked)
			{
				Model.DanceFrames = new string[] {FrameInput0.Text,
												  FrameInput1.Text,
												  FrameInput2.Text,
												  FrameInput3.Text};
			}

			UpdateProgressBars();
			ClearFrames();
		}

		private void SerializeAnimationButton_Click(object sender, EventArgs e)
		{
			OutputTextBox.Text = Controller.CreateAndSerializeAnimation();
		}

		private void ClearDataButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(text: "clear data for all frames?",
								caption: "Warning",
								buttons: MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				Controller.ClearData();
				ClearFrames();
			}
		}

		private void CopyButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(OutputTextBox.Text);
		}

		private void UpdateProgressBars()
		{
			IdleProgressBar.Value = 0;
			EatProgressBar.Value = 0;
			PlayProgressBar.Value = 0;
			DanceProgressBar.Value = 0;

			bool[] idleFrames = Controller.GetStatus(AnimationSet.States.idle);
			bool[] eatFrames = Controller.GetStatus(AnimationSet.States.eat);
			bool[] playFrames = Controller.GetStatus(AnimationSet.States.play);
			bool[] danceFrames = Controller.GetStatus(AnimationSet.States.dance);

			for (int index = 0; index < 4; index++)
			{
				if (idleFrames[index]) { IdleProgressBar.PerformStep(); }
				if (eatFrames[index]) { EatProgressBar.PerformStep(); }
				if (playFrames[index]) { PlayProgressBar.PerformStep(); }
				if (danceFrames[index]) { DanceProgressBar.PerformStep(); }
			}
		}

		private void ClearFrames()
		{
			FrameInput0.Clear();
			FrameInput1.Clear();
			FrameInput2.Clear();
			FrameInput3.Clear();
		}
	}
}
