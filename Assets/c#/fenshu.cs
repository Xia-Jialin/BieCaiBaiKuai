using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fenshu : MonoBehaviour {
    /// <summary>
    /// 游戏得分
    /// </summary>
    public static int defen;
   
    private Text text;
	// Use this for initialization
	void Start () {
        defen = 0;
        text = GameObject.Find("fenshu").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = defen.ToString();
	}
    
}
