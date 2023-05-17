namespace VendingMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hotDrink = new System.Windows.Forms.Button();
            this.addShoko = new System.Windows.Forms.CheckBox();
            this.addWater = new System.Windows.Forms.CheckBox();
            this.addMilk = new System.Windows.Forms.CheckBox();
            this.addWhippedMilk = new System.Windows.Forms.CheckBox();
            this.addSugar = new System.Windows.Forms.CheckBox();
            this.orderDrink = new System.Windows.Forms.Button();
            this.addCoffee = new System.Windows.Forms.CheckBox();
            this.iceCoffee = new System.Windows.Forms.Button();
            this.iceCoffeeDiat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.carmel = new System.Windows.Forms.CheckBox();
            this.whippedCream = new System.Windows.Forms.CheckBox();
            this.chocolate = new System.Windows.Forms.CheckBox();
            this.orderIceCoffee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.orderProduct = new System.Windows.Forms.Button();
            this.bag = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hotDrink
            // 
            this.hotDrink.Location = new System.Drawing.Point(148, 343);
            this.hotDrink.Name = "hotDrink";
            this.hotDrink.Size = new System.Drawing.Size(133, 63);
            this.hotDrink.TabIndex = 0;
            this.hotDrink.Text = "Hot drink";
            this.hotDrink.UseVisualStyleBackColor = true;
            this.hotDrink.Click += new System.EventHandler(this.button1_Click);
            // 
            // addShoko
            // 
            this.addShoko.AutoSize = true;
            this.addShoko.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addShoko.Location = new System.Drawing.Point(315, 110);
            this.addShoko.Name = "addShoko";
            this.addShoko.Size = new System.Drawing.Size(123, 32);
            this.addShoko.TabIndex = 1;
            this.addShoko.Text = "add shoko";
            this.addShoko.UseVisualStyleBackColor = true;
            this.addShoko.Visible = false;
            // 
            // addWater
            // 
            this.addWater.AutoSize = true;
            this.addWater.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addWater.Location = new System.Drawing.Point(315, 180);
            this.addWater.Name = "addWater";
            this.addWater.Size = new System.Drawing.Size(118, 32);
            this.addWater.TabIndex = 1;
            this.addWater.Text = "add water";
            this.addWater.UseVisualStyleBackColor = true;
            this.addWater.Visible = false;
            // 
            // addMilk
            // 
            this.addMilk.AutoSize = true;
            this.addMilk.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addMilk.Location = new System.Drawing.Point(316, 215);
            this.addMilk.Name = "addMilk";
            this.addMilk.Size = new System.Drawing.Size(107, 32);
            this.addMilk.TabIndex = 1;
            this.addMilk.Text = "add milk";
            this.addMilk.UseVisualStyleBackColor = true;
            this.addMilk.Visible = false;
            // 
            // addWhippedMilk
            // 
            this.addWhippedMilk.AutoSize = true;
            this.addWhippedMilk.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addWhippedMilk.Location = new System.Drawing.Point(316, 250);
            this.addWhippedMilk.Name = "addWhippedMilk";
            this.addWhippedMilk.Size = new System.Drawing.Size(188, 32);
            this.addWhippedMilk.TabIndex = 1;
            this.addWhippedMilk.Text = "add whipped milk";
            this.addWhippedMilk.UseVisualStyleBackColor = true;
            this.addWhippedMilk.Visible = false;
            // 
            // addSugar
            // 
            this.addSugar.AutoSize = true;
            this.addSugar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addSugar.Location = new System.Drawing.Point(315, 145);
            this.addSugar.Name = "addSugar";
            this.addSugar.Size = new System.Drawing.Size(118, 32);
            this.addSugar.TabIndex = 1;
            this.addSugar.Text = "add sugar";
            this.addSugar.UseVisualStyleBackColor = true;
            this.addSugar.Visible = false;
            // 
            // orderDrink
            // 
            this.orderDrink.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderDrink.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.orderDrink.Location = new System.Drawing.Point(315, 294);
            this.orderDrink.Name = "orderDrink";
            this.orderDrink.Size = new System.Drawing.Size(97, 32);
            this.orderDrink.TabIndex = 2;
            this.orderDrink.Text = "Confirm";
            this.orderDrink.UseVisualStyleBackColor = false;
            this.orderDrink.Visible = false;
            this.orderDrink.Click += new System.EventHandler(this.orderDrink_Click);
            // 
            // addCoffee
            // 
            this.addCoffee.AutoSize = true;
            this.addCoffee.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCoffee.Location = new System.Drawing.Point(316, 74);
            this.addCoffee.Name = "addCoffee";
            this.addCoffee.Size = new System.Drawing.Size(126, 32);
            this.addCoffee.TabIndex = 1;
            this.addCoffee.Text = "add Coffee";
            this.addCoffee.UseVisualStyleBackColor = true;
            this.addCoffee.Visible = false;
            // 
            // iceCoffee
            // 
            this.iceCoffee.BackgroundImage = global::VendingMachine.Properties.Resources.glass_foamy_cold_coffee_with_whipped_cream_chocolate_wooden_plate;
            this.iceCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iceCoffee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iceCoffee.ForeColor = System.Drawing.Color.Linen;
            this.iceCoffee.Location = new System.Drawing.Point(286, 343);
            this.iceCoffee.Name = "iceCoffee";
            this.iceCoffee.Size = new System.Drawing.Size(126, 63);
            this.iceCoffee.TabIndex = 3;
            this.iceCoffee.Text = "ice coffee";
            this.iceCoffee.UseVisualStyleBackColor = true;
            this.iceCoffee.Click += new System.EventHandler(this.iceCoffee_Click);
            // 
            // iceCoffeeDiat
            // 
            this.iceCoffeeDiat.Location = new System.Drawing.Point(417, 343);
            this.iceCoffeeDiat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iceCoffeeDiat.Name = "iceCoffeeDiat";
            this.iceCoffeeDiat.Size = new System.Drawing.Size(132, 63);
            this.iceCoffeeDiat.TabIndex = 4;
            this.iceCoffeeDiat.Text = "Ice Coffee Diat";
            this.iceCoffeeDiat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(316, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "build your drink";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // carmel
            // 
            this.carmel.AutoSize = true;
            this.carmel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carmel.Location = new System.Drawing.Point(316, 98);
            this.carmel.Name = "carmel";
            this.carmel.Size = new System.Drawing.Size(92, 32);
            this.carmel.TabIndex = 1;
            this.carmel.Text = "Carmel";
            this.carmel.UseVisualStyleBackColor = true;
            this.carmel.Visible = false;
            // 
            // whippedCream
            // 
            this.whippedCream.AutoSize = true;
            this.whippedCream.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whippedCream.Location = new System.Drawing.Point(316, 133);
            this.whippedCream.Name = "whippedCream";
            this.whippedCream.Size = new System.Drawing.Size(165, 32);
            this.whippedCream.TabIndex = 1;
            this.whippedCream.Text = "whipped cream";
            this.whippedCream.UseVisualStyleBackColor = true;
            this.whippedCream.Visible = false;
            // 
            // chocolate
            // 
            this.chocolate.AutoSize = true;
            this.chocolate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chocolate.Location = new System.Drawing.Point(316, 168);
            this.chocolate.Name = "chocolate";
            this.chocolate.Size = new System.Drawing.Size(119, 32);
            this.chocolate.TabIndex = 1;
            this.chocolate.Text = "Chocolate";
            this.chocolate.UseVisualStyleBackColor = true;
            this.chocolate.Visible = false;
            // 
            // orderIceCoffee
            // 
            this.orderIceCoffee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderIceCoffee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderIceCoffee.Location = new System.Drawing.Point(318, 211);
            this.orderIceCoffee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderIceCoffee.Name = "orderIceCoffee";
            this.orderIceCoffee.Size = new System.Drawing.Size(86, 32);
            this.orderIceCoffee.TabIndex = 6;
            this.orderIceCoffee.Text = "Confirm";
            this.orderIceCoffee.UseVisualStyleBackColor = false;
            this.orderIceCoffee.Visible = false;
            this.orderIceCoffee.Click += new System.EventHandler(this.orderIceCoffee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(316, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toppings";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // orderProduct
            // 
            this.orderProduct.Location = new System.Drawing.Point(611, 343);
            this.orderProduct.Name = "orderProduct";
            this.orderProduct.Size = new System.Drawing.Size(123, 63);
            this.orderProduct.TabIndex = 7;
            this.orderProduct.Text = "order";
            this.orderProduct.UseVisualStyleBackColor = true;
            this.orderProduct.Visible = false;
            this.orderProduct.Click += new System.EventHandler(this.orderProduct_Click);
            // 
            // bag
            // 
            this.bag.Location = new System.Drawing.Point(497, 122);
            this.bag.Name = "bag";
            this.bag.Size = new System.Drawing.Size(187, 90);
            this.bag.TabIndex = 8;
            this.bag.Text = "Bag";
            this.bag.UseVisualStyleBackColor = true;
            this.bag.Visible = false;
            this.bag.Click += new System.EventHandler(this.bag_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 88);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bag);
            this.Controls.Add(this.orderProduct);
            this.Controls.Add(this.orderIceCoffee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iceCoffeeDiat);
            this.Controls.Add(this.iceCoffee);
            this.Controls.Add(this.orderDrink);
            this.Controls.Add(this.addWhippedMilk);
            this.Controls.Add(this.addMilk);
            this.Controls.Add(this.addSugar);
            this.Controls.Add(this.addWater);
            this.Controls.Add(this.chocolate);
            this.Controls.Add(this.whippedCream);
            this.Controls.Add(this.carmel);
            this.Controls.Add(this.addCoffee);
            this.Controls.Add(this.addShoko);
            this.Controls.Add(this.hotDrink);
            this.Name = "Form1";
            this.Text = "                                              ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button hotDrink;
        private CheckBox addShoko;
        private CheckBox addWater;
        private CheckBox addMilk;
        private CheckBox addWhippedMilk;
        private CheckBox addSugar;
        private Button orderDrink;
        private CheckBox addCoffee;
        private Button iceCoffee;
        private Button iceCoffeeDiat;
        private Label label1;
        private CheckBox carmel;
        private CheckBox whippedCream;
        private CheckBox chocolate;
        private Button orderIceCoffee;
        private Label label2;
        private Button orderProduct;
        private Button bag;
        private Button button1;
    }
}