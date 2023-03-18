namespace MBL.Data.Entities
{
    public abstract class UserBook
    {
        public string UserId { get; set; }
        public virtual AppUser User { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }

    }
}
