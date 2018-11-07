using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chupeng : MonoBehaviour {
    private chuangjian a;
    public static bool b=true;
    // Use this for initialization
    void Start () {
        GameObject game = GameObject.Find("yindao");
        a = game.GetComponent<chuangjian>();
    }
	
	// Update is called once per frame
	void Update () {
      
    }
    private void OnMouseDown()
    {
        if (b)
        {
            Destroy(this.gameObject);
            a.Cj();
        }
       
    }

}
