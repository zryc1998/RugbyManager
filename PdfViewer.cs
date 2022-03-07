using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RugbyManager
{
    public partial class PdfViewer : Form
    {
        public PdfViewer(string fileName)
        {
            InitializeComponent();
            axAcroPDF1.LoadFile(fileName);
        }
    }
}
