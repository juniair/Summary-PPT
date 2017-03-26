using NotifyPropertyChangedApp.Command;
using Prism.Mvvm;
using System.ComponentModel;
using System.Windows.Input;
using System;

namespace NotifyPropertyChangedApp.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        public string ClickName
        {
            get { return _name; }
            set
            {
                if(_name != value)
                {
                    _name = value;
                    var handler = this.PropertyChanged;
                    handler(value, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public ICommand RunCommand;

        public MainWindowViewModel()
        {
            RunCommand = new RelayCommand<object>(run);
        }

        private void run(object obj)
        {
            ClickName = "Button Click";
        }
    }
}
