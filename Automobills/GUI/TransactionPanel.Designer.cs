namespace Automobills.GUI
{
    partial class TransactionPanel
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
            this.mAddTransactionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mAddTransactionButton
            // 
            this.mAddTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mAddTransactionButton.Location = new System.Drawing.Point(226, 469);
            this.mAddTransactionButton.Name = "mAddTransactionButton";
            this.mAddTransactionButton.Size = new System.Drawing.Size(75, 23);
            this.mAddTransactionButton.TabIndex = 0;
            this.mAddTransactionButton.Text = "Add Transaction";
            this.mAddTransactionButton.UseVisualStyleBackColor = true;
            // 
            // TransactionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mAddTransactionButton);
            this.Name = "TransactionPanel";
            this.Size = new System.Drawing.Size(531, 495);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mAddTransactionButton;
    }
}
