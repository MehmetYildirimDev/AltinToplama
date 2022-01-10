using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrolleri : MonoBehaviour
{
    public OyunKontrol oyunK;
    

    float hiz = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        if (oyunK.OyunAktif)
        {  

        
        //Klavyeden girdileri al�yoruz
        float x = Input.GetAxis("Horizontal");//Sa� sol tu�undan gelen bilgiler -sa� sol
        float y = Input.GetAxis("Vertical");//yukar� a�a�� tusundan gelen bilgiler-ileri geri 
        x *= Time.deltaTime * hiz;//daha yumu�ak bir ge�i� i�in bunu yapt�k
        y *= Time.deltaTime * hiz;

        transform.Translate(x, 0f, y);//konumu cevirmek yan� degistirmek diyor san�r�m-yukseklikte bir de�i�iklik yapmad�g�m� �c�n 0f verdik
        }
    }
    public AudioClip altin, dusme;
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("altin"))
        {
            AudioSource.PlayClipAtPoint(altin, transform.position);//altin sesini olusutur positionda  ///ge�i�i bir audio source olusturulup sonra yok ediliyor
            oyunK.AltinArtir();
            Destroy(c.gameObject);
        }
        else if (c.gameObject.tag.Equals("dusman"))
        {
            AudioSource.PlayClipAtPoint(dusme, transform.position);
            oyunK.OyunAktif = false;
        }
    }
}
