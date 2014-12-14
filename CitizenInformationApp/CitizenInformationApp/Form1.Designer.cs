namespace CitizenInformationApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_idtextBox = new System.Windows.Forms.TextBox();
            this.detailsinfotextBox = new System.Windows.Forms.TextBox();
            this.searchuseridtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchbyidButton = new System.Windows.Forms.Button();
            this.showallinfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id";
            // 
            // user_idtextBox
            // 
            this.user_idtextBox.Location = new System.Drawing.Point(90, 39);
            this.user_idtextBox.Name = "user_idtextBox";
            this.user_idtextBox.Size = new System.Drawing.Size(172, 20);
            this.user_idtextBox.TabIndex = 3;
            // 
            // detailsinfotextBox
            // 
            this.detailsinfotextBox.Location = new System.Drawing.Point(90, 91);
            this.detailsinfotextBox.Multiline = true;
            this.detailsinfotextBox.Name = "detailsinfotextBox";
            this.detailsinfotextBox.Size = new System.Drawing.Size(165, 84);
            this.detailsinfotextBox.TabIndex = 4;
            // 
            // searchuseridtextBox
            // 
            this.searchuseridtextBox.Location = new System.Drawing.Point(90, 263);
            this.searchuseridtextBox.Name = "searchuseridtextBox";
            this.searchuseridtextBox.Size = new System.Drawing.Size(165, 20);
            this.searchuseridtextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchbyidButton
            // 
            this.searchbyidButton.Location = new System.Drawing.Point(284, 263);
            this.searchbyidButton.Name = "searchbyidButton";
            this.searchbyidButton.Size = new System.Drawing.Size(75, 23);
            this.searchbyidButton.TabIndex = 7;
            this.searchbyidButton.Text = "Search";
            this.searchbyidButton.UseVisualStyleBackColor = true;
            this.searchbyidButton.Click += new System.EventHandler(this.searchbyidButton_Click);
            // 
            // showallinfoButton
            // 
            this.showallinfoButton.Location = new System.Drawing.Point(104, 356);
            this.showallinfoButton.Name = "showallinfoButton";
            this.showallinfoButton.Size = new System.Drawing.Size(151, 40);
            this.showallinfoButton.TabIndex = 8;
            this.showallinfoButton.Text = "Show All";
            this.showallinfoButton.UseVisualStyleBackColor = true;
            this.showallinfoButton.Click += new System.EventHandler(this.showallinfoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 425);
            this.Controls.Add(this.showallinfoButton);
            this.Controls.Add(this.searchbyidButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchuseridtextBox);
            this.Controls.Add(this.detailsinfotextBox);
            this.Controls.Add(this.user_idtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_idtextBox;
        private System.Windows.Forms.TextBox detailsinfotextBox;
        private System.Windows.Forms.TextBox searchuseridtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searchbyidButton;
        private System.Windows.Forms.Button showallinfoButton;
    }
}

