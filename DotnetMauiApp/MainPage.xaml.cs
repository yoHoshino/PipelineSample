using PipelineSampleCore.ViewModels;

namespace DotnetMauiApp;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}

