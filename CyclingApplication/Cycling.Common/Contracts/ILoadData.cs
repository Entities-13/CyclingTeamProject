using System.Collections.Generic;

namespace Cycling.Common.Contracts
{
    public interface ILoadData<T>
    {
        IEnumerable<T> LoadData(string filePath);
    }
}
