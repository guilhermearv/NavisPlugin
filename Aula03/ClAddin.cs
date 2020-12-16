using Autodesk.Navisworks.Api.Plugins;
using System.Windows.Forms;

namespace Aula03
{
    [Plugin("Aula03", "CONNAULA03", DisplayName = "AddinRibbon")]
    [RibbonLayout("Aula03.xaml")]
    [RibbonTab("ID_CustomTab_1", DisplayName = "CONNESSIONI")]
    [Command("ID_Button_1", Icon = "1_16.png", LargeIcon = "1_32.png", ToolTip = "Show a message")]
    public class ClAddin : CommandHandlerPlugin
    {
        public override int ExecuteCommand(string name, params string[] parameters)
        {
            switch (name)
            {
                case "ID_Button_1":
                    MessageBox.Show("ID_Button_1");
                    break;
                default:
                    break;
            }

            return 0;
        }
    }
}
