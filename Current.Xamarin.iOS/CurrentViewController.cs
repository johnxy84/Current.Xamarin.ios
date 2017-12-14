using System;

namespace Xamarin.Plugin
{
    public class CurrentViewController
    {
        /// <summary>
        /// Returns the current viewcontroller in the Hierachy of ViewControllers
        /// </summary>
        private static readonly Lazy<ICurrentViewController> Implementation = new Lazy<ICurrentViewController>(
            CreateCurrentActivity,
            System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Current settings to use
        /// </summary>
        public static ICurrentViewController Current
        {
            get
            {
                var ret = Implementation.Value;

                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        private static ICurrentViewController CreateCurrentActivity()
        {
#if PORTABLE
            
            return null;

            #else
            return new CurrentViewControllerImplementation();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly()

        {
            return new NotImplementedException(
                "This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        }
    }
}