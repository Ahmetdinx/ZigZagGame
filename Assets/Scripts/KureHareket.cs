using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KureHareket : MonoBehaviour
{
    private Vector3 yon;
    [SerializeField] float hiz;
    [SerializeField] YolOlustur yolOlusturuyoruz;
    [SerializeField] Text skorumuz;
    public static bool dusme;
    int skor;
    [SerializeField] Text enYuksekSkorumuz;
    [SerializeField] int enYuksekSkor;

    void Start()
    {
        yon = Vector3.forward;
        dusme = false;
        enYuksekSkor = PlayerPrefs.GetInt("enyuksekskor");
        enYuksekSkorumuz.text = enYuksekSkor.ToString();
    }

    
    void Update()
    {
        if (dusme == true)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (yon.x == 0)  // x e gitmiyorum z ye gidiyorum.
            {
                yon = Vector3.left;
            }
            else  //x yönünde gidiyorum.
            {
                yon = Vector3.forward;
            }

        }


        if (transform.position.y < -7f)
        {
            Destroy(this.gameObject);
            dusme = true;
            if (enYuksekSkor < skor)
            {
                enYuksekSkor = skor;
                PlayerPrefs.SetInt("enyuksekskor", enYuksekSkor);
            }
        }
    }



    void FixedUpdate()
    {
        if (dusme == true)
        {
            return;
        }
        if (( (skor % 10 ) == 0) && skor != 0)
        {
            hiz += 0.008f;
        }
      
        Vector3 kureMove = yon * Time.deltaTime * hiz;
        transform.position += kureMove;
    }



    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Yol")
        {
            StartCoroutine(YokEt(collision.gameObject));
            yolOlusturuyoruz.yolOlusturma();
            skor++;
            skorumuz.text = skor.ToString();
        }
        
    }



    IEnumerator YokEt(GameObject yokEdilecekYol)
    {
        yield return new WaitForSeconds(2f);
        yokEdilecekYol.AddComponent<Rigidbody>();
        yield return new WaitForSeconds(2f);
        Destroy(yokEdilecekYol);

    }
}
