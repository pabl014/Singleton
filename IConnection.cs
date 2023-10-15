using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton {
    public interface IConnection {
        char Get(int index);
        void Set(int index, char c);
        int Length();
    }
}
