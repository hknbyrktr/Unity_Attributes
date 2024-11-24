using UnityEngine;



public class UnityAttributes : MonoBehaviour
{

    [SerializeField]                               // Sadece Inspector' den ulaşılabilir.
    private int x;

    [HideInInspector]                              // Sadece Inspector' den ulaşılamaz.
    public int y;

    
}



public class Deneme 
{

    static void Main(string[] args)
    {
        UnityAttributes attributes = new UnityAttributes();             // UnityAttributes class' dan nesnemizi oluşturduk.

        attributes.x = 1;




        attributes.y = 1;

    }

    
}





