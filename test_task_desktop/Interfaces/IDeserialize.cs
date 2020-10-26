using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using test_task_desktop.Models;

namespace test_task_desktop.Interfaces
{
    interface IDeserialize
    {
        IEnumerable<T> DeserializeObj<T>(string result);
        StringContent SerializeObj<T>(T obj);
    }
}
