

namespace OneBackComboTrainingWeb
{
    public class TennisGame
    {
        private readonly string _fistPlayerName;
        private readonly string _secondPlayerName;
        private int firstScore = 0;
        private int secondScore = 0;

        private Dictionary<int, string> ScoreMap = new Dictionary<int, string>();

        public TennisGame(string fistPlayerName, string secondPlayerName)
        {
            _fistPlayerName = fistPlayerName;
            _secondPlayerName = secondPlayerName;
            ScoreMap.Add(0, "love");
            ScoreMap.Add(1, "fifteen");
            ScoreMap.Add(2, "thirty");
        }


        private string GetResultAfterDeuce()
        {
            if (firstScore > 3 && secondScore > 3)
            {
                if (firstScore == secondScore)
                {
                    return "deuce";
                }

                if (firstScore > secondScore)
                {
                    if (firstScore - secondScore == 1)
                        return _fistPlayerName + " adv";
                    return _fistPlayerName + " win";
                }

                if (secondScore > firstScore)
                {
                    if (secondScore - firstScore == 1)
                        return _secondPlayerName + " adv";
                    return _secondPlayerName + " win";
                }

            }

            return String.Empty;
        }

        private void AddScore( string scoredPlayer )
        {
            if (scoredPlayer == _fistPlayerName)
            {
                firstScore++;
            }
            else
            {
                secondScore++;
            }
        }

        public string RefreshScore(string scoredPlayer)
        {
            if (!string.IsNullOrEmpty(scoredPlayer))
            {
                AddScore(scoredPlayer);
            }
            

            if ((firstScore  + secondScore) < 6)
            {
                if (firstScore == secondScore)
                    return ScoreMap[firstScore] + " all";
                return ScoreMap[firstScore] + " " + ScoreMap[secondScore];
            }

            return GetResultAfterDeuce();
        }

    }
}



