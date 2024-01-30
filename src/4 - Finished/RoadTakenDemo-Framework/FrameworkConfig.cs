using RoadTakenDemo_Finished_Abstractions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RoadTakenDemo_Framework
{
    public class FrameworkConfig : Config
    {
        public override int FirstNumber {
            get => Int32.Parse(ConfigurationManager.AppSettings["FirstNumber"]);
            set => base.FirstNumber = value;
        }
    }
}
