using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SuperMap.Data;
using SuperMap.UI;
using SuperMap.Mapping;
using SuperMap.Analyst.NetworkAnalyst;
using System.Security.Policy;

namespace CampusMap
{
    class Analysis
    {
        private static String m_datasetName = "RoadNet";
        private static String m_nodeID = "SmNodeID";
        private static String m_edgeID = "SmEdgeID";
        private SelectMode m_selectMode;
        private MapControl m_mapControl;
        private Workspace m_workspace;
        private DatasetVector m_datasetLine;
        private DatasetVector m_datasetPoint;
        private Layer m_layerLine;
        private Layer m_layerPoint;
        private TrackingLayer m_trackingLayer;
        private Point2Ds m_Points;
        private GeoStyle m_style;
        private List<Int32> m_barrierNodes;
        private List<Int32> m_barrierEdges;
        private TransportationAnalyst m_analyst;
        private TransportationAnalystResult m_result;
        private DataGridView m_dataGridView;
        private Timer m_timer;
        private int m_count;
        private int m_flag;
        /// <summary>
        /// 选择模式枚举。
        /// Select mode enum
        /// </summary>
        public enum SelectMode
        {
            SelectPoint, None
        }
       
        /// <summary>
        /// 根据workspace、mapControl及DataGridView构造SampleRun对象。
        /// Initialize the SampleRun object with the specified workspace, mapControl, and dataGridView.
        /// </summary>
        public Analysis(Workspace workspace, MapControl mapControl)
        {
            m_workspace = workspace;
            m_mapControl = mapControl;

            m_mapControl.Map.Workspace = workspace;
            Initialize();
        }

        #region 初始化
        /// <summary>
        /// 打开网络数据集并初始化相应变量。
        /// Open the network dataset and initialize variables
        /// </summary>
        private void Initialize()
        {
            try
            {
                // 打开数据源,得到点线数据集
                // Open datasource and get the point , line datasets
       

                m_datasetLine = (DatasetVector)m_workspace.Datasources[0].Datasets["Campus_Network_1"];
                m_datasetPoint = m_datasetLine.ChildDataset;
                m_trackingLayer = m_mapControl.Map.TrackingLayer;
                m_trackingLayer.IsAntialias = true;

                // 初始化各变量
                // Initialzie variables
                m_flag = 1;
                m_Points = new Point2Ds();
                m_style = new GeoStyle();
                m_barrierNodes = new List<Int32>();
                m_barrierEdges = new List<Int32>();
                m_selectMode = SelectMode.SelectPoint;

                m_timer = new Timer();
                m_timer.Interval = 200;
                m_timer.Enabled = false;

                // 加载点数据集及线数据集并设置各自风格
                // Add point, line datasets and set their styles
                m_layerLine = m_mapControl.Map.Layers.Add(m_datasetLine, true);
                m_layerLine.IsSelectable = false;
                LayerSettingVector lineSetting = (LayerSettingVector)m_layerLine.AdditionalSetting;
                GeoStyle lineStyle = new GeoStyle();
                lineStyle.LineColor = Color.LightGray;
                lineStyle.LineWidth = 0.1;
                lineSetting.Style = lineStyle;

                m_layerPoint = m_mapControl.Map.Layers.Add(m_datasetPoint, true);
                LayerSettingVector pointSetting = (LayerSettingVector)m_layerPoint.AdditionalSetting;
                GeoStyle pointStyle = new GeoStyle();
                pointStyle.LineColor = Color.DarkGray;
                pointStyle.MarkerSize = new Size2D(2.5, 2.5);
                pointSetting.Style = pointStyle;

                // 调整mapControl的状态
                // Adjust the status of mapControl
                m_mapControl.Action = SuperMap.UI.Action.Select;
                m_mapControl.Map.IsAntialias = true;
                m_mapControl.IsWaitCursorEnabled = false;
                m_mapControl.Map.Refresh();

                //m_mapControl.MouseDown += new MouseEventHandler(m_mapControl_MouseDown);
                m_timer.Tick += new EventHandler(m_timer_Tick);
                Load();

            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 加载环境设置对象。
        // Add the TransportationAnalystSetting object
        /// </summary>
        public void Load()
        {
            try
            {
                // 设置网络分析基本环境，这一步骤需要设置分析权重、节点、弧段标识字段、容限
                // Set the basic environment of network analysis, including weight, node, edge, tolerance.
                TransportationAnalystSetting setting = new TransportationAnalystSetting();
                setting.NetworkDataset = m_datasetLine;
                setting.EdgeIDField = "SmEdgeID";
                setting.NodeIDField = "SmNodeID";
                setting.EdgeNameField = "NAME";

                setting.Tolerance = 89;

                WeightFieldInfos weightFieldInfos = new WeightFieldInfos();
                WeightFieldInfo weightFieldInfo = new WeightFieldInfo();
                weightFieldInfo.FTWeightField = "SmLength";
                weightFieldInfo.TFWeightField = "SmLength";
                weightFieldInfo.Name = "length";
                weightFieldInfos.Add(weightFieldInfo);
                setting.WeightFieldInfos = weightFieldInfos;
                setting.FNodeIDField = "SmFNode";
                setting.TNodeIDField = "SmTNode";

                // 构造交通网络分析对象，加载环境设置对象
                // Build the TransportationAnalyst object , and add environment setting object
                m_analyst = new TransportationAnalyst();
                m_analyst.AnalystSetting = setting;
                m_analyst.Load();
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }
        #endregion

        public void START()
        {
                m_mapControl.MouseDown += new MouseEventHandler(m_mapControl_MouseDown);
        }
        int index = 0;



        #region 选点
        /// <summary>
        /// MapControl MouseDown事件。
        /// MouseDown event of MapControl
        /// </summary>
        private void m_mapControl_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    Point point = new Point(e.X, e.Y);
                    Point2D mapPoint = m_mapControl.Map.PixelToMap(point);
                    if (m_mapControl.Map.Bounds.Contains(mapPoint))
                    {
                        if ((m_mapControl.Action == SuperMap.UI.Action.Select
                                || m_mapControl.Action == SuperMap.UI.Action.Select2)
                                && m_selectMode == SelectMode.SelectPoint)
                        {
                            if (index < 2)
                            {
                                AddPoint(mapPoint);
                                index++;
                            }
                            else
                            {
                                MessageBox.Show("请先清除再选点");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }



        /// <summary>
        /// 添加分析经过点。
        /// Add points along the path
        /// </summary>
        public void AddPoint(Point2D mapPoint)
        {
            try
            {
                // 在跟踪图层上添加点
                // Add points on the tracking layer
                m_Points.Add(mapPoint);
                GeoPoint geoPoint = new GeoPoint(mapPoint);
                m_style.LineColor = Color.Green;
                m_style.MarkerSize = new Size2D(8, 8);
                geoPoint.Style = m_style;
                m_trackingLayer.Add(geoPoint, "Point");

                // 在跟踪图层上添加文本对象
                // Add text objects on the tracking layer
                TextPart part = new TextPart();
                part.X = geoPoint.X;
                part.Y = geoPoint.Y;
                part.Text = m_flag.ToString();
                m_flag++;
                GeoText geoText = new GeoText(part);
                m_trackingLayer.Add(geoText, "Point");
                m_mapControl.Map.RefreshTrackingLayer();

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }


        #endregion

        #region 路径分析
        /// <summary>
        /// 进行最短路径分析。
        /// Optimal path analysis
        /// </summary>
        /// <returns></returns>
        Form2 f2=new Form2();
        public bool Analyst()
        {
            try
            {
                m_count = 0;
                TransportationAnalystParameter parameter = new TransportationAnalystParameter();

                parameter.WeightName = "length";

                // 设置最佳路径分析的返回对象
                // Set the return object of the optimal path analysis
                parameter.Points = m_Points;
                parameter.IsNodesReturn = true;
                parameter.IsEdgesReturn = true;
                parameter.IsPathGuidesReturn = true;
                parameter.IsRoutesReturn = true;

                // 进行分析并显示结果
                // Analyze
                m_result = m_analyst.FindPath(parameter, false);
                if (m_result == null)
                {
                    if (SuperMap.Data.Environment.CurrentCulture != "zh-CN")
                    {
                        MessageBox.Show("Failed");
                    }
                    else
                    {
                        MessageBox.Show("分析失败");
                    }
                    return false;
                }
                ShowResult();
                f2 = new Form2(m_result);
                m_selectMode = SelectMode.None;
                f2.ShowDialog();
                return true;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return false;
            }
        }
        #endregion

        #region 显示结果
        /// <summary>
        /// 显示结果。
        /// Show result
        /// </summary>
        public void ShowResult()
        {
            try
            {
                // 删除原有结果
                // Delete the original result
                int count = m_trackingLayer.Count;
                for (int i = 0; i < count; i++)
                {
                    int index = m_trackingLayer.IndexOf("result");
                    if (index != -1)
                    {
                        m_trackingLayer.Remove(index);
                    }
                }
                for (int i = 0; i < m_result.Routes.Length; i++)
                {
                    GeoLineM geoLineM = m_result.Routes[0];
                    m_style.LineColor = Color.Green;
                    m_style.LineWidth = 2;
                    geoLineM.Style = m_style;
                    m_trackingLayer.Add(geoLineM, "result");
                }
                m_mapControl.Map.RefreshTrackingLayer();

            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }
        #endregion

        #region 引导
        /// <summary>
        /// 开始导引。
        /// Start guiding
        /// </summary>
        public void Play()
        {
            m_timer.Start();
        }

        /// <summary>
        /// 停止导引。
        /// Stop guiding
        /// </summary>
        public void Stop()
        {
            m_timer.Stop();
        }

        /// <summary>
        /// 清除分析结果。
        /// Clear the analysis result
        /// </summary>
        public void Clear()
        {
            try
            {
                if (m_timer != null)
                    m_timer.Stop();

               f2.m_dataGridView.Rows.Clear();
                m_flag = 1;
                m_Points = new Point2Ds();
                m_barrierNodes = new List<Int32>();
                m_barrierEdges = new List<Int32>();
                m_mapControl.Map.Layers[0].Selection.Clear();
                m_mapControl.Map.Layers[1].Selection.Clear();
                m_mapControl.Map.TrackingLayer.Clear();
                m_mapControl.Map.Refresh();
                index = 0;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 设置选择模式
        /// Set the select mode
        /// </summary>
        /// <param name="mode"></param>
        public void SetSelectMode(SelectMode mode, Boolean canSelectLine)
        {
            
            m_selectMode = mode;
            m_layerLine.IsSelectable = canSelectLine;
        }

        /// <summary>
        /// 进行行驶导引。
        /// Path guide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                int index = m_trackingLayer.IndexOf("playPoint");
                if (index != -1)
                {
                    m_trackingLayer.Remove(index);
                }

                GeoLineM lineM = m_result.Routes[0];
                PointM pointM = lineM.GetPart(0)[m_count];

                // 构造模拟对象
                // Build simulation object
                GeoPoint point = new GeoPoint(pointM.X, pointM.Y);
                GeoStyle style = new GeoStyle();
                style.LineColor = Color.Red;
                style.MarkerSize = new Size2D(5, 5);
                point.Style = style;
                m_trackingLayer.Add(point, "playPoint");

                // 跟踪对象
                // Tracking object
                m_count++;
                if (m_count >= lineM.GetPart(0).Count)
                {
                    m_count = 0;
                }
                m_mapControl.Map.RefreshTrackingLayer();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}




