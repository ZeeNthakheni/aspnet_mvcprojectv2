namespace MVCProjectv2.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set;}
        public string UserId { get; set; }
        public Joke() { 
        
        }

    }
}
