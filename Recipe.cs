namespace CA24093002
{
    internal class Recipe
    {
        public string Food { get; set; }
        public int PrepTime { get; set; }
        public string Type { get; set; }
        public string Difficulity { get; set; }

        public override string ToString()
        {
            return $"{Food} ({Type}, eki: {PrepTime} perc, {Difficulity})";
        }

        public Recipe(string row)
        {
            var v = row.Split(';');
            Food = v[0];
            PrepTime = int.Parse(v[1]);
            Type = v[2];
            Difficulity = v[3];
        }
    }
}
