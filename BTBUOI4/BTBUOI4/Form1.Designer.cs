namespace BTBUOI4
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labHoten = new System.Windows.Forms.Label();
			this.labSBD = new System.Windows.Forms.Label();
			this.labdiachi = new System.Windows.Forms.Label();
			this.labten = new System.Windows.Forms.Label();
			this.labSĐT = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.butthem = new System.Windows.Forms.Button();
			this.butSua = new System.Windows.Forms.Button();
			this.butXoa = new System.Windows.Forms.Button();
			this.butCapnhat = new System.Windows.Forms.Button();
			this.butthoat = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// labHoten
			// 
			this.labHoten.AutoSize = true;
			this.labHoten.Location = new System.Drawing.Point(57, 30);
			this.labHoten.Name = "labHoten";
			this.labHoten.Size = new System.Drawing.Size(77, 17);
			this.labHoten.TabIndex = 0;
			this.labHoten.Text = "Họ và tên :";
			// 
			// labSBD
			// 
			this.labSBD.AutoSize = true;
			this.labSBD.Location = new System.Drawing.Point(57, 89);
			this.labSBD.Name = "labSBD";
			this.labSBD.Size = new System.Drawing.Size(97, 17);
			this.labSBD.TabIndex = 1;
			this.labSBD.Text = "Số báo danh :";
			// 
			// labdiachi
			// 
			this.labdiachi.AutoSize = true;
			this.labdiachi.Location = new System.Drawing.Point(57, 148);
			this.labdiachi.Name = "labdiachi";
			this.labdiachi.Size = new System.Drawing.Size(55, 17);
			this.labdiachi.TabIndex = 2;
			this.labdiachi.Text = "Đại chỉ:";
			// 
			// labten
			// 
			this.labten.AutoSize = true;
			this.labten.Location = new System.Drawing.Point(405, 33);
			this.labten.Name = "labten";
			this.labten.Size = new System.Drawing.Size(53, 17);
			this.labten.TabIndex = 3;
			this.labten.Text = "Tên bố";
			// 
			// labSĐT
			// 
			this.labSĐT.AutoSize = true;
			this.labSĐT.Location = new System.Drawing.Point(399, 89);
			this.labSĐT.Name = "labSĐT";
			this.labSĐT.Size = new System.Drawing.Size(103, 17);
			this.labSĐT.TabIndex = 4;
			this.labSĐT.Text = "Số điện thoại : ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(159, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(168, 22);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(159, 83);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(168, 22);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(159, 143);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(168, 22);
			this.textBox3.TabIndex = 7;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(530, 30);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(209, 22);
			this.textBox4.TabIndex = 8;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(530, 90);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(209, 22);
			this.textBox5.TabIndex = 9;
			// 
			// butthem
			// 
			this.butthem.Location = new System.Drawing.Point(60, 191);
			this.butthem.Name = "butthem";
			this.butthem.Size = new System.Drawing.Size(75, 23);
			this.butthem.TabIndex = 10;
			this.butthem.Text = "Thêm ";
			this.butthem.UseVisualStyleBackColor = true;
			this.butthem.Click += new System.EventHandler(this.butthem_Click);
			// 
			// butSua
			// 
			this.butSua.Location = new System.Drawing.Point(199, 190);
			this.butSua.Name = "butSua";
			this.butSua.Size = new System.Drawing.Size(75, 23);
			this.butSua.TabIndex = 11;
			this.butSua.Text = "Sửa";
			this.butSua.UseVisualStyleBackColor = true;
			// 
			// butXoa
			// 
			this.butXoa.Location = new System.Drawing.Point(325, 190);
			this.butXoa.Name = "butXoa";
			this.butXoa.Size = new System.Drawing.Size(75, 23);
			this.butXoa.TabIndex = 12;
			this.butXoa.Text = "Xóa";
			this.butXoa.UseVisualStyleBackColor = true;
			this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
			// 
			// butCapnhat
			// 
			this.butCapnhat.Location = new System.Drawing.Point(456, 190);
			this.butCapnhat.Name = "butCapnhat";
			this.butCapnhat.Size = new System.Drawing.Size(75, 23);
			this.butCapnhat.TabIndex = 13;
			this.butCapnhat.Text = "Cập nhật";
			this.butCapnhat.UseVisualStyleBackColor = true;
			this.butCapnhat.Click += new System.EventHandler(this.butCapnhat_Click);
			// 
			// butthoat
			// 
			this.butthoat.Location = new System.Drawing.Point(705, 190);
			this.butthoat.Name = "butthoat";
			this.butthoat.Size = new System.Drawing.Size(75, 23);
			this.butthoat.TabIndex = 14;
			this.butthoat.Text = "Thoát";
			this.butthoat.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(46, 244);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(734, 180);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.butthoat);
			this.Controls.Add(this.butCapnhat);
			this.Controls.Add(this.butXoa);
			this.Controls.Add(this.butSua);
			this.Controls.Add(this.butthem);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.labSĐT);
			this.Controls.Add(this.labten);
			this.Controls.Add(this.labdiachi);
			this.Controls.Add(this.labSBD);
			this.Controls.Add(this.labHoten);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Student Information";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labHoten;
		private System.Windows.Forms.Label labSBD;
		private System.Windows.Forms.Label labdiachi;
		private System.Windows.Forms.Label labten;
		private System.Windows.Forms.Label labSĐT;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button butthem;
		private System.Windows.Forms.Button butSua;
		private System.Windows.Forms.Button butXoa;
		private System.Windows.Forms.Button butCapnhat;
		private System.Windows.Forms.Button butthoat;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

