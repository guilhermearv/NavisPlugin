using Autodesk.Navisworks.Api.Plugins;
using System.Windows.Forms;

namespace Aula02
{
    [Plugin("Aula02", "CONN", DisplayName = "Navis Plugin :)")]
    public class CIAddin : AddInPlugin
    {
        public override int Execute(params string[] parameters)
        {
            MessageBox.Show("Olá mundo", "Execute", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return 0;
        }
    }
}
