using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour
{
    
    public Button NextSceneButton;
    public Button RestartSceneButton;


    public int MaxItems = 4;
    private int _itemsCollected = 0;
    private int _playerHP = 10;

    public TMP_Text HealthText;
    public TMP_Text ItemText;
    public TMP_Text ProgressText;

    // Start is called before the first frame update
    void Start()
    {
        //ItemText.text += _itemsCollected;
       // HealthText.text = "Player Health: " + _playerHP;
    }

    
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            Debug.LogFormat("Items:{0}", _itemsCollected);
            ItemText.text = "Items Collected: " + Items;

            if (_itemsCollected >= MaxItems)
            {
                ProgressText.text = "You've found all the items!";
                NextSceneButton.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) + "more!";
            }
        }
    }

    
    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            HealthText.text = "Player Health: " + HP;
            Debug.LogFormat("Lives: {0}", _playerHP);
            if(_playerHP <=0)
            {
                ProgressText.text = "You want another life with that?";
                RestartSceneButton.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                ProgressText.text = "Ouch... that's gotta hurt.";
            }
        }
    }

    public void RestartScene()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );

        Time.timeScale = 1f;
    }

    public void NextScene()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        Time.timeScale = 1f;
    }
}
