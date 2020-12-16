namespace NavisPlugin
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
            this.btStart = new System.Windows.Forms.Button();
            this.btAppendModel = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(13, 13);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(169, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "StartNavisworks";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btStart_mouseUp);
            // 
            // btAppendModel
            // 
            this.btAppendModel.Location = new System.Drawing.Point(12, 42);
            this.btAppendModel.Name = "btAppendModel";
            this.btAppendModel.Size = new System.Drawing.Size(170, 23);
            this.btAppendModel.TabIndex = 1;
            this.btAppendModel.Text = "AppendModel";
            this.btAppendModel.UseVisualStyleBackColor = true;
            this.btAppendModel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btAppendModel_mouseUp);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(12, 71);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(170, 23);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btClose_mouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 105);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAppendModel);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btAppendModel;
        private System.Windows.Forms.Button btClose;
    }
}

