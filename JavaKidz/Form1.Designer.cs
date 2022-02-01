
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
            this.installButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dOptions_fabricAPI = new System.Windows.Forms.CheckBox();
            this.loaderButton = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.comingSoon = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dirBox = new System.Windows.Forms.TextBox();
            this.dirLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dirButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.installButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.installButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.installButton.Location = new System.Drawing.Point(3, 7);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(198, 41);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "Start Installing";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.button1_Click);
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
            this.loaderButton.Enabled = false;
            this.loaderButton.ForeColor = System.Drawing.Color.Maroon;
            this.loaderButton.Location = new System.Drawing.Point(7, 76);
            this.loaderButton.Name = "loaderButton";
            this.loaderButton.Size = new System.Drawing.Size(91, 17);
            this.loaderButton.TabIndex = 5;
            this.loaderButton.Text = "Fabric Loader";
            this.comingSoon.SetToolTip(this.loaderButton, "The installer currently doesn\'t support this, sorry!");
            this.loaderButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.loaderButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dOptions_fabricAPI);
            this.panel1.Location = new System.Drawing.Point(3, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 110);
            this.panel1.TabIndex = 7;
            // 
            // bgTooltip
            // 
            this.bgTooltip.ToolTipTitle = "Credit";
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.outputBox.Location = new System.Drawing.Point(3, 54);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(537, 177);
            this.outputBox.TabIndex = 9;
            this.outputBox.Text = "";
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // comingSoon
            // 
            this.comingSoon.ToolTipTitle = "Coming Soon!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fabric Loader";
            this.comingSoon.SetToolTip(this.label2, "Sorry, we\'re still working on this feature.");
            // 
            // dirBox
            // 
            this.dirBox.Location = new System.Drawing.Point(210, 28);
            this.dirBox.Name = "dirBox";
            this.dirBox.ReadOnly = true;
            this.dirBox.Size = new System.Drawing.Size(283, 20);
            this.dirBox.TabIndex = 10;
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Location = new System.Drawing.Point(207, 12);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(157, 13);
            this.dirLabel.TabIndex = 11;
            this.dirLabel.Text = "Target .minecraft directory path:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.outputBox);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dirLabel);
            this.panel2.Controls.Add(this.dirButton);
            this.panel2.Controls.Add(this.dirBox);
            this.panel2.Controls.Add(this.installButton);
            this.panel2.Location = new System.Drawing.Point(142, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 322);
            this.panel2.TabIndex = 12;
            // 
            // dirButton
            // 
            this.dirButton.BackColor = System.Drawing.Color.Transparent;
            this.dirButton.FlatAppearance.BorderSize = 0;
            this.dirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dirButton.Image = global::JavaKidz.Properties.Resources.folder_mojang_25741;
            this.dirButton.Location = new System.Drawing.Point(493, 20);
            this.dirButton.Name = "dirButton";
            this.dirButton.Size = new System.Drawing.Size(44, 35);
            this.dirButton.TabIndex = 0;
            this.dirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dirButton.UseVisualStyleBackColor = false;
            this.dirButton.Click += new System.EventHandler(this.dirButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JavaKidz.Properties.Resources.Minecraft;
            this.pictureBox1.Location = new System.Drawing.Point(0, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(746, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.bgTooltip.SetToolTip(this.pictureBox1, " Animated Background by Артём Саркисян");
            // 
            // folderBrowser
            // 
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.UserProfile;
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // JavaKidz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 341);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "JavaKidz";
            this.ShowIcon = false;
            this.Text = "JavaKidz";
            this.Load += new System.EventHandler(this.JavaKidz_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox dOptions_fabricAPI;
        private System.Windows.Forms.CheckBox loaderButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip bgTooltip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.ToolTip comingSoon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dirBox;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dirButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}

