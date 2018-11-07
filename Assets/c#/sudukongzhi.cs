using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sudukongzhi : MonoBehaviour {
    /// <summary>
    /// 初始速度
    /// </summary>
    public static float kongzhi=0.1f;
    /// <summary>
    /// 速度增量
    /// </summary>
    float runSpeedDelta = 0.004f;
    /// <summary>
    /// 最大速度
    /// </summary>
    float maxSpeed = 1.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (kongzhi<maxSpeed)
        {
            kongzhi += runSpeedDelta * Time.deltaTime;
            //print(kongzhi);
        }
      
    }
}
