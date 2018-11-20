using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dibu : MonoBehaviour {
    private panduan c;
    public static bool a;
    // Use this for initialization
    void Start () {
        a = true;
        c = GameObject.Find("GameObject").GetComponent<panduan>();
    }

    // Update is called once per frame
    void Update () {
		
	}
    private void OnMouseDown()
    {
        print("123");
        if (a)
        {
            c.jiesuan();
        }
       
    }
}
