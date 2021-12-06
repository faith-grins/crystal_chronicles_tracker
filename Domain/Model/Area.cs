using System;

namespace Domain.Model
{
    public class Area : IComparable
    {
        public string Name { get; set; }
        public Cycle[] Cycles { get; set; }
        public Cycle CurrentCycle { get; set; }
        public int Tier2Points { get; set; }
        public int Tier3Points { get; set; }
        public int Tier4Points { get; set; }

        public Area(string name)
        {
            Name = name;
            Cycles = new Cycle[3];
            Cycles[0] = new Cycle(1);
            Cycles[1] = new Cycle(2);
            Cycles[2] = new Cycle(3);
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            var comparingArea = obj as Area;
            if (comparingArea == null)
            {
                return 1;
            }
            return Name.CompareTo(comparingArea.Name);
        }
    }
}
