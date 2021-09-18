using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject CreditPanel;
    public GameObject HowtoPanel;
    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        CreditPanel.SetActive(false);
        HowtoPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButtonClicked()
    {
        Application.LoadLevel("BrightDay");

    }
    public void CreditButtonClicked()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(true);
        HowtoPanel.SetActive(false);
    }
    public void HowtoButtonClicked()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(false);
        HowtoPanel.SetActive(true);
    }
    public void BackClicked()
    {
        MenuPanel.SetActive(true);
        CreditPanel.SetActive(false);
        HowtoPanel.SetActive(false);
    }
}
