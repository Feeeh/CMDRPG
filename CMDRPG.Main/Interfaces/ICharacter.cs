namespace CMDRPG.Main.Interfaces
{
    public interface ICharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Inteligence { get; set; }
        public int Evasion { get; set; }
    }
}