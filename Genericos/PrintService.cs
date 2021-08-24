using System;
using System.Collections.Generic;
using System.Text;

namespace Genericos
{
    class PrintService<T>
    {
        private T[] _value = new T [10];
        private int _count = 0;

        public void AddValue(T element)
        {   
            if(_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }

            _value[_count] = element;
            _count++;
        }

        public T First()
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            return _value[0];
        }

        public void Print()
        {
            Console.Write("[");
            for(int i = 0; i < _count - 1; i++)
            {
                Console.Write(_value[i]+ ", ");
            }
            
            if(_count > 0)
            {
                Console.Write(_count - 1);
            }
            Console.Write("]");
        }
    }
}
