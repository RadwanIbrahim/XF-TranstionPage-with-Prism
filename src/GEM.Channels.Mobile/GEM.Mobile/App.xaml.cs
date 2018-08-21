using Prism;
using Prism.Ioc;
using GEM.Mobile.ViewModels;
using GEM.Mobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using Prism.Services;
using Prism.Navigation;
using GEM.Mobile.Controls;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GEM.Mobile
{
    public partial class App : PrismApplication
    {


        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }



        public static new App Current => PrismApplication.Current as App;


        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("TransitionNavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TransitionNavigationPage>();

            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<DetailsPage>();
        }
    }
}
