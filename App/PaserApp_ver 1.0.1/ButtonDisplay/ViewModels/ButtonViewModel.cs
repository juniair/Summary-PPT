using PaserApp.Infra.Event;
using PaserApp.Infra.Model;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace ButtonDisplay.ViewModels
{
    public class ButtonViewModel : BindableBase
    {
        public IEventAggregator Event { get; set; }

        public ICommand CreateManCommand { get; set; }
        public ICommand CreateWomanCommand { get; set; }
        public ICommand ObjectToJsonCommand { get; set; }

        public ICommand JsonToXmlCommand { get; set; }

        private RootObject Root { get; set; }


        public ButtonViewModel(IEventAggregator ea)
        {
            Event = ea;
            Root = new RootObject();
            CreateManCommand = new DelegateCommand<object>(createMan);
            CreateWomanCommand = new DelegateCommand<object>((o) =>
            {
                Woman woman = new Woman();
                woman.Name = "영희";
                woman.Age = 25;
                woman.Dummy = new DummyObject();
                Root.Women.Add(woman);
            });

            ObjectToJsonCommand = new DelegateCommand<object>(sendObject);
            JsonToXmlCommand = new DelegateCommand<object>(sendJson);
        }

        private void sendJson(object obj)
        {
            Event.GetEvent<SendJsonDataEvent>().Publish(obj);
        }

        private void sendObject(object obj)
        {
            Event.GetEvent<JsonPaserEvent>().Publish(Root);
        }

        private void createMan(object obj)
        {
            Man man = new Man();
            man.Name = "철수";
            man.Age = 27;

            Root.Men.Add(man);
        }
    }
}
