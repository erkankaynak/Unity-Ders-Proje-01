using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    // De�i�kenleri publi tan�tt���m�zda Inspector k�sm�nda g�rebilir ve de�i�tirebiliriz.
    // Bunun bir di�er yolu da tan�m�n ba��na [SerializeField] yazmakt�r.

    // [SerializeField] float speed = 10f;
    public float hiz = 10f;



    // Bu metot Update metodu ilk kez �al��madan hemen �nce �al���r.
    void Start()
    {
        // UN�TY 'nin Console (konsol) k�sm�na mesaj yazmak i�in Debug.Log() komutu kullan�l�r.
        Debug.Log("Hareket Scripti �al��t�.");
    }

    // Bu metot her frame tekrarlan�r.

    private void Update()
    {

    }

    // A�a��daki kodlar� kesip Update i�erisine yap��t�r�p bir de o �ekilde �al��t�r�p, ne fark oldu�unuza bak�n�z.
    void FixedUpdate() 
    {
        // gameObject   : Bu scriptin �al��t��� nesne
        // transform    : Nesnenin transform bile�eni. Bu bile�en nesnenin konumunu, rotasyonunu ve boyular�n�n ayarland��� yerdir.
        // Translate    : Nesnenin konumunu de�i�tiren metottur. Nesnenin gidece�i y�n Vector olarak ifade edilir.

        gameObject.transform.Translate(Vector3.forward * hiz *  Time.deltaTime);


        // Input.GetKey()       : Klavyede bir tu�a bas�k tutuldu�unda aktif olur. 
        // transform.rotation   : Nesnenin rotasyon bilgileri. Bunlar� de�i�tirerek nesneyi belirli bir a��da d�nd�r�yoruz.


        // W tu�una bas�k tutulursa yap�lacak olanlar� yaz�yoruz.
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // Arac�n y�n�n� ileri olarka ayarla.

            if (hiz < 100)
                hiz += 2f; // E�er h�z 100 den k���kse h�z� artt�r
        }

        // S tu�una bas�k tutulursa yap�lacak olanlar� yaz�yoruz.
        if (Input.GetKey(KeyCode.S))
        {
            if (hiz > -1)
                hiz -= 2f; // E�er h�z s�f�rdan b�y�kse h�z� azalt.
        }


        // A tu�una bas�k tutulursa yap�lacak olanlar� yaz�yoruz.
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, -15f, 0f); // Y ekseninde 15 derece sola d�nd�r.
        }

        // A tu�una bas�k tutulursa yap�lacak olanlar� yaz�yoruz.
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.rotation = Quaternion.Euler(0f, 15f, 0f); // Y Ekseninde 15 derece sa�a d�nd�r.
        }
    }
}
