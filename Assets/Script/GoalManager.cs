using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoalManager : MonoBehaviour {

	public Text player01ScoreText;
	public Text player02ScoreText;

	private int player01Score;
	private int player02Score;

	private GameObject ball;
	private Vector3 ballSpawnPos = new Vector3(0, 0, 0);

	private void Start()
	{
		ball = GameObject.FindGameObjectWithTag("Ball");
		ballSpawnPos = ball.transform.position;
		player01ScoreText.text = "0";
		player02ScoreText.text = "0";
	}

	public void Score(Player player)
	{
		if(player == Player.One)
		{
			player02Score++;
			player02ScoreText.text = "" + player02Score;
			RespawnBall();
		}else{
			player01Score++;
			player01ScoreText.text = "" + player01Score;
			RespawnBall();
		}
	}

	private void RespawnBall()
	{
		ball.transform.position = ballSpawnPos;
		ball.rigidbody.velocity = Vector3.zero;
	}

}
