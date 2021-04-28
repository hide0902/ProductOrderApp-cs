
namespace ProductOrderApp
{
    partial class Accounting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting));
            this.liquidationButton = new System.Windows.Forms.Button();
            this.billLabel = new System.Windows.Forms.Label();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.paymentDisplayTexBox = new System.Windows.Forms.Label();
            this.yenLabel = new System.Windows.Forms.Label();
            this.billItemList = new System.Windows.Forms.TableLayoutPanel();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.billItemList.SuspendLayout();
            this.SuspendLayout();
            // 
            // liquidationButton
            // 
            this.liquidationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.liquidationButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.liquidationButton.ForeColor = System.Drawing.Color.White;
            this.liquidationButton.Location = new System.Drawing.Point(511, 359);
            this.liquidationButton.Name = "liquidationButton";
            this.liquidationButton.Size = new System.Drawing.Size(75, 40);
            this.liquidationButton.TabIndex = 1;
            this.liquidationButton.Text = "清算";
            this.liquidationButton.UseVisualStyleBackColor = false;
            this.liquidationButton.Click += new System.EventHandler(this.liquidationButton_Click);
            // 
            // billLabel
            // 
            this.billLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.billLabel.Location = new System.Drawing.Point(320, 0);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(158, 97);
            this.billLabel.TabIndex = 1;
            this.billLabel.Text = "お会計";
            this.billLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentTextBox.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.paymentTextBox.Location = new System.Drawing.Point(293, 359);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(212, 36);
            this.paymentTextBox.TabIndex = 0;
            this.paymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paymentDisplayTexBox
            // 
            this.paymentDisplayTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentDisplayTexBox.AutoSize = true;
            this.paymentDisplayTexBox.BackColor = System.Drawing.Color.White;
            this.paymentDisplayTexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentDisplayTexBox.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.paymentDisplayTexBox.Location = new System.Drawing.Point(293, 193);
            this.paymentDisplayTexBox.Name = "paymentDisplayTexBox";
            this.paymentDisplayTexBox.Size = new System.Drawing.Size(212, 66);
            this.paymentDisplayTexBox.TabIndex = 3;
            this.paymentDisplayTexBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yenLabel
            // 
            this.yenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.yenLabel.AutoSize = true;
            this.yenLabel.Font = new System.Drawing.Font("MS UI Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yenLabel.Location = new System.Drawing.Point(226, 194);
            this.yenLabel.Name = "yenLabel";
            this.yenLabel.Size = new System.Drawing.Size(61, 64);
            this.yenLabel.TabIndex = 4;
            this.yenLabel.Text = "\\";
            // 
            // billItemList
            // 
            this.billItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.billItemList.ColumnCount = 3;
            this.billItemList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.billItemList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.billItemList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.billItemList.Controls.Add(this.paymentDisplayTexBox, 1, 1);
            this.billItemList.Controls.Add(this.yenLabel, 0, 1);
            this.billItemList.Controls.Add(this.billLabel, 1, 0);
            this.billItemList.Controls.Add(this.paymentLabel, 0, 2);
            this.billItemList.Controls.Add(this.liquidationButton, 2, 2);
            this.billItemList.Controls.Add(this.paymentTextBox, 1, 2);
            this.billItemList.Location = new System.Drawing.Point(2, 1);
            this.billItemList.Name = "billItemList";
            this.billItemList.RowCount = 3;
            this.billItemList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.74888F));
            this.billItemList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.07175F));
            this.billItemList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.billItemList.Size = new System.Drawing.Size(800, 446);
            this.billItemList.TabIndex = 5;
            // 
            // paymentLabel
            // 
            this.paymentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.paymentLabel.Location = new System.Drawing.Point(98, 356);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(189, 35);
            this.paymentLabel.TabIndex = 5;
            this.paymentLabel.Text = "お支払金額";
            this.paymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Accounting
            // 
            this.AcceptButton = this.liquidationButton;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.billItemList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accounting";
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.Accounting_Load);
            this.billItemList.ResumeLayout(false);
            this.billItemList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button liquidationButton;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Label paymentDisplayTexBox;
        private System.Windows.Forms.Label yenLabel;
        private System.Windows.Forms.TableLayoutPanel billItemList;
        private System.Windows.Forms.Label paymentLabel;
    }
}