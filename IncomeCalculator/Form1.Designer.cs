namespace IncomeCalculator
{
    partial class home
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
            this.wagelbl = new System.Windows.Forms.Label();
            this.wagetxt = new System.Windows.Forms.TextBox();
            this.hourslbl = new System.Windows.Forms.Label();
            this.hourstxt = new System.Windows.Forms.TextBox();
            this.totallbl = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wagelbl
            // 
            this.wagelbl.AutoSize = true;
            this.wagelbl.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wagelbl.Location = new System.Drawing.Point(12, 23);
            this.wagelbl.Name = "wagelbl";
            this.wagelbl.Size = new System.Drawing.Size(171, 31);
            this.wagelbl.TabIndex = 0;
            this.wagelbl.Text = "Wage per hour";
            this.wagelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // wagetxt
            // 
            this.wagetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wagetxt.Location = new System.Drawing.Point(216, 22);
            this.wagetxt.Name = "wagetxt";
            this.wagetxt.Size = new System.Drawing.Size(93, 35);
            this.wagetxt.TabIndex = 1;
            // 
            // hourslbl
            // 
            this.hourslbl.AutoSize = true;
            this.hourslbl.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourslbl.Location = new System.Drawing.Point(11, 85);
            this.hourslbl.Name = "hourslbl";
            this.hourslbl.Size = new System.Drawing.Size(163, 31);
            this.hourslbl.TabIndex = 2;
            this.hourslbl.Text = "Hours worked";
            // 
            // hourstxt
            // 
            this.hourstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourstxt.Location = new System.Drawing.Point(216, 85);
            this.hourstxt.Name = "hourstxt";
            this.hourstxt.Size = new System.Drawing.Size(93, 35);
            this.hourstxt.TabIndex = 3;
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.Location = new System.Drawing.Point(12, 269);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(254, 25);
            this.totallbl.TabIndex = 4;
            this.totallbl.Text = "The total you have earned is";
            // 
            // totaltxt
            // 
            this.totaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltxt.Location = new System.Drawing.Point(272, 259);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.ReadOnly = true;
            this.totaltxt.Size = new System.Drawing.Size(104, 35);
            this.totaltxt.TabIndex = 5;
            this.totaltxt.TextChanged += new System.EventHandler(this.totaltxt_TextChanged);
            // 
            // calculatebtn
            // 
            this.calculatebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.calculatebtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebtn.Location = new System.Drawing.Point(12, 215);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(145, 40);
            this.calculatebtn.TabIndex = 6;
            this.calculatebtn.Text = "Calculate";
            this.calculatebtn.UseVisualStyleBackColor = false;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(419, 334);
            this.Controls.Add(this.calculatebtn);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.hourstxt);
            this.Controls.Add(this.hourslbl);
            this.Controls.Add(this.wagetxt);
            this.Controls.Add(this.wagelbl);
            this.MaximizeBox = false;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Calulator";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wagelbl;
        private System.Windows.Forms.TextBox wagetxt;
        private System.Windows.Forms.Label hourslbl;
        private System.Windows.Forms.TextBox hourstxt;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Button calculatebtn;
    }
}

