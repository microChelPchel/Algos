using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmAndStructedData.Logic.FormFactory
{
    internal interface ICreaterView
    {
        Control CallView(ViewEnum viewType);
    }
}
