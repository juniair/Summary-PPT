using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaserApp.Infra.Model
{
    public class DummyObject
    {
        public string DummyString { get; set; }
        public int DummyInt { get; set; }
        public DummyObject()
        {
            DummyString = "더미";
            DummyInt = 1;
        }

    }
}
