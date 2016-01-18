using System;

namespace DevStore.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime AcquireDate { get; set; }
        public bool IsActive { get; set; }

        public int CategoryId { get; set; } // Utilizado para relacionamento com Category
        public virtual Category Category { get; set; } // Utilizado para obter acesso as proriedades de Category em tempo de execução

        // Method Constructor
        public Product()
        {
            this.AcquireDate = DateTime.Now;
        }
        // Override ToString()
        public override string ToString()
        {
            return this.Title;
        }
    }
}
