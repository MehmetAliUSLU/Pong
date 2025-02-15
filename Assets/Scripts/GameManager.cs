using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int _playerScore,_computerScore;
    public Ball ball;
    public TextMeshProUGUI playerScoreText,computerScoreText;
    public Paddle playerPaddle,computerPaddle; 
    
    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        Resetting();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        Resetting();

    }

    public void Resetting()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
