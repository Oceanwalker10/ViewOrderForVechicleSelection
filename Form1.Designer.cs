namespace ViewOrder
{
	partial class ViewOrder
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
			this.orderSummary = new System.Windows.Forms.ListView();
			this.open = new System.Windows.Forms.Button();
			this.detailBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// orderSummary
			// 
			this.orderSummary.HideSelection = false;
			this.orderSummary.Location = new System.Drawing.Point(12, 12);
			this.orderSummary.Name = "orderSummary";
			this.orderSummary.Size = new System.Drawing.Size(461, 351);
			this.orderSummary.TabIndex = 1;
			this.orderSummary.UseCompatibleStateImageBehavior = false;
			this.orderSummary.SelectedIndexChanged += new System.EventHandler(this.orderSummary_SelectedIndexChanged);
			// 
			// open
			// 
			this.open.Location = new System.Drawing.Point(12, 389);
			this.open.Name = "open";
			this.open.Size = new System.Drawing.Size(75, 34);
			this.open.TabIndex = 2;
			this.open.Text = "Open";
			this.open.UseVisualStyleBackColor = true;
			this.open.Click += new System.EventHandler(this.open_Click);
			// 
			// detailBox
			// 
			this.detailBox.Location = new System.Drawing.Point(515, 12);
			this.detailBox.Multiline = true;
			this.detailBox.Name = "detailBox";
			this.detailBox.Size = new System.Drawing.Size(233, 351);
			this.detailBox.TabIndex = 3;
			// 
			// ViewOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(802, 518);
			this.Controls.Add(this.detailBox);
			this.Controls.Add(this.open);
			this.Controls.Add(this.orderSummary);
			this.Name = "ViewOrder";
			this.Text = "View Order";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView orderSummary;
		private System.Windows.Forms.Button open;
		private System.Windows.Forms.TextBox detailBox;
	}
}

