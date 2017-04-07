using Newtonsoft.Json;
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
using System.Xml;
using System.Xml.Linq;

namespace XmlDisplay.ViewModels
{
    public class XmlViewModel : BindableBase
    {
        private string xml;
        public string XmlData
        {
            get { return xml; }
            set { SetProperty(ref xml, value); }
        }

        private IEventAggregator Event { get; set; }

        public XmlViewModel(IEventAggregator ea)
        {
            Event = ea;
            Event.GetEvent<XmlPaserEvent>().Subscribe((s) =>
            {
                
                XNode node = JsonConvert.DeserializeXNode(s, "RootObject");
                XmlData = node.ToString();
            });

        }

    }
}
