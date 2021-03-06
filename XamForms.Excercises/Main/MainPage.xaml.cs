using ReactiveUI;
using ReactiveUI.XamForms;
using System.Reactive.Disposables;

namespace XamForms.Excercises.Main
{
    public partial class MainPage : ReactiveContentPage<MainViewModel>
    {
        public MainPage()
        {
            InitializeComponent();

            this.WhenActivated(disposable =>
            {
                this.Bind(ViewModel, x => x.MenuList, x => x.mCollection.ItemsSource).DisposeWith(disposable);
            });
        }
    }
}
