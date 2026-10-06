using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    pu class Store<T>
    {
        private readonly List<T> _items = new();

        public void Add(T item) => _items.Add(item);

        public T? GetById(int id)
        {
            foreach (var item in _items)
            {
                if (item.Id == id)      // <-- compiler error here
                    return item;
            }
            return default;
        }

        public List<T> GetAll() => _items;

        public bool Remove(int id)
        {
            var item = GetById(id);
            if (item is null)
                return false;
            return _items.Remove(item);
        }
    }
}
