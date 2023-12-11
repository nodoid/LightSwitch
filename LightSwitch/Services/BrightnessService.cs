#if ANDROID
using Android.Views;
#endif

using LightSwitch.Interfaces;

namespace LightSwitch.Services
{
    public class BrightnessService : IBrightnessService
    {
        public void SetBrightness(BrightnessLevel brightness)
        {
            // -1 is the device default brightness

            var level = brightness == BrightnessLevel.Mid ? 0.1 : -1;

#if ANDROID

            var window = MainActivity.AppActivity?.Window;

            if (window is not null)
            {
                using (var attr = new WindowManagerLayoutParams())
                {
                    attr.CopyFrom(window.Attributes);
                    attr.ScreenBrightness = (float)level;
                    window.Attributes = attr;
                }
            }

#endif

        }
    }
}
