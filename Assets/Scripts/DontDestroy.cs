using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

	public string objectTag;

	void Awake() {

		GameObject[] objs = GameObject.FindGameObjectsWithTag(objectTag);
		if(objs.Length > 1){
			Destroy(this.gameObject);
		}
		DontDestroyOnLoad(this.gameObject); 

	}
}
