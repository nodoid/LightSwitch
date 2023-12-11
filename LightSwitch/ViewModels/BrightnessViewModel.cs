using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LightSwitch.Interfaces;

namespace LightSwitch.ViewModels
{
    public partial class BrightnessViewModel : ObservableObject
    {
#nullable enable
        IBrightnessService? brightnessService => Startup.ServiceProvider.GetService<IBrightnessService>();
#nullable disable

        [ObservableProperty]
        bool lightOn;

        [RelayCommand]
        void SwitchOnOff()
        {
            brightnessService.SetBrightness(LightOn ? BrightnessLevel.Mid : BrightnessLevel.High);
            LightOn = !LightOn;
        }
    }
}
