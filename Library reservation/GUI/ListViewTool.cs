using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_reservation.GUI
{
    class ListViewTool
    {
        public void ShowDataInListView(DataTable dt, ListView lv)
        {
            lv.Clear();
            lv.AllowColumnReorder = true;
            lv.GridLines = true;
            lv.FullRowSelect = true;
            lv.View = View.Details;
            lv.Scrollable = true;
            lv.MultiSelect = false;
            lv.HeaderStyle = ColumnHeaderStyle.Clickable;
            lv.View = View.Details;
            int RowCount, ColumnCount;
            DataRow dr = null;
            if (dt == null) return;
            RowCount = dt.Rows.Count;
            ColumnCount = dt.Columns.Count;
            for (int i = 0; i < ColumnCount; i++)
            {
                lv.Columns.Add(dt.Columns[i].Caption.Trim(), lv.Width / ColumnCount);
            }
            if (RowCount == 0) return;
            for (int i = 0; i < RowCount; i++)
            {
                dr = dt.Rows[i];
                lv.Items.Add(dr[0].ToString());
                for (int j = 1; j < ColumnCount; j++)
                {
                    lv.Items[i].SubItems.Add(dr[j].ToString());
                }
            }

        }
    }
}
