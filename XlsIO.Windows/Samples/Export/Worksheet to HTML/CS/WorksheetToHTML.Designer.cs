namespace EssentialXlsIOSamples
{
    partial class WorksheetToHTML
    {
        #region Fields
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbWkSheet;
        private System.Windows.Forms.RadioButton rdbWkbook;
        #endregion        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorksheetToHTML));
            this.btnConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbWkSheet = new System.Windows.Forms.RadioButton();
            this.rdbWkbook = new System.Windows.Forms.RadioButton();
            this.viewInputTemplate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(192, 177);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(90, 26);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 27);
            this.label2.TabIndex = 75;
            this.label2.Text = "Click the button to view an HTML generated by Essential XlsIO.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(377, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 74;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbWkSheet);
            this.groupBox1.Controls.Add(this.rdbWkbook);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(87, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 39);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // rdbWkSheet
            // 
            this.rdbWkSheet.AutoSize = true;
            this.rdbWkSheet.Checked = true;
            this.rdbWkSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWkSheet.Location = new System.Drawing.Point(102, 16);
            this.rdbWkSheet.Name = "rdbWkSheet";
            this.rdbWkSheet.Size = new System.Drawing.Size(77, 17);
            this.rdbWkSheet.TabIndex = 1;
            this.rdbWkSheet.TabStop = true;
            this.rdbWkSheet.Text = "Worksheet";
            this.rdbWkSheet.UseVisualStyleBackColor = true;
            // 
            // rdbWkbook
            // 
            this.rdbWkbook.AutoSize = true;
            this.rdbWkbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWkbook.Location = new System.Drawing.Point(5, 16);
            this.rdbWkbook.Name = "rdbWkbook";
            this.rdbWkbook.Size = new System.Drawing.Size(75, 17);
            this.rdbWkbook.TabIndex = 0;
            this.rdbWkbook.Text = "Workbook";
            this.rdbWkbook.UseVisualStyleBackColor = true;
            // 
            // viewInputTemplate
            // 
            this.viewInputTemplate.Location = new System.Drawing.Point(87, 177);
            this.viewInputTemplate.Name = "viewInputTemplate";
            this.viewInputTemplate.Size = new System.Drawing.Size(90, 26);
            this.viewInputTemplate.TabIndex = 77;
            this.viewInputTemplate.Text = "Input Template";
            this.viewInputTemplate.UseVisualStyleBackColor = true;
            this.viewInputTemplate.Click += new System.EventHandler(this.viewInputTemplate_Click);
            // 
            // WorksheetToHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 210);
            this.Controls.Add(this.viewInputTemplate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WorksheetToHTML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorksheetToHTML";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Dispose
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
        #endregion

        private System.Windows.Forms.Button viewInputTemplate;

        
    }
}
