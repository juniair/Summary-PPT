using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;
using System;

namespace BindableApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public ICommand RunCommand { get; set; }

        public MainWindowViewModel()
        {
            RunCommand = new DelegateCommand<object>(run);
        }

        private void run(object obj)
        {
            Name = "Button Click";
        }
    }
}
