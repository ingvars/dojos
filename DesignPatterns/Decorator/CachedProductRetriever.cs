using System;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace DesignPatterns.Decorator
{
    public class CachedProductRetriever : IProductRetriever
    {
        private readonly SqlProductRetriever _sqlRetriever;
        private static readonly MemoryCache Cache = MemoryCache.Default;
        
        public CachedProductRetriever(SqlProductRetriever sqlRetriever)
        {
            _sqlRetriever = sqlRetriever;
        }

        public IEnumerable<string> GetProductIds()
        {
            return _sqlRetriever.GetProductIds();
        }

        public string GetProductIdByName(string name)
        {
            string key = $"GetProductIdByName_{name}";

            if (Cache.Contains(key))
            {
                return Cache[key].ToString();
            }

            var productId = _sqlRetriever.GetProductIdByName(name);
            Cache.Add(new CacheItem(key, productId), new CacheItemPolicy {AbsoluteExpiration = DateTime.Now.AddHours(2)});

            return productId;
        }
    }
}
