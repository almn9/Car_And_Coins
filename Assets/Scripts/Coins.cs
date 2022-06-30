using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameHandler GH;
    public AudioClip coinSound;
    // Start is called before the first frame update
    void Start()
    {
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }

            private void OnTriggerEnter(Collider other)
    {
        GH.coins++;

        // plays a clip (sound) whenever a coin is picked up
        AudioSource.PlayClipAtPoint(coinSound, transform.position);

        // This will allow the coin to disappear when picked up
        Destroy(gameObject);
    }
           
    }

