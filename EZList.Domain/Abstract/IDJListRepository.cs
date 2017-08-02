using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZList.Domain.Core;

namespace EZList.Domain.Abstract
{
    public interface IDJListRepository
    {
        IEnumerable<DJList> DJLists { get; }
    }
}
