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
        private CubesInfo _cubesInfo;

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

        public void SetCubesInfo(CubesInfo info)
        {
            _cubesInfo = info;
            this.dimSizeNumericUpDown.Value = info.DimensionSize;
            this.polygonsColorPicker.Color = ColorUtils.DrawingColor(_cubesInfo.Color);
        }

        private void dimSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _cubesInfo.DimensionSize = (int) this.dimSizeNumericUpDown.Value;
        }

        private void polygonsColorPicker_ColorSelected(object sender, ColorSelectedArg e)
        {
            _cubesInfo.Color = ColorUtils.XNAColor(e.Color);
        }
    }
}
