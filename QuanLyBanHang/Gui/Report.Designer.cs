
namespace QuanLyBanHang.Gui
{
    partial class Report
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewToday = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewMonth = new System.Windows.Forms.DataGridView();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelMoth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(103, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Today";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewToday
            // 
            this.dataGridViewToday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewToday.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToday.Location = new System.Drawing.Point(103, 121);
            this.dataGridViewToday.Name = "dataGridViewToday";
            this.dataGridViewToday.RowHeadersWidth = 51;
            this.dataGridViewToday.RowTemplate.Height = 24;
            this.dataGridViewToday.Size = new System.Drawing.Size(582, 213);
            this.dataGridViewToday.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(103, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 51);
            this.button3.TabIndex = 10;
            this.button3.Text = "This Month";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMonth
            // 
            this.dataGridViewMonth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMonth.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonth.Location = new System.Drawing.Point(103, 407);
            this.dataGridViewMonth.Name = "dataGridViewMonth";
            this.dataGridViewMonth.RowHeadersWidth = 51;
            this.dataGridViewMonth.RowTemplate.Height = 24;
            this.dataGridViewMonth.Size = new System.Drawing.Size(582, 269);
            this.dataGridViewMonth.TabIndex = 12;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(547, 76);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(70, 26);
            this.labelDay.TabIndex = 14;
            this.labelDay.Text = "label2";
            // 
            // labelMoth
            // 
            this.labelMoth.AutoSize = true;
            this.labelMoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoth.Location = new System.Drawing.Point(547, 352);
            this.labelMoth.Name = "labelMoth";
            this.labelMoth.Size = new System.Drawing.Size(70, 26);
            this.labelMoth.TabIndex = 15;
            this.labelMoth.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 701);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMoth);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.dataGridViewMonth);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridViewToday);
            this.Controls.Add(this.button1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewToday;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewMonth;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMoth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}