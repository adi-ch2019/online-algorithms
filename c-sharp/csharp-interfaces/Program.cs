using System;
using System.Collections.Generic;

namespace CustomCollection.Tests
{
    public class StringMap<TValue> : IStringMap<TValue>
        where TValue : class
    {
        private Dictionary<string, TValue> map = new Dictionary<string, TValue>();

        public int Count => map.Count;

        public TValue DefaultValue { get; set; }

        public bool AddElement(string key, TValue value)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Key cannot be an empty string", nameof(key));
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (map.ContainsKey(key))
            {
                map[key] = value;
                return true;
            }

            map[key] = value;
            return false;
        }

        public bool RemoveElement(string key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Key cannot be an empty string", nameof(key));

            return map.Remove(key);
        }

        public TValue GetValue(string key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Key cannot be an empty string", nameof(key));

            if (map.TryGetValue(key, out TValue value))
            {
                return value;
            }

            return DefaultValue;
        }
    }
}
