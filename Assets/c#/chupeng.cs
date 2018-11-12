using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chupeng : MonoBehaviour {
    private chuangjian a;
    public static bool b;
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
        if (b)
        {
            if (c)
            {
                Destroy(this.gameObject);
                a.Cj();
                fenshu.defen += 1;
            }
            else
            {
                Destroy(this.gameObject);
                a.DiLei();
                fenshu.defen += 1;
            }
           
        }
       
    }

}
