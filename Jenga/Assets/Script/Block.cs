using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	void Start () {
		Color color;
		int color_set = Random.Range (0, 3);
		switch(color_set){
		case 0:
			color = Color.red;
			GetComponent<Renderer>().material.color = color;
			break;
		case 1:
			color = Color.green;
			GetComponent<Renderer>().material.color = color;
			break;
		case 2:
			color = Color.blue;
			GetComponent<Renderer>().material.color = color;
			break;
		}
	}

	void Update () {

	}
}
