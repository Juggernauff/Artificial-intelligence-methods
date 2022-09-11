using ClosedXML.Excel;
using System.Data.SqlClient;
using TransportCompany1;
using TransportCompany2;

namespace DeliveryAppServer
{
    public static class DataBaseManager
    {

        private static SqlConnection sqlConnection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code\RITG\Practice_RITG\DeliveryAppServer\DeliveryAppServer\Database\database_app.mdf;Integrated Security=True");

        public static int CreateUser(User user)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO [Users] (lastName, firstName, patronymic, phoneNumber, address, login, password, isAdmin) " +
                    $"VALUES (@lastName, @firstName, @patronymic, @phoneNumber, @address, @login, @password, @role); " +
                    $"SELECT SCOPE_IDENTITY() AS newId",
                    sqlConnection);

                command.Parameters.AddWithValue("lastName", user.lastName);
                command.Parameters.AddWithValue("firstName", user.firstName);
                command.Parameters.AddWithValue("patronymic", user.patronymic);
                command.Parameters.AddWithValue("phoneNumber", user.phoneNumber);
                command.Parameters.AddWithValue("address", user.address);
                command.Parameters.AddWithValue("login", user.login);
                command.Parameters.AddWithValue("password", user.password);
                command.Parameters.AddWithValue("role", user.role);

                int id = Convert.ToInt32(command.ExecuteScalar());
                sqlConnection.Close();
                return id;
            }
            catch
            {
                sqlConnection.Close();
                return -1;
            }
        }
        public static User AuthUser(User user)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            try
            {
                SqlCommand command = new SqlCommand(
                    $"SELECT * FROM [Users] WHERE login = @login AND password = @password",
                    sqlConnection);
                command.Parameters.AddWithValue("login", user.login);
                command.Parameters.AddWithValue("password", user.password);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    user.id = Convert.ToInt32(reader.GetValue(0));
                    user.lastName = Convert.ToString(reader.GetValue(1));
                    user.firstName = Convert.ToString(reader.GetValue(2));
                    user.patronymic = Convert.ToString(reader.GetValue(3));
                    user.phoneNumber = Convert.ToString(reader.GetValue(4));
                    user.address = Convert.ToString(reader.GetValue(5));
                    user.role = (Role)Convert.ToInt16(reader.GetValue(8));
                }
                    sqlConnection.Close();
                    return user;
            }
            catch
            {
                sqlConnection.Close();
                return user;
            }
        }
        
        public static SDEK GetInfoSDEK(SDEK sdek)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            try
            {
                SqlCommand command = new SqlCommand(
                    $"SELECT * FROM [TransportCompanies] WHERE name = @name",
                    sqlConnection);
                command.Parameters.AddWithValue("name", sdek.name);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    sdek.id = Convert.ToInt32(reader.GetValue(0));
                    sdek.price_km = Convert.ToDecimal(reader.GetValue(2));
                    sdek.price_kg = Convert.ToDecimal(reader.GetValue(3));
                    sdek.price_insurance = Convert.ToDecimal(reader.GetValue(4));
                }
                sqlConnection.Close();
                return sdek;
            }
            catch
            {
                sqlConnection.Close();
                return sdek;
            }
        }
        public static UralTransit GetInfoUralTransit(UralTransit uralTransit)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            try
            {
                SqlCommand command = new SqlCommand(
                    $"SELECT * FROM [TransportCompanies] WHERE name = @name",
                    sqlConnection);
                command.Parameters.AddWithValue("name", uralTransit.name);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    uralTransit.id = Convert.ToInt32(reader.GetValue(0));
                    uralTransit.price_km = Convert.ToDecimal(reader.GetValue(2));
                    uralTransit.price_kg = Convert.ToDecimal(reader.GetValue(3));
                }
                sqlConnection.Close();
                return uralTransit;
            }
            catch
            {
                sqlConnection.Close();
                return uralTransit;
            }
        }
        public static bool CreateOrderSDEK(Order order)
        {
            var sqlConnectionSDEK = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code\RITG\Practice_RITG\DeliveryAppServer\DeliveryAppServer\Database\database_tc1.mdf;Integrated Security=True");
            if (sqlConnectionSDEK.State == System.Data.ConnectionState.Closed)
                sqlConnectionSDEK.Open();

            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO [Orders] (userId, whereFrom, fromDoor, whereTo, toDoor, weight, volume, price, dateTime) " +
                    $"VALUES (@userId, @whereFrom, @fromDoor, @whereTo, @toDoor, @weight, @volume, @price, @dateTime); ",
                    sqlConnectionSDEK);

                command.Parameters.AddWithValue("userId", order.userId);
                command.Parameters.AddWithValue("whereFrom", order.whereFrom);
                command.Parameters.AddWithValue("fromDoor", order.fromDoor);
                command.Parameters.AddWithValue("whereTo", order.whereTo);
                command.Parameters.AddWithValue("toDoor", order.toDoor);
                command.Parameters.AddWithValue("weight", order.weight);
                command.Parameters.AddWithValue("volume", order.volume);
                command.Parameters.AddWithValue("price", order.price);
                command.Parameters.AddWithValue("dateTime", order.DateTime);

                bool result = Convert.ToBoolean(command.ExecuteNonQuery());
                sqlConnection.Close();
                return result;
            }
            catch
            {
                sqlConnection.Close();
                return false;
            }
        }
        public static bool CreateOrderUralTransit(Order order)
        {
            try                                
            {
                string fileName = @"D:\Code\RITG\Practice_RITG\DeliveryAppServer\DeliveryAppServer\Database\database_tc2.xlsx";
                var wb = new XLWorkbook(fileName);
                var sh = wb.Worksheet(1);

                sh.Cell(1, 1).SetValue("id");
                sh.Cell(1, 2).SetValue("userId");
                sh.Cell(1, 3).SetValue("whereFrom");
                sh.Cell(1, 4).SetValue("fromDoor");
                sh.Cell(1, 5).SetValue("whereTo");
                sh.Cell(1, 6).SetValue("toDoor");
                sh.Cell(1, 7).SetValue("weight");
                sh.Cell(1, 8).SetValue("volume");
                sh.Cell(1, 9).SetValue("price");
                sh.Cell(1, 10).SetValue("DateTime");
                int index = sh.LastRowUsed().RowNumber() + 1;
                sh.Cell(index, 1).SetValue(index);
                sh.Cell(index, 2).SetValue(order.userId);
                sh.Cell(index, 3).SetValue(order.whereFrom);
                sh.Cell(index, 4).SetValue(order.fromDoor);
                sh.Cell(index, 5).SetValue(order.whereTo);
                sh.Cell(index, 6).SetValue(order.toDoor);
                sh.Cell(index, 7).SetValue(order.weight);
                sh.Cell(index, 8).SetValue(order.volume);
                sh.Cell(index, 9).SetValue(order.price);
                sh.Cell(index, 10).SetValue(order.DateTime);
                wb.SaveAs(fileName);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static IEnumerable<Order> GetOrdersSDEK(bool isAdmin)
        {
            if (isAdmin == false)
                return null;
            List<Order> orders = new List<Order>();
            var sqlConnectionSDEK = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code\RITG\Practice_RITG\DeliveryAppServer\DeliveryAppServer\Database\database_tc1.mdf;Integrated Security=True");
            if (sqlConnectionSDEK.State == System.Data.ConnectionState.Closed)
                sqlConnectionSDEK.Open();
            try
            {
                SqlCommand command = new SqlCommand(
                    $"SELECT * FROM [Orders]",
                    sqlConnectionSDEK);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Order order = new Order(
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetBoolean(3),
                        reader.GetString(4),
                        reader.GetBoolean(5),
                        reader.GetDecimal(6),
                        reader.GetDecimal(7),
                        reader.GetDecimal(8),
                        reader.GetDateTime(9));
                    order.id = reader.GetInt32(0);
                    orders.Add(order);
                }
                sqlConnection.Close();
                return orders;
            }
            catch
            {
                sqlConnection.Close();
                return orders;
            }
        }
        public static IEnumerable<Order> GetOrdersUralTransit(bool isAdmin)
        {
            if (isAdmin == false)
                return null;
            List<Order> orders = new List<Order>();
            string fileName = @"D:\Code\RITG\Practice_RITG\DeliveryAppServer\DeliveryAppServer\Database\database_tc2.xlsx";
            try
            {
                var wb = new XLWorkbook(fileName);
                var sh = wb.Worksheet(1);
                var rows = sh.RangeUsed().RowsUsed();
                foreach (var row in rows)
                {
                    if (row.RowNumber() == 1)
                        continue;

                    Order order = new Order(
                        Convert.ToInt32(row.Cell(2).Value),
                        Convert.ToString(row.Cell(3).Value),
                        Convert.ToBoolean(row.Cell(4).Value),
                        Convert.ToString(row.Cell(5).Value),
                        Convert.ToBoolean(row.Cell(6).Value),
                        Convert.ToDecimal(row.Cell(7).Value),
                        Convert.ToDecimal(row.Cell(8).Value),
                        Convert.ToDecimal(row.Cell(9).Value),
                        Convert.ToDateTime(row.Cell(10).Value));
                    order.id = Convert.ToInt32(row.Cell(1).Value);
                    orders.Add(order);
                }
                return orders;
            }
            catch
            {
                return orders;
            }
        }
    }
}
