namespace FContent
{
    partial class MainWindowForm
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
            if ( disposing && ( components != null ) )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.rTxtFileList = new System.Windows.Forms.RichTextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectFolderPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTxtFileList
            // 
            this.rTxtFileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtFileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rTxtFileList.Location = new System.Drawing.Point(12, 123);
            this.rTxtFileList.Name = "rTxtFileList";
            this.rTxtFileList.ReadOnly = true;
            this.rTxtFileList.Size = new System.Drawing.Size(1082, 393);
            this.rTxtFileList.TabIndex = 0;
            this.rTxtFileList.Text = "";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPath.Location = new System.Drawing.Point(12, 40);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(883, 30);
            this.txtPath.TabIndex = 1;
            // 
            // btnSelectFolderPath
            // 
            this.btnSelectFolderPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btnSelectFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectFolderPath.Location = new System.Drawing.Point(917, 40);
            this.btnSelectFolderPath.Name = "btnSelectFolderPath";
            this.btnSelectFolderPath.Size = new System.Drawing.Size(177, 30);
            this.btnSelectFolderPath.TabIndex = 2;
            this.btnSelectFolderPath.Text = "Browse folder";
            this.btnSelectFolderPath.UseVisualStyleBackColor = true;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1107, 580);
            this.Controls.Add(this.btnSelectFolderPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.rTxtFileList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FContent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtFileList;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectFolderPath;
    }
}

