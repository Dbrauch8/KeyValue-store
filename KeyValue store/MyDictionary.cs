using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValue_store
{
    class MyDictionary
    {
       private KeyValue[] book = new KeyValue[50];

        private int tracker = 1;
        

        public object this [string searchKey]
        {

            get
            {
                 var result = book.Where(x => x.key == searchKey).ToList();

                 if (result.Count() > 0)
                 {
                     return result[0].value;
                 }
                 else
                 {
                     throw new KeyNotFoundException($"{searchKey} not found.");
                 }
            }
            set
            {
               var result = book.Where(x => x.key == searchKey).ToList();

               if (result.Count() == 0)
               {
                    book[tracker - 1] = new KeyValue(searchKey, value);
                    tracker++;
               }
            }
         

        }

    }
}
