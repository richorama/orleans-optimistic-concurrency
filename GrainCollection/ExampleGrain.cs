using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Orleans;
using MyGrainInterfaces;
using Orleans.Providers;

namespace GrainCollection
{

    public interface IExampleGrainState : IGrainState
    {
        string Value { get; set; }
    }

    [StorageProvider(ProviderName = "AzureStore")]
    public class ExampleGrain : Orleans.Grain<IExampleGrainState>, IExampleGrain
    {
        ReadResponse ComposeResponse()
        {
            return new ReadResponse
            {
                ETag = this.State.Etag,
                Value = this.State.Value
            };
        }

        public Task<ReadResponse> GetValue()
        {
            return Task.FromResult(ComposeResponse());
        }

        public async Task<ReadResponse> SetValue(string value, string eTag)
        {
            if (this.State.Etag != null)
            {
                // if the state has an etag, we must ensure that the value passed in matches it
                if (this.State.Etag != eTag) throw new ArgumentException("not the most recent value for eTag", "eTag");
            }

            if (this.State.Value == value)
            {
                // nothing to do
                return ComposeResponse();
            }

            this.State.Value = value;

            // must not be marked as reentrant, as the etag will change at this write operation
            await this.State.WriteStateAsync();

            return ComposeResponse();
        }
    }
}
