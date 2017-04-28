namespace BlindTest
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		//private System.Windows.Forms.TabPage tabControl1;
	//	private System.Windows.Forms.TabPage tabControl2;

		// Declare variables.
		private System.Windows.Forms.RadioButton RadioButton2;
		private System.Windows.Forms.RadioButton RadioButton1;
		private System.Windows.Forms.RadioButton RadioButton3;
		private System.Windows.Forms.RadioButton RadioButton4;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label text;
		private System.Windows.Forms.Button button;
		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>

		private void InitializeComponent()
		{
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.RadioButton3 = new System.Windows.Forms.RadioButton();
			this.RadioButton4 = new System.Windows.Forms.RadioButton();
			this.text = new System.Windows.Forms.Label();
			this.button = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.RadioButton2);
			this.tabPage1.Controls.Add(this.RadioButton1);
			this.tabPage1.Controls.Add(this.RadioButton3);
			this.tabPage1.Controls.Add(this.RadioButton4);
			this.tabPage1.Controls.Add(this.text);
			this.tabPage1.Controls.Add(this.button);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(627, 345);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Blind Test Musical";
			// 
			// RadioButton2
			// 
			this.RadioButton2.Location = new System.Drawing.Point(40, 112);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(152, 24);
			this.RadioButton2.TabIndex = 1;
			this.RadioButton2.Text = "radioButton2";
			// 
			// RadioButton1
			// 
			this.RadioButton1.Location = new System.Drawing.Point(40, 72);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(152, 24);
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.Text = "radioButton1";
			// 
			// RadioButton3
			// 
			this.RadioButton3.Location = new System.Drawing.Point(40, 153);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new System.Drawing.Size(152, 24);
			this.RadioButton3.TabIndex = 0;
			this.RadioButton3.Text = "radioButton3";
			// 
			// RadioButton4
			// 
			this.RadioButton4.Location = new System.Drawing.Point(40, 194);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new System.Drawing.Size(152, 24);
			this.RadioButton4.TabIndex = 4;
			this.RadioButton4.Text = "radioButton4";
			// 
			// text
			// 
			this.text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.text.Location = new System.Drawing.Point(14, 26);
			this.text.Name = "text";
			this.text.Size = new System.Drawing.Size(230, 23);
			this.text.TabIndex = 5;
			this.text.Text = "Quel est le titre du son ?";
			this.text.Click += new System.EventHandler(this.text_Click);
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(57, 251);
			this.button.Name = "button";
			this.button.Text = "Valider";
			this.button.Size = new System.Drawing.Size(112, 31);
			this.button.TabIndex = 6;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(16, 16);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(635, 371);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(627, 345);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Configuration";
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(663, 399);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Blind Test Musical";
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		/// <summary>
		/// 
		/// </summary>

	}
}

