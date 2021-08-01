
namespace ScienceBook.Settings
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.newPagePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UseNewPlaceholdersCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 20F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.button1.Location = new System.Drawing.Point(762, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SaveSettings);
            // 
            // newPagePath
            // 
            this.newPagePath.Location = new System.Drawing.Point(257, 126);
            this.newPagePath.Name = "newPagePath";
            this.newPagePath.Size = new System.Drawing.Size(359, 20);
            this.newPagePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(61, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Page Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(61, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Use New Item Placeholders";
            // 
            // UseNewPlaceholdersCheckBox
            // 
            this.UseNewPlaceholdersCheckBox.AutoSize = true;
            this.UseNewPlaceholdersCheckBox.Location = new System.Drawing.Point(406, 199);
            this.UseNewPlaceholdersCheckBox.Name = "UseNewPlaceholdersCheckBox";
            this.UseNewPlaceholdersCheckBox.Size = new System.Drawing.Size(15, 14);
            this.UseNewPlaceholdersCheckBox.TabIndex = 4;
            this.UseNewPlaceholdersCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(930, 530);
            this.Controls.Add(this.UseNewPlaceholdersCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPagePath);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(946, 569);
            this.MinimumSize = new System.Drawing.Size(946, 569);
            this.Name = "SettingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Science Book";
            this.Load += new System.EventHandler(this.loadSettings);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newPagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox UseNewPlaceholdersCheckBox;
    }
}