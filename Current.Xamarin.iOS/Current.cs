using UIKit;

namespace Current.Xamarin.iOS
{
    public class Current
    {
        /// <summary>
        /// Returns the current viewcontroller in the Hierachy of ViewControllers
        /// </summary>
        public static UIViewController CurrentViewController
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