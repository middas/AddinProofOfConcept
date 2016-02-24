using System;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddinView.V1
{
    [AddInBase]
    public interface ICallback
    {
        void DoWork();
    }
}
