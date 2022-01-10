using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{

    public OyunKontrol OyunK;

    float hassasiyet = 5f;
    float yumusaklik = 2f;

    Vector2 GecisPos;
    Vector2 camPos;

    GameObject Oyuncu;
    // Start is called before the first frame update
    void Start()
    {
        Oyuncu = transform.parent.gameObject;//kameranýn baðlý oldugu(biz baðladýk ) parent game objectene baðladýk 

        camPos.y = 9;///BURADA
    }

    // Update is called once per frame
    void Update()
    {
        if (OyunK.OyunAktif)
        {

        

        Vector2 farePos = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));//Farenin ilk konumuna göre yeni bir nokta oluþturuyoruz 
        farePos = Vector2.Scale(farePos, new Vector2(yumusaklik * hassasiyet,yumusaklik*hassasiyet));
        //Bu noktamýz uzerinde scale komutuyla uzerinde bir degiþiklik geniþletme iþlemi yapýcaz ///bunu daha gerçeðe yakýn bir hareket için yapýcaz    
        GecisPos.x = Mathf.Lerp(GecisPos.x, farePos.x, 1f / yumusaklik);
        //lerp animasyon içindi ->GecisPos.x   den  GecisPos.y geçiþi  1f/yumusaklik sürede yapýyor --> daha gercekci bir görünü için
        GecisPos.y = Mathf.Lerp(GecisPos.y, farePos.y, 1f / yumusaklik);

        camPos += GecisPos;//bunu neden yaptýk anlamadým

        transform.localRotation = Quaternion.AngleAxis(-camPos.y, Vector3.right);//local olma sebebi kendi ekseni -> right anlamý x ekseni demek 
        //Kameramýzý yukarý assagý dogru haraket etirirken faremizden aldýgýmýz y deðeri göre olusturdugumuz y degerini kullanarak kemaramýzý asagý yukarý haraket ettirmiþ olucaz
        ///sað sol için oyuncunun yönunu deðiþtiricez
        ///
        Oyuncu.transform.localRotation = Quaternion.AngleAxis(camPos.x, Oyuncu.transform.up);//Oyuncuyu dönderiyoruz 
        }
    }
}
