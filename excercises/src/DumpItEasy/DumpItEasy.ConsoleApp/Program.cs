using DumpItEasy;

Customer customer = new(
          "John",
          "Smith",
          30,
          "john@example.com",
          "Dworcowa 1",
          "555-123-4567",
          new DateTime(2020, 01, 01));

customer.Dump();