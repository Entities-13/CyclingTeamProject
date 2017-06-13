using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace Cycling.Web.Common.Contracts
{
    public interface ILoadXmlData<T>
    {
        void GetListOfWinner(XmlReader node, IList<TourData> tour);
    }
}