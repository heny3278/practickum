using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class ChildModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string tz { get; set; }
        public DateTime BirthDate { get; set; }

        [ForeignKey("Parent")]
        public int ParentId { get; set; }
        public UserModel Parent { get; set; }
    }
}
