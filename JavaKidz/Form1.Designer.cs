
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JavaKidz));
            this.installButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.dOptions_fabricAPI = new System.Windows.Forms.CheckBox();
            this.loaderButton = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(449, 12);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(198, 41);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "Start Installing";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBar.Location = new System.Drawing.Point(8, 95);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(639, 14);
            this.progressBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Download Options";
            // 
            // dOptions_fabricAPI
            // 
            this.dOptions_fabricAPI.AutoSize = true;
            this.dOptions_fabricAPI.Checked = true;
            this.dOptions_fabricAPI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dOptions_fabricAPI.Location = new System.Drawing.Point(7, 53);
            this.dOptions_fabricAPI.Name = "dOptions_fabricAPI";
            this.dOptions_fabricAPI.Size = new System.Drawing.Size(75, 17);
            this.dOptions_fabricAPI.TabIndex = 4;
            this.dOptions_fabricAPI.Text = "Fabric API";
            this.dOptions_fabricAPI.UseVisualStyleBackColor = true;
            // 
            // loaderButton
            // 
            this.loaderButton.AutoSize = true;
            this.loaderButton.Location = new System.Drawing.Point(7, 76);
            this.loaderButton.Name = "loaderButton";
            this.loaderButton.Size = new System.Drawing.Size(91, 17);
            this.loaderButton.TabIndex = 5;
            this.loaderButton.Text = "Fabric Loader";
            this.loaderButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loaderButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dOptions_fabricAPI);
            this.panel1.Location = new System.Drawing.Point(8, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 96);
            this.panel1.TabIndex = 7;
            // 
            // bgTooltip
            // 
            this.bgTooltip.ToolTipTitle = "Credit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.bgTooltip.SetToolTip(this.pictureBox1, " Animated Background by Артём Саркисян");
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputBox.ForeColor = System.Drawing.Color.Lime;
            this.outputBox.Location = new System.Drawing.Point(8, 115);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(639, 121);
            this.outputBox.TabIndex = 9;
            this.outputBox.Text = "";
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // JavaKidz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(659, 310);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "JavaKidz";
            this.ShowIcon = false;
            this.Text = "JavaKidz";
            this.Load += new System.EventHandler(this.JavaKidz_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox dOptions_fabricAPI;
        private System.Windows.Forms.CheckBox loaderButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip bgTooltip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox outputBox;
    }
}

