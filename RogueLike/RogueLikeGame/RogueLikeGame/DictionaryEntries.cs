using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public class DictionaryEntries     //XML Serialize the player scores
    {
        public List<int> Id { get; set; } = new List<int>();
        public List<string> Name { get; set; } = new List<string>();
        public List<int> Points { get; set; } = new List<int>();
        public List<string> Date { get; set; } = new List<string>();

        public DictionaryEntries()
        {

        }

        public void AddToLists(string name, int points, string date)
        {
            if (Id.Count == 0)
            {
                this.Id.Add(1);
                this.Name.Add(name);
                this.Points.Add(points);
                this.Date.Add(date);
            }
            else
            {
                if (Id[Id.Count - 1] != -1)
                {
                    this.Id.Add(Id[Id.Count - 1] + 1); //Add a new id +1 higher than last one 
                }
                this.Name.Add(name);
                this.Points.Add(points);
                this.Date.Add(date);
            }
        }
    }
}
