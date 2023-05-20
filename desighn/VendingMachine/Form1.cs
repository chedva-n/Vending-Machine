using VendingMachine.BuilderHotDrink;
using VendingMachine.ColdDrinkDecorator;
using VendingMachine.FactoryReport;
using VendingMachine.State;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        VendingMachine VendingMachine=new VendingMachine();
        private HotDrinkBuilder builder;
        CheckBox[] builderCheckboxes;
        CheckBox[] decoratorCheckboxes;
        Context context;
        private Product selectedProduct;


        public Form1()
        {
            InitializeComponent();
            context = new Context(new Selection(this));
            builder = new HotDrinkBuilder();
            builderCheckboxes = new CheckBox[] { addCoffee, addMilk,addShoko,addSugar,addWater,addWhippedMilk};
            decoratorCheckboxes = new CheckBox[] { carmel, whippedCream, chocolate };
        }
        public  void Selection()
        {
            clearBord();
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
            selectedProduct=product;
            //MessageBox.Show($"Selected product: {product.Name}\n Price: {product.Price}");
           VendingMachine.RemoveProduct(product);
            product.WriteToFile(product);
            context.Request();
            
        }
        private void iceCoffee_Click(object sender, EventArgs e)
        {
            clearBord();
            foreach (var item in decoratorCheckboxes) item.Visible = true;
            orderIceCoffee.Visible = true;
            label2.Visible = true;

        }



        private void Hot_drink_Click(object sender, EventArgs e)
        {
            clearBord();
            showIngredientsHotdrink();

        }
        private void showIngredientsHotdrink()
        {
            foreach (var item in builderCheckboxes)item.Visible = true;
            orderDrink.Visible=true;
            label1.Visible=true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void orderDrink_Click(object sender, EventArgs e)
        {
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
            HotDrink result= builder.getDrink();

            result.WriteToFile(result);
            string listString = string.Join(Environment.NewLine, result.Ingredients);

            MessageBox.Show(listString, "Your Drink contains:");
            orderProduct_Click(sender, e);

            //MessageBox.Show($"Selected product: {builder.getDrink().Name}\nPrice: {builder.getDrink().Price}");
        }
        private void clearBord()
        {
            foreach(Control item in Controls)
            {
                item.Visible = false;
            }
        }



        private void orderIceCoffee_Click(object sender, EventArgs e)
        {
            
            IceCoffee basicIceCoffee = new IceCoffee();
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
            List<string> chosenToppings = new List<string>();

            foreach (CheckBox checkBox in listcheckd)
            {
                chosenToppings.Add(checkBox.Text);
            }

            string toppingsText = string.Join(Environment.NewLine, chosenToppings);

            MessageBox.Show(toppingsText, $"Ice coffee\n price: {basicIceCoffee.GetCost()}");
            orderProduct_Click( sender,  e);
            //goToPay.Visible = true;
        }
        public void Payment()
        {
            clearBord();
            back.Visible = true;
            Label label = new Label();
            Controls.Add(label);

label.Text=  $"{selectedProduct.Price}";
            label.Width = 500;
           // MessageBox.Show("sum for paiment:", $"{selectedProduct.Price} ", MessageBoxButtons.OK);
            //context.Request();
        }
        public void Wrapper()
        {
            clearBord();
            bag.Visible = true;
            giftWrapper.Visible = true;
            orderProduct.Visible = true;
        }
        private void orderProduct_Click(object sender, EventArgs e)
        {
          
            context.Request();
        }

        private void bag_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            context.Request();
        }
    }
   
}