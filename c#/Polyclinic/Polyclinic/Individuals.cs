using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class Individuals : Form
    {
        public Individuals()
        {
            InitializeComponent();
        }

        private void Individuals_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyclinicDataSet.Individuals". При необходимости она может быть перемещена или удалена.
            this.individualsTableAdapter.Fill(this.polyclinicDataSet.Individuals);

        }

        private void individualsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
