namespace NoteTakingApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.titleLabel = new System.Windows.Forms.Label();
			this.messageLabel = new System.Windows.Forms.Label();
			this.titleValue = new System.Windows.Forms.TextBox();
			this.messageValue = new System.Windows.Forms.TextBox();
			this.newButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.readButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.titleLabel.Location = new System.Drawing.Point(61, 49);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(61, 29);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "Title";
			// 
			// messageLabel
			// 
			this.messageLabel.AutoSize = true;
			this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.messageLabel.Location = new System.Drawing.Point(61, 162);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(112, 29);
			this.messageLabel.TabIndex = 1;
			this.messageLabel.Text = "Message";
			// 
			// titleValue
			// 
			this.titleValue.Location = new System.Drawing.Point(231, 53);
			this.titleValue.Name = "titleValue";
			this.titleValue.Size = new System.Drawing.Size(268, 27);
			this.titleValue.TabIndex = 2;
			// 
			// messageValue
			// 
			this.messageValue.Location = new System.Drawing.Point(231, 166);
			this.messageValue.Multiline = true;
			this.messageValue.Name = "messageValue";
			this.messageValue.Size = new System.Drawing.Size(268, 138);
			this.messageValue.TabIndex = 3;
			// 
			// newButton
			// 
			this.newButton.Location = new System.Drawing.Point(231, 346);
			this.newButton.Name = "newButton";
			this.newButton.Size = new System.Drawing.Size(94, 29);
			this.newButton.TabIndex = 4;
			this.newButton.Text = "New";
			this.newButton.UseVisualStyleBackColor = true;
			this.newButton.Click += new System.EventHandler(this.newButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(767, 346);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(94, 29);
			this.deleteButton.TabIndex = 5;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// readButton
			// 
			this.readButton.Location = new System.Drawing.Point(558, 346);
			this.readButton.Name = "readButton";
			this.readButton.Size = new System.Drawing.Size(94, 29);
			this.readButton.TabIndex = 6;
			this.readButton.Text = "Read";
			this.readButton.UseVisualStyleBackColor = true;
			this.readButton.Click += new System.EventHandler(this.readButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(405, 346);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(94, 29);
			this.saveButton.TabIndex = 7;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(558, 53);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 29;
			this.dataGridView1.Size = new System.Drawing.Size(303, 251);
			this.dataGridView1.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(967, 462);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.readButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.newButton);
			this.Controls.Add(this.messageValue);
			this.Controls.Add(this.titleValue);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.titleLabel);
			this.ForeColor = System.Drawing.Color.Purple;
			this.Name = "Form1";
			this.Text = "Note taking app";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label titleLabel;
		private Label messageLabel;
		private TextBox titleValue;
		private TextBox messageValue;
		private Button newButton;
		private Button deleteButton;
		private Button readButton;
		private Button saveButton;
		private DataGridView dataGridView1;
	}
}