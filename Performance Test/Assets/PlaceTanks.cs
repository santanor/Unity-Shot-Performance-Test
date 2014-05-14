using UnityEngine;
using System.Collections;

public class PlaceTanks : MonoBehaviour {

	float currentFilePos;
	int counter;
	float currentColumnPos;
	// Use this for initialization
	void Start () {
		currentFilePos = 15f;
		counter = 0;
		currentColumnPos = 120f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.Space))
		{

			GameObject go = (GameObject)Resources.Load("Tank");
			Instantiate(go, new Vector3(currentColumnPos, 0, currentFilePos), Quaternion.identity);
			currentColumnPos += 3f;
			counter ++;
			if (counter >= 10)
			{
				currentColumnPos = 120f;
				currentFilePos += 5f;
				counter = 0;
			}


		}
	}
}
