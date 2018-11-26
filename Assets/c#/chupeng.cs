using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chupeng : MonoBehaviour {
    private chuangjian a;
    /// <summary>
    /// 模块点击开关
    /// </summary>
    public static bool b;
    /// <summary>
    /// 地雷模式开关
    /// </summary>
    public static bool c;
    // Use this for initialization
    void Start () {
        GameObject game = GameObject.Find("yindao");
        a = game.GetComponent<chuangjian>();
        b = true;
    }
	
	// Update is called once per frame
	void Update () {
      
    }
    private void OnMouseDown()
    {
        //判断游戏是否未结束
        if (b)
        {
            //判断游戏模式，是创建普通块，否随机创建地雷块
            if (c)
            {
                Destroy(this.gameObject);
                a.DiLei();
                fenshu.defen += 1;
            }
            else
            {
                Destroy(this.gameObject);
                a.Cj();
                fenshu.defen += 1;
            }
           
        }
       
    }

}
