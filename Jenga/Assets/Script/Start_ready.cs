using UnityEngine;
using System.Collections;

public class Start_ready : MonoBehaviour {
	public float layer = 5; //積む段数
	public float side = 3; //1段の本数
	float drop_height = 2; //初期位置（高度）
	public float blocksize = 0.5f; //ブロックのサイズ
	public GameObject myCube;
	
	// Use this for initialization
	void Start () {
		for(int i = 0; i < layer; i++){
			for(int x = 0; x < side; x++){
				if(i%2 == 0){
					Instantiate (myCube, new Vector3 (blocksize, transform.position.y + i*blocksize + drop_height, transform.position.z + (x*blocksize)), Quaternion.Euler (0, i*90, 0));
				}else{
					Instantiate (myCube, new Vector3 (transform.position.x + (x*blocksize), transform.position.y + i*blocksize + drop_height, blocksize), Quaternion.Euler (0, i*90, 0));
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
