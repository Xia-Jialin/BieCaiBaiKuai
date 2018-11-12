using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sudukongzhi : MonoBehaviour {
    /// <summary>
    /// 初始速度
    /// </summary>
    public static float kongzhi;
    /// <summary>
    /// 普通模式速度增量
    /// </summary>
    public float runSpeedDelta = 0.003f;
    /// <summary>
    /// 极速模式速度增量
    /// </summary>
    public float runSpeedDelta2 = 0.01f;
    public static bool MoShiKaiGuan;
    /// <summary>
    /// 最大速度
    /// </summary>
    float maxSpeed = 1.0f;
    
    // Use this for initialization
    void Start () {
        kongzhi = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
        if (MoShiKaiGuan)
        {
            if (kongzhi < maxSpeed)
            {
                kongzhi += runSpeedDelta * Time.deltaTime;
                //print(kongzhi);
            }
        }
        else
        {
            if (kongzhi < maxSpeed)
            {
                kongzhi += runSpeedDelta2 * Time.deltaTime;
                //print(kongzhi);
            }
        }
        
    }

}
