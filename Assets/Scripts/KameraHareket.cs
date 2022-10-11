using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareket : MonoBehaviour
{
    // Bu kod ile kameranýn tanký takip etmesini saðlayacaðýz.
    // Her frame gösteriminde kameranýn pozisyonunu, tankýn pozisyonuna uygun þekilde deðiþtireceðiz.
    // Kameranýn aracý biraz arkadan ve yukarýdan takip etmesi için bir offset vektorü tanýmlayýp bunu kullanacaðýz.

    // ÖNEMLÝ
    // Bu scripti Camera nesnesine sürükleyip býrakýn.
    // Camera nesnesini seçip, tank bölümüme, sahnedeki tanký sürükleyip býrakýn.

    public GameObject tank; // Yazdýðýmýz kodlarýn tankýn pozisyonuna eriþebilmesi için, tank nesnesi ile arasýnda bir baðlantý olmalýdýr.
    public Vector3 offset = new Vector3(0f, 6f, -20f);


    void Start()
    {
        
    }

    void Update()
    {
        transform.position = tank.transform.position + offset;        
    }
}
