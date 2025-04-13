namespace Domain.Entities
using Application.Models;
using Infrastructure.Data;

{
    public class Customer
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    private Customer() { } // For EF/Core or serialization

    private Customer(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public static Customer Create(int id, string name)
    {
        customer = new Customer(id, name)


            var repository = new CustomerRepository();
        repository.Add(customer);

        return customer;
    }

    public CustomerDTO ToDto()
    {
        return new CustomerDTO
        {
            Id = this.Id,
            Name = this.Name
        };
    }
}
}
