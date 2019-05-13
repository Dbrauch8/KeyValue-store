using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValue_store
{
    struct KeyValue
    {
        public readonly string key;
        public readonly object value;

        public KeyValue(string key, object value)
        {
            this.key = key;
            this.value = value;
        }


    }
    
}
