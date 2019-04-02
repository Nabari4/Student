using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    class CadryList : IEnumerable
    {
        private List<Cadry> cadry;
        public int Length
        {
            get { return cadry.Count; }
        }
        public CadryList(int size)
        {
            cadry = new List<Cadry>(size);
        }
        public void AddItem()
        {
            Cadry item = new Cadry();
            item.GetInfo();
            cadry.Add(item);
        }
        public void RemoveItem(int pos)
        {
            cadry.RemoveAt(pos);
        }
        public Cadry this[int index]
        {
            get { return cadry[index]; }
            set { cadry[index] = value; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return cadry.GetEnumerator();
        }
    }
}
