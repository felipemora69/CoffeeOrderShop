namespace DonutShopLesson
{
    partial class DonutOrder
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
            this.cb_Flavor = new System.Windows.Forms.ComboBox();
            this.numericValue = new System.Windows.Forms.NumericUpDown();
            this.btn_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(27, 31);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(92, 33);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Donut";
            // 
            // cb_Flavor
            // 
            this.cb_Flavor.FormattingEnabled = true;
            this.cb_Flavor.Items.AddRange(new object[] {
            "Boston Cream",
            "Sprinkles",
            "Chocolate",
            "Maple"});
            this.cb_Flavor.Location = new System.Drawing.Point(33, 88);
            this.cb_Flavor.Name = "cb_Flavor";
            this.cb_Flavor.Size = new System.Drawing.Size(121, 22);
            this.cb_Flavor.TabIndex = 1;
            this.cb_Flavor.Text = "Boston Cream";
            // 
            // numericValue
            // 
            this.numericValue.Location = new System.Drawing.Point(191, 88);
            this.numericValue.Name = "numericValue";
            this.numericValue.ReadOnly = true;
            this.numericValue.Size = new System.Drawing.Size(46, 22);
            this.numericValue.TabIndex = 2;
            this.numericValue.ValueChanged += new System.EventHandler(this.numericValue_ValueChanged);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(257, 16);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(30, 28);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "X";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // DonutOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.numericValue);
            this.Controls.Add(this.cb_Flavor);
            this.Controls.Add(this.lbl_Name);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(310, 132);
            this.Name = "DonutOrder";
            this.Size = new System.Drawing.Size(310, 132);
            this.Load += new System.EventHandler(this.DonutOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.ComboBox cb_Flavor;
        private System.Windows.Forms.NumericUpDown numericValue;
        private System.Windows.Forms.Button btn_Remove;
    }
}
