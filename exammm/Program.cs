using exammm;
using Microsoft.EntityFrameworkCore;

// Добавление в Good
/*using (AppDB db = new AppDB())
{
    Good t = new Good { Name = "Тетрадь", Price = 100 };
    Good a = new Good { Name = "Маркер", Price = 500 };
    Good m = new Good { Name = "Клавиатура", Price = 700 };
    Good k = new Good { Name = "Мышь", Price = 800 };
    Good l = new Good { Name = "Овощ", Price = 900 };
    Good o = new Good { Name = "Подушка", Price = 300 };
    Good u = new Good { Name = "Пылесос", Price = 1000 };
    Good p = new Good { Name = "Заяц", Price = 110 };

    db.Goods.AddRange(t, a, m, k, l, o, u, p);
    db.SaveChanges();

    var users = db.Goods.ToList();
    Console.WriteLine("Список товаров:");
    foreach (Good d in users)
    {
        Console.WriteLine($"{d.Id}.{d.Name} - {d.Price}");
    }
}*/


// Добавление в Users
/*using (AppDB db = new AppDB())
{
    Users tom = new Users { Name = "Tom", Age = 33, Male = 0 };
    Users alice = new Users { Name = "Alice", Age = 26, Male = 1 };
    Users mike = new Users { Name = "Mike", Age = 32, Male = 0 };
    Users mil = new Users { Name = "Mil", Age = 26, Male = 1 };

    db.AddRange(tom, alice, mike, mil);
    db.SaveChanges();

    var users = db.Users.ToList();
    Console.WriteLine("Список пользователей:");
    foreach (Users u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Male} - {u.Age}");
    }
}*/


// Добавление в Saled
/*using (AppDB db = new AppDB())
{
    Saled sa1 = new Saled { Date = Convert.ToDateTime("2023-01-10").Date, Sum = 100, UserId = 1 };
    Saled sa2 = new Saled { Date = Convert.ToDateTime("2023-01-11").Date, Sum = 500, UserId = 2 };
    Saled sa3 = new Saled { Date = Convert.ToDateTime("2023-01-12").Date, Sum = 700, UserId = 3 };
    Saled sa4 = new Saled { Date = Convert.ToDateTime("2023-01-13").Date, Sum = 100, UserId = 4 };
    Saled sa5 = new Saled { Date = Convert.ToDateTime("2023-01-14").Date, Sum = 500, UserId = 3 };
    Saled sa6 = new Saled { Date = Convert.ToDateTime("2023-01-11").Date, Sum = 900, UserId = 3 };
    Saled sa7 = new Saled { Date = Convert.ToDateTime("2023-01-12").Date, Sum = 100, UserId = 1 };
    Saled sa8 = new Saled { Date = Convert.ToDateTime("2023-01-11").Date, Sum = 500, UserId = 2 };
    Saled sa9 = new Saled { Date = Convert.ToDateTime("2023-01-10").Date, Sum = 100, UserId = 2 };
    Saled sa10 = new Saled { Date = Convert.ToDateTime("2023-01-13").Date, Sum = 100, UserId = 1 };
    Saled sa11 = new Saled { Date = Convert.ToDateTime("2023-01-15").Date, Sum = 1000, UserId = 1 };
    Saled sa12 = new Saled { Date = Convert.ToDateTime("2023-01-13").Date, Sum = 500, UserId = 4 };
    Saled sa13 = new Saled { Date = Convert.ToDateTime("2023-01-14").Date, Sum = 100, UserId = 3 };
    Saled sa14 = new Saled { Date = Convert.ToDateTime("2023-01-11").Date, Sum = 500, UserId = 3 };
    Saled sa15 = new Saled { Date = Convert.ToDateTime("2023-01-12").Date, Sum = 1000, UserId = 1 };
    Saled sa16 = new Saled { Date = Convert.ToDateTime("2023-01-14").Date, Sum = 110, UserId = 3 };

    db.Saleds.AddRange(sa1, sa2, sa3, sa4, sa5, sa6, sa7, sa8, sa9, sa10, sa11, sa12, sa13, sa14, sa15, sa16);
    db.SaveChanges();

    var sale = db.Saleds.ToList();
    Console.WriteLine("Список продаж:");
    foreach (Saled d in sale)
    {
        Console.WriteLine($"{d.Id}.{d.Date} - {d.Sum} - {d.UserId}");
    }
}*/

// Добавление в Good_saled
/*using (AppDB db = new AppDB())
{
    Good_saled good_Saled1 = new Good_saled { GoodId = 1, SaledId = 1 };
    Good_saled good_Saled2 = new Good_saled { GoodId = 2, SaledId = 2 };
    Good_saled good_Saled3 = new Good_saled { GoodId = 3, SaledId = 3 };
    Good_saled good_Saled4 = new Good_saled { GoodId = 1, SaledId = 4 };
    Good_saled good_Saled5 = new Good_saled { GoodId = 2, SaledId = 5 };
    Good_saled good_Saled6 = new Good_saled { GoodId = 5, SaledId = 6 };
    Good_saled good_Saled7 = new Good_saled { GoodId = 1, SaledId = 7 };
    Good_saled good_Saled8 = new Good_saled { GoodId = 2, SaledId = 8 };
    Good_saled good_Saled9 = new Good_saled { GoodId = 1, SaledId = 9 };
    Good_saled good_Saled10 = new Good_saled { GoodId = 1, SaledId = 10 };
    Good_saled good_Saled11 = new Good_saled { GoodId = 7, SaledId = 11 };
    Good_saled good_Saled12 = new Good_saled { GoodId = 2, SaledId = 12 };
    Good_saled good_Saled13 = new Good_saled { GoodId = 1, SaledId = 13 };
    Good_saled good_Saled14 = new Good_saled { GoodId = 2, SaledId = 14 };
    Good_saled good_Saled15 = new Good_saled { GoodId = 7, SaledId = 15 };
    Good_saled good_Saled16 = new Good_saled { GoodId = 8, SaledId = 16 };

    db.AddRange(good_Saled1, good_Saled2, good_Saled3, good_Saled4, good_Saled5, 
        good_Saled6, good_Saled7, good_Saled8, good_Saled9, good_Saled10, good_Saled11, good_Saled12,good_Saled13, good_Saled14, good_Saled15,
        good_Saled16);
    db.AddRange();
    db.SaveChanges();

    var goodsale = db.Good_Selads.ToList();
    Console.WriteLine("Список продажи товаров:");
    foreach (Good_saled d in goodsale)
    {
        Console.WriteLine($"{d.GoodId} - {d.SaledId}");
    }
}*/

// Все продажи товаров 
using (AppDB db = new AppDB())
{
    var res = db.Goods.Join(db.Good_Selads,
        i => i.Id,
        c => c.GoodId,
        (i, c) => new
        {
            Name = i.Name,
            SaleId = c.SaledId
        })
        .Join(db.Saleds,
        i => i.SaleId,
        c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = c.Sum,
            UserId = c.UserId
        })
        .Join(db.Users, i => i.UserId, c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = i.Sum,
            Male = c.Male
        });
    
    Console.WriteLine("Все продажи товаров ");
    foreach (var d in res)
    {
        if (d.Male == 0) Console.WriteLine($"{d.Name} - {d.Sum} - мужчина");
        else if (d.Male == 1) Console.WriteLine($"{d.Name} - {d.Sum} - женщина");
    }
    Console.WriteLine();
}


// ЗАДАНИЕ 1: Какие товары самые продаваемые у женщин и у мужчин

// Самые продаваемые товары у женщин
using (AppDB db = new AppDB())
{
    var res = db.Goods.Join(db.Good_Selads,
        i => i.Id,
        c => c.GoodId,
        (i, c) => new
        {
            GoodId = c.GoodId,
            Name = i.Name,
            SaleId = c.SaledId
        })
        .Join(db.Saleds,
        i => i.SaleId,
        c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            GoodId = i.GoodId,
            UserId = c.UserId
        })
        .Join(db.Users, i => i.UserId, c => c.Id,
        (i, c) => new
        {
            GoodId = i.GoodId,
            Name = i.Name,
            Male = c.Male
        }).
        Where(u => u.Male == 1).GroupBy(u => u.Name).
        Select(g => new { Name = g.Key, Count = g.Count()}).OrderByDescending(c=>c.Count).First();
    
    Console.WriteLine($"Самый продаваемый товар у женщин: {res.Name}, купили {res.Count} раза");
}

// Самые продаваемые товары у мужчин
using (AppDB db = new AppDB())
{
    var res = db.Goods.Join(db.Good_Selads,
        i => i.Id,
        c => c.GoodId,
        (i, c) => new
        {
            GoodId = c.GoodId,
            Name = i.Name,
            SaleId = c.SaledId
        })
        .Join(db.Saleds,
        i => i.SaleId,
        c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            GoodId = i.GoodId,
            UserId = c.UserId
        })
        .Join(db.Users, i => i.UserId, c => c.Id,
        (i, c) => new
        {
            GoodId = i.GoodId,
            Name = i.Name,
            Male = c.Male
        }).
        Where(u => u.Male == 0).GroupBy(u => u.Name).
        Select(g => new { Name = g.Key, Count = g.Count() }).OrderByDescending(c => c.Count).First();

    Console.WriteLine($"Самый продаваемый товар у мужчин: {res.Name}, купили {res.Count} раза");
}


// ЗАДАНИЕ 2: Максимум, среднее и сумма продаж у женщин и мужчин


// Max продаж у женщин
using (AppDB db = new AppDB())
{
    var res = db.Goods.Join(db.Good_Selads,
        i => i.Id,
        c => c.GoodId,
        (i, c) => new
        {
            Name = i.Name,
            SaleId = c.SaledId
        })
        .Join(db.Saleds,
        i => i.SaleId,
        c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = c.Sum,
            UserId = c.UserId
        })
        .Join(db.Users, i => i.UserId, c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = i.Sum,
            Male = c.Male
        }).
        Where(u => u.Male == 1).Max(u => u.Sum);
    Console.WriteLine($"Максимальное продаж у женщин: {res}");
}


// Среднее продаж у женщин
using (AppDB db = new AppDB())
{
    var res = db.Goods.Join(db.Good_Selads,
        i => i.Id,
        c => c.GoodId,
        (i, c) => new
        {
            Name = i.Name,
            SaleId = c.SaledId
        })
        .Join(db.Saleds,
        i => i.SaleId,
        c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = c.Sum,
            UserId = c.UserId
        })
        .Join(db.Users, i => i.UserId, c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = i.Sum,
            Male = c.Male
        }).
        Where(u => u.Male == 1).Average(u => u.Sum);
    Console.WriteLine($"Среднее продаж у женщин: {res}");
}


// Сумма продаж у женщин
using (AppDB db = new AppDB())
{
    var res = db.Goods.Join(db.Good_Selads,
        i => i.Id,
        c => c.GoodId,
        (i, c) => new
        {
            Name = i.Name,
            SaleId = c.SaledId
        })
        .Join(db.Saleds,
        i => i.SaleId,
        c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = c.Sum,
            UserId = c.UserId
        })
        .Join(db.Users, i => i.UserId, c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = i.Sum,
            Male = c.Male
        }).
        Where(u => u.Male == 1).Sum(u => u.Sum);
    Console.WriteLine($"Сумма продаж у женщин: {res}");
}


// Max продаж у мужчин
using (AppDB db = new AppDB())
{
    var res = db.Goods.Join(db.Good_Selads,
        i => i.Id,
        c => c.GoodId,
        (i, c) => new
        {
            Name = i.Name,
            SaleId = c.SaledId
        })
        .Join(db.Saleds,
        i => i.SaleId,
        c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = c.Sum,
            UserId = c.UserId
        })
        .Join(db.Users, i => i.UserId, c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = i.Sum,
            Male = c.Male
        }).
        Where(u => u.Male == 0).Max(u => u.Sum);
    Console.WriteLine($"Максимальное продаж у мужчин: {res}");
}

// Среднее продаж у мужчин
using (AppDB db = new AppDB())
{
    var res = db.Goods.Join(db.Good_Selads,
        i => i.Id,
        c => c.GoodId,
        (i, c) => new
        {
            Name = i.Name,
            SaleId = c.SaledId
        })
        .Join(db.Saleds,
        i => i.SaleId,
        c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = c.Sum,
            UserId = c.UserId
        })
        .Join(db.Users, i => i.UserId, c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = i.Sum,
            Male = c.Male
        }).
        Where(u => u.Male == 0).Average(u => u.Sum);
    Console.WriteLine($"Среднее продаж у мужчин: {res}");
}

//Сумма продаж у мужчин
using (AppDB db = new AppDB())
{
    var res = db.Goods.Join(db.Good_Selads,
        i => i.Id,
        c => c.GoodId,
        (i, c) => new
        {
            Name = i.Name,
            SaleId = c.SaledId
        })
        .Join(db.Saleds,
        i => i.SaleId,
        c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = c.Sum,
            UserId = c.UserId
        })
        .Join(db.Users, i => i.UserId, c => c.Id,
        (i, c) => new
        {
            Name = i.Name,
            Sum = i.Sum,
            Male = c.Male
        }).
        Where(u => u.Male == 0).Sum(u => u.Sum);
    Console.WriteLine($"Сумма продаж у мужчин: {res}");
}