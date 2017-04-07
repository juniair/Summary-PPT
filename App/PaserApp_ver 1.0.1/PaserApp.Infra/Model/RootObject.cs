using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaserApp.Infra.Model
{
    public class RootObject
    {
        public List<Man> Men { get; set; }

        public List<Woman> Women { get; set; }

        public RootObject()
        {
            Men = new List<Man>();
            Women = new List<Woman>();
        }
    }
}
