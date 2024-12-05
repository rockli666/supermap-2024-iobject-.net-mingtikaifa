using SuperMap.Data;
using SuperMap.Mapping;
using SuperMap.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CampusMap
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(MapControl mapControl1) 
        {
            InitializeComponent();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //获取选择集
            Selection[] selection = mapControl1.Map.FindSelection(true);

            //判断选择集是否为空
            if (selection == null || selection.Length == 0)
            {
                return;
            }

            //将选择集转换为记录
            Recordset recordset = selection[0].ToRecordset();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < recordset.FieldCount; i++)
            {
                //定义并获得字段名称
                String fieldName = recordset.GetFieldInfos()[i].Name;

                //将得到的字段名称添加到dataGridView列中
                dataGridView1.Columns.Add(fieldName, fieldName);
            }

            //初始化row
            DataGridViewRow row = null;

            //根据选中记录的个数，将选中对象的信息添加到dataGridView中显示
            while (!recordset.IsEOF)
            {
                row = new DataGridViewRow();
                for (int i = 0; i < recordset.FieldCount; i++)
                {
                    //定义并获得字段值
                    Object fieldValue = recordset.GetFieldValue(i);

                    //将字段值添加到dataGridView中对应的位置
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    if (fieldValue != null)
                    {
                        cell.ValueType = fieldValue.GetType();
                        cell.Value = fieldValue;
                    }

                    row.Cells.Add(cell);
                }

                dataGridView1.Rows.Add(row);

                recordset.MoveNext();
            }
            dataGridView1.Update();
            recordset.Dispose();
        }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}




