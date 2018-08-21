using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using GEM.Mobile.Extentions;
using GEM.Mobile.Controls;

namespace GEM.Mobile.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public ICommand ClickmeCommand { get; set; }
        private readonly INavigationService _NavigationService;
        public MainPageViewModel(INavigationService navigationService)
        {
            _NavigationService = navigationService;
            ClickmeCommand = new DelegateCommand(OnClickMe);
        }

        private void OnClickMe()
        {
            _NavigationService.NavigateAsync("DetailsPage", TransitionType.SlideFromBottom);

        }
    }
}
