namespace BioloadCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.comboVolume = new System.Windows.Forms.ComboBox();
            this.textVolume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioGallons = new System.Windows.Forms.RadioButton();
            this.radioLitres = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(88, 317);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(112, 31);
            this.buttonSubmit.TabIndex = 18;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // comboVolume
            // 
            this.comboVolume.FormattingEnabled = true;
            this.comboVolume.Location = new System.Drawing.Point(296, 260);
            this.comboVolume.Name = "comboVolume";
            this.comboVolume.Size = new System.Drawing.Size(190, 21);
            this.comboVolume.TabIndex = 17;
            // 
            // textVolume
            // 
            this.textVolume.Location = new System.Drawing.Point(296, 201);
            this.textVolume.Name = "textVolume";
            this.textVolume.Size = new System.Drawing.Size(190, 20);
            this.textVolume.TabIndex = 16;
            this.textVolume.TextChanged += new System.EventHandler(this.textVolume_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 80);
            this.label4.TabIndex = 15;
            this.label4.Text = "Enter tank volume\r\n                      \r\n                   Or\r\n               " +
    "\r\nUse predifined volumes\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(192, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 60);
            this.label2.TabIndex = 11;
            this.label2.Text = "This calculator estimates the number of\r\nfish you can have based on tank volume \r" +
    "\n(in gallons) and size of fish.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "How Many Marine Fish can I Have?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(632, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Based on your tank size, we reccommend that you can have the following number of " +
    "fish:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(50, 403);
            this.labelOutput.MaximumSize = new System.Drawing.Size(500, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 20);
            this.labelOutput.TabIndex = 22;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.Location = new System.Drawing.Point(53, 530);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(112, 31);
            this.buttonClearAll.TabIndex = 23;
            this.buttonClearAll.Text = "Clear";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(486, 530);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(112, 31);
            this.buttonClose.TabIndex = 24;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 590);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioLitres);
            this.groupBox1.Controls.Add(this.radioGallons);
            this.groupBox1.Location = new System.Drawing.Point(53, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 25);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // radioGallons
            // 
            this.radioGallons.AutoSize = true;
            this.radioGallons.Location = new System.Drawing.Point(36, 2);
            this.radioGallons.Name = "radioGallons";
            this.radioGallons.Size = new System.Drawing.Size(60, 17);
            this.radioGallons.TabIndex = 0;
            this.radioGallons.TabStop = true;
            this.radioGallons.Text = "Gallons";
            this.radioGallons.UseVisualStyleBackColor = true;
            this.radioGallons.CheckedChanged += new System.EventHandler(this.radioGallons_CheckedChanged);
            // 
            // radioLitres
            // 
            this.radioLitres.AutoSize = true;
            this.radioLitres.Location = new System.Drawing.Point(476, 2);
            this.radioLitres.Name = "radioLitres";
            this.radioLitres.Size = new System.Drawing.Size(50, 17);
            this.radioLitres.TabIndex = 1;
            this.radioLitres.TabStop = true;
            this.radioLitres.Text = "Litres";
            this.radioLitres.UseVisualStyleBackColor = true;
            this.radioLitres.CheckedChanged += new System.EventHandler(this.radioLitres_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboVolume);
            this.Controls.Add(this.textVolume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(668, 627);
            this.Name = "Form1";
            this.Text = "Fish Stock Calculator";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form1_Scroll);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ComboBox comboVolume;
        private System.Windows.Forms.TextBox textVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioGallons;
        private System.Windows.Forms.RadioButton radioLitres;
    }
}

