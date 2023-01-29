using Heaven.ViewModel;

namespace Heaven.View;

public partial class Page_Home : ContentPage
{
    public Page_Home()
    {
        InitializeComponent();
        BindingContext = new VM_Page_Home(Navigation);

    }
}