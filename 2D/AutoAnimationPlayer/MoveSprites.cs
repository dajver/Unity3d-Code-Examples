using UnityEngine;
using System.Collections;

public class MoveSprites : MonoBehaviour
{
	public int AnimationPlayNumber = 0;
	
	void Update ()
	{
		BroadcastMessage ("PrePlay");
		BroadcastMessage ("PlayAnimation", AnimationPlayNumber);
	}
}