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
    public partial class AddForm : Form
    {
        private MainForm form;

        public AddForm()
        {
            InitializeComponent();
            LoadGroups();
        }

        public AddForm(MainForm form) : this()
        {
            this.form = form;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            string name = textNameBox.Text;
            int groupId = ((Group)comboGroupBox.SelectedItem).Id;
            (int, int) result = DBStudents.GetInstance().AddNewStudent(name, groupId);
            form.addedLabel.Visible = true;
            form.idLabel.Visible = true;
            form.addedInputLabel.Text = result.Item1.ToString();
            form.idInputLabel.Text = result.Item2.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void LoadGroups()
        {
            IEnumerable<Group> groups = DBGroups.GetInstance().GetAllGroups();
            foreach (Group group in groups)
            {
                comboGroupBox.Items.Add(group);
            }
        }
    }
}
