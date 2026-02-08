using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp_Many_To_Many.Data
{
    public class Team
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Game> AwayGames { get; set; } = new HashSet<Game>();
        public ICollection<Game> HomeGames { get; set; } = new HashSet<Game>();
    }
}
