using System.Diagnostics;
using UnityEngine;


public class UnityAttributes : MonoBehaviour
{


    [Header("Isimler")]                                            // Degiskenleri kategorize etmek icin.
    public string osman;
    public string gültekin;

    [Header("Sayilar")]
    [Tooltip("Toplanacak sayilardan ilki.")]                       // Degiskenlere ipucu eklemek icin.
    public int sayi_1;

    [Tooltip("Toplanacak sayilardan ikincisi.")]
    public int sayi_2;



    private void Start()
    {

        int toplam = sayi_1 + sayi_2;

        Debug.Log("Sayıların Toplamı = " + toplam);

        Debug.Log("Sayıların Çarpımı = " + Carpım(4, 5));
    }




 


    /// <summary>                                                  // Degisken, Metod, Class ve Proporty lere aciklama eklemek icin.
    /// Bu metod verilen sayıları carpar.
    /// </summary>
    /// <returns>
    /// Carpımın sonucu.
    /// </returns>
    public int Carpım(int s_1, int s_2)
    {
        int carpım = s_1 * s_2;

        return carpım;
    }



}
