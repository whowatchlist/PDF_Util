using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Util
{
    public interface IFolderPicker
    {
        Task<String> PickFolder();
    }
}
