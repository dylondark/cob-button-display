using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_test
{
    // this class allows for changing the behavior of the web browsers in regards to handling new tabs/windows
    class ChromiumLifeSpanHandler : ILifeSpanHandler
    {
        public bool OnBeforePopup(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            // when a link requests that a new window/tab be opened, prevent the new window and redirect the original browser to that link
            newBrowser = null;
            browser.MainFrame.LoadUrl(targetUrl);
            //MessageBox.Show("onbeforepopup");
            return true;
        }

        public void OnAfterCreated(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            //MessageBox.Show("onaftercreated");
        }

        public bool DoClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            //MessageBox.Show("doclose");
            return true;
        }

        public void OnBeforeClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            //MessageBox.Show("onbeforeclose");
        }

    }
}
