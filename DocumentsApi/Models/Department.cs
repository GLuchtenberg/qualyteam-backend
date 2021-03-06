using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace DocumentsApi.Models
{
    public class Department
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        

        [Required,JsonIgnore]
        public ICollection<DocumentDepartment> DocumentDepartments { get; set; }
    }
}