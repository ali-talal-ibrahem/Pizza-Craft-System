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
            this.btn_Toppings = new System.Windows.Forms.Button();
            this.btn_ReadyMade = new System.Windows.Forms.Button();
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
            // btn_Toppings
            // 
            this.btn_Toppings.BackColor = System.Drawing.Color.Transparent;
            this.btn_Toppings.BackgroundImage = global::PizzaCraft.Properties.Resources.Customize_Toppings_Selecte1;
            this.btn_Toppings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Toppings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Toppings.FlatAppearance.BorderSize = 0;
            this.btn_Toppings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Toppings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Toppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Toppings.Font = new System.Drawing.Font("Anton", 20F);
            this.btn_Toppings.ForeColor = System.Drawing.Color.White;
            this.btn_Toppings.Location = new System.Drawing.Point(465, 180);
            this.btn_Toppings.Name = "btn_Toppings";
            this.btn_Toppings.Size = new System.Drawing.Size(222, 340);
            this.btn_Toppings.TabIndex = 3;
            this.btn_Toppings.Text = "  Toppings\r\n   Type";
            this.btn_Toppings.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Toppings.UseVisualStyleBackColor = false;
            this.btn_Toppings.Click += new System.EventHandler(this.btn_Choose_Click);
            this.btn_Toppings.MouseEnter += new System.EventHandler(this.btn_Choose_MouseEnter);
            this.btn_Toppings.MouseLeave += new System.EventHandler(this.btn_Choose_MouseLeave);
            // 
            // btn_ReadyMade
            // 
            this.btn_ReadyMade.BackColor = System.Drawing.Color.Transparent;
            this.btn_ReadyMade.BackgroundImage = global::PizzaCraft.Properties.Resources.Pizza_Menu_Selecte;
            this.btn_ReadyMade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ReadyMade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ReadyMade.FlatAppearance.BorderSize = 0;
            this.btn_ReadyMade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ReadyMade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ReadyMade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReadyMade.Font = new System.Drawing.Font("Anton", 20F);
            this.btn_ReadyMade.ForeColor = System.Drawing.Color.White;
            this.btn_ReadyMade.Location = new System.Drawing.Point(119, 180);
            this.btn_ReadyMade.Name = "btn_ReadyMade";
            this.btn_ReadyMade.Size = new System.Drawing.Size(222, 340);
            this.btn_ReadyMade.TabIndex = 2;
            this.btn_ReadyMade.Text = "Ready-made   \r\nType  ";
            this.btn_ReadyMade.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_ReadyMade.UseVisualStyleBackColor = false;
            this.btn_ReadyMade.Click += new System.EventHandler(this.btn_Choose_Click);
            this.btn_ReadyMade.MouseEnter += new System.EventHandler(this.btn_Choose_MouseEnter);
            this.btn_ReadyMade.MouseLeave += new System.EventHandler(this.btn_Choose_MouseLeave);
            // 
            // Pizza_SelectOrderType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaCraft.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 511);
            this.Controls.Add(this.btn_Toppings);
            this.Controls.Add(this.btn_ReadyMade);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pizza_SelectOrderType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pizza Craft - Select Order Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Toppings;
        private System.Windows.Forms.Button btn_ReadyMade;
    }
}