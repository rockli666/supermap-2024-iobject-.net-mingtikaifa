using SuperMap.Data;
using SuperMap.Mapping;
using SuperMap.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CampusMap
{
    static public  class ShowInMap
    {
        static public void ShowCustomStyle(MapControl mapControl1, int i,bool click)
        {
            if (!click)
            {
                foreach (Layer layer in mapControl1.Map.Layers)
                {
                    layer.IsVisible = false;
                }
                mapControl1.Map.Layers[i].IsVisible = true;
                mapControl1.Map.EnsureVisible(mapControl1.Map.Layers[i]);
                mapControl1.Map.Layers[1].IsVisible = true;
                mapControl1.Map.Layers[4].IsVisible = true;
            }
            else
            {
                foreach (Layer layer in mapControl1.Map.Layers)
                {
                    layer.IsVisible = true;
                }
                mapControl1.Map.Layers[2].IsVisible = false;
                mapControl1.Map.Layers[3].IsVisible = false;
            }

        }
    }
}
