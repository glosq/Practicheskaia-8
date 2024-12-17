namespace Practicheskaia_8
{
    interface Figura
    {
        public int Perimetr { get; set; }
        public int Plochad { get; set; }
    }
    interface IComparable
    {
        bool CompareTo(object obj);
    }
    class Pramoygolnik : Figura, IComparable
    {
        public int Perimetr { get; set; }
        public int Plochad { get; set; }
        public Pramoygolnik(int perimetr, int plochad)
        {
            Perimetr = perimetr;
            Plochad = plochad;
        }
        public string Information()
        {
            string info = "Периметр прямоугольника:" + Perimetr + "Площадь прямоугольника:" + Plochad;
            return info;
        }
        public bool CompareTo(object obj)
        {
            Kryg kryg = (Kryg)obj;
            if (kryg.Plochad == this.Plochad) return true;
            return false;
        }
    }
    class Kryg : Figura
    {
        public int Perimetr { get; set; }
        public int Plochad { get; set; }
        public Kryg(int perimetr, int plochad)
        {
            Perimetr = perimetr;
            Plochad = plochad;
        }
        public string Information()
        {
            string info = "Периметр круга: " + Perimetr + " Площадь круга: " + Plochad;
            return info;
        }
    }
}
