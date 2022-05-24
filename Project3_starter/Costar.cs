/// <summary>
/// This class is used when two actors have been in the same movie. 
/// It holds info on who those two actors were and what movie they both were in.
/// </summary>

namespace Project3_starter
{
    public class Costar
    {
        public Actor FirstActor { get; private set; }
        public Actor SecondActor { get; private set; }
        public string Movie { get; private set; }

        public Costar(Actor first, Actor second, string movie)
        {
            FirstActor = first;
            SecondActor = second;
            Movie = movie;
        }
    }
}
