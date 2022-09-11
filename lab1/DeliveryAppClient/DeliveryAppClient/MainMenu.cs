using System;
using System.Windows.Forms;
using DeliveryAppClient.Calculators;

namespace DeliveryAppClient
{
    public partial class MainMenu : Form
    {
        private User user;       
        public MainMenu(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, System.EventArgs e)
        {
            lblHello.Text += user.firstName;
            if (user.role == Role.Admin)
                btnGoAdminForm.Visible = true;
        }

        private void btnCreateOrder_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tbWhereFrom.Text) || string.IsNullOrEmpty(tbWhereTo.Text) || string.IsNullOrEmpty(mtbHeight.Text) || string.IsNullOrEmpty(mtbLength.Text) || string.IsNullOrEmpty(mtbWidth.Text) || string.IsNullOrEmpty(mtbWeight.Text))
            {
                MessageBox.Show("Существуют пустые поля!");
                return;
            }
            string whereFrom = tbWhereFrom.Text;
            string whereTo = tbWhereTo.Text;
            bool fromDoor = cbFromDoor.Checked;
            bool toDoor = cbToDoor.Checked;
            decimal height = decimal.Parse(mtbHeight.Text);
            decimal length = decimal.Parse(mtbLength.Text);
            decimal width = decimal.Parse(mtbWidth.Text);
            decimal weight = decimal.Parse(mtbWeight.Text);
            decimal volume = height * length * width;
            dynamic tc = null;
            if (height <= 0 || length <= 0 || width <= 0 || weight <= 0)
            {
                MessageBox.Show("Некорректные данные заказа!");
                return;
            }
            switch (cbTC.SelectedItem)
            {
                case null:
                    MessageBox.Show("Выберите торговую компанию!");
                    return;
                case "SDEK":
                    // Получить данные SDEK`a
                    tc = APIManager.GetInfoSDEK();
                    //MessageBox.Show(APIManager.GetInfoSDEK().ToString());
                    break;
                case "UralTransit":
                    // Получить данные UralTransit`a
                    tc = APIManager.GetInfoUralTransit();
                    //MessageBox.Show(APIManager.GetInfoUralTransit().ToString());
                    break;
            }
            object data = null;
            decimal price = 0;

            // Вместо API 2GIS - затычка
            decimal num_km = new Random().Next(4, 90);
            decimal num_kg = new Random().Next(1, 230);
            Order order;
            switch (cbCalculator.SelectedItem)
            {
                case null:
                    MessageBox.Show("Выберите калькулятор!");
                    return;
                case "Алиса":
                    MessageBox.Show("Алиса");
                    Alisa alisaCalculate = new Alisa();
                    price = alisaCalculate.Calculate(tc, num_km, num_kg);
                    // Условие, если нажато окей в MesssageBox`e то запись, иначе contenue
                    order = new Order(user.id, whereFrom, fromDoor, whereTo, toDoor, weight, volume, price, DateTime.Now);
                    if (tc.name == "SDEK")
                        APIManager.CreateOrderSDEK(order);
                    else if (tc.name == "UralTransit")
                        APIManager.CreateOrderUralTransit(order);
                    alisaCalculate.SaveLogs(price);
                    MessageBox.Show("Заказ сформирован на сумму: " + order.price);
                    break;
                case "Олег":
                    MessageBox.Show("Олег");
                    Oleg olegCalculate = new Oleg();
                    price = olegCalculate.Calculate(tc, num_km, num_kg);
                    order = new Order(user.id, whereFrom, fromDoor, whereTo, toDoor, weight, volume, price, DateTime.Now);
                    if (tc.name == "SDEK")
                        APIManager.CreateOrderSDEK(order);
                    else if (tc.name == "UralTransit")
                        APIManager.CreateOrderUralTransit(order);
                    olegCalculate.SaveLogs(price);
                    MessageBox.Show("Заказ сформирован на сумму: " + order.price);
                    break;
                case "Маруся":
                    MessageBox.Show("Маруся");
                    Marusya marusyaCalculate = new Marusya();
                    price = marusyaCalculate.Calculate(tc, num_km, num_kg);
                    order = new Order(user.id, whereFrom, fromDoor, whereTo, toDoor, weight, volume, price, DateTime.Now);
                    if (tc.name == "SDEK")
                        APIManager.CreateOrderSDEK(order);
                    else if (tc.name == "UralTransit")
                        APIManager.CreateOrderUralTransit(order);
                    marusyaCalculate.SaveLogs(price);
                    MessageBox.Show("Заказ сформирован на сумму: " + order.price);
                    break;
            }
            MessageBox.Show(price.ToString());
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoAdminForm_Click(object sender, System.EventArgs e)
        {
            AdminForm adminForm = new AdminForm(user);
            adminForm.Show(this);
            Hide();
        }
    }
}
