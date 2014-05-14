using UnityEngine;
using System.Collections;

public class InterfaceController : MonoBehaviour {



	void OnGUI()
	{
		if(GUI.Button(new Rect((Screen.height/2)+50,( Screen.height/2) +50, 100, 50), "Slow Mode"))
			Application.LoadLevel("SlowMode");
		if(GUI.Button(new Rect((Screen.height/2)+50,( Screen.height/2) -50, 100, 50), "Fast Mode"))
			Application.LoadLevel("FastMode");
	}
}
