using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupAnimasyonKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float sayac = 2f;
    // Update is called once per frame
    void Update()
    {   ///Sayac�m�z� 4 sny ile 2 san�ye aras�nda tekrar oynat�caz 
        sayac -= Time.deltaTime;
        if (sayac < 0)
        {
            GetComponent<Animator>().Play(0);// getcompenetle animatore ulas�p oyna dedik ( 0 sebebi 0. indis )
            sayac = Random.Range(4f, 6f);
        }
    }

}
