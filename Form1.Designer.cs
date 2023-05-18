namespace CompilationPrinciples
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.NewFile = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(794, 703);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(812, 129);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(99, 30);
            this.Save.TabIndex = 1;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAs.Location = new System.Drawing.Point(812, 185);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(99, 30);
            this.SaveAs.TabIndex = 2;
            this.SaveAs.Text = "另存为";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // NewFile
            // 
            this.NewFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewFile.Location = new System.Drawing.Point(812, 77);
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(99, 30);
            this.NewFile.TabIndex = 3;
            this.NewFile.Text = "新建";
            this.NewFile.UseVisualStyleBackColor = true;
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // Open
            // 
            this.Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Open.Location = new System.Drawing.Point(812, 236);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(99, 30);
            this.Open.TabIndex = 4;
            this.Open.Text = "打开";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Run
            // 
            this.Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Run.Location = new System.Drawing.Point(812, 284);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(99, 30);
            this.Run.TabIndex = 5;
            this.Run.Text = "执行";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 727);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.NewFile);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "ToyPL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.Button NewFile;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Run;
    }
}

