using syncfusion_maui_toolkit_stroke_areaseries_android_issue.ViewModels;

namespace syncfusion_maui_toolkit_stroke_areaseries_android_issue
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel viewModel )
        {
            BindingContext = viewModel;
            InitializeComponent();
        }
    }
}
