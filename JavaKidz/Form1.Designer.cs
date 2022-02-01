
namespace JavaKidz
{
    partial class JavaKidz
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
            this.installButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.apiButton = new System.Windows.Forms.CheckBox();
            this.loaderButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(12, 12);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(198, 41);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "Start Installing";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 59);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(198, 15);
            this.progressBar.TabIndex = 1;
            // 
            // outputBox
            // 
            this.outputBox.Enabled = false;
            this.outputBox.FormattingEnabled = true;
            this.outputBox.Location = new System.Drawing.Point(12, 80);
            this.outputBox.Name = "outputBox";
            this.outputBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.outputBox.Size = new System.Drawing.Size(639, 121);
            this.outputBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Download Options";
            // 
            // apiButton
            // 
            this.apiButton.AutoSize = true;
            this.apiButton.Checked = true;
            this.apiButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.apiButton.Location = new System.Drawing.Point(230, 29);
            this.apiButton.Name = "apiButton";
            this.apiButton.Size = new System.Drawing.Size(75, 17);
            this.apiButton.TabIndex = 4;
            this.apiButton.Text = "Fabric API";
            this.apiButton.UseVisualStyleBackColor = true;
            // 
            // loaderButton
            // 
            this.loaderButton.AutoSize = true;
            this.loaderButton.Location = new System.Drawing.Point(230, 53);
            this.loaderButton.Name = "loaderButton";
            this.loaderButton.Size = new System.Drawing.Size(91, 17);
            this.loaderButton.TabIndex = 5;
            this.loaderButton.Text = "Fabric Loader";
            this.loaderButton.UseVisualStyleBackColor = true;
            // 
            // JavaKidz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 209);
            this.Controls.Add(this.loaderButton);
            this.Controls.Add(this.apiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.installButton);
            this.Name = "JavaKidz";
            this.ShowIcon = false;
            this.Text = "JavaKidz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox outputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox apiButton;
        private System.Windows.Forms.CheckBox loaderButton;
    }
}

