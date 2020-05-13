using SampleBL.Interface;
using SampleCL;
using SampleCL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleBL.Services
{
    public class SampleBL : ISampleBL
    {
        private ISampleRL sample;
        public SampleBL(ISampleRL sample)
        {
            this.sample = sample;
        }
        public string Return_Name(Sample model)
        {
            return this.sample.Return_Name(model);
        }

    }
}
