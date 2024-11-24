using UnityEngine;



[ExecuteInEditMode]  
public class UnityAttributes : MonoBehaviour
{

    [Range(0,100)]                         // Inspector' de slider için.
    public int speed;



    [Space(5)]                             // Inspector' de değişkenin üst boşluk mesafesi.
    public int x;
    [Space(15)]
    public int y;   
    [Space(25)]
    public int z;
    


    private void Update()                  // Klasik Update metodu ama her zaman çalışır.
    {
        Debug.Log("Hem Editörde hem de oyun sırasında çalışır !!!");
    }


}







