namespace TodoistNetTest.Forms
{
    partial class ApiTokenInputBox
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
            this.tableLayoutApiToken = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxApiToken = new System.Windows.Forms.TextBox();
            this.labelApiToken = new System.Windows.Forms.Label();
            this.tableLayoutApiTokenButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tableLayoutApiToken.SuspendLayout();
            this.tableLayoutApiTokenButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutApiToken
            // 
            this.tableLayoutApiToken.ColumnCount = 1;
            this.tableLayoutApiToken.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutApiToken.Controls.Add(this.textBoxApiToken, 0, 1);
            this.tableLayoutApiToken.Controls.Add(this.labelApiToken, 0, 0);
            this.tableLayoutApiToken.Controls.Add(this.tableLayoutApiTokenButtons, 0, 2);
            this.tableLayoutApiToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutApiToken.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutApiToken.Name = "tableLayoutApiToken";
            this.tableLayoutApiToken.RowCount = 3;
            this.tableLayoutApiToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutApiToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutApiToken.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutApiToken.Size = new System.Drawing.Size(285, 111);
            this.tableLayoutApiToken.TabIndex = 0;
            // 
            // textBoxApiToken
            // 
            this.textBoxApiToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApiToken.Location = new System.Drawing.Point(3, 45);
            this.textBoxApiToken.Name = "textBoxApiToken";
            this.textBoxApiToken.PasswordChar = '*';
            this.textBoxApiToken.Size = new System.Drawing.Size(279, 20);
            this.textBoxApiToken.TabIndex = 1;
            // 
            // labelApiToken
            // 
            this.labelApiToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelApiToken.Location = new System.Drawing.Point(3, 0);
            this.labelApiToken.Name = "labelApiToken";
            this.labelApiToken.Size = new System.Drawing.Size(279, 40);
            this.labelApiToken.TabIndex = 0;
            this.labelApiToken.Text = "Enter your Todoist API Key:";
            this.labelApiToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutApiTokenButtons
            // 
            this.tableLayoutApiTokenButtons.ColumnCount = 2;
            this.tableLayoutApiTokenButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutApiTokenButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutApiTokenButtons.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutApiTokenButtons.Controls.Add(this.buttonOk, 0, 0);
            this.tableLayoutApiTokenButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutApiTokenButtons.Location = new System.Drawing.Point(3, 74);
            this.tableLayoutApiTokenButtons.Name = "tableLayoutApiTokenButtons";
            this.tableLayoutApiTokenButtons.RowCount = 1;
            this.tableLayoutApiTokenButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutApiTokenButtons.Size = new System.Drawing.Size(279, 34);
            this.tableLayoutApiTokenButtons.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(171, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.Location = new System.Drawing.Point(32, 5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "&OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // ApiTokenInputBox
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(285, 111);
            this.Controls.Add(this.tableLayoutApiToken);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApiTokenInputBox";
            this.Text = "API Token";
            this.tableLayoutApiToken.ResumeLayout(false);
            this.tableLayoutApiToken.PerformLayout();
            this.tableLayoutApiTokenButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutApiToken;
        private System.Windows.Forms.TextBox textBoxApiToken;
        private System.Windows.Forms.Label labelApiToken;
        private System.Windows.Forms.TableLayoutPanel tableLayoutApiTokenButtons;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}