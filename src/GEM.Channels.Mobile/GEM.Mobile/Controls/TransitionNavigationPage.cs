using Xamarin.Forms;

namespace GEM.Mobile.Controls
{
    public class TransitionNavigationPage : NavigationPage
    {
        public static readonly BindableProperty TransitionTypeProperty =
             BindableProperty.Create("TransitionType", typeof(TransitionType), typeof(TransitionNavigationPage), TransitionType.Default);

        public TransitionType TransitionType
        {
            get { return (TransitionType)GetValue(TransitionTypeProperty); }
            set { SetValue(TransitionTypeProperty, value); }
        }

        public TransitionNavigationPage() : base()
        {
        }

        public TransitionNavigationPage(Page root) : base(root)
        {
        }
    }

    public enum TransitionType
    {
        /// <summary>
        /// Do not animate the transition.
        /// </summary>
        None = -1,

        /// <summary>
        /// Let the OS decide how to animate the transition.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Show a fade transition animation.
        /// </summary>
        Fade = 1,

        /// <summary>
        /// Show a flip transition animation.
        /// </summary>
        Flip = 2,

        /// <summary>
        /// Show a scale transition animation.
        /// </summary>
        Scale = 3,

        /// <summary>
        /// Show a slide form left transition animation.
        /// </summary>
        SlideFromLeft = 4,

        /// <summary>
        /// Show a slide form right transition animation.
        /// </summary>
        SlideFromRight = 5,

        /// <summary>
        /// Show a slide form top transition animation.
        /// </summary>
        SlideFromTop = 6,

        /// <summary>
        /// Show a slide form bottom transition animation.
        /// </summary>
        SlideFromBottom = 7
    }
}
