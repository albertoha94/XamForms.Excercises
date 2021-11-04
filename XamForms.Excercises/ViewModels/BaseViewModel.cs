using ReactiveUI;
using Splat;

namespace XamForms.Excercises.ViewModels
{
    public class BaseViewModel : ReactiveObject, IRoutableViewModel, IActivatableViewModel
    {

        /// <summary>
        /// Title to display in the Navigation Page.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the current page path.
        /// </summary>
        public string UrlPathSegment { get; }

        /// <summary>
        /// Gets the screen used for routing operations.
        /// </summary>
        public IScreen HostScreen { get; }

        /// <summary>
        /// Activator required for <see cref="IActivatableViewModel"/>.
        /// </summary>
        public ViewModelActivator Activator { get; } = new ViewModelActivator();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseViewModel"/> class.
        /// </summary>
        /// <param name="route">The title of the view model for routing purposes.</param>
        /// <param name="hostScreen">The screen used for routing purposes.</param>
        protected BaseViewModel(string route, string title, IScreen hostScreen = null)
        {
            UrlPathSegment = route;
            Title = title;
            HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();
        }
    }
}
