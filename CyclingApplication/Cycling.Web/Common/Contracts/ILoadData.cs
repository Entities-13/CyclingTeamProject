using System.Collections.Generic;

namespace Cycling.Web.Common.Contracts
{
    public interface ILoadData<T>
    {
        IEnumerable<T> LoadData(string filePath);
    }
}
