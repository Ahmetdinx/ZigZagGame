using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenkDegistir : MonoBehaviour
{
    [SerializeField] Color[] yolRenklerimiz;
    [SerializeField] Color[] topRenklerimiz;
    [SerializeField] Material yolMateryali;
    [SerializeField] Material topMareryali;
    int yolRenkSecimi;
    int topRenkSecimi;

    void Start()
    {
        yolRenkSecimi = Random.Range(0, 5);
        yolMateryali.color = yolRenklerimiz[yolRenkSecimi];

        topRenkSecimi = Random.Range(0, 5);
        topMareryali.color = topRenklerimiz[topRenkSecimi];
    }
}
