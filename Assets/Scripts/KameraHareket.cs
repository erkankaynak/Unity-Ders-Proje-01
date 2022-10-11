using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareket : MonoBehaviour
{
    // Bu kod ile kameran�n tank� takip etmesini sa�layaca��z.
    // Her frame g�steriminde kameran�n pozisyonunu, tank�n pozisyonuna uygun �ekilde de�i�tirece�iz.
    // Kameran�n arac� biraz arkadan ve yukar�dan takip etmesi i�in bir offset vektor� tan�mlay�p bunu kullanaca��z.

    // �NEML�
    // Bu scripti Camera nesnesine s�r�kleyip b�rak�n.
    // Camera nesnesini se�ip, tank b�l�m�me, sahnedeki tank� s�r�kleyip b�rak�n.

    public GameObject tank; // Yazd���m�z kodlar�n tank�n pozisyonuna eri�ebilmesi i�in, tank nesnesi ile aras�nda bir ba�lant� olmal�d�r.
    public Vector3 offset = new Vector3(0f, 6f, -20f);


    void Start()
    {
        
    }

    void Update()
    {
        transform.position = tank.transform.position + offset;        
    }
}
