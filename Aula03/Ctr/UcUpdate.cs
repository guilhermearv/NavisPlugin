using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03.Ctr
{
    public partial class UcUpdate : UserControl
    {
        public UcUpdate()
        {
            InitializeComponent();
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            Dock = DockStyle.Fill;
        }

        private void btUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Update");
        }
    }
}
