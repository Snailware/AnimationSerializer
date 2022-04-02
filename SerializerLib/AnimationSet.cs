using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializerLib
{
	public class AnimationSet
	{
		public enum States
		{
			idle,
			eat,
			play,
			dance
		}

		public AnimationSet(string[] idle,
							string[] eat,
							string[] play,
							string[] dance = null)
		{
			Idle = idle;
			Eat = eat;
			Play = play;
			Dance = dance ?? new string[] { "", "", "", "" };
		}

		public string[] Idle { get; set; }
		public string[] Eat { get; set; }
		public string[] Play { get; set; }
		public string[] Dance { get; set; }
	}
}
