using System.Collections;

namespace Cycling.Common.Contracts
{
    public interface ILoadData
    {
        ICollection LoadData(string filePath);
    }
}
