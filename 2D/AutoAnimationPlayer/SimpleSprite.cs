using UnityEngine;
using System.Collections;

public class SimpleSprite : MonoBehaviour
{
	public Texture[] animation0;
	public Texture[] animation1;
	public Texture[] animation2;
	public Texture[] animation3;
	public Texture[] animation4;
	public Texture[] animation5;
	public float animationSpeed = 10;
	private int animationPlay;
	
	void PrePlay ()
	{
		StopAllCoroutines ();
	}
	
	public  IEnumerator  PlayAnimation (int animationPlay)
	{
		while (true) {
			if (animationPlay == 0) {
				int index0 = (int)(Time.time * animationSpeed);
				index0 = index0 % animation0.Length;
				renderer.material.mainTexture = animation0 [index0];
			}
			if (animationPlay == 1) {
				int index1 = (int)(Time.time * animationSpeed);
				index1 = index1 % animation1.Length;
				renderer.material.mainTexture = animation1 [index1];
			}
			if (animationPlay == 2) {
				int index2 = (int)(Time.time * animationSpeed);
				index2 = index2 % animation2.Length;
				renderer.material.mainTexture = animation2 [index2];
			}
			if (animationPlay == 3) {
				int index3 = (int)(Time.time * animationSpeed);
				index3 = index3 % animation3.Length;
				renderer.material.mainTexture = animation3 [index3];
			}
			if (animationPlay == 4) {
				int index4 = (int)(Time.time * animationSpeed);
				index4 = index4 % animation4.Length;
				renderer.material.mainTexture = animation4 [index4];
			}
			if (animationPlay == 5) {
				int index5 = (int)(Time.time * animationSpeed);
				index5 = index5 % animation5.Length;
				renderer.material.mainTexture = animation5 [index5];
			}		
			yield return new WaitForSeconds(0);
		} 
	}
	
	public void SetSpeed (float speed)
	{
		animationSpeed = speed;	
	}
}
