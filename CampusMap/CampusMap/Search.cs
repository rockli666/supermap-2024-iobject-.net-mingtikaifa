using SuperMap.Data;
using SuperMap.Mapping;
using SuperMap.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CampusMap
{
   static public class Search
    {
       public static void search(MapControl mapControl1,string textBox1)
        {
            if (textBox1 == "学生证")
                textBox1 = "1号教学楼";
            if (textBox1 == "锻炼")
                textBox1 = "操场";
            foreach (Layer layer in mapControl1.Map.Layers)
            {
                layer.IsVisible = true;           
            }
            mapControl1.Map.Layers[2].IsVisible = false;
            mapControl1.Map.Layers[3].IsVisible = false;
            //定义查询条件信息;
            QueryParameter queryParameter = new QueryParameter();
            string text1 = "名称" + " " + " Like" + " " + "\"" + "%"+textBox1+ "%" + "\"";
            queryParameter.AttributeFilter = text1;
            queryParameter.CursorType = CursorType.Static;
            Boolean hasGeometry = false;
            //遍历每一个图层，实现多图层查询
            foreach(Layer layer in mapControl1.Map.Layers)
            {
                //得到矢量数据集并强制转换为矢量数据集类型
                DatasetVector dataset = layer.Dataset as DatasetVector;

                if (dataset == null)
                {
                    continue;
                }
                //通过查询条件对矢量数据集进行查询,从数据集中查询出属性数据，
                Recordset recordset = dataset.Query(queryParameter);
                //判断是否有查询结果
                if (recordset.RecordCount > 0)
                {
                    hasGeometry = true;            
                }
                //把查询得到的数据加入到选择集中(使其高亮显示)
                Selection selection = layer.Selection;
                mapControl1.Map.EnsureVisible(recordset);
                selection.FromRecordset(recordset);
              
                recordset.Dispose();
            
            }
            //没有查询结果，弹出提示
            if (!hasGeometry)
            {
                MessageBox.Show("没有符合查询条件的结果");
            }
            
            //当可创建对象使用完毕后，使用Dispose方法来释放所占用的内部资源。
            queryParameter.Dispose();
            
            //刷新地图窗口显示
            mapControl1.Refresh();
            mapControl1.Map.Refresh();
            Form3 f3 = new Form3(mapControl1);
            f3.ShowDialog();
            Selection[] s = mapControl1.Map.FindSelection(true);
            foreach(Selection a in s)
            a.Clear();
            hasGeometry = false;
        }
    }
}
