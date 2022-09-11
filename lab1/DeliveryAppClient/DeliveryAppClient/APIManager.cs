using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace DeliveryAppClient
{
    public static class APIManager
    {
        public static User Authorization(User user)
        {
            if (user.login == "" || user.password == "")
                return null;

            string url = "https://localhost:7110/Authentication?login=" + user.login + "&password=" + user.password;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "POST";
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
                dynamic newUser = JsonConvert.DeserializeObject(response);
                user =  new User(newUser.lastName.ToString(), newUser.firstName.ToString(), newUser.patronymic.ToString(), newUser.phoneNumber.ToString(), newUser.address.ToString(), newUser.login.ToString(), newUser.password.ToString(), (Role)newUser.role);
                user.id = newUser.id;
                return user;
            }
        }
        public static User Registration(User user)
        {
            if (user.login == "" || user.password == "")
                return null;

            string url = $"https://localhost:7110/Registration?lastName={user.lastName}&firstName={user.firstName}&patronymic={user.patronymic}&phoneNumber={user.phoneNumber}&address={user.address}&login={user.login}&password={user.password}&role={(int)user.role}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "POST";
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
                dynamic id = JsonConvert.DeserializeObject(response);
                user.id = int.Parse(id.ToString());
                return user;
            }
        }
        public static bool CreateOrderSDEK(Order order)
        {
            string url = $"https://localhost:7110/CreateOrderSDEK?userId={order.userId}&whereFrom={order.whereFrom}&fromDoor={order.fromDoor}&whereTo={order.whereTo}&toDoor={order.toDoor}&weight={order.weight}&volume={order.volume}&price={order.price}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
                bool access = bool.Parse(JsonConvert.DeserializeObject(response).ToString());
                return access;
            }
        }
        public static bool CreateOrderUralTransit(Order order)
        {
            string url = $"https://localhost:7110/CreateOrderUralTransit?userId={order.userId}&whereFrom={order.whereFrom}&fromDoor={order.fromDoor}&whereTo={order.whereTo}&toDoor={order.toDoor}&weight={order.weight}&volume={order.volume}&price={order.price}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
                bool access = bool.Parse(JsonConvert.DeserializeObject(response).ToString());
                return access;
            }
        }
        public static object GetInfoSDEK()
        {
            string url = "https://localhost:7110/GetInfoSDEK";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
                dynamic infoSDEK = JsonConvert.DeserializeObject(response);
                return new { infoSDEK.id, infoSDEK.name, infoSDEK.price_km, infoSDEK.price_kg, infoSDEK.price_insurance };
            }
        }
        public static object GetInfoUralTransit()
        {
            string url = "https://localhost:7110/GetInfoUralTransit";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
                dynamic infoUralTransit = JsonConvert.DeserializeObject(response);
                return new { infoUralTransit.id, infoUralTransit.name, infoUralTransit.price_km, infoUralTransit.price_kg};
            }
        }
        public static List<Order> GetOrdersSDEK(Role role)
        {
            List<Order> orders = new List<Order>();
            switch (role)
            {
                case Role.Admin:
                    string url = "https://localhost:7110/GetOrdersSDEK?isAdmin=true";
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpWebRequest.Method = "POST";
                    HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    string response;
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                        dynamic result = JsonConvert.DeserializeObject(response);
                        foreach (var row in result)
                        {
                            Order order = new Order((int)row.userId, (string)row.whereFrom, (bool)row.fromDoor, (string)row.whereTo, (bool)row.toDoor, (decimal)row.weight, (decimal)row.volume, (decimal)row.price, (DateTime)row.dateTime);
                            order.id = row.id;
                            orders.Add(order);
                        }
                    }
                    return orders;
                case Role.User:
                    return orders;
            }
            return orders;
        }
        public static List<Order>  GetOrdersUralTransit(Role role)
        {
            List<Order> orders = new List<Order>();
            switch (role)
            {
                case Role.Admin:
                    string url = "https://localhost:7110/GetOrdersUralTransit?isAdmin=true";
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpWebRequest.Method = "POST";
                    HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    string response;
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                        dynamic result = JsonConvert.DeserializeObject(response);
                        foreach (var row in result)
                        {
                            Order order = new Order((int)row.userId, (string)row.whereFrom, (bool)row.fromDoor, (string)row.whereTo, (bool)row.toDoor, (decimal)row.weight, (decimal)row.volume, (decimal)row.price, (DateTime)row.dateTime);
                            order.id = row.id;
                            orders.Add(order);
                        }
                    }
                    return orders;
                case Role.User:
                    return orders;
            }
            return orders;
        }
    }
}
