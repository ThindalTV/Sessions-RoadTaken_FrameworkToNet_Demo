using RoadTakenDemoTemplate.Prepared.Abstractions;
using System;
using System.Configuration;

namespace RoadTakenDemo.Prepared.Framework
{
    public class FrameworkConfig : Config
    {
        public override int FirstNumber {
            get => Int32.Parse(ConfigurationManager.AppSettings["FirstNumber"]);
            set => base.FirstNumber = value;
        }
    }
}
