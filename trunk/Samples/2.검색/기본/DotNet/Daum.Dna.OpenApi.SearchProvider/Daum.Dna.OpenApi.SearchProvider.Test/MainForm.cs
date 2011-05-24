using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Daum.Dna.OpenApi.SearchProvider.Responses;

namespace Daum.Dna.OpenApi.SearchProvider.Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BlogData d = OpenApiProvider.RequestBlogApi("7fd190dd37f0ad9d15cbfd69e6d1aa3320623256", "apple", 10, 1, "accu", "rss", "");
            
        }
    }
}
