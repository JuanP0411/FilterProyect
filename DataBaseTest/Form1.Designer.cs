namespace DataBaseTest
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
            this.btLoad = new System.Windows.Forms.Button();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btPrev = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(876, 47);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(183, 57);
            this.btLoad.TabIndex = 0;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(353, 236);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersWidth = 51;
            this.dgData.RowTemplate.Height = 24;
            this.dgData.Size = new System.Drawing.Size(644, 315);
            this.dgData.TabIndex = 1;
            this.dgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(384, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identifier";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(553, 47);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(189, 22);
            this.tbUrl.TabIndex = 4;
            this.tbUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(553, 142);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(189, 22);
            this.tbId.TabIndex = 5;
            this.tbId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(251, 347);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(85, 63);
            this.btPrev.TabIndex = 6;
            this.btPrev.Text = "Prev";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(1016, 347);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(85, 63);
            this.btNext.TabIndex = 7;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filters";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 435);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 574);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.btLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

