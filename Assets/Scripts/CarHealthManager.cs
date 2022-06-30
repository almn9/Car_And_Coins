using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarHealthManager : MonoBehaviour
{

    public float health = 100;



   
    public void ApplyDamage(int val)
    {

        health = health - val;

        GetComponent<CarUIManager>().SetBarVal(health);

        // If car health reaches 0, the car is destroyed.
        if (health <= 0)
        {
            Destroy(gameObject);



            // This will bring the game over screen when the car is destroyed
            SceneManager.LoadScene("Game Over Screen");
        }
    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
