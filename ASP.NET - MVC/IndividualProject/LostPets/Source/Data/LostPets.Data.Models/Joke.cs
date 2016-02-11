using LostPets.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPets.Data.Models
{
    public class Joke : BaseModel<int>
    {
        public string Content
        { get; set; }

        public int CategoryId
        { get; set; }

        public virtual JokeCategory Category
        { get; set; }
    }
}