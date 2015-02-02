using UnityEngine;
using System.Collections;

public class PlayersController : MonoBehaviour {
	public GameObject player01;
	public GameObject player02;
	public float speed = 20;
	
	void Update () 
	{
		if(Input.GetMouseButton(0))
		{
			Vector3 mousePos = Input.mousePosition;
			Ray ray = Camera.main.ScreenPointToRay(mousePos);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				if(hit.transform.tag != "Player")
				{
					if(mousePos.x < Screen.width/2+50)//player 1 pos
					{
						Vector3 player01Movement = Vector3.MoveTowards(player01.transform.position,hit.point,speed * Time.deltaTime);
						player01.rigidbody.MovePosition(player01Movement);
					}
					if(mousePos.x > Screen.width/2-50)//player 2 pos
					{
						Vector3 player02Movement = Vector3.MoveTowards(player02.transform.position,hit.point,speed * Time.deltaTime);
						player02.rigidbody.MovePosition(player02Movement);
					} 
				}
			}
		}
	}
}
