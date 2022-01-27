namespace Automobills.GUI
{
    partial class ControlPanel
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
            this.mOverviewButton = new System.Windows.Forms.Button();
            this.mTransactionButton = new System.Windows.Forms.Button();
            this.mAcountsButton = new System.Windows.Forms.Button();
            this.mDebts = new System.Windows.Forms.Button();
            this.mBudget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mOverviewButton
            // 
            this.mOverviewButton.BackColor = System.Drawing.SystemColors.Control;
            this.mOverviewButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mOverviewButton.Location = new System.Drawing.Point(3, 3);
            this.mOverviewButton.Name = "mOverviewButton";
            this.mOverviewButton.Size = new System.Drawing.Size(141, 48);
            this.mOverviewButton.TabIndex = 0;
            this.mOverviewButton.Text = "Overview";
            this.mOverviewButton.UseVisualStyleBackColor = false;
            // 
            // mTransactionButton
            // 
            this.mTransactionButton.BackColor = System.Drawing.SystemColors.Control;
            this.mTransactionButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTransactionButton.Location = new System.Drawing.Point(3, 57);
            this.mTransactionButton.Name = "mTransactionButton";
            this.mTransactionButton.Size = new System.Drawing.Size(141, 48);
            this.mTransactionButton.TabIndex = 0;
            this.mTransactionButton.Text = "Transactions";
            this.mTransactionButton.UseVisualStyleBackColor = false;
            // 
            // mAcountsButton
            // 
            this.mAcountsButton.BackColor = System.Drawing.SystemColors.Control;
            this.mAcountsButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAcountsButton.Location = new System.Drawing.Point(3, 111);
            this.mAcountsButton.Name = "mAcountsButton";
            this.mAcountsButton.Size = new System.Drawing.Size(141, 48);
            this.mAcountsButton.TabIndex = 0;
            this.mAcountsButton.Text = "Acounts";
            this.mAcountsButton.UseVisualStyleBackColor = false;
            // 
            // mDebts
            // 
            this.mDebts.BackColor = System.Drawing.SystemColors.Control;
            this.mDebts.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDebts.Location = new System.Drawing.Point(3, 165);
            this.mDebts.Name = "mDebts";
            this.mDebts.Size = new System.Drawing.Size(141, 48);
            this.mDebts.TabIndex = 0;
            this.mDebts.Text = "Debts";
            this.mDebts.UseVisualStyleBackColor = false;
            // 
            // mBudget
            // 
            this.mBudget.BackColor = System.Drawing.SystemColors.Control;
            this.mBudget.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBudget.Location = new System.Drawing.Point(3, 219);
            this.mBudget.Name = "mBudget";
            this.mBudget.Size = new System.Drawing.Size(141, 48);
            this.mBudget.TabIndex = 0;
            this.mBudget.Text = "Budget";
            this.mBudget.UseVisualStyleBackColor = false;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mBudget);
            this.Controls.Add(this.mDebts);
            this.Controls.Add(this.mAcountsButton);
            this.Controls.Add(this.mTransactionButton);
            this.Controls.Add(this.mOverviewButton);
            this.Name = "ControlPanel";
            this.Size = new System.Drawing.Size(149, 274);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mOverviewButton;
        private System.Windows.Forms.Button mTransactionButton;
        private System.Windows.Forms.Button mAcountsButton;
        private System.Windows.Forms.Button mDebts;
        private System.Windows.Forms.Button mBudget;
    }
}
