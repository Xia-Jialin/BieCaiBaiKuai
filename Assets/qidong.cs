using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class qidong : MonoBehaviour {
    public Sprite Image1;
    public Sprite Image2;
    /// <summary>
    /// 暂停开关
    /// </summary>
    private bool a;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /// <summary>
    /// 暂停开启/关闭
    /// </summary>
    public void zanting()
    {
        //是否暂停
        if (a)
        {
            this.GetComponent<Image>().sprite = Image1;
            yidong.kaiguan = true;
            chupeng.b = true;
            dibu.a = true;
            a = false;
        }
        else
        {
            this.GetComponent<Image>().sprite = Image2;
            yidong.kaiguan = false;
            chupeng.b = false;
            dibu.a = false;
            a = true;
        }
        
    }
}
