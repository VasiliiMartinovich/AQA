namespace HW13;

using System;
using System.Collections.Generic;
using System.Linq;

//У вас есть две коллекции: список заказов и список клиентов. Вам нужно сформировать отчет по продажам за определенный период.

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        
        List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Иван", City = "Минск", RegistrationDate = new DateTime(2023, 5, 10)},
            new Customer { Id = 2, Name = "Анна", City = "Гродно", RegistrationDate = new DateTime(2024, 1, 15)},
            new Customer { Id = 3, Name = "Петр", City = "Минск", RegistrationDate = new DateTime(2023, 11, 20)},
            new Customer { Id = 4, Name = "Мария", City = "Брест", RegistrationDate = new DateTime(2024, 2, 1)}
        };

        List<Order> orders = new List<Order>
        {
            new Order { Id = 1, CustomerId = 1, OrderDate = new DateTime(2024,2,5), TotalAmount = 2500, Status = "Completed"},
            new Order { Id = 2, CustomerId = 1, OrderDate = new DateTime(2024,2,10), TotalAmount = 1500, Status = "Completed"},
            new Order { Id = 3, CustomerId = 2, OrderDate = new DateTime(2024,3,12), TotalAmount = 4000, Status = "Completed"},
            new Order { Id = 4, CustomerId = 2, OrderDate = new DateTime(2025,1,20), TotalAmount = 500, Status = "Cancelled"},
            new Order { Id = 5, CustomerId = 3, OrderDate = new DateTime(2024,2,15), TotalAmount = 7000, Status = "Completed"},
            new Order { Id = 6, CustomerId = 4, OrderDate = new DateTime(2025,8,25), TotalAmount = 1200, Status = "Pending"},
            new Order { Id = 7, CustomerId = 4, OrderDate = new DateTime(2024,2,28), TotalAmount = 3500, Status = "Completed"}
        };
        
        // Задание 1. Фильтрация (Where + лямбда)
        // Выведите все завершенные (Completed) заказы на сумму больше 2000.
        var completedOrders = orders.Where(o => o.Status == "Completed" && o.TotalAmount > 2000);
        
        foreach (var order in completedOrders)
            Console.WriteLine($"{order.Status} - {order.TotalAmount}");
        
        // Задание 2. Проекция (Select + анонимный тип)
        // Создайте список, содержащий имена клиентов и их общую сумму заказов.
        var customerTotals = customers.Select(c => new
        {
            c.Name,
            Total = orders
                .Where(o => o.CustomerId == c.Id)
                .Sum(o => o.TotalAmount)
        });
        foreach (var i in customerTotals)
            Console.WriteLine($"{i.Name} - {i.Total}");
        
        // Задание 3. Группировка (GroupBy)
        // Сгруппируйте заказы по городу клиента. Для каждого города выведите:
        // Количество заказов
        // Общую сумму продаж

        var cityOrders = orders
            .Join(customers,
                o => o.CustomerId,
                c => c.Id,
                (order, customer) => new
                {
                    customer.City,
                    order.TotalAmount
                })
            .GroupBy(x => x.City);
        
        foreach (var group in cityOrders)
        {
            Console.WriteLine($"Город: {group.Key}");
            Console.WriteLine($"Количество заказов: {group.Count()}");
            Console.WriteLine($"Общая сумма: {group.Sum(x => x.TotalAmount)}");
            Console.WriteLine();
        }
        
        // Задание 4*. Фильтрация + Проекция + Сортировка
        //  Составьте топ-3 клиентов по сумме заказов за февраль 2024. Выведите имя клиента и общую сумму.
        
        var topCustomers = orders
            .Where (o => o.OrderDate.Month == 2 && o.OrderDate.Year == 2024)
            .GroupBy(o => o.CustomerId)
            .Select(group => new
            {
                CustomerId = group.Key,
                TotalAmount = group.Sum(x => x.TotalAmount)
            })
            .Join(customers,
                x => x.CustomerId,
                c => c.Id,
                (x, c) => new 
                {
                c.Name,
                x.TotalAmount
                })
            .OrderByDescending(x => x.TotalAmount)
            .Take(3);
        
        foreach (var customer in topCustomers)
        {
            Console.WriteLine($"{customer.Name} - {customer.TotalAmount}");
        }
        
        // Задание 5*. Join
        // Создайте отчет: список заказов с именем клиента. Отсортируйте по дате заказа (от новых к старым).
        
        Console.WriteLine("Отчет: ");
        
        var customerOrders = orders
            .Join(customers,
                o => o.CustomerId,
                c => c.Id,
                (order, customer) => new
                {
                    customer.Name,
                    order.OrderDate,
                    order.TotalAmount,
                    order.Status
                })
            .OrderByDescending(x => x.OrderDate);

        foreach (var order in customerOrders)
        {
            Console.WriteLine($"{order.Name} - {order.OrderDate} - {order.TotalAmount} - {order.Status}");
        }

    }
}