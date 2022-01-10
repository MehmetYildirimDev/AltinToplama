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

        
        //Klavyeden girdileri alýyoruz
        float x = Input.GetAxis("Horizontal");//Sað sol tuþundan gelen bilgiler -sað sol
        float y = Input.GetAxis("Vertical");//yukarý aþaðý tusundan gelen bilgiler-ileri geri 
        x *= Time.deltaTime * hiz;//daha yumuþak bir geçiþ için bunu yaptýk
        y *= Time.deltaTime * hiz;

        transform.Translate(x, 0f, y);//konumu cevirmek yaný degistirmek diyor sanýrým-yukseklikte bir deðiþiklik yapmadýgýmý ýcýn 0f verdik
        }
    }
    public AudioClip altin, dusme;
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("altin"))
        {
            AudioSource.PlayClipAtPoint(altin, transform.position);//altin sesini olusutur positionda  ///geçiçi bir audio source olusturulup sonra yok ediliyor
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
