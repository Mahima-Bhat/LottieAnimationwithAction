using System;
using System.Collections.Generic;
using System.Text;
using Lottie.Forms;
using Xamarin.Forms;

namespace LottieAnimationEx.Action
{
    public class StopLottieAnimationTriggerAction : TriggerAction<AnimationView>
    {
        protected override void Invoke(AnimationView sender)
        {
            sender.Progress = 0;
            
        }
    }
}
