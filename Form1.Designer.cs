namespace DonutShopLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtb_Receipt = new System.Windows.Forms.RichTextBox();
            this.btn_AddCoffee = new System.Windows.Forms.Button();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.btn_ClearLast = new System.Windows.Forms.Button();
            this.btn_AddDonut = new System.Windows.Forms.Button();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.btn_Language = new System.Windows.Forms.Button();
            this.orderContainer = new DonutShopLesson.Container();
            this.SuspendLayout();
            // 
            // rtb_Receipt
            // 
            this.rtb_Receipt.Location = new System.Drawing.Point(553, 13);
            this.rtb_Receipt.Name = "rtb_Receipt";
            this.rtb_Receipt.Size = new System.Drawing.Size(235, 458);
            this.rtb_Receipt.TabIndex = 2;
            this.rtb_Receipt.Text = "";
            // 
            // btn_AddCoffee
            // 
            this.btn_AddCoffee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddCoffee.BackgroundImage")));
            this.btn_AddCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddCoffee.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCoffee.ForeColor = System.Drawing.Color.White;
            this.btn_AddCoffee.Location = new System.Drawing.Point(12, 24);
            this.btn_AddCoffee.Name = "btn_AddCoffee";
            this.btn_AddCoffee.Size = new System.Drawing.Size(91, 91);
            this.btn_AddCoffee.TabIndex = 4;
            this.btn_AddCoffee.Text = "Add Coffee";
            this.btn_AddCoffee.UseVisualStyleBackColor = true;
            this.btn_AddCoffee.Click += new System.EventHandler(this.btn_AddCoffee_Click);
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.BackColor = System.Drawing.Color.White;
            this.btn_ClearAll.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearAll.Location = new System.Drawing.Point(12, 248);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(184, 25);
            this.btn_ClearAll.TabIndex = 5;
            this.btn_ClearAll.Text = "Clear All";
            this.btn_ClearAll.UseVisualStyleBackColor = false;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_ClearLast
            // 
            this.btn_ClearLast.BackColor = System.Drawing.Color.White;
            this.btn_ClearLast.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearLast.Location = new System.Drawing.Point(12, 201);
            this.btn_ClearLast.Name = "btn_ClearLast";
            this.btn_ClearLast.Size = new System.Drawing.Size(184, 40);
            this.btn_ClearLast.TabIndex = 6;
            this.btn_ClearLast.Text = "Clear Last Item";
            this.btn_ClearLast.UseVisualStyleBackColor = false;
            this.btn_ClearLast.Click += new System.EventHandler(this.btn_ClearLast_Click);
            // 
            // btn_AddDonut
            // 
            this.btn_AddDonut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddDonut.BackgroundImage")));
            this.btn_AddDonut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddDonut.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddDonut.ForeColor = System.Drawing.Color.Black;
            this.btn_AddDonut.Location = new System.Drawing.Point(109, 24);
            this.btn_AddDonut.Name = "btn_AddDonut";
            this.btn_AddDonut.Size = new System.Drawing.Size(87, 91);
            this.btn_AddDonut.TabIndex = 7;
            this.btn_AddDonut.Text = "Add Donut";
            this.btn_AddDonut.UseVisualStyleBackColor = true;
            this.btn_AddDonut.Click += new System.EventHandler(this.btn_AddDonut_Click);
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.BackColor = System.Drawing.Color.White;
            this.btn_CheckOut.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut.Location = new System.Drawing.Point(12, 121);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(184, 74);
            this.btn_CheckOut.TabIndex = 8;
            this.btn_CheckOut.Text = "CHECKOUT";
            this.btn_CheckOut.UseVisualStyleBackColor = false;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // btn_Language
            // 
            this.btn_Language.BackColor = System.Drawing.Color.White;
            this.btn_Language.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Language.Location = new System.Drawing.Point(12, 279);
            this.btn_Language.Name = "btn_Language";
            this.btn_Language.Size = new System.Drawing.Size(184, 25);
            this.btn_Language.TabIndex = 9;
            this.btn_Language.Text = "Language";
            this.btn_Language.UseVisualStyleBackColor = false;
            this.btn_Language.Click += new System.EventHandler(this.btn_Language_Click);
            // 
            // orderContainer
            // 
            this.orderContainer.Location = new System.Drawing.Point(216, 13);
            this.orderContainer.Name = "orderContainer";
            this.orderContainer.Size = new System.Drawing.Size(331, 459);
            this.orderContainer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.btn_Language);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.btn_AddDonut);
            this.Controls.Add(this.btn_ClearLast);
            this.Controls.Add(this.btn_ClearAll);
            this.Controls.Add(this.btn_AddCoffee);
            this.Controls.Add(this.orderContainer);
            this.Controls.Add(this.rtb_Receipt);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtb_Receipt;
        private Container orderContainer;
        private System.Windows.Forms.Button btn_AddCoffee;
        private System.Windows.Forms.Button btn_ClearAll;
        private System.Windows.Forms.Button btn_ClearLast;
        private System.Windows.Forms.Button btn_AddDonut;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Button btn_Language;
    }
}

