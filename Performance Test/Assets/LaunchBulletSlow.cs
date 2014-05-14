using UnityEngine;
using System.Collections;

public class LaunchBulletSlow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("Launch", 1f, 0.2f);
	}
	
	void Launch()
	{
		GameObject go = (GameObject)Resources.Load("Bullet");
		GameObject clonedBullet = (GameObject)Instantiate(go, this.transform.position, Quaternion.identity);
		Destroy(clonedBullet, 1f);
	}
}
