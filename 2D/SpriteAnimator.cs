using UnityEngine;
using System.Collections;

public class SpriteAnimator : MonoBehaviour
{
	public int columns = 3;
	public int rows = 4;
	public float Speed = 10f;
 
	//текущий фрейм на экран
	private int currentFrame = 0;
 
	void Start ()
	{
		StartCoroutine (updateTiling ());
 
		//выставляем сколько будет показывать картинок на один спрайт
		Vector2 size = new Vector2 (1f / columns, 1f / rows);
		renderer.sharedMaterial.SetTextureScale ("_MainTex", size);
	}
 
	private IEnumerator updateTiling ()
	{
		while (true) {
			//перемещаемся к следующей картинке
			currentFrame++;
			if (currentFrame >= rows * columns)
				currentFrame = 0;
 
			//разрезаем фрейм на х и у координаты
			Vector2 offset = new Vector2 ((float)currentFrame / columns - (currentFrame / columns), //x currentFrame 
                                          (currentFrame / columns) / (float)rows);          		//y currentFrame 
 
			renderer.sharedMaterial.SetTextureOffset ("_MainTex", offset);
 
			yield return new WaitForSeconds(1f / Speed);
		}
 
	}
}
