using UnityEngine;
using System.Collections.Generic;
using System;
using System.Collections;

public class BagBullets : MonoBehaviour {


	GameObject bullet;
	GameObject clonedBullet;
	Queue<GameObject> bullets;
	// Use this for initialization
	void Start () {
		bullets = new Queue<GameObject>();
		bullet = (GameObject)Resources.Load("Bullet");
		for(int i = 0; i < 300; i++)
		{
			clonedBullet = (GameObject)Instantiate(bullet, new Vector3(-100,-100,-100), Quaternion.identity);
			clonedBullet.SetActive(false);
			bullets.Enqueue(clonedBullet);
		}
	}
	
	public GameObject GetBullet()
	{
		if(bullets.Count > 0)
			return bullets.Dequeue();

		if(bullets.Count < 20)
			StartCoroutine(Reload());
		return GetBullet();
	}

	public IEnumerator Reload()
	{
		for(int i = 0; i < 20; i++)
		{
			clonedBullet = (GameObject)Instantiate(bullet, new Vector3(-100,-100,-100), Quaternion.identity);
			clonedBullet.SetActive(false);
			bullets.Enqueue(clonedBullet);
		}
		yield return null;
	}

	public IEnumerator ReturnBullet(GameObject go, float seconds)
	{
		yield return new WaitForSeconds(seconds);
		go.transform.position = new Vector3(-100,-100,-100);
		go.SetActive(false);
		bullets.Enqueue(go);
	}
}
