using System.Collections.Generic;
using System.Xml;
using Cycling.Models;

namespace Cycling.Web.Common.Contracts
{
    public interface ILoadJsonData<T>
    {
        ICollection<T> LoadDataFromJson(string filePath);
    }
}
