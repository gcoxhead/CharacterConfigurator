using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField]

    private GameObject[] _UI;
    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {
        MenuUI();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MenuUI()
    {
        _UI[0].SetActive(true);
        _UI[1].SetActive(false);
        _UI[2].SetActive(false);
        _UI[3].SetActive(false);

    }
    public void CharCustGUI()
    {
        _UI[0].SetActive(false);
        _UI[1].SetActive(true);
        _UI[2].SetActive(false);
        _UI[3].SetActive(false);

    }

    public void ShieldGUI()
    {
        _UI[0].SetActive(false);
        _UI[1].SetActive(false);
        _UI[2].SetActive(true);
        _UI[3].SetActive(false);

    }

    public void SwordGUI()
    {
        _UI[0].SetActive(false);
        _UI[1].SetActive(true);
        _UI[2].SetActive(true);
        _UI[3].SetActive(true);
        
    }
}


