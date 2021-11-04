using ReactiveUI.XamForms;
using Xamarin.Forms.Xaml;
using XamForms.Excercises.ViewModels;

namespace XamForms.Excercises.MagicGradients
{
    /// <summary>
    /// Exercise of library using MagicGradients.
    /// Source:
    /// https://benetskyybogdan.medium.com/design-beautiful-gradients-practical-guide-in-xamarin-forms-with-magic-gradients-57896c1a9efc
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MGExPage : ReactiveContentPage<MGExViewModel>
    {
        public MGExPage()
        {
            InitializeComponent();
        }
    }
}