using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
	public partial class FrmEvaluation : Form
	{
		private Student student;
		public FrmEvaluation(Student selectedStudent)
		{
			InitializeComponent();
			student = selectedStudent;
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
