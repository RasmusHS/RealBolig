using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealBolig
{
    public partial class CreateBolig : Form
    {
        public CreateBolig()
        {
            InitializeComponent();
        }

        private void CreateBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet1.Bolig_Status' table. You can move, or remove it, as needed.
            this.bolig_StatusTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet1.Bolig_Status);
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet1.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter1.Fill(this.kaspermark_dk_db_realboligDataSet1.Bolig);
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet1.Kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet1.Kunde);
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet.Bolig' table. You can move, or remove it, as needed.
            //this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);
        }
    }
}
