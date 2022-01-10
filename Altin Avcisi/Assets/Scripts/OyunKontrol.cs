using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public bool OyunAktif = false;
    public int AltinSayasi = 0;
    public UnityEngine.UI.Text altin;
    public UnityEngine.UI.Button BaslaButtonu;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
        //  GetComponent<AudioSource>().Stop();///Durdurmak için
       // GetComponent<AudioSource>().Pause();///kaldýgý yerden daha sonr devam etmesi için
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AltinArtir()
    {
        AltinSayasi++;  
        altin.text ="Altin: "+ AltinSayasi.ToString();
    }
    public void OyunaBasla()
    {
        OyunAktif = true;
        BaslaButtonu.gameObject.SetActive(false);//butonu pasif hale getiriyoruz
    }
}
