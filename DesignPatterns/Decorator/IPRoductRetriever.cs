using System.Collections.Generic;

namespace DesignPatterns.Decorator
{
    public interface IProductRetriever
    {
        IEnumerable<string> GetProductIds();
        string GetProductIdByName(string name);
    }
}