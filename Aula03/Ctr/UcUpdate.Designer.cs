
namespace Aula03.Ctr
{
    partial class UcUpdate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btUpdate = new System.Windows.Forms.Button();
            this.btClearLog = new System.Windows.Forms.Button();
            this.checkAutoUpdate = new System.Windows.Forms.CheckBox();
            this.checkPause = new System.Windows.Forms.CheckBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btUpdate
            // 
            this.btUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUpdate.Location = new System.Drawing.Point(0, 0);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(306, 23);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btUpdate_MouseUp);
            // 
            // btClearLog
            // 
            this.btClearLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btClearLog.Location = new System.Drawing.Point(0, 423);
            this.btClearLog.Name = "btClearLog";
            this.btClearLog.Size = new System.Drawing.Size(306, 23);
            this.btClearLog.TabIndex = 1;
            this.btClearLog.Text = "Clear Log";
            this.btClearLog.UseVisualStyleBackColor = true;
            this.btClearLog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btClear_MouseUp);
            // 
            // checkAutoUpdate
            // 
            this.checkAutoUpdate.AutoSize = true;
            this.checkAutoUpdate.Location = new System.Drawing.Point(4, 30);
            this.checkAutoUpdate.Name = "checkAutoUpdate";
            this.checkAutoUpdate.Size = new System.Drawing.Size(86, 17);
            this.checkAutoUpdate.TabIndex = 2;
            this.checkAutoUpdate.Text = "Auto Update";
            this.checkAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // checkPause
            // 
            this.checkPause.AutoSize = true;
            this.checkPause.Location = new System.Drawing.Point(4, 54);
            this.checkPause.Name = "checkPause";
            this.checkPause.Size = new System.Drawing.Size(56, 17);
            this.checkPause.TabIndex = 3;
            this.checkPause.Text = "Pause";
            this.checkPause.UseVisualStyleBackColor = true;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(0, 78);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(306, 346);
            this.tbLog.TabIndex = 4;
            this.tbLog.Text = "Monitoring Models...";
            // 
            // UcUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.checkPause);
            this.Controls.Add(this.checkAutoUpdate);
            this.Controls.Add(this.btClearLog);
            this.Controls.Add(this.btUpdate);
            this.Name = "UcUpdate";
            this.Size = new System.Drawing.Size(306, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btClearLog;
        private System.Windows.Forms.CheckBox checkAutoUpdate;
        private System.Windows.Forms.CheckBox checkPause;
        private System.Windows.Forms.TextBox tbLog;
    }
}
