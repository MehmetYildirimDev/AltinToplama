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

        
        //Klavyeden girdileri alýyoruz
        float x = Input.GetAxis("Horizontal");//Sað sol tuþundan gelen bilgiler -sað sol
        float y = Input.GetAxis("Vertical");//yukarý aþaðý tusundan gelen bilgiler-ileri geri 
        x *= Time.deltaTime * hiz;//daha yumuþak bir geçiþ için bunu yaptýk
        y *= Time.deltaTime * hiz;

        transform.Translate(x, 0f, y);//konumu cevirmek yaný degistirmek diyor sanýrým-yukseklikte bir deðiþiklik yapmadýgýmý ýcýn 0f verdik
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
