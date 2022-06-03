using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public interface IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
    }
}
