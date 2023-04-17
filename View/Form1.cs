using _2110_3layers.BLL;
using _2110_3layers.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2110_3layers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBBLSH();
        }
        public void SetCBBLSH()
        {
            QLSVBLL bll = new QLSVBLL();
            cbbLopSH.Items.AddRange(bll.GetCBB().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID_Lop = ((CBBItem)cbbLopSH.SelectedItem).Value;
            QLSVBLL bll = new QLSVBLL();
            dgv.DataSource = bll.GetSVByIDLop(ID_Lop);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SV s = new SV();
            QLSVBLL bll = new QLSVBLL();
            bll.AddSVBLL(s);
            dgv.DataSource = bll.GetSVByIDLop(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QLSVBLL bll = new QLSVBLL();
            if (dgv.SelectedRows.Count == 1)
            {
                string MSSV = dgv.SelectedRows[0].Cells[0].Value.ToString();
                SV s = bll.GetSVByMSSV(MSSV);
                //Edit
                bll.UpdateSVBLL(s);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QLSVBLL bll = new QLSVBLL();
            if (dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgv.SelectedRows)
                {
                    string MSSV = i.Cells[0].Value.ToString();
                    bll.DelSVBLL(MSSV);
                }
            }
            dgv.DataSource = bll.GetSVByIDLop(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (DataGridViewRow i in dgv.Rows)
            {
                list.Add(i.Cells[0].Value.ToString());
                QLSVBLL bll = new QLSVBLL();
                dgv.DataSource = bll.SortBy(list, "");
            }
        }
    }
}
