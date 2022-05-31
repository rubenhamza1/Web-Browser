using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WebPreglednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
      
        private void btnGo_Click(object sender, EventArgs e)
        {
            tabControl1.Navigate(txtBrowser.Text);
        }

        private void tsHome_Click(object sender, EventArgs e)
        {
            webbrowser1.GoHome();
        }

        private void tsBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void tsForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void tsNewtab_Click(object sender, EventArgs e)
        {
            TabPage tabpage = new TabPage();
            tabpage.Text = "New Tab";
            tabControl1.Controls.Add(tabpage);
            WebBrowser webbrowser = new WebBrowser();
            webbrowser.Parent = tabpage;
            webbrowser.Dock = DockStyle.Fill;
            webbrowser.Navigate("www.google.com");
        }

        private void tsRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
