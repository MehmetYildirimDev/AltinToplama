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
        Oyuncu = transform.parent.gameObject;//kameran?n ba?l? oldugu(biz ba?lad?k ) parent game objectene ba?lad?k 

        camPos.y = 9;///BURADA
    }

    // Update is called once per frame
    void Update()
    {
        if (OyunK.OyunAktif)
        {

        

        Vector2 farePos = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));//Farenin ilk konumuna g?re yeni bir nokta olu?turuyoruz 
        farePos = Vector2.Scale(farePos, new Vector2(yumusaklik * hassasiyet,yumusaklik*hassasiyet));
        //Bu noktam?z uzerinde scale komutuyla uzerinde bir degi?iklik geni?letme i?lemi yap?caz ///bunu daha ger?e?e yak?n bir hareket i?in yap?caz    
        GecisPos.x = Mathf.Lerp(GecisPos.x, farePos.x, 1f / yumusaklik);
        //lerp animasyon i?indi ->GecisPos.x   den  GecisPos.y ge?i?i  1f/yumusaklik s?rede yap?yor --> daha gercekci bir g?r?n? i?in
        GecisPos.y = Mathf.Lerp(GecisPos.y, farePos.y, 1f / yumusaklik);

        camPos += GecisPos;//bunu neden yapt?k anlamad?m

        transform.localRotation = Quaternion.AngleAxis(-camPos.y, Vector3.right);//local olma sebebi kendi ekseni -> right anlam? x ekseni demek 
        //Kameram?z? yukar? assag? dogru haraket etirirken faremizden ald?g?m?z y de?eri g?re olusturdugumuz y degerini kullanarak kemaram?z? asag? yukar? haraket ettirmi? olucaz
        ///sa? sol i?in oyuncunun y?nunu de?i?tiricez
        ///
        Oyuncu.transform.localRotation = Quaternion.AngleAxis(camPos.x, Oyuncu.transform.up);//Oyuncuyu d?nderiyoruz 
        }
    }
}
