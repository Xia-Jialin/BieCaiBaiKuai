using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changjing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void shuaxin()
    {
        SceneManager.LoadScene("123");
    }
    public void zhuyemian()
    {
        SceneManager.LoadScene("main");
    }
    public void jingdian()
    {
        sudukongzhi.MoShiKaiGuan=true;
        chupeng.c = true;
        SceneManager.LoadScene("123");
    }
   
    public void jisu()
    {
        chupeng.c = true;
        sudukongzhi.MoShiKaiGuan = false;
        SceneManager.LoadScene("123");
    }
    public void dilei()
    {
        chupeng.c = false;
        sudukongzhi.MoShiKaiGuan = true;
        SceneManager.LoadScene("123");
    }
    public void tuichu()
    {
        Application.Quit();
    }
}
