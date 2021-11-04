using ReactiveUI;
using System.Collections;
using System.Collections.Generic;
using XamForms.Excercises.MagicGradients;
using XamForms.Excercises.ViewModels;

namespace XamForms.Excercises.Main
{
    public class MainViewModel : BaseViewModel
    {

        public IEnumerable MenuList { get; }
        public ReactiveCommand<IRoutableViewModel, IRoutableViewModel> ClickedCommand { get; }


        public MainViewModel() : base("home", "Xamarin Exercises")
        {
            MenuList = BuildMenu();
            ClickedCommand = ReactiveCommand.CreateFromObservable((IRoutableViewModel vm) => HostScreen.Router.Navigate.Execute(vm));
        }

        private List<RowModel> BuildMenu()
        {
            return new List<RowModel>
            {
                new RowModel{ Title = "Magic Gradients", RowVM = new MGExViewModel() }
            };
        }
    }
}
