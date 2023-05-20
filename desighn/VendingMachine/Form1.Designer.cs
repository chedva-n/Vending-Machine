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
            this.giftWrapper = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hotDrink
            // 
            this.hotDrink.BackgroundImage = global::VendingMachine.Properties.Resources.two_cups_coffee_plate_coffee_table_with_beans;
            this.hotDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hotDrink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotDrink.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hotDrink.Location = new System.Drawing.Point(204, 460);
            this.hotDrink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hotDrink.Name = "hotDrink";
            this.hotDrink.Size = new System.Drawing.Size(152, 84);
            this.hotDrink.TabIndex = 0;
            this.hotDrink.Text = "Hot drink";
            this.hotDrink.UseVisualStyleBackColor = true;
            this.hotDrink.Click += new System.EventHandler(this.Hot_drink_Click);
            // 
            // addShoko
            // 
            this.addShoko.AutoSize = true;
            this.addShoko.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addShoko.Location = new System.Drawing.Point(360, 147);
            this.addShoko.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addShoko.Name = "addShoko";
            this.addShoko.Size = new System.Drawing.Size(154, 39);
            this.addShoko.TabIndex = 1;
            this.addShoko.Text = "add shoko";
            this.addShoko.UseVisualStyleBackColor = true;
            this.addShoko.Visible = false;
            // 
            // addWater
            // 
            this.addWater.AutoSize = true;
            this.addWater.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addWater.Location = new System.Drawing.Point(360, 240);
            this.addWater.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addWater.Name = "addWater";
            this.addWater.Size = new System.Drawing.Size(148, 39);
            this.addWater.TabIndex = 1;
            this.addWater.Text = "add water";
            this.addWater.UseVisualStyleBackColor = true;
            this.addWater.Visible = false;
            // 
            // addMilk
            // 
            this.addMilk.AutoSize = true;
            this.addMilk.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addMilk.Location = new System.Drawing.Point(361, 287);
            this.addMilk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addMilk.Name = "addMilk";
            this.addMilk.Size = new System.Drawing.Size(133, 39);
            this.addMilk.TabIndex = 1;
            this.addMilk.Text = "add milk";
            this.addMilk.UseVisualStyleBackColor = true;
            this.addMilk.Visible = false;
            // 
            // addWhippedMilk
            // 
            this.addWhippedMilk.AutoSize = true;
            this.addWhippedMilk.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addWhippedMilk.Location = new System.Drawing.Point(361, 333);
            this.addWhippedMilk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addWhippedMilk.Name = "addWhippedMilk";
            this.addWhippedMilk.Size = new System.Drawing.Size(236, 39);
            this.addWhippedMilk.TabIndex = 1;
            this.addWhippedMilk.Text = "add whipped milk";
            this.addWhippedMilk.UseVisualStyleBackColor = true;
            this.addWhippedMilk.Visible = false;
            // 
            // addSugar
            // 
            this.addSugar.AutoSize = true;
            this.addSugar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addSugar.Location = new System.Drawing.Point(360, 193);
            this.addSugar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addSugar.Name = "addSugar";
            this.addSugar.Size = new System.Drawing.Size(149, 39);
            this.addSugar.TabIndex = 1;
            this.addSugar.Text = "add sugar";
            this.addSugar.UseVisualStyleBackColor = true;
            this.addSugar.Visible = false;
            // 
            // orderDrink
            // 
            this.orderDrink.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderDrink.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.orderDrink.Location = new System.Drawing.Point(360, 392);
            this.orderDrink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderDrink.Name = "orderDrink";
            this.orderDrink.Size = new System.Drawing.Size(111, 43);
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
            this.addCoffee.Location = new System.Drawing.Point(361, 99);
            this.addCoffee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addCoffee.Name = "addCoffee";
            this.addCoffee.Size = new System.Drawing.Size(159, 39);
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
            this.iceCoffee.Location = new System.Drawing.Point(362, 460);
            this.iceCoffee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iceCoffee.Name = "iceCoffee";
            this.iceCoffee.Size = new System.Drawing.Size(144, 84);
            this.iceCoffee.TabIndex = 3;
            this.iceCoffee.Text = "ice coffee";
            this.iceCoffee.UseVisualStyleBackColor = true;
            this.iceCoffee.Click += new System.EventHandler(this.iceCoffee_Click);
            // 
            // iceCoffeeDiat
            // 
            this.iceCoffeeDiat.BackgroundImage = global::VendingMachine.Properties.Resources.chocolate_smoothie;
            this.iceCoffeeDiat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iceCoffeeDiat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iceCoffeeDiat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iceCoffeeDiat.Location = new System.Drawing.Point(512, 460);
            this.iceCoffeeDiat.Name = "iceCoffeeDiat";
            this.iceCoffeeDiat.Size = new System.Drawing.Size(140, 84);
            this.iceCoffeeDiat.TabIndex = 4;
            this.iceCoffeeDiat.Text = "Ice Coffee Diat";
            this.iceCoffeeDiat.UseVisualStyleBackColor = true;
            this.iceCoffeeDiat.Click += iceCoffee_Click;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            // 
            // carmel
            // 
            this.carmel.AutoSize = true;
            this.carmel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carmel.Location = new System.Drawing.Point(361, 131);
            this.carmel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.carmel.Name = "carmel";
            this.carmel.Size = new System.Drawing.Size(115, 39);
            this.carmel.TabIndex = 1;
            this.carmel.Text = "Carmel";
            this.carmel.UseVisualStyleBackColor = true;
            this.carmel.Visible = false;
            // 
            // whippedCream
            // 
            this.whippedCream.AutoSize = true;
            this.whippedCream.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whippedCream.Location = new System.Drawing.Point(361, 177);
            this.whippedCream.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.whippedCream.Name = "whippedCream";
            this.whippedCream.Size = new System.Drawing.Size(209, 39);
            this.whippedCream.TabIndex = 1;
            this.whippedCream.Text = "whipped cream";
            this.whippedCream.UseVisualStyleBackColor = true;
            this.whippedCream.Visible = false;
            // 
            // chocolate
            // 
            this.chocolate.AutoSize = true;
            this.chocolate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chocolate.Location = new System.Drawing.Point(361, 224);
            this.chocolate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chocolate.Name = "chocolate";
            this.chocolate.Size = new System.Drawing.Size(148, 39);
            this.chocolate.TabIndex = 1;
            this.chocolate.Text = "Chocolate";
            this.chocolate.UseVisualStyleBackColor = true;
            this.chocolate.Visible = false;
            // 
            // orderIceCoffee
            // 
            this.orderIceCoffee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderIceCoffee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderIceCoffee.Location = new System.Drawing.Point(363, 281);
            this.orderIceCoffee.Name = "orderIceCoffee";
            this.orderIceCoffee.Size = new System.Drawing.Size(98, 43);
            this.orderIceCoffee.TabIndex = 6;
            this.orderIceCoffee.Text = "Confirm";
            this.orderIceCoffee.UseVisualStyleBackColor = false;
            this.orderIceCoffee.Visible = false;
            this.orderIceCoffee.Click += new System.EventHandler(this.orderIceCoffee_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            // 
            // orderProduct
            // 
            this.orderProduct.Location = new System.Drawing.Point(711, 460);
            this.orderProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderProduct.Name = "orderProduct";
            this.orderProduct.Size = new System.Drawing.Size(141, 84);
            this.orderProduct.TabIndex = 7;
            this.orderProduct.Text = "order";
            this.orderProduct.UseVisualStyleBackColor = true;
            this.orderProduct.Visible = false;
            this.orderProduct.Click += new System.EventHandler(this.orderProduct_Click);
            // 
            // bag
            // 
            this.bag.Location = new System.Drawing.Point(568, 163);
            this.bag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bag.Name = "bag";
            this.bag.Size = new System.Drawing.Size(214, 120);
            this.bag.TabIndex = 8;
            this.bag.Text = "Bag";
            this.bag.UseVisualStyleBackColor = true;
            this.bag.Visible = false;
            this.bag.Click += new System.EventHandler(this.bag_Click);
            // 
            // giftWrapper
            // 
            this.giftWrapper.Location = new System.Drawing.Point(169, 165);
            this.giftWrapper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.giftWrapper.Name = "giftWrapper";
            this.giftWrapper.Size = new System.Drawing.Size(211, 117);
            this.giftWrapper.TabIndex = 9;
            this.giftWrapper.Text = "Gift Wrapper";
            this.giftWrapper.UseVisualStyleBackColor = true;
            this.giftWrapper.Visible = false;
            this.giftWrapper.Click += new System.EventHandler(this.giftWrapper_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(680, 460);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(156, 65);
            this.back.TabIndex = 12;
            this.back.Text = "back to mechine";
            this.back.UseVisualStyleBackColor = true;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.back);
            this.Controls.Add(this.giftWrapper);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "                                              ";
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
        private Button giftWrapper;
        private Button back;
    }
}