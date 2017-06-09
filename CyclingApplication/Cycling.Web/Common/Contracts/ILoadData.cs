using System.Collections.Generic;
using System.Xml;
using Cycling.Models;

namespace Cycling.Web.Common.Contracts
{
    public interface ILoadData<T>
    {
        ICollection<Cyclist> LoadDataFromJson(string filePath);

        void GetListOfWinner(XmlReader node, IList<TourData> tour);
    }
}
