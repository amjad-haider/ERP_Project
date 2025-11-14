using System;
using System.Collections.Generic;
using System.Linq;

namespace ErpSimulator
{
    // --- STEP 1: DEFINE DATA MODELS ---
    // Represents an item in our inventory
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int QuantityInStock { get; set; }
    }

    // Represents a customer sales order
    public class SalesOrder
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int QuantitySold { get; set; }
    }

    // --- STEP 2: DEFINE CORE BUSINESS LOGIC ---
    // This class acts as our core ERP logic module
    // It connects Sales to Inventory
    public class ErpLogic
    {
        // This list acts as our "Inventory Database"
        private List<Product> inventoryDatabase;

        public ErpLogic()
        {
            // Initialize the database with some sample data
            inventoryDatabase = new List<Product>
            {
                new Product { ProductId = 101, Name = "Laptop", QuantityInStock = 50 },
                new Product { ProductId = 102, Name = "Mouse", QuantityInStock = 200 }
            };
        }

        // This is the core ERP function
        // It processes a sales order and updates inventory in real-time
        public bool ProcessSalesOrder(SalesOrder order)
        {
            Console.WriteLine($"--- Processing Order {order.OrderId} for {order.QuantitySold} units of Product {order.ProductId} ---");

            // 1. Find the product in the inventory
            Product product = inventoryDatabase.FirstOrDefault(p => p.ProductId == order.ProductId);

            if (product == null)
            {
                Console.WriteLine($"ERROR: Product {order.ProductId} not found in inventory. Order rejected.");
                return false;
            }

            // 2. Check if there is enough stock
            if (product.QuantityInStock < order.QuantitySold)
            {
                Console.WriteLine($"ERROR: Insufficient stock for {product.Name}.");
                Console.WriteLine($"Stock: {product.QuantityInStock}, Required: {order.QuantitySold}. Order rejected.");
                return false;
            }

            // 3. Fulfill the order: Update inventory
            product.QuantityInStock -= order.QuantitySold;
            
            Console.WriteLine($"SUCCESS: Order {order.OrderId} processed.");
            Console.WriteLine($"Inventory for {product.Name} updated. New stock: {product.QuantityInStock}");
            return true;
        }

        // Helper function to display current inventory
        public void ShowCurrentInventory()
        {
            Console.WriteLine("\n--- CURRENT INVENTORY STATUS ---");
            foreach (var product in inventoryDatabase)
            {
                Console.WriteLine($"ID: {product.ProductId}, Name: {product.Name}, Stock: {product.QuantityInStock}");
            }
            Console.WriteLine("----------------------------------");
        }
    }

    // --- STEP 3: RUN THE SIMULATION ---
    // This is our main application entry point
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting ERP Simulation...");
            
            // 1. Initialize the ERP Logic module
            ErpLogic erp = new ErpLogic();

            // 2. Show initial inventory
            erp.ShowCurrentInventory();

            // 3. Simulate a successful order
            SalesOrder order1 = new SalesOrder { OrderId = 1, ProductId = 101, QuantitySold = 10 };
            erp.ProcessSalesOrder(order1);
            
            // 4. Show updated inventory
            erp.ShowCurrentInventory();

            // 5. Simulate a failed order (insufficient stock)
            SalesOrder order2 = new SalesOrder { OrderId = 2, ProductId = 101, QuantitySold = 999 };
            erp.ProcessSalesOrder(order2);

            // 6. Simulate another successful order
            SalesOrder order3 = new SalesOrder { OrderId = 3, ProductId = 102, QuantitySold = 50 };
            erp.ProcessSalesOrder(order3);

            // 7. Show final inventory
            erp.ShowCurrentInventory();

            Console.WriteLine("\nERP Simulation Complete. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}