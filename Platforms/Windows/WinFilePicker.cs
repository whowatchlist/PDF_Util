using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFolderPicker = Windows.Storage.Pickers.FolderPicker;

namespace PDF_Util.Platforms.Windows
{
    public class WinFilePicker : IFolderPicker
    {
        public async Task<String> PickFolder()
        {
            var fp = new WindowsFolderPicker();

            // Windows 10 needs this
            fp.FileTypeFilter.Add("*");

            var handle = ((MauiWinUIWindow)App.Current.Windows[0].Handler.PlatformView).WindowHandle;

            WinRT.Interop.InitializeWithWindow.Initialize(fp, handle);

            var output = await fp.PickSingleFolderAsync();

            return output.Path;
        }
    }
}
