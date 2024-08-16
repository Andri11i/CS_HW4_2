using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW4
{
    public class Storage<T>
    {
        private T item;
        public void SetItem(T item)
        {
            this.item = item;
        }
        public T GetItem()
        {
            return item;
        }
    }
}
