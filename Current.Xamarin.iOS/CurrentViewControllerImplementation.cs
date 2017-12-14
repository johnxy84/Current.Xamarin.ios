using UIKit;

namespace Xamarin.Plugin
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class CurrentViewControllerImplementation : ICurrentViewController
    {
        /// <summary>
        /// Gets or sets the ViewController.
        /// </summary>
        /// <value>The activity.</value>

        public UIViewController ViewController
        {
            get
            {
                var window = UIApplication.SharedApplication.KeyWindow;
                var controller = window.RootViewController;
                while (controller.PresentedViewController != null)
                {
                    controller = controller.PresentedViewController;
                }
                return controller;
            }
        }
    }
}