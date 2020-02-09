namespace PhotoLabeling
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
            this.picCurrent = new System.Windows.Forms.PictureBox();
            this.picPrev = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChosePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.checkMoveFolders = new System.Windows.Forms.CheckBox();
            this.checkRegexRename = new System.Windows.Forms.CheckBox();
            this.textRegexFolders = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegexReame = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.txtLabeled = new System.Windows.Forms.TextBox();
            this.txtFolderLabels = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            this.SuspendLayout();
            // 
            // picCurrent
            // 
            this.picCurrent.Location = new System.Drawing.Point(667, 41);
            this.picCurrent.Name = "picCurrent";
            this.picCurrent.Size = new System.Drawing.Size(330, 286);
            this.picCurrent.TabIndex = 0;
            this.picCurrent.TabStop = false;
            this.picCurrent.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picPrev
            // 
            this.picPrev.Location = new System.Drawing.Point(331, 198);
            this.picPrev.Name = "picPrev";
            this.picPrev.Size = new System.Drawing.Size(330, 286);
            this.picPrev.TabIndex = 1;
            this.picPrev.TabStop = false;
            // 
            // picNext
            // 
            this.picNext.Location = new System.Drawing.Point(1003, 198);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(330, 286);
            this.picNext.TabIndex = 2;
            this.picNext.TabStop = false;
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(132, 23);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(227, 26);
            this.txtPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(772, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current picture";
            // 
            // btnChosePath
            // 
            this.btnChosePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChosePath.Location = new System.Drawing.Point(21, 18);
            this.btnChosePath.Name = "btnChosePath";
            this.btnChosePath.Size = new System.Drawing.Size(105, 36);
            this.btnChosePath.TabIndex = 5;
            this.btnChosePath.Text = "Chose Path";
            this.btnChosePath.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1115, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Next picture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Previous picture";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNext.Location = new System.Drawing.Point(1100, 516);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(168, 74);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSplit.Location = new System.Drawing.Point(754, 516);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(168, 74);
            this.btnSplit.TabIndex = 9;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrev.Location = new System.Drawing.Point(416, 516);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(168, 74);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // checkMoveFolders
            // 
            this.checkMoveFolders.AutoSize = true;
            this.checkMoveFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkMoveFolders.Location = new System.Drawing.Point(12, 198);
            this.checkMoveFolders.Name = "checkMoveFolders";
            this.checkMoveFolders.Size = new System.Drawing.Size(146, 44);
            this.checkMoveFolders.TabIndex = 11;
            this.checkMoveFolders.Text = "Move pictures in \r\nindividual folders";
            this.checkMoveFolders.UseVisualStyleBackColor = true;
            // 
            // checkRegexRename
            // 
            this.checkRegexRename.AutoSize = true;
            this.checkRegexRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkRegexRename.Location = new System.Drawing.Point(12, 296);
            this.checkRegexRename.Name = "checkRegexRename";
            this.checkRegexRename.Size = new System.Drawing.Size(153, 44);
            this.checkRegexRename.TabIndex = 12;
            this.checkRegexRename.Text = "Rename pictures \r\nafter regex";
            this.checkRegexRename.UseVisualStyleBackColor = true;
            this.checkRegexRename.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textRegexFolders
            // 
            this.textRegexFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRegexFolders.Location = new System.Drawing.Point(131, 245);
            this.textRegexFolders.Name = "textRegexFolders";
            this.textRegexFolders.Size = new System.Drawing.Size(102, 26);
            this.textRegexFolders.TabIndex = 13;
            this.textRegexFolders.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Folder regex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rename regex";
            // 
            // txtRegexReame
            // 
            this.txtRegexReame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegexReame.Location = new System.Drawing.Point(131, 343);
            this.txtRegexReame.Name = "txtRegexReame";
            this.txtRegexReame.Size = new System.Drawing.Size(102, 26);
            this.txtRegexReame.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Remaining pictures";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Labeled pictures";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "No of labels";
            // 
            // txtRemaining
            // 
            this.txtRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemaining.Location = new System.Drawing.Point(163, 421);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.ReadOnly = true;
            this.txtRemaining.Size = new System.Drawing.Size(82, 26);
            this.txtRemaining.TabIndex = 20;
            // 
            // txtLabeled
            // 
            this.txtLabeled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabeled.Location = new System.Drawing.Point(163, 454);
            this.txtLabeled.Name = "txtLabeled";
            this.txtLabeled.ReadOnly = true;
            this.txtLabeled.Size = new System.Drawing.Size(82, 26);
            this.txtLabeled.TabIndex = 21;
            // 
            // txtFolderLabels
            // 
            this.txtFolderLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderLabels.Location = new System.Drawing.Point(163, 488);
            this.txtFolderLabels.Name = "txtFolderLabels";
            this.txtFolderLabels.ReadOnly = true;
            this.txtFolderLabels.Size = new System.Drawing.Size(82, 26);
            this.txtFolderLabels.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 680);
            this.Controls.Add(this.txtFolderLabels);
            this.Controls.Add(this.txtLabeled);
            this.Controls.Add(this.txtRemaining);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRegexReame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textRegexFolders);
            this.Controls.Add(this.checkRegexRename);
            this.Controls.Add(this.checkMoveFolders);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChosePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picPrev);
            this.Controls.Add(this.picCurrent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCurrent;
        private System.Windows.Forms.PictureBox picPrev;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChosePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.CheckBox checkMoveFolders;
        private System.Windows.Forms.CheckBox checkRegexRename;
        private System.Windows.Forms.TextBox textRegexFolders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegexReame;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.TextBox txtLabeled;
        private System.Windows.Forms.TextBox txtFolderLabels;
    }
}

