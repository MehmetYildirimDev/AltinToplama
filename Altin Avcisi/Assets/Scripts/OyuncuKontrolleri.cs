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
    
    // Update is called once per frame
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
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("altin"))
        {
            oyunK.AltinSayasi++;
        }
        else if (c.gameObject.tag.Equals("dusman"))
        {
            oyunK.OyunAktif = false;
        }
    }
}
