using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public GameBehaviour GameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("Game Manager").GetComponent<GameBehaviour>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("Item Collected!");
            GameManager.Items += 1;
        }
    }
}
