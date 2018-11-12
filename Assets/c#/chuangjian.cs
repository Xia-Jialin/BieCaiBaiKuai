using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chuangjian : MonoBehaviour {
    public   GameObject yindao1;
    public GameObject yindao2;
    static  GameObject roadGuideObj;
    static  Transform roadGuideTrans;

    // Use this for initialization
    void Start () {
        roadGuideObj = Instantiate(yindao1);
        roadGuideTrans = roadGuideObj.transform;
        for (int i = 0; i < 4; i++)
        {
            Cj();
        }
    }

    // Update is called once per frame
    void Update () {
       

    }
   
    public  void Cj()
    {
        int randomValue = Random.Range(0, 3);
        Vector3 a;
        switch (randomValue)
        {
            case 0:
                a = new Vector3(1.2f, roadGuideTrans.position.y, roadGuideTrans.position.z);
                Instantiate(yindao1, a, roadGuideTrans.rotation,transform);
                roadGuideTrans.position += new Vector3(0, 4.8f, 0);
                break;
            case 1:
                a = new Vector3(3.6f, roadGuideTrans.position.y, roadGuideTrans.position.z);
                Instantiate(yindao1, a, roadGuideTrans.rotation,transform);
                roadGuideTrans.position += new Vector3(0, 4.8f, 0);
                break;
            case 2:
                a = new Vector3(6f, roadGuideTrans.position.y, roadGuideTrans.position.z);
                Instantiate(yindao1, a, roadGuideTrans.rotation,transform);
                roadGuideTrans.position += new Vector3(0, 4.8f, 0);
                break;
        }
    }
    public void Cj2()
    {
        int randomValue = Random.Range(0, 3);
        Vector3 a;
        switch (randomValue)
        {
            case 0:
                a = new Vector3(1.2f, roadGuideTrans.position.y, roadGuideTrans.position.z);
                Instantiate(yindao2, a, roadGuideTrans.rotation, transform);
                roadGuideTrans.position += new Vector3(0, 4.8f, 0);
                break;
            case 1:
                a = new Vector3(3.6f, roadGuideTrans.position.y, roadGuideTrans.position.z);
                Instantiate(yindao2, a, roadGuideTrans.rotation, transform);
                roadGuideTrans.position += new Vector3(0, 4.8f, 0);
                break;
            case 2:
                a = new Vector3(6f, roadGuideTrans.position.y, roadGuideTrans.position.z);
                Instantiate(yindao2, a, roadGuideTrans.rotation, transform);
                roadGuideTrans.position += new Vector3(0, 4.8f, 0);
                break;
        }
    }
    public void DiLei()
    {
        int randomValue = Random.Range(0, 5);
        if (randomValue==3)
        {
            Cj2();
        }
        else
        {
            Cj();
        }
    }
}
