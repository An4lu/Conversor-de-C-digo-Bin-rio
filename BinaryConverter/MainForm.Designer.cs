/*
 * Created by SharpDevelop.
 * User: Anabu
 * Date: 01/03/2024
 * Time: 16:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BinaryConverter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.BinaryTextBox = new System.Windows.Forms.TextBox();
			this.TranslationTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ConvertButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BinaryTextBox
			// 
			this.BinaryTextBox.Font = new System.Drawing.Font("Pixter-Granular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BinaryTextBox.Location = new System.Drawing.Point(43, 60);
			this.BinaryTextBox.Name = "BinaryTextBox";
			this.BinaryTextBox.Size = new System.Drawing.Size(564, 31);
			this.BinaryTextBox.TabIndex = 0;
			// 
			// TranslationTextBox
			// 
			this.TranslationTextBox.Font = new System.Drawing.Font("Pixter-Granular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TranslationTextBox.Location = new System.Drawing.Point(43, 137);
			this.TranslationTextBox.Name = "TranslationTextBox";
			this.TranslationTextBox.Size = new System.Drawing.Size(564, 31);
			this.TranslationTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Pixter-Granular Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SeaShell;
			this.label1.Location = new System.Drawing.Point(43, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 30);
			this.label1.TabIndex = 2;
			this.label1.Text = "Código Binário :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Pixter-Granular Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.SeaShell;
			this.label2.Location = new System.Drawing.Point(43, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(219, 30);
			this.label2.TabIndex = 3;
			this.label2.Text = "Texto :";
			// 
			// ConvertButton
			// 
			this.ConvertButton.BackColor = System.Drawing.Color.SeaShell;
			this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ConvertButton.Font = new System.Drawing.Font("Pixter-Granular Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConvertButton.ForeColor = System.Drawing.Color.LightCoral;
			this.ConvertButton.Location = new System.Drawing.Point(43, 203);
			this.ConvertButton.Name = "ConvertButton";
			this.ConvertButton.Size = new System.Drawing.Size(416, 43);
			this.ConvertButton.TabIndex = 4;
			this.ConvertButton.Text = "Confirmar";
			this.ConvertButton.UseVisualStyleBackColor = false;
			this.ConvertButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConvertButtonMouseClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SeaShell;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Pixter-Granular Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.LightCoral;
			this.button1.Location = new System.Drawing.Point(465, 203);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 43);
			this.button1.TabIndex = 5;
			this.button1.Text = "Limpar Campos";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCoral;
			this.ClientSize = new System.Drawing.Size(646, 287);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ConvertButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TranslationTextBox);
			this.Controls.Add(this.BinaryTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BinaryConverter";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button ConvertButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TranslationTextBox;
		private System.Windows.Forms.TextBox BinaryTextBox;
	}
}
