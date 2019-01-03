namespace Dictionary
{
    partial class Add
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtbng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsy = new System.Windows.Forms.TextBox();
            this.txteng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bengali :";
            // 
            // txtbng
            // 
            this.txtbng.Location = new System.Drawing.Point(126, 93);
            this.txtbng.Name = "txtbng";
            this.txtbng.Size = new System.Drawing.Size(177, 20);
            this.txtbng.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Synonym :";
            // 
            // txtsy
            // 
            this.txtsy.Location = new System.Drawing.Point(126, 134);
            this.txtsy.Name = "txtsy";
            this.txtsy.Size = new System.Drawing.Size(177, 20);
            this.txtsy.TabIndex = 1;
            // 
            // txteng
            // 
            this.txteng.Location = new System.Drawing.Point(126, 55);
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(177, 20);
            this.txteng.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "English :";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(30, 233);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(90, 37);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(140, 181);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(90, 37);
            this.save.TabIndex = 2;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(140, 233);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(90, 37);
            this.edit.TabIndex = 2;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(247, 233);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 37);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(421, 365);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txtbng);
            this.Controls.Add(this.txtsy);
            this.Controls.Add(this.txteng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsy;
        private System.Windows.Forms.TextBox txteng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
    }
}