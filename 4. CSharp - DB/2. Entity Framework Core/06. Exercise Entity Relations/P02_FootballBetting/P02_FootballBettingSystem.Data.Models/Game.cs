using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBettingSystem.Data.Models
{
    public class Game
    {
        public Game()
        {
            Bets = new HashSet<Bet>();
        }
        [Key]
        public int GameId { get; set; }
        public virtual ICollection<Bet> Bets { get; set; }
    }
}
