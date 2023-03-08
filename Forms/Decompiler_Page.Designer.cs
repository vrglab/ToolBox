namespace ToolBox.Forms
{
    partial class Decompiler_Page
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
            this.unityDecompilerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unityDecompilerButton
            // 
            this.unityDecompilerButton.Location = new System.Drawing.Point(23, 28);
            this.unityDecompilerButton.Name = "unityDecompilerButton";
            this.unityDecompilerButton.Size = new System.Drawing.Size(103, 23);
            this.unityDecompilerButton.TabIndex = 0;
            this.unityDecompilerButton.Text = "Unity Decompiler";
            this.unityDecompilerButton.UseVisualStyleBackColor = true;
            this.unityDecompilerButton.Click += new System.EventHandler(this.unityDecompilerButton_Click);
            // 
            // Decompiler_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unityDecompilerButton);
            this.Name = "Decompiler_Page";
            this.Text = "Decompiler_Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button unityDecompilerButton;
    }
}