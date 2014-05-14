using UnityEngine;
using System.Collections;

public class LaunchBullet : MonoBehaviour {

	BagBullets bag;
	// Use this for initialization
	void Start () {
		InvokeRepeating("Launch", 1f, 0.3f);
		bag = FindObjectOfType<BagBullets>();
	}

	void Launch()
	{
		GameObject go = bag.GetBullet();
		go.transform.position = this.transform.position;
		go.SetActive(true);
		bag.ReturnBullet(go, 2f);
	}
}
