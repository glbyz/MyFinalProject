using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string Key);
        object Get(string key);
        void Add(string Key, object value, int duration);
        bool IsAdd(string Key);
        void Remove(string Key);
        void RemoveByPattern(string pattern);
    }
}
