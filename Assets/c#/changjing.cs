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
    /// <summary>
    /// 重启游戏界面
    /// </summary>
    public void shuaxin()
    {
        SceneManager.LoadScene("123");
    }
    /// <summary>
    /// 打开主页面
    /// </summary>
    public void zhuyemian()
    {
        SceneManager.LoadScene("main");
    }
    /// <summary>
    /// 打开经典模式
    /// </summary>
    public void jingdian()
    {
        sudukongzhi.MoShiKaiGuan=true;
        chupeng.c = true;
        SceneManager.LoadScene("123");
    }
   /// <summary>
   /// 打开极速模式
   /// </summary>
    public void jisu()
    {
        chupeng.c = true;
        sudukongzhi.MoShiKaiGuan = false;
        SceneManager.LoadScene("123");
    }
    /// <summary>
    /// 打开地雷模式
    /// </summary>
    public void dilei()
    {
        chupeng.c = false;
        sudukongzhi.MoShiKaiGuan = true;
        SceneManager.LoadScene("123");
    }
    /// <summary>
    /// 退出程序
    /// </summary>
    public void tuichu()
    {
        Application.Quit();
    }
}
