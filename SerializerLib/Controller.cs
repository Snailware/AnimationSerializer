using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SerializerLib
{
	public static class Controller
	{
        public static void SaveAnimationFrames(AnimationSet.States state,
                                               string frame0,
                                               string frame1,
                                               string frame2,
                                               string frame3)
        {
            switch (state)
            {
                case AnimationSet.States.idle:
                    Model.IdleFrames = new string[] { frame0, frame1, frame2, frame3 };
                    break;
                case AnimationSet.States.eat:
                    Model.EatFrames = new string[] { frame0, frame1, frame2, frame3 };
                    break;
                case AnimationSet.States.play:
                    Model.PlayFrames = new string[] { frame0, frame1, frame2, frame3 };
                    break;
                case AnimationSet.States.dance:
                    Model.DanceFrames = new string[] { frame0, frame1, frame2, frame3 };
                    break;
            }
        }

        public static string CreateAndSerializeAnimation()
        {
            AnimationSet animation = new AnimationSet(Model.IdleFrames,
                                                      Model.EatFrames,
                                                      Model.PlayFrames,
                                                      Model.PlayFrames);
            return JsonSerializer.Serialize(animation);
        }

        public static bool[] GetStatus(AnimationSet.States state)
        {
            switch (state)
            {
                case AnimationSet.States.idle:
                    return CheckStatus(Model.IdleFrames);
                case AnimationSet.States.eat:
                    return CheckStatus(Model.EatFrames);
                case AnimationSet.States.play:
                    return CheckStatus(Model.PlayFrames);
                case AnimationSet.States.dance:
                    return CheckStatus(Model.DanceFrames);
                default:
                    return null;
            }
        }

        public static void ClearData()
        {
            Model.IdleFrames = new string[] { "", "", "", "" };
            Model.EatFrames = new string[] { "", "", "", "" };
            Model.PlayFrames = new string[] { "", "", "", "" };
            Model.DanceFrames = new string[] { "", "", "", "" };
        }

        private static bool[] CheckStatus(string[] animation)
        {
            bool[] output = new bool[4];
            for (int index = 0; index < animation.Length; index++)
            {
                output[index] = !string.IsNullOrWhiteSpace(animation[index]);
            }
            return output;
        }
    }
}
