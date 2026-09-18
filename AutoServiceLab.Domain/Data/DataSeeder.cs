using AutoServiceLab.Domain.Entities;
using AutoServiceLab.Domain.Enums;

namespace AutoServiceLab.Domain.Data;

public static class DataSeeder
{
    public static List<Client> GetClients()
    {
        return
        [
            new() { Id = 1, FullName = "Иванов Иван Иванович", Phone = "+7-927-111-11-11" },
            new() { Id = 2, FullName = "Петрова Мария Сергеевна", Phone = "+7-927-222-22-22" },
            new() { Id = 3, FullName = "Сидоров Алексей Петрович", Phone = "+7-927-333-33-33" },
            new() { Id = 4, FullName = "Козлова Елена Дмитриевна", Phone = "+7-927-444-44-44" },
            new() { Id = 5, FullName = "Морозов Дмитрий Андреевич", Phone = "+7-927-555-55-55" },
            new() { Id = 6, FullName = "Волкова Анна Владимировна", Phone = "+7-927-666-66-66" },
            new() { Id = 7, FullName = "Зайцев Артем Олегович", Phone = "+7-927-777-77-77" },
            new() { Id = 8, FullName = "Соколова Наталья Игоревна", Phone = "+7-927-888-88-88" },
            new() { Id = 9, FullName = "Кузнецов Максим Романович", Phone = "+7-927-999-99-99" },
            new() { Id = 10, FullName = "Смирнова Ольга Павловна", Phone = "+7-927-000-00-00" },
        ];

    }

    public static List<Car> GetCars(List<Client> clients)
    {

        var cars = new List<Car>
        {
            new() { Id = 1, LicensePlate = "А001АА163", Brand = CarBrand.Toyota, Model = "Camry", Year = 2020, ClientId = clients[1].Id },
            new() { Id = 2, LicensePlate = "В002ВВ163", Brand = CarBrand.BMW, Model = "X5", Year = 2022, ClientId = clients[1].Id },
            new() { Id = 3, LicensePlate = "С003СС163", Brand = CarBrand.Mercedes, Model = "E-Class", Year = 2021, ClientId = clients[2].Id },
            new() { Id = 4, LicensePlate = "Е004ЕЕ163", Brand = CarBrand.Audi, Model = "Q7", Year = 2020, ClientId = clients[3].Id },
            new() { Id = 5, LicensePlate = "К005КК163", Brand = CarBrand.Volkswagen, Model = "Passat", Year = 2019, ClientId = clients[4].Id },
            new() { Id = 6, LicensePlate = "М006ММ163", Brand = CarBrand.Ford, Model = "Focus", Year = 2021, ClientId = clients[5].Id },
            new() { Id = 7, LicensePlate = "Н007НН163", Brand = CarBrand.Toyota, Model = "Land Cruiser", Year = 2022, ClientId = clients[6].Id },
            new() { Id = 8, LicensePlate = "О008ОО163", Brand = CarBrand.Hyundai, Model = "Sonata", Year = 2020, ClientId = clients[7].Id },
            new() { Id = 9, LicensePlate = "Р009РР163", Brand = CarBrand.Nissan, Model = "X-Trail", Year = 2021, ClientId = clients[8].Id },
            new() { Id = 10, LicensePlate = "Т010ТТ163", Brand = CarBrand.BMW, Model = "3 Series", Year = 2020, ClientId = clients[9].Id },
        };

        foreach(var car in cars)
        {
            clients.First(c => c.Id == car.ClientId).Cars.Add(car);
        }

        return cars;
        
    }
    public static List<Mechanic> GetMechanics()
    {
        return
        [
            new() { Id = 1, FullName = "Сидоров Петр Иванович", Phone = "+7-937-111-11-11", Specialization = "Engine", HourlyRate = 2500 },
            new() { Id = 2, FullName = "Иванов Александр Петрович", Phone = "+7-937-111-11-12", Specialization = "Electrical", HourlyRate = 2200 },
            new() { Id = 3, FullName = "Петрова Екатерина Сергеевна", Phone = "+7-937-111-11-13", Specialization = "Body", HourlyRate = 2000 },
            new() { Id = 4, FullName = "Смирнов Денис Андреевич", Phone = "+7-937-111-11-14", Specialization = "Transmission", HourlyRate = 2400 },
            new() { Id = 5, FullName = "Козлова Ольга Дмитриевна", Phone = "+7-937-111-11-15", Specialization = "Engine", HourlyRate = 1900 },
            new() { Id = 6, FullName = "Морозов Владимир Игоревич", Phone = "+7-937-111-11-16", Specialization = "Electrical", HourlyRate = 2800 },
            new() { Id = 7, FullName = "Новикова Мария Олеговна", Phone = "+7-937-111-11-17", Specialization = "Body", HourlyRate = 1700 },
            new() { Id = 8, FullName = "Федоров Алексей Романович", Phone = "+7-937-111-11-18", Specialization = "Transmission", HourlyRate = 2100 },
            new() { Id = 9, FullName = "Егоров Михаил Валерьевич", Phone = "+7-937-111-11-19", Specialization = "Engine", HourlyRate = 3000 },
            new() { Id = 10, FullName = "Тимофеев Илья Андреевич", Phone = "+7-937-111-11-10", Specialization = "Electrical", HourlyRate = 1600 },
        ];
    }

    public static List<Part> GetParts()
    {
        return
        [
            new() { Id = 1, Name = "Масло моторное 5W-30", PartNumber = "OIL-001", Category = PartCategory.Oils, PurchasePrice = 4500, SellingPrice = 6000, QuantityInStock = 25, MinStockQuantity = 5 },
            new() { Id = 2, Name = "Фильтр масляный", PartNumber = "FIL-001", Category = PartCategory.Filters, PurchasePrice = 500, SellingPrice = 800, QuantityInStock = 40, MinStockQuantity = 10 },
            new() { Id = 3, Name = "Фильтр воздушный", PartNumber = "FIL-002", Category = PartCategory.Filters, PurchasePrice = 700, SellingPrice = 1100, QuantityInStock = 35, MinStockQuantity = 8 },
            new() { Id = 4, Name = "Колодки передние", PartNumber = "BRK-001", Category = PartCategory.BrakeSystem, PurchasePrice = 2500, SellingPrice = 3800, QuantityInStock = 15, MinStockQuantity = 5 },
            new() { Id = 5, Name = "Колодки задние", PartNumber = "BRK-002", Category = PartCategory.BrakeSystem, PurchasePrice = 2200, SellingPrice = 3500, QuantityInStock = 12, MinStockQuantity = 5 },
            new() { Id = 6, Name = "Свечи зажигания", PartNumber = "IGN-001", Category = PartCategory.Ignition, PurchasePrice = 800, SellingPrice = 1400, QuantityInStock = 30, MinStockQuantity = 10 },
            new() { Id = 7, Name = "Аккумулятор 60Ач", PartNumber = "BAT-001", Category = PartCategory.Batteries, PurchasePrice = 6000, SellingPrice = 8500, QuantityInStock = 8, MinStockQuantity = 3 },
            new() { Id = 8, Name = "Ремень ГРМ", PartNumber = "BEL-001", Category = PartCategory.Belts, PurchasePrice = 1500, SellingPrice = 2200, QuantityInStock = 10, MinStockQuantity = 3 },
            new() { Id = 9, Name = "Тормозная жидкость DOT-4", PartNumber = "FLU-001", Category = PartCategory.Oils, PurchasePrice = 600, SellingPrice = 1000, QuantityInStock = 20, MinStockQuantity = 5 },
            new() { Id = 10, Name = "Шина летняя 225/45 R17", PartNumber = "TIR-001", Category = PartCategory.Tires, PurchasePrice = 15000, SellingPrice = 19000, QuantityInStock = 4, MinStockQuantity = 2 },
        ];
    }

    public static List<ServiceOrder> GetOrders(List<Client> clients, List<Car> cars)
    {
        return
        [
            new() { Id = 1, CreatedDate = new DateTime(2026, 1, 5), Status = OrderStatus.Completed, Description = "Замена масла", ClientId = clients[0].Id, CarId = cars[0].Id },
            new() { Id = 2, CreatedDate = new DateTime(2026, 1, 10), Status = OrderStatus.InProgress, Description = "Стук", ClientId = clients[1].Id, CarId = cars[1].Id },
            new() { Id = 3, CreatedDate = new DateTime(2026, 1, 15), Status = OrderStatus.Created, Description = "Проверка", ClientId = clients[2].Id, CarId = cars[2].Id },
            new() { Id = 4, CreatedDate = new DateTime(2026, 1, 20), Status = OrderStatus.WaitingParts, Description = "Скрип", ClientId = clients[3].Id, CarId = cars[3].Id },
            new() { Id = 5, CreatedDate = new DateTime(2026, 1, 25), Status = OrderStatus.Completed, Description = "Сезонная замена", ClientId = clients[4].Id, CarId = cars[4].Id },
            new() { Id = 6, CreatedDate = new DateTime(2026, 2, 1), Status = OrderStatus.Cancelled, Description = "Вмятина", ClientId = clients[5].Id, CarId = cars[5].Id },
            new() { Id = 7, CreatedDate = new DateTime(2026, 2, 5), Status = OrderStatus.InProgress, Description = "Не работает свет", ClientId = clients[6].Id, CarId = cars[6].Id },
            new() { Id = 8, CreatedDate = new DateTime(2026, 2, 10), Status = OrderStatus.Completed, Description = "Не заводится", ClientId = clients[7].Id, CarId = cars[7].Id },
            new() { Id = 9, CreatedDate = new DateTime(2026, 2, 15), Status = OrderStatus.Created, Description = "Стук", ClientId = clients[8].Id, CarId = cars[8].Id },
            new() { Id = 10, CreatedDate = new DateTime(2026, 2, 20), Status = OrderStatus.WaitingParts, Description = "Проблемы", ClientId = clients[9].Id, CarId = cars[9].Id },
        ];
    }

    public static List<ServiceWork> GetServiceWorks(List<ServiceOrder> orders, List<Mechanic> mechanics)
    {
        return
        [
            new() { Id = 1, WorkType = WorkType.OilChange, Description = "Замена масла", LaborCost = 3750, ServiceOrderId = orders[0].Id, MechanicId = mechanics[0].Id },
            new() { Id = 2, WorkType = WorkType.Diagnostics, Description = "Диагностика", LaborCost = 2500, ServiceOrderId = orders[0].Id, MechanicId = mechanics[1].Id },
            new() { Id = 3, WorkType = WorkType.EngineRepair, Description = "Ремонт двигателя", LaborCost = 20000, ServiceOrderId = orders[1].Id, MechanicId = mechanics[2].Id },
            new() { Id = 4, WorkType = WorkType.BrakeRepair, Description = "Замена колодок", LaborCost = 5000, ServiceOrderId = orders[3].Id, MechanicId = mechanics[3].Id },
            new() { Id = 5, WorkType = WorkType.TireReplacement, Description = "Замена шин", LaborCost = 2400, ServiceOrderId = orders[4].Id, MechanicId = mechanics[4].Id },
            new() { Id = 6, WorkType = WorkType.ElectricalRepair, Description = "Ремонт проводки", LaborCost = 6600, ServiceOrderId = orders[6].Id, MechanicId = mechanics[5].Id },
            new() { Id = 7, WorkType = WorkType.Diagnostics, Description = "Диагностика электрики", LaborCost = 1100, ServiceOrderId = orders[6].Id, MechanicId = mechanics[6].Id },
            new() { Id = 8, WorkType = WorkType.OilChange, Description = "Замена масла", LaborCost = 2500, ServiceOrderId = orders[9].Id, MechanicId = mechanics[7].Id },
            new() { Id = 9, WorkType = WorkType.EngineRepair, Description = "Ремонт охлаждения", LaborCost = 12500, ServiceOrderId = orders[9].Id, MechanicId = mechanics[8].Id },
            new() { Id = 10, WorkType = WorkType.TransmissionRepair, Description = "Ремонт АКПП", LaborCost = 24000, ServiceOrderId = orders[9].Id, MechanicId = mechanics[9].Id },
        ];
    }

    public static List<PartUsage> GetPartUsages(List<ServiceOrder> orders, List<Part> parts)
    {
        return
        [
            new() { Id = 1, Quantity = 1, PriceAtTime = 6000, PartId = parts[0].Id, ServiceOrderId = orders[0].Id },
            new() { Id = 2, Quantity = 1, PriceAtTime = 800, PartId = parts[1].Id, ServiceOrderId = orders[0].Id },
            new() { Id = 3, Quantity = 2, PriceAtTime = 3800, PartId = parts[3].Id, ServiceOrderId = orders[3].Id },
            new() { Id = 4, Quantity = 4, PriceAtTime = 19000, PartId = parts[9].Id, ServiceOrderId = orders[4].Id },
            new() { Id = 5, Quantity = 1, PriceAtTime = 1400, PartId = parts[5].Id, ServiceOrderId = orders[6].Id },
            new() { Id = 6, Quantity = 1, PriceAtTime = 8500, PartId = parts[6].Id, ServiceOrderId = orders[7].Id },
            new() { Id = 7, Quantity = 1, PriceAtTime = 6000, PartId = parts[0].Id, ServiceOrderId = orders[9].Id },
            new() { Id = 8, Quantity = 1, PriceAtTime = 800, PartId = parts[1].Id, ServiceOrderId = orders[9].Id },
            new() { Id = 9, Quantity = 1, PriceAtTime = 6800, PartId = parts[9].Id, ServiceOrderId = orders[9].Id },
            new() { Id = 10, Quantity = 1, PriceAtTime = 2200, PartId = parts[7].Id, ServiceOrderId = orders[1].Id },
        ];
    }

    public static List<Invoice> GetInvoices(List<ServiceOrder> orders)
    {
        return
        [
            new() { Id = 1, InvoiceNumber = "INV-2026-000001", InvoiceDate = new DateTime(2026, 1, 7), DueDate = new DateTime(2026, 1, 21), Amount = 7050, PaidAmount = 7050, PaymentStatus = PaymentStatus.Paid, PaymentMethod = PaymentMethod.Card, ServiceOrderId = orders[0].Id },
        new() { Id = 2, InvoiceNumber = "INV-2026-000002", InvoiceDate = new DateTime(2026, 1, 12), DueDate = new DateTime(2026, 1, 26), Amount = 20000, PaidAmount = 0, PaymentStatus = PaymentStatus.Unpaid, ServiceOrderId = orders[1].Id },
        new() { Id = 3, InvoiceNumber = "INV-2026-000003", InvoiceDate = new DateTime(2026, 1, 27), DueDate = new DateTime(2026, 2, 10), Amount = 76000, PaidAmount = 76000, PaymentStatus = PaymentStatus.Paid, PaymentMethod = PaymentMethod.Cash, ServiceOrderId = orders[4].Id },
        new() { Id = 4, InvoiceNumber = "INV-2026-000004", InvoiceDate = new DateTime(2026, 2, 8), DueDate = new DateTime(2026, 2, 22), Amount = 9100, PaidAmount = 4500, PaymentStatus = PaymentStatus.PartiallyPaid, PaymentMethod = PaymentMethod.Card, ServiceOrderId = orders[6].Id },
        new() { Id = 5, InvoiceNumber = "INV-2026-000005", InvoiceDate = new DateTime(2026, 2, 13), DueDate = new DateTime(2026, 2, 27), Amount = 11000, PaidAmount = 11000, PaymentStatus = PaymentStatus.Paid, PaymentMethod = PaymentMethod.Card, ServiceOrderId = orders[7].Id },
        new() { Id = 6, InvoiceNumber = "INV-2026-000006", InvoiceDate = new DateTime(2026, 2, 28), DueDate = new DateTime(2026, 3, 14), Amount = 9700, PaidAmount = 9700, PaymentStatus = PaymentStatus.Paid, PaymentMethod = PaymentMethod.Card, ServiceOrderId = orders[9].Id },
        new() { Id = 7, InvoiceNumber = "INV-2026-000007", InvoiceDate = new DateTime(2026, 3, 5), DueDate = new DateTime(2026, 3, 19), Amount = 12500, PaidAmount = 6000, PaymentStatus = PaymentStatus.PartiallyPaid, PaymentMethod = PaymentMethod.Card, ServiceOrderId = orders[9].Id },
        new() { Id = 8, InvoiceNumber = "INV-2026-000008", InvoiceDate = new DateTime(2026, 2, 25), DueDate = new DateTime(2026, 3, 11), Amount = 30800, PaidAmount = 0, PaymentStatus = PaymentStatus.Unpaid, ServiceOrderId = orders[9].Id },
        new() { Id = 9, InvoiceNumber = "INV-2026-000009", InvoiceDate = new DateTime(2026, 1, 22), DueDate = new DateTime(2026, 2, 5), Amount = 13100, PaidAmount = 0, PaymentStatus = PaymentStatus.Unpaid, ServiceOrderId = orders[3].Id },
        new() { Id = 10, InvoiceNumber = "INV-2026-000010", InvoiceDate = new DateTime(2026, 2, 1), DueDate = new DateTime(2026, 2, 15), Amount = 0, PaidAmount = 0, PaymentStatus = PaymentStatus.Refunded, ServiceOrderId = orders[5].Id },
    ];
    }
}

