using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private DBDataContext context;
        private void Form2_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("");
            try
            {
                context = new DBDataContext();
                var result = from l in context.TBL_LICENSE_GENERATEs select l;
                dataGridView1.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
         //   MessageBox.Show(e.ColumnIndex.ToString());
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            var dialog = MessageBox.Show(this, "Are you sure to Edit?","", MessageBoxButtons.OKCancel);
            if (dialog == System.Windows.Forms.DialogResult.OK)
            {
                if (row != null)
                {
                    try
                    {
                        // string strVillageCode = row.Cells["VILLAGE_CODE"].Value.ToString();
                        //  int num = Convert.ToInt32((row.Cells["NOTE"].Value.ToString()));
                        // MessageBox.Show(row.Cells["CREATE_BY"].Value.ToString());
                        if (row.Cells["NOTE"].Value == null)
                        {
                            MessageBox.Show("NullExpection");
                        }
                        else
                        {
                            MessageBox.Show(row.Cells["NOTE"].Value.ToString());
                        }

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                }
            }
            
        }
    }
}
