using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_task_desktop.Interfaces;
using Newtonsoft.Json;
using System.Net.Http;

namespace test_task_desktop.Classes
{
    class JsConvert :IDeserialize
    {
        public IEnumerable<T> DeserializeObj<T> (string result)
        {
            return JsonConvert.DeserializeObject<IEnumerable<T>>(result);
        }

        public StringContent SerializeObj<T>(T obj)
        {
            return new StringContent(
                    JsonConvert.SerializeObject(obj),
                    Encoding.UTF8, "application/json");
        }
    }
}
