
namespace View
{
    partial class NewPlayerForm
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
            this.labelNewPlayer = new System.Windows.Forms.Label();
            this.textPlayerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNewPlayer
            // 
            this.labelNewPlayer.AutoSize = true;
            this.labelNewPlayer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNewPlayer.Location = new System.Drawing.Point(12, 93);
            this.labelNewPlayer.Name = "labelNewPlayer";
            this.labelNewPlayer.Size = new System.Drawing.Size(274, 31);
            this.labelNewPlayer.TabIndex = 0;
            this.labelNewPlayer.Text = "Enter New Player\'s Name:";
            // 
            // textPlayerName
            // 
            this.textPlayerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPlayerName.Location = new System.Drawing.Point(311, 99);
            this.textPlayerName.Name = "textPlayerName";
            this.textPlayerName.Size = new System.Drawing.Size(175, 34);
            this.textPlayerName.TabIndex = 1;
            this.textPlayerName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textPlayerName_KeyUp);
            // 
            // NewPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 241);
            this.Controls.Add(this.textPlayerName);
            this.Controls.Add(this.labelNewPlayer);
            this.Name = "NewPlayerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewPlayer;
        private System.Windows.Forms.TextBox textPlayerName;
    }
}