namespace Blackjack
{
    partial class Main
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
            this.top = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.playerCard3 = new System.Windows.Forms.PictureBox();
            this.playerCard4 = new System.Windows.Forms.PictureBox();
            this.playerCard5 = new System.Windows.Forms.PictureBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.dealer1 = new System.Windows.Forms.PictureBox();
            this.dealer2 = new System.Windows.Forms.PictureBox();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer2)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.top.Controls.Add(this.title);
            this.top.Controls.Add(this.close);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(834, 37);
            this.top.TabIndex = 0;
            this.top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(3, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(108, 24);
            this.title.TabIndex = 1;
            this.title.Text = "Blackjack";
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.Location = new System.Drawing.Point(739, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(95, 37);
            this.close.TabIndex = 0;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // playerCard1
            // 
            this.playerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerCard1.Location = new System.Drawing.Point(160, 279);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(125, 181);
            this.playerCard1.TabIndex = 1;
            this.playerCard1.TabStop = false;
            // 
            // hitButton
            // 
            this.hitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(196)))));
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.hitButton.Location = new System.Drawing.Point(12, 279);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(142, 37);
            this.hitButton.TabIndex = 2;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.standButton.Location = new System.Drawing.Point(12, 322);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(142, 37);
            this.standButton.TabIndex = 3;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // playerCard2
            // 
            this.playerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerCard2.Location = new System.Drawing.Point(291, 279);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(125, 181);
            this.playerCard2.TabIndex = 5;
            this.playerCard2.TabStop = false;
            // 
            // playerCard3
            // 
            this.playerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerCard3.Location = new System.Drawing.Point(422, 279);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(125, 181);
            this.playerCard3.TabIndex = 6;
            this.playerCard3.TabStop = false;
            // 
            // playerCard4
            // 
            this.playerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerCard4.Location = new System.Drawing.Point(553, 279);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(125, 181);
            this.playerCard4.TabIndex = 7;
            this.playerCard4.TabStop = false;
            // 
            // playerCard5
            // 
            this.playerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerCard5.Location = new System.Drawing.Point(684, 279);
            this.playerCard5.Name = "playerCard5";
            this.playerCard5.Size = new System.Drawing.Size(125, 181);
            this.playerCard5.TabIndex = 8;
            this.playerCard5.TabStop = false;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.valueLabel.Location = new System.Drawing.Point(52, 393);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(62, 30);
            this.valueLabel.TabIndex = 9;
            this.valueLabel.Text = "0/21";
            // 
            // dealer1
            // 
            this.dealer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dealer1.Location = new System.Drawing.Point(291, 43);
            this.dealer1.Name = "dealer1";
            this.dealer1.Size = new System.Drawing.Size(86, 125);
            this.dealer1.TabIndex = 10;
            this.dealer1.TabStop = false;
            // 
            // dealer2
            // 
            this.dealer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dealer2.Location = new System.Drawing.Point(383, 43);
            this.dealer2.Name = "dealer2";
            this.dealer2.Size = new System.Drawing.Size(86, 125);
            this.dealer2.TabIndex = 11;
            this.dealer2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(834, 487);
            this.Controls.Add(this.dealer2);
            this.Controls.Add(this.dealer1);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.playerCard5);
            this.Controls.Add(this.playerCard4);
            this.Controls.Add(this.playerCard3);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.PictureBox playerCard3;
        private System.Windows.Forms.PictureBox playerCard4;
        private System.Windows.Forms.PictureBox playerCard5;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.PictureBox dealer1;
        private System.Windows.Forms.PictureBox dealer2;
    }
}

