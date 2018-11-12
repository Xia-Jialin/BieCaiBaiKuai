using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yidong : MonoBehaviour {
    public static bool kaiguan;
	// Use this for initialization
	void Start () {
        kaiguan = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (kaiguan){
            transform.position = new Vector2(transform.position.x, transform.position.y - sudukongzhi.kongzhi);
        }
    }
}
