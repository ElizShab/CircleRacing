﻿
namespace CircleRacing
{
    partial class EditMembers
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
            this.AddMember_B = new System.Windows.Forms.Button();
            this.DeleteMember_B = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddMember_B
            // 
            this.AddMember_B.Location = new System.Drawing.Point(506, 99);
            this.AddMember_B.Name = "AddMember_B";
            this.AddMember_B.Size = new System.Drawing.Size(139, 65);
            this.AddMember_B.TabIndex = 1;
            this.AddMember_B.Text = "Добавить участника";
            this.AddMember_B.UseVisualStyleBackColor = true;
            this.AddMember_B.Click += new System.EventHandler(this.AddMember_B_Click);
            // 
            // DeleteMember_B
            // 
            this.DeleteMember_B.Location = new System.Drawing.Point(506, 186);
            this.DeleteMember_B.Name = "DeleteMember_B";
            this.DeleteMember_B.Size = new System.Drawing.Size(139, 57);
            this.DeleteMember_B.TabIndex = 2;
            this.DeleteMember_B.Text = "Удалить участника";
            this.DeleteMember_B.UseVisualStyleBackColor = true;
            this.DeleteMember_B.Click += new System.EventHandler(this.DeleteMember_B_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.listBox1.Location = new System.Drawing.Point(12, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 312);
            this.listBox1.TabIndex = 3;
            // 
            // EditMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 344);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DeleteMember_B);
            this.Controls.Add(this.AddMember_B);
            this.Name = "EditMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список участников";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddMember_B;
        private System.Windows.Forms.Button DeleteMember_B;
        public System.Windows.Forms.ListBox listBox1;
    }
}