using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Windows.Forms;
using SuperMap.Data;
using SuperMap.Mapping;
using SuperMap.UI;

namespace CampusMap
{
    public partial class Form1 : Form
    {
        private Analysis m_sampleRun;
        bool start = true;
        bool end = true;
        public Form1()
        {
            InitializeComponent();
            //打开地图
            OpenMap.open(mapControl1, mapNavigationControl1, workspace1, panel1);
            mapControl1.Map.Layers[0].IsVisible = false;
            mapControl1.Map.Layers[1].IsVisible = false;
        }
        /// <summary>
        /// 全幅显示的函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Layer layer in mapControl1.Map.Layers)
            {
                layer.IsVisible = true;
            }
            mapControl1.Map.Layers[2].IsVisible = false;
            mapControl1.Map.Layers[3].IsVisible = false;
            mapControl1.Map.Refresh();
            mapControl1.Map.ViewEntire();
        }

        /// <summary>
        /// 控件绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            mapControl1.Dock = DockStyle.Fill;
            mapNavigationControl1.MapControl = mapControl1;
            //panle绑定mapcontrol
            this.panel1.Controls.Add(mapControl1);
            //关联mapcontrol与workspace            
            mapControl1.Map.Workspace = workspace1;
            m_sampleRun = new Analysis(workspace1, mapControl1);
        }
        /// <summary>
        /// 资源释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void From1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mapControl1.Dispose();
            mapControl1 = null;
            workspace1.Dispose();
            workspace1 = null;
            //sampleRun.Dispose();
        }

        #region 界面动画
        //侧边框动画
        bool sidebarExpand = false;
        bool suosouExpand = false;
        bool nagtiveExpand = false;
        bool placeExpand = false;
        private void sidebarTimer_tICK(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                side1.Width -= 10;
                if (side1.Width == side1.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    side.Stop();
                }
                //关闭搜索框
                if (suosouExpand == true)
                {
                    sousuo.Start();
                    sousuo1.Height -= 10;
                    if (sousuo1.Height == sousuo1.MinimumSize.Height)
                    {
                        suosouExpand = false;
                        sousuo.Stop();
                    }
                }
                //关闭导航框
                if (nagtiveExpand == true)
                {
                    nagtive.Start();
                    nagtive1.Height -= 10;
                    if (nagtive1.Height == nagtive1.MinimumSize.Height)
                    {
                        nagtiveExpand = false;
                        nagtive.Stop();
                    }
                }
                //关闭图层框
                if (placeExpand == true)
                {
                    place.Start();
                    place1.Height -= 20;
                    if (place1.Height == place1.MinimumSize.Height)
                    {
                        placeExpand = false;
                        place.Stop();
                    }
                }
            }
            else
            {
                side1.Width += 10;
                if (side1.Width == side1.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    side.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            side.Start();
        }

        //搜索动画
        private void button2_Click(object sender, EventArgs e)
        {
            sousuo.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            place.Start();
        }

        private void place_tICK(object sender, EventArgs e)
        {
            if (!sidebarExpand)
            {
                side.Start();
                //打开侧边框
                side1.Width += 10;
                if (side1.Width == side1.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    side.Stop();
                }
                //打开搜索框
                if (!placeExpand)
                {
                    place1.Height += 10;
                    if (place1.Height == place1.MaximumSize.Height)
                    {
                        placeExpand = true;
                        place.Stop();
                    }
                }
            }
            else
            {
                if (!placeExpand)
                {
                    place1.Height += 10;
                    if (place1.Height == place1.MaximumSize.Height)
                    {
                        placeExpand = true;
                        place.Stop();
                    }
                }
                else
                {
                    place1.Height -= 10;
                    if (place1.Height == place1.MinimumSize.Height)
                    {
                        placeExpand = false;
                        place.Stop();
                    }
                }
            }
        }

        private void sousuo_tICK(object sender, EventArgs e)
        {
            if (!sidebarExpand)
            {
                side.Start();
                //打开侧边框
                side1.Width += 10;
                if (side1.Width == side1.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    side.Stop();
                }
                //打开搜索框
                if (!suosouExpand)
                {
                    sousuo1.Height += 10;
                    if (sousuo1.Height == sousuo1.MaximumSize.Height)
                    {
                        suosouExpand = true;
                        sousuo.Stop();
                    }
                }
            }
            else
            {
                if (!suosouExpand)
                {
                    sousuo1.Height += 10;
                    if (sousuo1.Height == sousuo1.MaximumSize.Height)
                    {
                        suosouExpand = true;
                        sousuo.Stop();
                    }
                }
                else
                {
                    sousuo1.Height -= 10;
                    if (sousuo1.Height == sousuo1.MinimumSize.Height)
                    {
                        suosouExpand = false;
                        sousuo.Stop();
                    }
                }
            }
        }
        /// <summary>
        /// 导航
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            nagtive.Start();
        }

        private void nagtive_tICK(object sender, EventArgs e)
        {
            if (!sidebarExpand)
            {
                side.Start();
                //打开侧边框
                side1.Width += 10;
                if (side1.Width == side1.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    side.Stop();
                }
                //打开导航框
                if (!nagtiveExpand)
                {
                    nagtive1.Height += 10;
                    if (nagtive1.Height == nagtive1.MaximumSize.Height)
                    {
                        nagtiveExpand = true;
                        nagtive.Stop();
                    }
                }
            }
            else
            {
                if (!nagtiveExpand)
                {
                    nagtive1.Height += 10;
                    if (nagtive1.Height == nagtive1.MaximumSize.Height)
                    {
                        nagtiveExpand = true;
                        nagtive.Stop();
                    }
                }
                else
                {
                    nagtive1.Height -= 10;
                    if (nagtive1.Height == nagtive1.MinimumSize.Height)
                    {
                        nagtiveExpand = false;
                        nagtive.Stop();
                    }
                }
            }
        }

        #endregion

        /// <summary>
        ///查询功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("查询信息不能为空");
                return;
            }
            Search.search(mapControl1, textBox1.Text);
        }

        private void side1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// 选择查属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //获取选择集
            Selection[] selection = mapControl1.Map.FindSelection(true);

            //判断选择集是否为空
            if (selection == null || selection.Length == 0)
            {
                MessageBox.Show("请选择要查询的对象");
                return;
            }
            else
            {
                Form3 f3 = new Form3(mapControl1);
                f3.ShowDialog();
            }
        }


        #region 导航功能
        /// <summary>
        /// 获取toolStrip_dataCompiler	   
        /// Get toolStrip_dataCompiler
        /// </summary>
        bool addp = false;
        int i = 0;
        private void toolStrip_dataCompiler_Click(object sender, EventArgs e)
        {
            if (!addp && i == 0)
            {
                m_sampleRun.START();
                addp = true;
                i++;
            }
            else if (!addp && i != 0)
            {
                Analysis.SelectMode mode = Analysis.SelectMode.SelectPoint;
                m_sampleRun.SetSelectMode(mode, false);
                EnabledControl(true);
                addp = true;
            }
            else
            {
                m_sampleRun.Clear();
                Analysis.SelectMode mode = Analysis.SelectMode.None;
                m_sampleRun.SetSelectMode(mode, false);
                EnabledControl(true);
                addp = false;
            }
        }

        private void EnabledControl(bool isEnabled)
        {
            radioButtonPoint.Enabled = isEnabled;
            toolStripButtonAnalyst.Enabled = isEnabled;
            toolStripButtonStop.Enabled = !isEnabled;
            toolStripButtonPlay.Enabled = !isEnabled;
        }

        /// <summary>
        /// 获取toolStrip_addStartPoint_Click         
        /// Get toolStrip_addStartPoint_Click
        /// </summary>
        private void toolStrip_addStartPoint_Click(object sender, EventArgs e)
        {
            if (m_sampleRun.Analyst())
            {
                EnabledControl(false);
            }
        }

        /// <summary>
        /// 获取toolStrip_addEndPoint_Click         
        /// Get toolStrip_addEndPoint_Click
        /// </summary>
        private void toolStrip_addEndPoint_Click(object sender, EventArgs e)
        {
            m_sampleRun.Play();
        }
        /// <summary>
        /// 获取toolStrip_pathAnalyst_Click         
        /// Get toolStrip_pathAnalyst_Click
        /// </summary>
        private void toolStrip_pathAnalyst_Click(object sender, EventArgs e)
        {
            m_sampleRun.Stop();
        }

        /// <summary>
        /// 获取toolStrip_clear_Click
        /// Get toolStrip_clear_Click
        /// </summary>
        private void toolStrip_clear_Click(object sender, EventArgs e)
        {
            try
            {
                m_sampleRun.Clear();

                Analysis.SelectMode mode = Analysis.SelectMode.SelectPoint;
                m_sampleRun.SetSelectMode(mode, false);
                //addp = false;
                EnabledControl(true);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }
        #endregion

        #region 图层显示
        bool click1 = true, click2 = true, click3 = true, click4 = true, click5 = true, click6 = true;

        private void button10_Click(object sender, EventArgs e)
        {
            if (click1) click1 = false;
            else if (!click1) click1 = true;
            ShowInMap.ShowCustomStyle(mapControl1, 10, click1);
            mapControl1.Map.Refresh();
            click2 = true; click3 = true; click4 = true; click5 = true; click6 = true;
        }
       
        private void button6_Click(object sender, EventArgs e)
        {
            if (click2) click2 = false;
            else if (!click2) click2 = true;
            ShowInMap.ShowCustomStyle(mapControl1, 9, click2);
            mapControl1.Map.Refresh();
            click1 = true; click3 = true; click4 = true; click5 = true; click6 = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click3) click3 = false;
            else if (!click3) click3 = true;
            ShowInMap.ShowCustomStyle(mapControl1, 5, click3);
            mapControl1.Map.Refresh();
            click2 = true; click1 = true; click4 = true; click5 = true; click6 = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click4) click4 = false;
            else if (!click4) click4 = true;
            ShowInMap.ShowCustomStyle(mapControl1, 6, click4);
            mapControl1.Map.Refresh();
            click2 = true; click3 = true; click1 = true; click5 = true; click6 = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click5) click5 = false;
            else if (!click5) click5 = true;
            ShowInMap.ShowCustomStyle(mapControl1, 7, click5);
            mapControl1.Map.Refresh();
            click2 = true; click3 = true; click4 = true; click1 = true; click6 = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (click6) click6 = false;
            else if (!click6) click6 = true;
            ShowInMap.ShowCustomStyle(mapControl1, 1, click6);
            mapControl1.Map.Refresh();
            click2 = true; click3 = true; click4 = true; click5 = true; click1 = true;
        }

        /// <summary>
        /// 三维展示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            if (mapControl1.Map.Layers[2].IsVisible == false)
            {
                mapControl1.Map.Layers[2].IsVisible = true;
                mapControl1.Map.Layers[3].IsVisible = true;
            }
            else
            {
                mapControl1.Map.Layers[2].IsVisible = false;
                mapControl1.Map.Layers[3].IsVisible = false;
            }
            mapControl1.Map.Refresh();
        }
        #endregion
    }
}