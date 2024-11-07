namespace CustomerApplication.Data
{
    using CustomerApplication.Model;
    using System.Collections.Generic;

    public static class InMemoryDataStore
    {
        // Static list to hold customer data in memory
        public static List<Customer> Customers { get; } = new List<Customer>();

        // Counter to generate unique IDs for new customers
        public static int NextId { get; set; } = 1;
    }
}
