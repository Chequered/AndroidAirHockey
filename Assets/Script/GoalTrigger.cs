using UnityEngine;
using System.Collections;

public enum Player
{
	One,
	Two
}

public class GoalTrigger : MonoBehaviour {

	public Player player;
	private GoalManager GM;

	private void Start()
	{
		GM = GameObject.FindGameObjectWithTag("GoalManager").GetComponent<GoalManager>();
	}

	private void OnTriggerEnter(Collider col)
	{
		if(col.transform.tag == "Ball")
		{
			GM.Score(player);
		}
	}
}
