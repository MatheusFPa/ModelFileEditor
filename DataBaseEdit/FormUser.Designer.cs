namespace DataBaseEdit
{
    partial class FormUser
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
            this.labelUserLog = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonUserEnter = new System.Windows.Forms.Button();
            this.labelStatusUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserLog
            // 
            this.labelUserLog.AutoSize = true;
            this.labelUserLog.Location = new System.Drawing.Point(13, 22);
            this.labelUserLog.Name = "labelUserLog";
            this.labelUserLog.Size = new System.Drawing.Size(43, 20);
            this.labelUserLog.TabIndex = 0;
            this.labelUserLog.Text = "User";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(62, 19);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(240, 26);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(13, 67);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(44, 20);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Data";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(62, 61);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(240, 26);
            this.textBoxData.TabIndex = 3;
            // 
            // buttonUserEnter
            // 
            this.buttonUserEnter.Enabled = false;
            this.buttonUserEnter.Location = new System.Drawing.Point(62, 105);
            this.buttonUserEnter.Name = "buttonUserEnter";
            this.buttonUserEnter.Size = new System.Drawing.Size(75, 39);
            this.buttonUserEnter.TabIndex = 4;
            this.buttonUserEnter.Text = "Enter";
            this.buttonUserEnter.UseVisualStyleBackColor = true;
            this.buttonUserEnter.Click += new System.EventHandler(this.buttonUserEnter_Click);
            // 
            // labelStatusUser
            // 
            this.labelStatusUser.AutoSize = true;
            this.labelStatusUser.Location = new System.Drawing.Point(155, 114);
            this.labelStatusUser.Name = "labelStatusUser";
            this.labelStatusUser.Size = new System.Drawing.Size(0, 20);
            this.labelStatusUser.TabIndex = 5;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(450, 244);
            this.ControlBox = false;
            this.Controls.Add(this.labelStatusUser);
            this.Controls.Add(this.buttonUserEnter);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelUserLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserLog;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button buttonUserEnter;
        private System.Windows.Forms.Label labelStatusUser;
    }
}