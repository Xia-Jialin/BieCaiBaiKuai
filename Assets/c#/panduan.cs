using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panduan : MonoBehaviour {
    public  GameObject a;
    /// <summary>
    /// 游戏得分
    /// </summary>
    public Text text;
    /// <summary>
    /// 最高分
    /// </summary>
    public Text text2;
    /// <summary>
    /// 地雷块创建
    /// </summary>
    private chuangjian diLeiKuai;
    // Use this for initialization
    void Start () {
        GameObject game = GameObject.Find("yindao");
        diLeiKuai = game.GetComponent<chuangjian>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        //判断是否为地雷块
        if (col.tag=="dilei")
        {
            Destroy(col, 1f);
            diLeiKuai.DiLei();
            fenshu.defen += 1;
        }
        else
        {
            jiesuan();
        }
       
    }
    /// <summary>
    /// 对游戏得分进行结算
    /// </summary>
    public void jiesuan()
    {
        yidong.kaiguan = false;
        chupeng.b = false;
        dibu.a = false;
        a.SetActive(true);
        int zuigao = PlayerPrefs.GetInt("zuigao");
        text.text = fenshu.defen.ToString();
        if (fenshu.defen>zuigao)
        {
            PlayerPrefs.SetInt("zuigao", fenshu.defen);
        } 
        text2.text= PlayerPrefs.GetInt("zuigao").ToString();
    }
}
