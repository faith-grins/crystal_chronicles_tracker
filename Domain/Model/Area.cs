namespace Domain.Model
{
    public class Area
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
        }
    }
}
