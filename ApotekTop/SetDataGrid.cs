using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekTop
{
    class SetDataGrid
    {
        
        public void HiddenColumns(DataGridView thisGrid, byte numberOfColumns)
        {
            thisGrid.Columns[numberOfColumns].Visible = false;
        }

        public void CreateHeader(DataGridView thisGrid, byte thisCount, string nameOfColumns, string sizeOfColumns = null)
        //Format penggunaan contoh : CreateHeader(datagridView1, 3, "dummy, nama, username, password, level
        {
            thisGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            thisGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DeepSkyBlue;            
            thisGrid.AutoGenerateColumns = true;

            string[] emdCap, emdLebar;
            emdCap = nameOfColumns.Split(',');
            emdLebar = sizeOfColumns.Split(',');
          
            for (int i = 0; i <= thisCount; i++)
            {
                thisGrid.Columns[i].HeaderText = emdCap[i];
            }
            for (int j = 0; j <= thisCount; j++)
            {
                thisGrid.Columns[j].Width = Byte.Parse(emdLebar[j]);
               // thisGrid.Columns[j].Width = thisGrid.Width;
            }
        }

        //public double ThisNumberGrid
        //{
        //    get { return this.thisNumberGrid; }
        //    set { this.thisNumberGrid = value;  }
        //}
    }
}
