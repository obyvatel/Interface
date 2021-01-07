using System.Collections.Generic;

namespace RunGame
{
    class GameCatch
    {
        public List<Игрок> gamers { get; private set; }
        Игрок leader;

        public GameCatch()
        {
            gamers = new List<Игрок>();
            leader = null;
        }

        public void AddGamer(Игрок gamer)
        {
            gamers.Add(gamer);
            SetNewLeader(gamer);
        }

        public void Step()
        {
            RunAll();
            FindNewLeader();
        }

        private void FindNewLeader()
        {
            foreach (Игрок g in gamers)
                if (leader.Поймал(g))
                {
                    SetNewLeader(g);
                    break;
                }
        }

        private void RunAll()
        {
            foreach (Игрок g in gamers)
                g.Беги();
        }

        private void SetNewLeader(Игрок gamer)
        {
            if (leader != null)
                leader.НеГоля();
            leader = gamer;
            if (leader != null)
                leader.Голя();
        }
    }
}
