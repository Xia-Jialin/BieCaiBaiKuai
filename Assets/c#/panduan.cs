using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panduan : MonoBehaviour {
    public  GameObject a;
    public Text text;
    public Text text2;
    private chuangjian v;
    // Use this for initialization
    void Start () {
        GameObject game = GameObject.Find("yindao");
        v = game.GetComponent<chuangjian>();
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
            v.DiLei();
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
