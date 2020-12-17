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

namespace Aula03.Ctr
{
    public partial class UcUpdate : UserControl
    {
        public Timer UpTimer = new Timer { Enabled = true, Interval = 1000 };

        public List<FileInfo> ListInfos = new List<FileInfo>();

        public UcUpdate()
        {
            InitializeComponent();
            btUpdate.Enabled = false;

            UpTimer.Tick += UpTimerOnTick;

            Autodesk.Navisworks.Api.Application.ActiveDocumentChanged += ApplicationOnActiveDocumentChanged;
        }

        private void ApplicationOnActiveDocumentChanged(object sender, EventArgs e)
        {
            ListInfos.Clear();
        }

        private void UpTimerOnTick(object sender, EventArgs eventArgs)
        {
            if (checkPause.Checked) return;
            if (Autodesk.Navisworks.Api.Application.ActiveDocument == null) return;

            var activeDocument = Autodesk.Navisworks.Api.Application.ActiveDocument;

            foreach (var model in activeDocument.Models)
            {
                var currentInfo = new FileInfo(model.SourceFileName);
                var lastInfo = ListInfos.FirstOrDefault(i => i.FullName == currentInfo.FullName);

                if (lastInfo != null)
                {
                    var time = Math.Abs((lastInfo.LastAccessTime - currentInfo.LastWriteTime).TotalSeconds);

                    if (time > 1)
                    {
                        ListInfos.Remove(lastInfo);
                        ListInfos.Add(currentInfo);

                        tbLog.AppendText(string.Concat(currentInfo.Name, " was update!", Environment.NewLine));

                        if (checkAutoUpdate.Checked)
                        {
                            UpdateModel();
                        }
                    }
                }
                else
                {
                    ListInfos.Add(currentInfo);
                }
            }
        }

        private void UpdateModel()
        {
            Autodesk.Navisworks.Api.Application.ActiveDocument.UpdateFiles();
            tbLog.AppendText(string.Concat("The active document was update!", Environment.NewLine));
            btUpdate.Enabled = false;
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            Dock = DockStyle.Fill;
        }

        private void btUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateModel();
        }

        private void btClear_MouseUp(object sender, MouseEventArgs e)
        {
            tbLog.Clear();
        }
    }
}
