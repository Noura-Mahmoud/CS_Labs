namespace mickey
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDrag = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrag
            // 
            this.btnDrag.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDrag.Location = new System.Drawing.Point(58, 53);
            this.btnDrag.Name = "btnDrag";
            this.btnDrag.Size = new System.Drawing.Size(49, 29);
            this.btnDrag.TabIndex = 0;
            this.btnDrag.Text = "+";
            this.btnDrag.UseVisualStyleBackColor = false;
            this.btnDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDrag_MouseDown);
            this.btnDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDrag_MouseMove);
            this.btnDrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDrag_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnClose.Location = new System.Drawing.Point(365, 53);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDrag;
        private Button btnClose;
    }
}