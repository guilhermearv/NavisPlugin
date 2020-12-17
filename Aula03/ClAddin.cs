using Aula03.Ctr;
using Autodesk.Navisworks.Api.Plugins;
using System;
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
                    if (!Autodesk.Navisworks.Api.Application.IsAutomated)
                    {
                        var pluginRecord = Autodesk.Navisworks.Api.Application.Plugins.FindPlugin("Aula04.CONNAULA04");

                        if (pluginRecord is DockPanePluginRecord && pluginRecord.IsEnabled)
                        {
                            var dockPanel = (DockPanePlugin)(pluginRecord.LoadedPlugin ?? pluginRecord.LoadPlugin());
                            dockPanel.ActivatePane();
                        }
                    }
                    break;
                default:
                    break;
            }

            return 0;
        }
    }
}

namespace Aula04
{
    [Plugin("Aula04", "CONNAULA04", DisplayName = "Aula 04")]
    [DockPanePlugin(200, 400, AutoScroll = true, MinimumHeight = 100, MinimumWidth = 200)]
    public class Aula04 : DockPanePlugin
    {
        public override Control CreateControlPane()
        {
            return new UcUpdate { Dock = DockStyle.Fill };
        }

        public override void DestroyControlPane(Control pane)
        {
            try
            {
                var ctr = (UcUpdate)pane;
                ctr?.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
