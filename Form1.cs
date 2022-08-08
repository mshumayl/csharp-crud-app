using System.Data;

namespace Shumayl_Notes {
    public partial class Form1 : Form {

        DataTable table;
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Body", typeof(String));

            dgvList.DataSource = table;
            dgvList.Columns["Body"].Visible = false;
            dgvList.Columns["Title"].Width = dgvList.Width-4; //not sure why this overshoots the box without the offset

        }

        private void bttNew_Click(object sender, EventArgs e) {
            txtTitle.Clear();
            rtxtNote.Clear();
        }

        private void bttSave_Click(object sender, EventArgs e) {
            table.Rows.Add(txtTitle.Text, rtxtNote.Text);
            txtTitle.Clear();
            rtxtNote.Clear();
        }

        private void bttRead_Click(object sender, EventArgs e) {

            if (dgvList.CurrentCell != null) {

                int index = dgvList.CurrentCell.RowIndex;

                if (index > -1) { //if any item is selected, index will be >0
                    txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                    rtxtNote.Text = table.Rows[index].ItemArray[1].ToString();
                }
            }        
        }

        private void bttDelete_Click(object sender, EventArgs e) {
            
            if (dgvList.CurrentCell != null) {
                int index = dgvList.CurrentCell.RowIndex;
                table.Rows[index].Delete();
                txtTitle.Clear();
                rtxtNote.Clear();
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void bttUpdate_Click(object sender, EventArgs e) {
            
            if (dgvList.CurrentCell != null) {
                int index = dgvList.CurrentCell.RowIndex;

                if (index > -1) { //if any item is selected, index will be >0
                    table.Rows[index][0] = txtTitle.Text;
                    table.Rows[index][1] = rtxtNote.Text;
                }
            }
        }
    }
}