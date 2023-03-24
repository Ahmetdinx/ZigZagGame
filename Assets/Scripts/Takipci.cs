using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takipci : MonoBehaviour
{
    [SerializeField] Transform takipEdilen;
    [SerializeField] private Vector3 mesafe;

    void Start()
    {
        mesafe = transform.position - takipEdilen.position;
    }

    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (KureHareket.dusme == true)
        {
            return;
        }
        transform.position = takipEdilen.position + mesafe;

    }
}
