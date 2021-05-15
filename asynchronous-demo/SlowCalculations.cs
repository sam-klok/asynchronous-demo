using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace asynchronous_demo
{
    public class SlowCalculations
    {
        //slow calculations
        public string GetData() {

            var random = new Random();
            Thread.Sleep(4000); // imitating slow calculations
            int num = random.Next(100000);

            return num.ToString();
        }

        // converting method above to asynchronous method
        public async Task<string> GetDataAsync() {
            return await Task.Run(() => GetData());
        }
    }
}
