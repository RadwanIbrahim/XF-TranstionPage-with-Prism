using GEM.Mobile.Controls;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GEM.Mobile.Extentions
{
    public static class NavigationServiceExt
    {
        public static Task NavigateAsync(this INavigationService navigationService, string name, TransitionType transitionType = TransitionType.Default, NavigationParameters parameters = null, bool? useModalNavigation = null, bool animated = true)
        {
            (App.Current.MainPage as TransitionNavigationPage).TransitionType = transitionType;
            return navigationService.NavigateAsync(name, parameters, useModalNavigation, animated);
        }
        public static Task NavigateAsync(this INavigationService navigationService, Uri uri, TransitionType transitionType = TransitionType.Default, NavigationParameters parameters = null, bool? useModalNavigation = null, bool animated = true)
        {
            (App.Current.MainPage as TransitionNavigationPage).TransitionType = transitionType;
            return navigationService.NavigateAsync(uri, parameters, useModalNavigation, animated);
        }
    }
}
