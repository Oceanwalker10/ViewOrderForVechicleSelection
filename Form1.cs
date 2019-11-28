using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ViewOrder
{
	public partial class ViewOrder : Form
	{
		public ViewOrder()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void initListView()
		{

			orderSummary.View = View.Details;
			orderSummary.Columns.Add("Requested delivery date", -2, HorizontalAlignment.Left);
			orderSummary.Columns.Add("Customere Name", -2, HorizontalAlignment.Left);
			orderSummary.Columns.Add("Model", -2, HorizontalAlignment.Left);
			orderSummary.Columns.Add("Total cost", -2, HorizontalAlignment.Left);

			foreach (Vehicle item in Control.vehicleList)
			{
				ListViewItem li = new ListViewItem(item.DeliveryDate.ToString());
				li.SubItems.Add(item.FName + " " + item.LName);
				li.SubItems.Add(item.VehicleName);
				li.SubItems.Add(item.Cost.ToString());
				orderSummary.Items.Add(li);
			}

		}

		private void open_Click(object sender, EventArgs e)
		{
			DialogResult result;
			string file;

			using (OpenFileDialog chooser = new OpenFileDialog())
			{
				result = chooser.ShowDialog();
				file = chooser.FileName;
			}

			if (result == DialogResult.OK)
			{
				Control.ReadVehicles(file);
				initListView();
				//try
				//{
				//	Control.ReadVehicles(file);
				//	initListView();
				//}
				//catch (Exception ex) { }

			}
		}

		private void orderSummary_SelectedIndexChanged(object sender, EventArgs e)
		{
			//StringBuilder tmp = new StringBuilder();
			//tmp.AppendLine(Control.vehicleList[0].FName + " " + Control.vehicleList[0].LName);
			//detailBox.Text = tmp.ToString();
		}
	}
}
