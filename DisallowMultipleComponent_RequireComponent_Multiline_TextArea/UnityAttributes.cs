using UnityEngine;


[DisallowMultipleComponent]
[RequireComponent(typeof(Canvas))]
public class UnityAttributes : MonoBehaviour
{

    [Multiline]
    public string Multiline;

    [TextArea]
    public string TextArea ;

   
}



