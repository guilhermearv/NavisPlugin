using Autodesk.Navisworks.Api.Automation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavisPlugin
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Navisworks App
        /// </summary>
        public NavisworksApplication NwApp { get; set; }
        
        /// <summary>
        /// Construtor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicia o Navisworks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btStart_mouseUp(object sender, MouseEventArgs e)
        {
            //Inicia o Navisworks
            NwApp = new NavisworksApplication();
            //Define a janela do Navisworks está visivel.
            NwApp.Visible = true;
        }
        
        /// <summary>
        /// Anexa modelos ao Navisworks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAppendModel_mouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                var dg = new OpenFileDialog();
                if (dg.ShowDialog()==DialogResult.OK)
                {
                    //Append do modelo
                    NwApp.AppendFile(dg.FileName);
                }
            }
            catch (Exception exception)
            {
                //Messagem de erro
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            //Fechando o Navisworks
            NwApp.Dispose();
            base.OnClosing(e);
        }

        /// <summary>
        /// Fecha o Navisworks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClose_mouseUp(object sender, MouseEventArgs e)
        {
            NwApp.Dispose();
        }
    }
}
