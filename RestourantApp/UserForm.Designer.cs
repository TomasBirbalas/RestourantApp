namespace RestourantApp
{
    partial class UserForm
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
            this.btnGetNewTable = new System.Windows.Forms.Button();
            this.lbPersonCount = new System.Windows.Forms.Label();
            this.inputPersonCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetNewTable
            // 
            this.btnGetNewTable.Location = new System.Drawing.Point(805, 509);
            this.btnGetNewTable.Name = "btnGetNewTable";
            this.btnGetNewTable.Size = new System.Drawing.Size(175, 40);
            this.btnGetNewTable.TabIndex = 0;
            this.btnGetNewTable.Text = "Book Table";
            this.btnGetNewTable.UseVisualStyleBackColor = true;
            this.btnGetNewTable.Click += new System.EventHandler(this.btnGetNewTable_Click);
            // 
            // lbPersonCount
            // 
            this.lbPersonCount.AutoSize = true;
            this.lbPersonCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPersonCount.Location = new System.Drawing.Point(806, 444);
            this.lbPersonCount.Name = "lbPersonCount";
            this.lbPersonCount.Size = new System.Drawing.Size(174, 25);
            this.lbPersonCount.TabIndex = 1;
            this.lbPersonCount.Text = "How many people";
            // 
            // inputPersonCount
            // 
            this.inputPersonCount.Location = new System.Drawing.Point(805, 477);
            this.inputPersonCount.Name = "inputPersonCount";
            this.inputPersonCount.Size = new System.Drawing.Size(175, 23);
            this.inputPersonCount.TabIndex = 2;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 561);
            this.Controls.Add(this.inputPersonCount);
            this.Controls.Add(this.lbPersonCount);
            this.Controls.Add(this.btnGetNewTable);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetNewTable;
        private System.Windows.Forms.Label lbPersonCount;
        private System.Windows.Forms.TextBox inputPersonCount;
    }
}