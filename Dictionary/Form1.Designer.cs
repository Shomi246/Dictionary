namespace Dictionary
{
    partial class Dictionary
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
            this.add = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.txteng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Gainsboro;
            this.add.ForeColor = System.Drawing.Color.Sienna;
            this.add.Location = new System.Drawing.Point(363, 22);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(69, 28);
            this.add.TabIndex = 0;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // datagrid
            // 
            this.datagrid.BackgroundColor = System.Drawing.Color.Gray;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(42, 156);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(366, 235);
            this.datagrid.TabIndex = 1;
            // 
            // txteng
            // 
            this.txteng.Location = new System.Drawing.Point(133, 59);
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(177, 20);
            this.txteng.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "English :";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(172, 99);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(90, 37);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(472, 403);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txteng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.add);
            this.Name = "Dictionary";
            this.Text = "Dictionary";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.TextBox txteng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
    }
}

