using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaComponents
{
    public abstract class DictionaryOperations<T>
    {
        public abstract void AddComponent(T componentType);
        public abstract void DeleteComponent(T componentType);
        public abstract Dictionary<string,T> GetComponents();
        public abstract bool IsEmpty();
    }
}
