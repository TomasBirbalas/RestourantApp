namespace RestourantApp
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lbPinCode = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.inputUserPinCode = new System.Windows.Forms.TextBox();
            this.inputUserId = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lbPinCode);
            this.panelMain.Controls.Add(this.lbId);
            this.panelMain.Controls.Add(this.inputUserPinCode);
            this.panelMain.Controls.Add(this.inputUserId);
            this.panelMain.Controls.Add(this.btnLogin);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(0, 129);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1008, 600);
            this.panelMain.TabIndex = 0;
            // 
            // lbPinCode
            // 
            this.lbPinCode.AutoSize = true;
            this.lbPinCode.Location = new System.Drawing.Point(387, 235);
            this.lbPinCode.Name = "lbPinCode";
            this.lbPinCode.Size = new System.Drawing.Size(107, 15);
            this.lbPinCode.TabIndex = 4;
            this.lbPinCode.Text = "Enter Your pincode";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(387, 181);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(119, 15);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "Enter Your Id number";
            // 
            // inputUserPinCode
            // 
            this.inputUserPinCode.Location = new System.Drawing.Point(387, 256);
            this.inputUserPinCode.Name = "inputUserPinCode";
            this.inputUserPinCode.PasswordChar = '*';
            this.inputUserPinCode.Size = new System.Drawing.Size(220, 23);
            this.inputUserPinCode.TabIndex = 2;
            // 
            // inputUserId
            // 
            this.inputUserId.Location = new System.Drawing.Point(387, 203);
            this.inputUserId.Name = "inputUserId";
            this.inputUserId.Size = new System.Drawing.Size(220, 23);
            this.inputUserId.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(448, 327);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.textBoxFullName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1008, 129);
            this.panelHeader.TabIndex = 1;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxFullName.Location = new System.Drawing.Point(773, 52);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.ReadOnly = true;
            this.textBoxFullName.Size = new System.Drawing.Size(206, 23);
            this.textBoxFullName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox inputUserId;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbPinCode;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox inputUserPinCode;
        private System.Windows.Forms.TextBox textBoxFullName;
    }
}
