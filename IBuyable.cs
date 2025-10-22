using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem.Models
{
    public interface IBuyable
    {
        void Buy();
        void Return();
    }
}
