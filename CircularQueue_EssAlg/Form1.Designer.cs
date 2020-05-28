namespace CircularQueue
{
    partial class Form1
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
            this.queuePictureBox = new System.Windows.Forms.PictureBox();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstContend = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.queuePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // queuePictureBox
            // 
            this.queuePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.queuePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.queuePictureBox.Location = new System.Drawing.Point(42, 41);
            this.queuePictureBox.Name = "queuePictureBox";
            this.queuePictureBox.Size = new System.Drawing.Size(253, 259);
            this.queuePictureBox.TabIndex = 9;
            this.queuePictureBox.TabStop = false;
            this.queuePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.queuePictureBox_Paint);
            // 
            // dequeueButton
            // 
            this.dequeueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dequeueButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dequeueButton.Location = new System.Drawing.Point(220, 12);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 8;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // enqueueButton
            // 
            this.enqueueButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.enqueueButton.Location = new System.Drawing.Point(139, 12);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 7;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // itemTextBox
            // 
            this.itemTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemTextBox.Location = new System.Drawing.Point(48, 14);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(76, 20);
            this.itemTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item:";
            // 
            // lstContend
            // 
            this.lstContend.FormattingEnabled = true;
            this.lstContend.Location = new System.Drawing.Point(325, 41);
            this.lstContend.Name = "lstContend";
            this.lstContend.Size = new System.Drawing.Size(123, 251);
            this.lstContend.TabIndex = 10;
            this.lstContend.SelectedIndexChanged += new System.EventHandler(this.lstContents_SelectedIndexChanged);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(477, 90);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(123, 26);
            this.btnList.TabIndex = 11;
            this.btnList.Text = "Show Queue";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(477, 275);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(123, 23);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.enqueueButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.dequeueButton;
            this.ClientSize = new System.Drawing.Size(633, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lstContend);
            this.Controls.Add(this.queuePictureBox);
            this.Controls.Add(this.dequeueButton);
            this.Controls.Add(this.enqueueButton);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CircularQueue";
            ((System.ComponentModel.ISupportInitialize)(this.queuePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox queuePictureBox;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstContend;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label2;
    }
}

