using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class ChangeSceneOnRightClick : MonoBehaviour {

	public string targetSceneName;

	// Called when mouse is over this gameObject
	void OnMouseOver(){
		if(Input.GetMouseButtonDown(1)){
			SceneManager.LoadScene(targetSceneName);
		}
	}
}
