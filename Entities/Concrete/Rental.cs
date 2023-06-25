using Core.Entities;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime RenDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string Description { get; set; }

        public decimal DailyPrice { get; set; }

        public bool IsAvilable { get; set; }

    }
}