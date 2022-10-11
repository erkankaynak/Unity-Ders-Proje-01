using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    // Deðiþkenleri publi tanýttýðýmýzda Inspector kýsmýnda görebilir ve deðiþtirebiliriz.
    // Bunun bir diðer yolu da tanýmýn baþýna [SerializeField] yazmaktýr.

    // [SerializeField] float speed = 10f;
    public float hiz = 10f;



    // Bu metot Update metodu ilk kez çalýþmadan hemen önce çalýþýr.
    void Start()
    {
        // UNÝTY 'nin Console (konsol) kýsmýna mesaj yazmak için Debug.Log() komutu kullanýlýr.
        Debug.Log("Hareket Scripti çalýþtý.");
    }

    // Bu metot her frame tekrarlanýr.

    private void Update()
    {

    }

    // Aþaðýdaki kodlarý kesip Update içerisine yapýþtýrýp bir de o þekilde çalýþtýrýp, ne fark olduðunuza bakýnýz.
    void FixedUpdate() 
    {
        // gameObject   : Bu scriptin çalýþtýðý nesne
        // transform    : Nesnenin transform bileþeni. Bu bileþen nesnenin konumunu, rotasyonunu ve boyularýnýn ayarlandýðý yerdir.
        // Translate    : Nesnenin konumunu deðiþtiren metottur. Nesnenin gideceði yön Vector olarak ifade edilir.

        gameObject.transform.Translate(Vector3.forward * hiz *  Time.deltaTime);


        // Input.GetKey()       : Klavyede bir tuþa basýk tutulduðunda aktif olur. 
        // transform.rotation   : Nesnenin rotasyon bilgileri. Bunlarý deðiþtirerek nesneyi belirli bir açýda döndürüyoruz.


        // W tuþuna basýk tutulursa yapýlacak olanlarý yazýyoruz.
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // Aracýn yönünü ileri olarka ayarla.

            if (hiz < 100)
                hiz += 2f; // Eðer hýz 100 den küçükse hýzý arttýr
        }

        // S tuþuna basýk tutulursa yapýlacak olanlarý yazýyoruz.
        if (Input.GetKey(KeyCode.S))
        {
            if (hiz > -1)
                hiz -= 2f; // Eðer hýz sýfýrdan büyükse hýzý azalt.
        }


        // A tuþuna basýk tutulursa yapýlacak olanlarý yazýyoruz.
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, -15f, 0f); // Y ekseninde 15 derece sola döndür.
        }

        // A tuþuna basýk tutulursa yapýlacak olanlarý yazýyoruz.
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, 15f, 0f); // Y Ekseninde 15 derece saða döndür.
        }
    }
}
