
namespace Satisfactory_Editor
{
    partial class ProfileSelectForm
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
            this.SelectProfileButton = new System.Windows.Forms.Button();
            this.createNewProfileButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SelectProfileButton
            // 
            this.SelectProfileButton.Location = new System.Drawing.Point(123, 121);
            this.SelectProfileButton.Name = "SelectProfileButton";
            this.SelectProfileButton.Size = new System.Drawing.Size(104, 23);
            this.SelectProfileButton.TabIndex = 0;
            this.SelectProfileButton.Text = "Select";
            this.SelectProfileButton.UseVisualStyleBackColor = true;
            this.SelectProfileButton.Click += new System.EventHandler(this.SelectProfileButton_Click);
            // 
            // createNewProfileButton
            // 
            this.createNewProfileButton.Location = new System.Drawing.Point(123, 81);
            this.createNewProfileButton.Name = "createNewProfileButton";
            this.createNewProfileButton.Size = new System.Drawing.Size(104, 23);
            this.createNewProfileButton.TabIndex = 2;
            this.createNewProfileButton.Text = "create new profile";
            this.createNewProfileButton.UseVisualStyleBackColor = true;
            this.createNewProfileButton.Click += new System.EventHandler(this.createNewProfileButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(233, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // ProfileSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.createNewProfileButton);
            this.Controls.Add(this.SelectProfileButton);
            this.Name = "ProfileSelectForm";
            this.Text = "Profile Select Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectProfileButton;
        private System.Windows.Forms.Button createNewProfileButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

