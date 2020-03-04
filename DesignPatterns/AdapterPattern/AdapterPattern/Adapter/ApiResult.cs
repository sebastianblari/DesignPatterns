using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adapter
{
    public class ApiResult<T>
    {
        public int Count { get; set; }
        public List<T> Results { get; set; }
        public string Next { get; set; }
    }
}
