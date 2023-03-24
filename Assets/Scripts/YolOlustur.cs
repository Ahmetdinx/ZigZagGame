using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YolOlustur : MonoBehaviour
{
    [SerializeField] GameObject sonYol;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            yolOlusturma();
        }
    }

   
    void Update()
    {
        
    }
    public void yolOlusturma()
    {
        Vector3 yon ;
        if (Random.Range(0,2)==0)
        {
            yon = Vector3.forward;
        }
        else
        {
            yon = Vector3.left;
        }

        
        
        sonYol = Instantiate(sonYol, sonYol.transform.position + yon , sonYol.transform.rotation);
    }
}
