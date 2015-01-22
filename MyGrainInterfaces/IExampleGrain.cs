using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Orleans;

namespace MyGrainInterfaces
{
    public class ReadResponse
    {
        public string Value { get; set; }
        public string ETag { get; set; }
    }

    public interface IExampleGrain : IGrain
    {
        Task<ReadResponse> GetValue();
        Task<ReadResponse> SetValue(string value, string eTag);
    }
}
