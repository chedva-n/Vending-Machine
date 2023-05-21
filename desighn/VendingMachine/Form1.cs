using VendingMachine.BuilderHotDrink;
using VendingMachine.ColdDrinkDecorator;
using VendingMachine.FactoryReport;
using VendingMachine.State;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        VendingMachine vendingMachine = new VendingMachine();
        private HotDrinkBuilder builder;
        CheckBox[] builderCheckboxes;
        CheckBox[] decoratorCheckboxes;
        private Product selectedProduct;
        Context context;

        public Form1()
        {
            InitializeComponent();
            context = vendingMachine.context;
            context = new Context(new Selection(this));
            builder = new HotDrinkBuilder();
            builderCheckboxes = new CheckBox[] { addCoffee, addMilk, addShoko, addSugar, addWater, addWhippedMilk };
            decoratorCheckboxes = new CheckBox[] { carmel, whippedCream, chocolate };
        }
        public void Selection()
        {
            clearBord();
            iceCoffee.Visible = true;
            iceCoffeeDiat.Visible = true;
            hotDrink.Visible = true;
            int buttonTop = 10;
            int buttonLeft = 10;
            int buttonMargin = 10;
            int buttonWidth = 150;
            int buttonHeight = 60;
            int columnCount = 4;
            int columnIndex = 0;
            int row = 0;

            foreach (var product in VendingMachine.snacksAndBottles)
            {
                Button button = new Button();
                button.Text = $"{product.Key.Name}\n{product.Key.Price}";
                button.Tag = product.Key;
                button.Click += ProductButton_Click;
                button.Left = buttonLeft + (buttonWidth + buttonMargin) * columnIndex;
                button.Top = buttonTop + (buttonHeight + buttonMargin) * row;
                button.Width = buttonWidth;
                button.Height = buttonHeight;
                Controls.Add(button);
                columnIndex++;
                if (columnIndex >= columnCount)
                {
                    columnIndex = 0;
                    row++;
                }
            }
        }


        private void ProductButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SnacksAndBottles product = (SnacksAndBottles)button.Tag;
            selectedProduct = product;
            vendingMachine.RemoveProduct(product);
            product.WriteToFile(product);
            context.Request();
        }
        private void iceCoffee_Click(object sender, EventArgs e)
        {
            clearBord();
            foreach (var item in decoratorCheckboxes) { 
                item.Visible = true; 
                item.Checked = false;
            }
            orderIceCoffee.Visible = true;
            label2.Visible = true;
            Button clickedButton = (Button)sender;
            orderIceCoffee.Tag = clickedButton.Name;
        }
        private void orderIceCoffee_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonName = (string)orderIceCoffee.Tag; 
            Drink drink = new Drink();
            IceCoffee basicIceCoffee=new IceCoffee();
            if (buttonName == "iceCoffee")
            {
                drink = VendingMachine.drinks.Keys.FirstOrDefault(d => d.Name == "Ice Coffee");
                basicIceCoffee = (IceCoffee)drink;
            }
            else
            {
                drink = VendingMachine.drinks.Keys.FirstOrDefault(d => d.Name == "Diat Ice Coffee");
                basicIceCoffee = (DiatIceCoffee)drink;
            }
            

            List<CheckBox> listcheckd = new List<CheckBox>();

            foreach (CheckBox checkBox in decoratorCheckboxes)
            {
                if (checkBox.Checked)
                {
                    listcheckd.Add(checkBox);
                }
            }
            foreach (CheckBox checkBox in listcheckd)
            {
                switch (checkBox.Name)
                {
                    case "carmel":
                        basicIceCoffee = new CaramelDecorator(basicIceCoffee);
                        break;
                    case "whippedCream":
                        basicIceCoffee = new WhippedCreamDecorator(basicIceCoffee);
                        break;
                    case "chocolate":
                        basicIceCoffee = new BrownChocolateDecorator(basicIceCoffee);
                        break;
                }

            }
            IceCoffee result = new IceCoffee();
            result.Price = basicIceCoffee.GetCost();
            result.Name = basicIceCoffee.Name;
            selectedProduct = result;
            List<string> chosenToppings = new List<string>();

            foreach (CheckBox checkBox in listcheckd)
            {
                chosenToppings.Add(checkBox.Text);
            }

            string toppingsText = string.Join(Environment.NewLine, chosenToppings);

            MessageBox.Show(toppingsText, $"Ice coffee\n price: {basicIceCoffee.GetCost()}");
            vendingMachine.RemoveDrink(drink);
            result.WriteToFile(result);
            context.Request();
        }


        private void Hot_drink_Click(object sender, EventArgs e)
        {
            clearBord();
            showIngredientsHotdrink();
        }
        private void showIngredientsHotdrink()
        {
            foreach (var item in builderCheckboxes)
            {
                item.Visible = true;
                item.Checked = false;
            }
            orderDrink.Visible = true;
            label1.Visible = true;
        }
        private void orderDrink_Click(object sender, EventArgs e)
        {
            Drink drink= VendingMachine.drinks.Keys.FirstOrDefault(d => d.Name == "Hot drink");
            HotDrink hotDrink=(HotDrink)drink;
            foreach (CheckBox item in builderCheckboxes)
            {
                if (item.Checked)
                {
                    switch (item.Name)
                    {
                        case "addCoffee":
                            builder.AddCoffee();
                            break;
                        case "addShoko":
                            builder.AddShoko();
                            break;
                        case "addWater":
                            builder.AddWater();
                            break;
                        case "addSugar":
                            builder.AddSugar();
                            break;
                        case "addMilk":
                            builder.AddMilk();
                            break;
                        case "addWhippedMilk":
                            builder.AddWhippedmilk();
                            break;
                    }
                }
            }
            hotDrink = builder.getDrink();
            vendingMachine.RemoveDrink(drink);
            hotDrink.WriteToFile(hotDrink);
            string listString = string.Join(Environment.NewLine, hotDrink.Ingredients);
            MessageBox.Show(listString, "Your Drink contains:");
            selectedProduct = hotDrink;
            context.Request();
        }

        private void clearBord()
        {
            foreach (Control item in Controls)
            {
                item.Visible = false;
            }
        }
        public void Wrapper()
        {
            clearBord();
            bag.Visible = true;
            giftWrapper.Visible = true;
            orderProduct.Visible = true;
        }
        public void Payment()
        {
            clearBord();
            back.Visible = true;
            Label label = new Label();
            label.Text = $"sum for payment:\n{selectedProduct.Price} ¤";
            label.Width = 500;
            label.Anchor = AnchorStyles.None;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font(label.Font.FontFamily, 20, label.Font.Style);
            Controls.Add(label);
        }
        
        private void orderProduct_Click(object sender, EventArgs e)
        {
            context.Request();
        }

        private void bag_Click(object sender, EventArgs e)
        {
            selectedProduct.Price += 1;
        }

        
        private void back_Click(object sender, EventArgs e)
        {
            context.Request();
        }

        private void giftWrapper_Click(object sender, EventArgs e)
        {
            selectedProduct.Price += 5;
        }


    }

}