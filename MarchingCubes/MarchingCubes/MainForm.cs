using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarchingCubes
{
    public partial class MainForm : Form
    {
        public MainGame Game { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        public IntPtr CanvasHandle
        {
            get { return xnaPictureBox.Handle; }
        }

        public Size ViewportSize
        {
            get { return xnaPictureBox.Size; }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
