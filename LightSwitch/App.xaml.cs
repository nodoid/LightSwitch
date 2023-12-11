namespace LightSwitch
{
    public partial class App : Application
    {
        public static IServiceProvider Service { get; set; }

        public App()
        {
            InitializeComponent();
            Service = Startup.Init();
            MainPage = new AppShell();
        }
    }
}
