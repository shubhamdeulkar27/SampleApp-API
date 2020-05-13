using SampleCL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCL.Services
{
    public class SampleRL : ISampleRL
    {
        public string Return_Name(Sample model)
        {
            return "My Name is " + model.Name;
        }
    }
}
