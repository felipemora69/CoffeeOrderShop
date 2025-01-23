namespace DonutShopLesson
{
    partial class CoffeeOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Name = new System.Windows.Forms.Label();
            this.cb_Size = new System.Windows.Forms.ComboBox();
            this.hasCream = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(23, 14);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(100, 33);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Coffee";
            // 
            // cb_Size
            // 
            this.cb_Size.FormattingEnabled = true;
            this.cb_Size.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cb_Size.Location = new System.Drawing.Point(25, 69);
            this.cb_Size.Name = "cb_Size";
            this.cb_Size.Size = new System.Drawing.Size(121, 22);
            this.cb_Size.TabIndex = 1;
            this.cb_Size.Text = "Small";
            // 
            // hasCream
            // 
            this.hasCream.AutoSize = true;
            this.hasCream.ForeColor = System.Drawing.Color.White;
            this.hasCream.Location = new System.Drawing.Point(192, 73);
            this.hasCream.Name = "hasCream";
            this.hasCream.Size = new System.Drawing.Size(58, 18);
            this.hasCream.TabIndex = 2;
            this.hasCream.Text = "Cream";
            this.hasCream.UseVisualStyleBackColor = true;
            // 
            // CoffeeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.Controls.Add(this.hasCream);
            this.Controls.Add(this.cb_Size);
            this.Controls.Add(this.lbl_Name);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CoffeeOrder";
            this.Size = new System.Drawing.Size(310, 132);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.ComboBox cb_Size;
        private System.Windows.Forms.CheckBox hasCream;
    }
}
