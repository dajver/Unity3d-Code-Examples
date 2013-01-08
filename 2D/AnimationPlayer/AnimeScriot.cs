using UnityEngine;
using System.Collections;

public class AnimeScriot : MonoBehaviour
{
	
	public int columnSize = 1;					//x (u) координата
	public int rowSize = 6;						//y (v) координата
	public int colFrameStart = 0;				//координата по х начального кадра
	public int rowFrameStart = 0;				//координата по у начального кадра
	public int totalFrame = 6;					//количество кадров анимации
	public float framesPerSecond = 10f;			//скорость анимации
	
	void Update ()
	{
		aniSprite(columnSize, rowSize, colFrameStart, rowFrameStart, totalFrame, framesPerSecond);	
	}

	public void aniSprite (int columnSize, int rowSize, int colFrameStart, int rowFrameStart, 
						   int totalFrames, float framesPerSecond)
	{
		
		int index = (int)(Time.time * framesPerSecond);   			 				// номер кадра в анимации
		index = index % totalFrames;   							 	 				// деление с остатком
	   	
		int u = index % columnSize;
		int v = index / columnSize;
		Vector2 size = new Vector2 (1.0f / columnSize, 1.0f / rowSize);    		// расчет масштаба
		Vector2 offset = new Vector2 ((u + colFrameStart) * size.x,
	   	                          	(1 - size.y) - (v + rowFrameStart) * size.y);   // расчет смещения
	   	
		renderer.material.mainTextureOffset = offset;   			 				// смещение текстуры
		renderer.material.mainTextureScale = size;   				 				// масштаб текстуры
	}
}
