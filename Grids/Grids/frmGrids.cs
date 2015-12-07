using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grids
{
    public partial class frmGrids : Form
    {
        public frmGrids()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //grdTest.ColumnCount = 3;
            //grdTest.Rows[0].Cells[0].Value = "Col 1";
           // grdTest.Rows[0].Cells[1].Value = "Col 2";
           // grdTest.Rows[0].Cells[2].Value = "Col 3";

            grdTest.Columns.Add("Col1", "ID");
            grdTest.Columns.Add("Col2", "Name");
            grdTest.Columns.Add("Col3", "Blurb");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = grdTest.Rows.Add();
            grdTest.Rows[index].Cells[0].Value = grdTest.RowCount-1;
            grdTest.Rows[index].Cells[1].Value = "Book " + (grdTest.RowCount - 1).ToString();
            grdTest.Rows[index].Cells[2].Value = "Blah Blah";
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //can not delete the very last row
            if (grdTest.Rows.Count == 1)
            {
                MessageBox.Show("No Rows to Delete");
                return;
            }
                
            
            //remove the selected row
            grdTest.Rows.RemoveAt(grdTest.CurrentCell.RowIndex);

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //Clear currently selected row and Set row index to Row 0
            grdTest.ClearSelection();
            grdTest.Rows[0].Selected = true;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            //Clear currently selected row and Set row index to last row
            grdTest.ClearSelection();
            grdTest.Rows[grdTest.Rows.Count-2].Selected = true;
        }

     
        private void grdTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //display (extract) the value in the selected cell in a MessageBox
            MessageBox.Show("The value in the selected cell is :" + grdTest.CurrentCell.Value);
        }
    }
}
