using System.Data;

namespace NoteTakingApp
{
	public partial class Form1 : Form
	{
		DataTable table;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			table = new DataTable();
			table.Columns.Add("Title", typeof(string));
			table.Columns.Add("Message",typeof(string));

			dataGridView1.DataSource = table;

			dataGridView1.Columns["Message"].Visible = false;
			dataGridView1.Columns["Title"].Width = 183;
		}

		private void newButton_Click(object sender, EventArgs e)
		{
			titleValue.Clear();
			messageValue.Clear();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			table.Rows.Add(titleValue.Text,messageValue.Text);

			titleValue.Clear();
			messageValue.Clear();
		}

		private void readButton_Click(object sender, EventArgs e)
		{
			try
			{
				int index = dataGridView1.CurrentCell.RowIndex;

				if (index > -1)
				{
					titleValue.Text = table.Rows[index].ItemArray[0].ToString();
					messageValue.Text = table.Rows[index].ItemArray[1].ToString();
				}
			}
			catch (NullReferenceException ev)
			{
				Console.WriteLine(ev.ToString());
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			try
			{
				int index = dataGridView1.CurrentCell.RowIndex;
				table.Rows[index].Delete();
			}
			catch (NullReferenceException ear)
			{
				Console.WriteLine(ear.ToString());
			}
		}
	}
}