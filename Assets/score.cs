using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    Text text;
    public static int book1A = 0;
    
    
    

    void Start (){
        text = GetComponent <Text> ();
    }

    void Update (){
        text.text = book1A.ToString ();
        
        
        
    }
}
