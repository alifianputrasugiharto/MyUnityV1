using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    public GameObject CanvasKalah;

    // Start is called before the first frame update
    void Start()
    {
        CanvasKalah.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToClicked()
    {
        Application.LoadLevel("menu");

    }

}
