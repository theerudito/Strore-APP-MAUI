using Heaven.View;

namespace Heaven;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new Page_Home();
    }
}
