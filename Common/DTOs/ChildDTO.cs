using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
    public class ChildDTO
    {
       
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string tz { get; set; }
        public DateTime BirthDate { get; set; }
        [ForeignKey("Parent")]

        public int ParentId { get; set; }
        public UserDTO parent { get; set; }
    }
}
