using AutoServiceLab.Domain.Data;
using AutoServiceLab.Domain.Entities;

namespace AutoServiceLab.Tests.Fixtures;

public class AutoServiceFixture
{
    public readonly List<Client> Clients;
    public readonly List<Car> Cars;
    public readonly List<Mechanic> Mechanics;
    public readonly List<Part> Parts;
    public readonly List<PartUsage> PartUsages;
    public readonly List<ServiceOrder> ServiceOrders;
    public readonly List<ServiceWork> ServiceWorks;
    public readonly List<Invoice> Invoices;


    public AutoServiceFixture()
    {
        Clients = DataSeeder.GetClients();
        Cars = DataSeeder.GetCars(Clients);
        Mechanics = DataSeeder.GetMechanics();
        Parts = DataSeeder.GetParts();
        ServiceOrders = DataSeeder.GetOrders(Clients, Cars);
        PartUsages = DataSeeder.GetPartUsages(ServiceOrders, Parts);
        ServiceWorks = DataSeeder.GetServiceWorks(ServiceOrders, Mechanics);
        Invoices = DataSeeder.GetInvoices(ServiceOrders); 


    }


}
