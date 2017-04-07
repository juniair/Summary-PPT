using PaserApp.Infra.Model;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaserApp.Infra.Event
{
    public class ManToJsonPaserEvent : PubSubEvent<Man> { }
    public class WomanToJsonPaserEvent : PubSubEvent<Woman> { }

    public class JsonPaserEvent : PubSubEvent<RootObject> { }


    public class SendJsonDataEvent : PubSubEvent<object> { }

    public class XmlPaserEvent : PubSubEvent<string> { }
}
