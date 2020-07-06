using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LottieAnimationEx.Action
{
    public class StartButtonVisibility : TriggerAction<ImageButton>
    {
        protected override void Invoke(ImageButton sender)
        {
            sender.IsVisible = true;

        }
    }
}
