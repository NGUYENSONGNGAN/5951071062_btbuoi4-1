using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTBUOI4
{
	public partial class Form1 : Form
	{
		SqlConnection con = new SqlConnection("Data Source=LAPTOP-AJMJJI2P;Initial Catalog=DemoCRUD;Integrated Security=True");
		public Form1()
		{
			InitializeComponent();
			StudentsRecod();
		}

		private void Form1_Load(object sender , EventArgs e)
		{
			StudentsRecod();
			
		}
		private void StudentsRecod()
		{
			SqlConnection con = new SqlConnection("Data Source=LAPTOP-AJMJJI2P;Initial Catalog=DemoCRUD;Integrated Security=True");
			SqlCommand cmn = new SqlCommand("select * From StudentsTb", con);
			DataTable TB = new DataTable();
			con.Open();
			SqlDataReader srd = cmn.ExecuteReader();
			TB.Load(srd);
			con.Close();
			dataGridView1.DataSource = TB;
			
		}
		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}
		private bool  IsValibData()
		{
			if(textBox1.Text == string.Empty || textBox4.Text == string.Empty
				||textBox3.Text == string.Empty||string.IsNullOrEmpty(textBox5.Text)||string.IsNullOrEmpty(textBox4.Text))
			{
				MessageBox.Show("Có chỗ chưa nhập dữ liệu", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void butthem_Click(object sender, EventArgs e)
		{
			if(IsValibData())
			{
				SqlCommand cmd = new SqlCommand("insert into StudentsTb values" + "(@Name,@FartherName,@RollNumber,@Address,@Mobile)" + con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@Name", textBox1.Text);
				cmd.Parameters.AddWithValue("@FatherName", textBox4.Text);
				cmd.Parameters.AddWithValue("@RollName", textBox2.Text);
				cmd.Parameters.AddWithValue("@Address", textBox3.Text);
				cmd.Parameters.AddWithValue("@Mobile", textBox5.Text);
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
				StudentsRecod();
			}	
		}

		public int StudentID;
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			StudentID = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
			textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
		}

		private void butCapnhat_Click(object sender, EventArgs e)
		{
			if(StudentID > 0 )
			{
				SqlCommand cmd = new SqlCommand("UPDATE StudentsTb SET" + "Name = @Name , FatherName = @FatherName"
					+"RollNumber = @RollNumber , Address = @Address,"	+"Mobile = @Mobile Where StudentsTb = @StudenID",con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@Name", textBox1.Text);
				cmd.Parameters.AddWithValue("@FatherName", textBox4.Text);
				cmd.Parameters.AddWithValue("@RollNumber", textBox2.Text);
				cmd.Parameters.AddWithValue("@Address", textBox3.Text);
				cmd.Parameters.AddWithValue("@Mobile", textBox5.Text);
				cmd.Parameters.AddWithValue("@StudenID", this.StudentID);
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
				StudentsRecod();
			
			}
			else
			{
				MessageBox.Show("Cập nhật bị lỗi !!", "Lỗi !",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}

		private void butXoa_Click(object sender, EventArgs e)
		{
			if(StudentID > 0 )
			{
				SqlCommand cmd = new SqlCommand("DELETE FROM StudentsTb WHERE StudentID = @StudentID");
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@StudentID" , this.StudentID);
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
				StudentsRecod();
			}
			else
			{
				MessageBox.Show("Xóa bị lỗi !!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
	}
