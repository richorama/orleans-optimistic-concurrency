using MyGrainInterfaces;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SiloHost
{
    /// <summary>
    /// Orleans test silo host
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // The Orleans silo environment is initialized in its own app domain in order to more
            // closely emulate the distributed situation, when the client and the server cannot
            // pass data via shared memory.
            AppDomain hostDomain = AppDomain.CreateDomain("OrleansHost", null, new AppDomainSetup
            {
                AppDomainInitializer = InitSilo,
                AppDomainInitializerArguments = args,
            });

            Orleans.OrleansClient.Initialize("DevTestClientConfiguration.xml");

            Test().Wait();

            Console.WriteLine("Finished testing");
            Console.ReadLine();

            hostDomain.DoCallBack(ShutdownSilo);
        }


        static async Task Test()
        {
            var guid = Guid.NewGuid();
            var grain = ExampleGrainFactory.GetGrain(guid);
            var value1 = await grain.SetValue("foo", null);

            Debug.Assert(value1.Value == "foo");

            var value2 = await grain.SetValue("bar", value1.ETag);

            Debug.Assert(value2.Value == "bar");
            Debug.Assert(value2.ETag != value1.ETag);

            var value3 = await grain.GetValue();

            Debug.Assert(value3.Value == "bar");
            Debug.Assert(value3.ETag == value3.ETag);

            // send in a request with a stale etag
            try
            {
                var value4 = await grain.SetValue("qux", value1.ETag);
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception was thrown!");
            }
        }

        static void InitSilo(string[] args)
        {
            hostWrapper = new OrleansHostWrapper(args);

            if (!hostWrapper.Run())
            {
                Console.Error.WriteLine("Failed to initialize Orleans silo");
            }
        }

        static void ShutdownSilo()
        {
            if (hostWrapper != null)
            {
                hostWrapper.Dispose();
                GC.SuppressFinalize(hostWrapper);
            }
        }

        private static OrleansHostWrapper hostWrapper;
    }
}
