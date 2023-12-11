namespace LightSwitch.Interfaces
{
    public interface IBrightnessService
    {
        void SetBrightness(BrightnessLevel brightness);
    }

    public enum BrightnessLevel
    {
        Mid, High
    }
}
