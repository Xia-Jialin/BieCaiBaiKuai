using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panduan : MonoBehaviour {
    GameObject a;
	// Use this for initialization
	void Start () {
        a = GameObject.Find("Canvas");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        yidong.kaiguan = false;
        chupeng.b = false;
    }
}
