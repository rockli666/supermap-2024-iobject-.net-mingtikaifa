using SuperMap.Analyst.NetworkAnalyst;
using SuperMap.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CampusMap
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(TransportationAnalystResult m_result)
        {
            InitializeComponent();
            m_dataGridView.AutoResizeColumns();
            m_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            m_dataGridView.Columns.Clear();
            if (SuperMap.Data.Environment.CurrentCulture != "zh-CN")
            {
                m_dataGridView.Columns.Add("No", "No");
                m_dataGridView.Columns.Add("Guide", "Guide");
                m_dataGridView.Columns.Add("Cost", "Cost");
                m_dataGridView.Columns.Add("Distance", "Distance");
            }
            else
            {
                m_dataGridView.Columns.Add("序号", "序号");
                m_dataGridView.Columns.Add("导引", "导引");
            }

            for (int i = 0; i < m_dataGridView.Columns.Count; i++)
            {
                m_dataGridView.Columns[i].ReadOnly = true;
            }
            FillDataGridView(0,m_result);
        }

        #region 填表
        /// <summary>
        /// 填充DataGridView。
        /// Fill DataGridView
        /// </summary>
        /// <param name="pathNum"></param>
        public void FillDataGridView(Int32 pathNum, TransportationAnalystResult m_result)
        {
            try
            {
                // 清除原数据，添加初始点信息
                // Clear original data and add start point information
                m_dataGridView.Rows.Clear();
                Object[] objs = new Object[4];
                objs[0] = m_dataGridView.RowCount;
                if (SuperMap.Data.Environment.CurrentCulture != "zh-CN")
                {
                    objs[1] = "Start";
                }
                else
                {
                    objs[1] = "从起始点出发";
                }
                objs[2] = "--";
                objs[3] = "--";
                m_dataGridView.Rows.Add(objs);

                // 得到行驶导引对象，根据导引子项类型的不同进行不同的填充
                // Get the PathGuide object, and make different fill according to different items
                PathGuide[] pathGuides = m_result.PathGuides;
                PathGuide pathGuide = pathGuides[pathNum];

                for (int j = 1; j < pathGuide.Count; j++)
                {
                    PathGuideItem item = pathGuide[j];
                    objs[0] = m_dataGridView.RowCount;

                    if (SuperMap.Data.Environment.CurrentCulture != "zh-CN")
                    {
                        // 导引子项为站点的添加方式
                        // If the item is a stop
                        if (item.IsStop)
                        {
                            String side = "None";
                            if (item.SideType == SideType.Left)
                                side = "Left";
                            if (item.SideType == SideType.Right)
                                side = "Right";
                            if (item.SideType == SideType.Middle)
                                side = "On the road";
                            String dis = item.Distance.ToString();
                            if (item.Index == -1 && item.ID == -1)
                            {
                                continue;
                            }
                            if (j != pathGuide.Count - 1)
                            {
                                objs[1] = "Arrive at [" + item.Index + " route], on the " + side
                                        + dis;
                            }
                            else
                            {
                                objs[1] = "Arrive at destination " + side + dis;
                            }
                            objs[2] = "";
                            objs[3] = "";
                            m_dataGridView.Rows.Add(objs);
                        }
                        // 导引子项为弧段的添加方式
                        // If the item is an edge
                        if (item.IsEdge)
                        {
                            String direct = "Go ahead";
                            if (item.DirectionType == DirectionType.East)
                                direct = "East";
                            if (item.DirectionType == DirectionType.West)
                                direct = "West";
                            if (item.DirectionType == DirectionType.South)
                                direct = "South";
                            if (item.DirectionType == DirectionType.North)
                                direct = "North";

                            String weight = item.Weight.ToString();
                            String roadName = item.Name;
                            if (weight.Equals("0") && roadName.Equals(""))
                            {
                                objs[1] = "Go " + direct + " " + item.Length;
                                objs[2] = weight;
                                objs[3] = item.Length;
                                m_dataGridView.Rows.Add(objs);
                            }
                            else
                            {
                                String roadString = roadName.Equals("") ? "Anonymous road" : roadName;
                                objs[1] = "Go along with [" + roadString + "], " + direct + " direction"
                                        + item.Length;
                                objs[2] = weight;
                                objs[3] = item.Length;
                                m_dataGridView.Rows.Add(objs);
                            }
                        }
                    }
                    else
                    {
                        // 导引子项为站点的添加方式
                        // If the item is a stop
                        if (item.IsStop)
                        {
                            String side = "无";
                            if (item.SideType == SideType.Left)
                                side = "左侧";
                            if (item.SideType == SideType.Right)
                                side = "右侧";
                            if (item.SideType == SideType.Middle)
                                side = "道路上";
                            String dis = item.Distance.ToString();
                            if (item.Index == -1 && item.ID == -1)
                            {
                                continue;
                            }
                            if (j != pathGuide.Count - 1)
                            {
                                objs[1] = "到达[" + item.Index + "号路由点],在道路" + side
                                        + dis;
                            }
                            else
                            {
                                objs[1] = "到达终点,在道路" + side + dis;
                            }
                            objs[2] = "";
                            objs[3] = "";
                            m_dataGridView.Rows.Add(objs);
                        }
                        // 导引子项为弧段的添加方式
                        // If the item is an edge
                        if (item.IsEdge)
                        {
                            String direct = "直行";
                            if (item.DirectionType == DirectionType.East)
                                direct = "东";
                            if (item.DirectionType == DirectionType.West)
                                direct = "西";
                            if (item.DirectionType == DirectionType.South)
                                direct = "南";
                            if (item.DirectionType == DirectionType.North)
                                direct = "北";

                            String weight = item.Weight.ToString();
                            String roadName = item.Name;
                            if (weight.Equals("0") && roadName.Equals(""))
                            {
                                objs[1] = "朝" + direct + "行走" + item.Length;
                                objs[2] = weight;
                                objs[3] = item.Length;
                                m_dataGridView.Rows.Add(objs);
                            }
                            else
                            {
                                String roadString = roadName.Equals("") ? "匿名路段" : roadName;
                                objs[1] = "沿着[" + roadString + "],朝" + direct + "行走"
                                        + item.Length;
                                objs[2] = weight;
                                objs[3] = item.Length;
                                m_dataGridView.Rows.Add(objs);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }
        #endregion
    }
}
