using System;
using System.Collections;
using System.Collections.Generic;

namespace iterator
{
    public class ShapeIterator
    {
        private Shape[] _shapes;
        private int number;
        public ShapeIterator(Shape[] thing)
        {
            _shapes = thing;
        }

        public bool MoveNext()
        {
            if (number >= _shapes.Length || _shapes[number] == null)
                return false;
            return true;
        }

        public Shape next()
        {
            return _shapes[number++];
        }
        
        public void Dispose()
        { 
            if (_shapes[number - 1] != null)
            {
                for (int i = number - 1; i < (_shapes.Length - 1); i++)
                {
                    _shapes[i] = _shapes[i + 1];
                }

                _shapes[_shapes.Length - 1] = default(Shape);
            }
        }
    }
}