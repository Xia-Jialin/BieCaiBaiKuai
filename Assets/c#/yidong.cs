using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yidong : MonoBehaviour {
    /// <summary>
    /// 移动开关
    /// </summary>
    public static bool kaiguan;
	// Use this for initialization
	void Start () {
        kaiguan = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (kaiguan){
            //块移动
            transform.position = new Vector2(transform.position.x, transform.position.y - sudukongzhi.kongzhi);
        }
    }
}
