using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmiCalcuator
{
    public partial class DeailsInstalments : Form
    {
        DataTable dataTable;

        List<Model> models = new List<Model>();
        public DeailsInstalments(List<Model> a)
        {
            this.models = a;
            InitializeComponent();
            dataGridView.ClearSelection();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
           
            dataTable = new DataTable();
            dataTable.Columns.Add("Sno");
                dataTable.Columns.Add("Intrest amount");
                dataTable.Columns.Add("princpal amount");
                dataTable.Columns.Add("amount due");
            for (int i = 0; i < models.Count; i++)
            { 
               
                DataRow row = dataTable.NewRow();
                row["Sno"] = models[i].sno;
                row["Intrest amount"] = models[i].intrestAmount;
                row["princpal amount"] = models[i].principalAmount;
                row["amount due"] = models[i].dueAmount;
                dataTable.Rows.Add(row);
               
            }
             dataGridView.DataSource = dataTable;

        }

        private void cancel_buttton_Click(object sender, EventArgs e)
        {
            while (dataGridView.Rows.Count > 1)
            {
                dataGridView.Rows.RemoveAt(0);
                dataGridView.Refresh();
            }

            models.Clear();

            this.Close();
        }
    }
}
