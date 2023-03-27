namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private Player _player1;
        private Player _player2;
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
	        _player1 = new Player(player1Name);
	        _player2 = new Player(player2Name);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == _player1.PlayerName)
                _player1.MScore += 1;
            else
                _player2.MScore += 1;
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (_player1.MScore == _player2.MScore)
            {
                switch (_player1.MScore)
                {
                    case 0:
                        score = "Love-All";
                        break;
                    case 1:
                        score = "Fifteen-All";
                        break;
                    case 2:
                        score = "Thirty-All";
                        break;
                    default:
                        score = "Deuce";
                        break;

                }
            }
            else if (_player1.MScore >= 4 || _player2.MScore >= 4)
            {
                var minusResult = _player1.MScore - _player2.MScore;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = _player1.MScore;
                    else { score += "-"; tempScore = _player2.MScore; }
                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }
    }
}

