using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace file_explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browser_btn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    webBrowser.Url = new Uri(dialog.SelectedPath);
                    path_text.Text = dialog.SelectedPath;
                }
            }
        }


        private void back_btn_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            if (!webBrowser.CanGoForward)
                webBrowser.GoForward();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
