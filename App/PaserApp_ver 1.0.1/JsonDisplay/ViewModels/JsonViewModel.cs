using PaserApp.Infra.Event;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using PaserApp.Infra.Model;
using Newtonsoft.Json;
using System.Windows;

namespace JsonDisplay.ViewModels
{
    public class JsonViewModel : BindableBase
    {
        private string jsonData;
        public string JsonData
        {
            get { return jsonData; }
            set { SetProperty(ref jsonData, value); }
        }
        public IEventAggregator Event { get; set; }
        public JsonViewModel(IEventAggregator ea)
        {
            Event = ea;
            Event.GetEvent<JsonPaserEvent>().Subscribe(createJsonData);
            Event.GetEvent<SendJsonDataEvent>().Subscribe(sendJsonData);
        }

        private void sendJsonData(object obj)
        {
            if(JsonData != null)
            {
                Event.GetEvent<XmlPaserEvent>().Publish(JsonData);
            }
            else
            {
                Event.GetEvent<XmlPaserEvent>().Publish(@"{'Result': 'json data 가 없습니다.'}");
            } 
        }

        private void createJsonData(RootObject obj)
        {
            
            JsonData = JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
    }
}
