using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueGeneric
{

    struct KeyValue<K, V>
    {
        public readonly K key;
        public readonly V value;

        public KeyValue(K key, V value)
        {
            this.key = key;
            this.value = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
