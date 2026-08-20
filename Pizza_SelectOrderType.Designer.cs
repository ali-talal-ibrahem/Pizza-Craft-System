namespace PizzaCraft
{
    partial class Pizza_SelectOrderType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pizza_SelectOrderType));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ChooseToppings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Anton", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(108, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 101);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Type Of Order";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::PizzaCraft.Properties.Resources.Customize_Toppings_Selecte1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Anton", 20F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(465, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 340);
            this.button2.TabIndex = 3;
            this.button2.Text = "  Toppings\r\n   Type";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_ChooseToppings
            // 
            this.btn_ChooseToppings.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChooseToppings.BackgroundImage = global::PizzaCraft.Properties.Resources.Pizza_Menu_Selecte;
            this.btn_ChooseToppings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChooseToppings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChooseToppings.FlatAppearance.BorderSize = 0;
            this.btn_ChooseToppings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ChooseToppings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ChooseToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChooseToppings.Font = new System.Drawing.Font("Anton", 20F);
            this.btn_ChooseToppings.ForeColor = System.Drawing.Color.White;
            this.btn_ChooseToppings.Location = new System.Drawing.Point(119, 180);
            this.btn_ChooseToppings.Name = "btn_ChooseToppings";
            this.btn_ChooseToppings.Size = new System.Drawing.Size(222, 340);
            this.btn_ChooseToppings.TabIndex = 2;
            this.btn_ChooseToppings.Text = "Ready-made   \r\nType  ";
            this.btn_ChooseToppings.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_ChooseToppings.UseVisualStyleBackColor = false;
            // 
            // Pizza_SelectOrderType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaCraft.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 511);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ChooseToppings);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pizza_SelectOrderType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Craft - Select Order Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ChooseToppings;
    }
}