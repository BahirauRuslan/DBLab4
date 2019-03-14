using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBLab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            IEnumerable<StudentGroupRecord> records = DBStudents.GetInstance().GetAllStudents();
            FillTable(records);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ;
        }

        private void FillTable(IEnumerable<StudentGroupRecord> records)
        {
            int i = 0;
            mainGridView.RowCount = records.Count();
            foreach (StudentGroupRecord record in records)
            {
                mainGridView[0, i].Value = record.FullName;
                mainGridView[1, i++].Value = record.Group;
            }
        }
    }
}
