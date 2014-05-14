using UnityEngine;
using System.Collections;

public class HUDFPS : MonoBehaviour 
{
	
	float frameCount;
	float dt;
	float fps;
	float updateRate;  // 4 updates per sec.
	
	void Start()
	{
		 frameCount = 0f;
		 dt = 0.0f;
		 fps = 0.0f;
		 updateRate = 4.0f; 
		if( !guiText )
		{
			Debug.Log("UtilityFramesPerSecond needs a GUIText component!");
			enabled = false;
			return;
		}
	}
	
	void Update()
	{
		frameCount++;		
		dt +=Time.deltaTime;
		if(dt > 1.0f/updateRate)
		{
			fps = frameCount/dt;
			frameCount = 0;
			dt -= 1.0f/updateRate;
		}
		guiText.text = fps.ToString();
	}
}