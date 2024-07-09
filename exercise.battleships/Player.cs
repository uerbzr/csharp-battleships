namespace exercise.battleships
{
    public class Player
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Score {  get; set; } = 0;
        

    }
}