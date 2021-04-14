using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Diagnostics;

namespace StreamDesk
{
    public partial class frmInfo : Form
    {
        public frmInfo(string title, string url, string description, string provider)
        {
            InitializeComponent();
            elementHost1.Child = new ScrollViewer();
            TextBlock block = new TextBlock() { TextWrapping = TextWrapping.Wrap, Background = System.Windows.Media.Brushes.White };
            ((ScrollViewer)elementHost1.Child).Content = block;

            block.Inlines.AddRange(new Inline[] { new Run("Name: ") { FontWeight = FontWeights.Bold }, new Run(title), new LineBreak() });
            block.Inlines.AddRange(new Inline[] { new Run("URL: ") { FontWeight = FontWeights.Bold }, getNewHyperlink(url), new LineBreak() });
            block.Inlines.AddRange(new Inline[] { new Run("Provider: ") { FontWeight = FontWeights.Bold }, new Run(provider), new LineBreak() });
            block.Inlines.AddRange(new Inline[] { new LineBreak() });
            block.Inlines.AddRange(new Inline[] { new Run("Description: ") { FontWeight = FontWeights.Bold }, new Run(description)});
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Hyperlink getNewHyperlink(string url)
        {
            Hyperlink hl = new Hyperlink(new Run(url));
            hl.RequestNavigate+=new System.Windows.Navigation.RequestNavigateEventHandler(hl_RequestNavigate);
            hl.NavigateUri = new Uri(url);
            return hl;
        }

        void hl_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
