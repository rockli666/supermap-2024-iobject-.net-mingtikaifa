using SuperMap.Data;
using SuperMap.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CampusMap
{
    public static class OpenMap
    {
        public static void open(MapControl mapControl1,MapNavigationControl mapNavigationControl1,Workspace workspace1,Panel panel1)
        {
            mapControl1.Dock = DockStyle.Fill;
            mapNavigationControl1.MapControl = mapControl1;
            //panle绑定mapcontrol
            panel1.Controls.Add(mapControl1);
            //关联mapcontrol与workspace            
            mapControl1.Map.Workspace = workspace1;
            //地图打开
            mapControl1.Map.Close();
            workspace1.Close();
            WorkspaceConnectionInfo workspaceConnectionInfo = new WorkspaceConnectionInfo();
            string path = Application.StartupPath;
            string fileName = @"../../../../Campus.smwu";
            FileInfo file = new FileInfo(fileName);
            string fullName = file.FullName;
            workspaceConnectionInfo.Server = fullName;
            workspaceConnectionInfo.Type = WorkspaceType.SMWU;
            workspace1.Open(workspaceConnectionInfo);
            string mapName = workspace1.Maps[0];
            mapControl1.Map.Open(mapName);
            mapControl1.Map.ViewEntire();


        }
    }
}
