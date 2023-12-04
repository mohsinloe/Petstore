using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetstoreAPI.DTO
{
    public class Pet
    {
        public double id { get; set; }
        public Category category { get; set; } = new Category { id = 99999999, name = "Null Category" };
        public string? name { get; set; }
        public List<string>? photoUrls { get; set; }
        public List<Tag>? tags { get; set; }
        public string? status { get; set; }
    }
}
