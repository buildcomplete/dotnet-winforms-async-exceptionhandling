namespace FormsCBThrowsException
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
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.buttonThrowAndRethrowNewExceptionAsync = new System.Windows.Forms.Button();
			this.buttonThrowAndWrapExceptionAsync = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.textBox2, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.buttonThrowAndRethrowNewExceptionAsync, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.buttonThrowAndWrapExceptionAsync, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 2;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(828, 507);
			this.tableLayoutPanel.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Location = new System.Drawing.Point(203, 256);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(622, 248);
			this.textBox2.TabIndex = 4;
			// 
			// buttonThrowAndRethrowNewExceptionAsync
			// 
			this.buttonThrowAndRethrowNewExceptionAsync.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonThrowAndRethrowNewExceptionAsync.Location = new System.Drawing.Point(3, 256);
			this.buttonThrowAndRethrowNewExceptionAsync.Name = "buttonThrowAndRethrowNewExceptionAsync";
			this.buttonThrowAndRethrowNewExceptionAsync.Size = new System.Drawing.Size(194, 248);
			this.buttonThrowAndRethrowNewExceptionAsync.TabIndex = 2;
			this.buttonThrowAndRethrowNewExceptionAsync.Text = "Throw And Rethrow new Exception Async";
			this.buttonThrowAndRethrowNewExceptionAsync.UseVisualStyleBackColor = true;
			this.buttonThrowAndRethrowNewExceptionAsync.Click += new System.EventHandler(this.buttonThrowAndRethrowNewExceptionAsync_Click);
			// 
			// buttonThrowAndWrapExceptionAsync
			// 
			this.buttonThrowAndWrapExceptionAsync.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonThrowAndWrapExceptionAsync.Location = new System.Drawing.Point(3, 3);
			this.buttonThrowAndWrapExceptionAsync.Name = "buttonThrowAndWrapExceptionAsync";
			this.buttonThrowAndWrapExceptionAsync.Size = new System.Drawing.Size(194, 247);
			this.buttonThrowAndWrapExceptionAsync.TabIndex = 1;
			this.buttonThrowAndWrapExceptionAsync.Text = "Throw And >Wrap< Exception Async";
			this.buttonThrowAndWrapExceptionAsync.UseVisualStyleBackColor = true;
			this.buttonThrowAndWrapExceptionAsync.Click += new System.EventHandler(this.buttonThrowAndWrapExceptionAsync_Click);
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(203, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(622, 247);
			this.textBox1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 507);
			this.Controls.Add(this.tableLayoutPanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button buttonThrowAndRethrowNewExceptionAsync;
		private System.Windows.Forms.Button buttonThrowAndWrapExceptionAsync;
		private System.Windows.Forms.TextBox textBox1;
	}
}

