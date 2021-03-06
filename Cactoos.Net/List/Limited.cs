﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cactoos.List
{
    internal class Limited<T> : IEnumerable<T>
    {
        private IEnumerable<T> _source;
        private int _items;
 
        public Limited(IEnumerable<T> source, int items)
        {
            _source = source;
            _items = items;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return _source.Take(_items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
