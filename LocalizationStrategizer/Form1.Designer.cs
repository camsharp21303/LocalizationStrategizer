namespace LocalizationStrategizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResetDrawables = new System.Windows.Forms.Button();
            this.DownArms = new System.Windows.Forms.Button();
            this.codeOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 550);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseClick);
            // 
            // ResetDrawables
            // 
            this.ResetDrawables.Location = new System.Drawing.Point(568, 12);
            this.ResetDrawables.Name = "ResetDrawables";
            this.ResetDrawables.Size = new System.Drawing.Size(75, 23);
            this.ResetDrawables.TabIndex = 2;
            this.ResetDrawables.Text = "Reset";
            this.ResetDrawables.UseVisualStyleBackColor = true;
            this.ResetDrawables.Click += new System.EventHandler(this.resetDrawables_Click);
            // 
            // DownArms
            // 
            this.DownArms.Location = new System.Drawing.Point(789, 11);
            this.DownArms.Name = "DownArms";
            this.DownArms.Size = new System.Drawing.Size(190, 25);
            this.DownArms.TabIndex = 3;
            this.DownArms.Text = "Put Down F-Arms";
            this.DownArms.UseVisualStyleBackColor = true;
            this.DownArms.Click += new System.EventHandler(this.DownArms_Click);
            // 
            // codeOutput
            // 
            this.codeOutput.Location = new System.Drawing.Point(878, 119);
            this.codeOutput.Name = "codeOutput";
            this.codeOutput.Size = new System.Drawing.Size(378, 461);
            this.codeOutput.TabIndex = 4;
            this.codeOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1268, 592);
            this.Controls.Add(this.codeOutput);
            this.Controls.Add(this.DownArms);
            this.Controls.Add(this.ResetDrawables);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1286, 639);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ResetDrawables;
        private System.Windows.Forms.Button DownArms;
        private System.Windows.Forms.RichTextBox codeOutput;
    }
}

