using System.Collections.Generic;
using Cycling.Models;

namespace Cycling.Web.Contracts
{
    public interface IFindCyclist
    {
        IEnumerable<Cyclist> Find();
    }
}