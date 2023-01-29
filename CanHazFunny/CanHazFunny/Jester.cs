namespace CanHazFunny
{
    public class Jester
    {
        private readonly IJokeService _jokeService;
        private readonly IJokeDisplay _jokeDisplay;

        public Jester(IJokeDisplay? jokeDisplay, IJokeService? jokeService)
        {
            if (jokeService == null) { throw new System.ArgumentNullException(nameof(jokeService)); }
            if (jokeDisplay == null) { throw new System.ArgumentNullException(nameof(jokeDisplay)); }

            _jokeService = jokeService;
            _jokeDisplay = jokeDisplay;
        }

        public void TellJoke()
        {
            string jokes = _jokeService.GetJoke();
            while (jokes.ToLower().Contains("chuck norris"))
            {
                jokes = _jokeService.GetJoke();
            }
            _jokeDisplay.Display(jokes);
        }
    }
}
