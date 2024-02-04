﻿using RoadTakenDemo.Finished.Abstractions;
using System;
using System.Configuration;

namespace RoadTakenDemo.Finished.Framework
{
    public class FrameworkConfig : Config
    {
        public override int FirstNumber {
            get => Int32.Parse(ConfigurationManager.AppSettings["FirstNumber"]);
            set => base.FirstNumber = value;
        }
    }
}
