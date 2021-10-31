using System.Collections;
using System.Collections.Generic;

namespace XamForms.Excercises.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        public IEnumerable MenuList { get; }


        public MainViewModel() : base("home", "Xamarin Exercises")
        {
            MenuList = BuildMenu();
        }

        private List<string> BuildMenu()
        {
            return new List<string>
            {
                "hola"
                //new Tuple<string, Type>("Magic Gradients", typeof(MainViewModel))
            };
        }
    }
}
