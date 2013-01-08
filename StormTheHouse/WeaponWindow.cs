using UnityEngine;
using System.Collections;

public class WeaponWindow : MonoBehaviour
{
	Ray ray;
	RaycastHit hit;
	public GameObject Window;
	public GameObject Enemy;
	public int cagePrice = 500;
	public int wallUpgradePrice = 800;
	int p = 1;
	
	void Update ()
	{
		ray = Camera.main.ScreenPointToRay (Input.mousePosition); 
		//проверка на клик
		if (Input.GetMouseButtonDown (0)) {
			//проверка на клик по ГО  или по пустому полю
			if (Physics.Raycast (ray, out hit, 1000)) {
				switch (hit.collider.gameObject.name) {
				case "ClipSize": {
						// увеличивает объем обоймы
						// создать переменную которая будет задавать на сколько увеличить объем обоймы
						GameObject go = GameObject.Find ("House");
						Player pl = (Player)go.GetComponent (typeof(Player));
						if (pl.Money != 0) {
							if (pl.Money >= cagePrice) {
								pl.Money -= cagePrice;
								pl.cage += 1;
								pl.currentCage = pl.cage;
							}
						}
					}
					break;
					
				case "CraftMan":{
						Debug.Log ("CraftMan");
					}
					break;
					
				case "GunMan":{
						//помогает убивать врагов, сделать AI бота стрельбы по врагам
					}
					break;
					
				case "MissileSite":{
						Debug.Log ("MissileSite");
					}
					break;
					
				case "Repair":{
						Debug.Log ("Repair");
					}
					break;
					
				case "SniperRifle":{
						Debug.Log ("SniperRifle");
					}
					break;
					
				case "UpgradeHouse":{
						Debug.Log ("UpgradeHouse");
					}
					break;
					
				case "UpgradeWall":{
						// чинит заграждение добавляя разные картинки и увеличивая количество жизни самого заграждения
						GameObject fence = GameObject.Find ("Fence");
						MoveSprites move = (MoveSprites)fence.GetComponent (typeof(MoveSprites));
						GameObject house = GameObject.Find ("House");
						Player play = (Player)house.GetComponent (typeof(Player));
						Block block = (Block)fence.GetComponent (typeof(Block));
						if (p != 3) {
							if (p <= 3) {
								if (play.Money != 0) {
									if (play.Money >= wallUpgradePrice) {
										play.Money -= wallUpgradePrice;
										move.AnimationPlayNumber = p++;
										if (block.MaxHealth >= 200) {
											block.MaxHealth = block.MaxHealth;
										} else {
											block.MaxHealth += 50;
										}
									}
								}
							}
						}
					}
					break;
				
				case "DoneBtn":{
						//запускает всю игру
						GameObject go = GameObject.Find ("Skyes");
						SkyesMove skyMove = (SkyesMove)go.GetComponent (typeof(SkyesMove));
						skyMove.Speed = 1f;
						skyMove.RepeatTime = 10f;
						skyMove.StartTime = 3f;
						Window.SetActive (false);
						Enemy.SetActive (true);
					}
					break;
				}
			}	
		}
	}
}
