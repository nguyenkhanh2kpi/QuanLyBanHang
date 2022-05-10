
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.dataGridViewToday = new System.Windows.Forms.DataGridView();
            this.dataGridViewMonth = new System.Windows.Forms.DataGridView();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelMoth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewToday
            // 
            this.dataGridViewToday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewToday.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToday.Location = new System.Drawing.Point(98, 46);
            this.dataGridViewToday.Name = "dataGridViewToday";
            this.dataGridViewToday.RowHeadersWidth = 51;
            this.dataGridViewToday.RowTemplate.Height = 24;
            this.dataGridViewToday.Size = new System.Drawing.Size(582, 284);
            this.dataGridViewToday.TabIndex = 7;
            // 
            // dataGridViewMonth
            // 
            this.dataGridViewMonth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMonth.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonth.Location = new System.Drawing.Point(98, 386);
            this.dataGridViewMonth.Name = "dataGridViewMonth";
            this.dataGridViewMonth.RowHeadersWidth = 51;
            this.dataGridViewMonth.RowTemplate.Height = 24;
            this.dataGridViewMonth.Size = new System.Drawing.Size(582, 306);
            this.dataGridViewMonth.TabIndex = 12;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(551, 17);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(70, 26);
            this.labelDay.TabIndex = 14;
            this.labelDay.Text = "label2";
            // 
            // labelMoth
            // 
            this.labelMoth.AutoSize = true;
            this.labelMoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoth.Location = new System.Drawing.Point(551, 357);
            this.labelMoth.Name = "labelMoth";
            this.labelMoth.Size = new System.Drawing.Size(70, 26);
            this.labelMoth.TabIndex = 15;
            this.labelMoth.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sales Today";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sales This Month";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(686, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 284);
            this.button1.TabIndex = 22;
            this.button1.Text = "Export Excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(686, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 306);
            this.button2.TabIndex = 23;
            this.button2.Text = "Export Excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(925, 701);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMoth);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.dataGridViewMonth);
            this.Controls.Add(this.dataGridViewToday);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewToday;
        private System.Windows.Forms.DataGridView dataGridViewMonth;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMoth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}