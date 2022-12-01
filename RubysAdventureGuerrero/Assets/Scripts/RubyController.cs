using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public int maxHealth = 5;
    int currentHealth;


    Rigidbody2D rigidbody2d;
    float horizantal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 240;
        
    }

    // Update is called once per frame
    void Update()
    {
        //create variables to use the built in axes
        float horizontal = Input.GetAxis("Horizantal");
        float vertical = Input.GetAxis("Vertical");

        //Create a movement vector
    }
    void FixedUpdate()
    {
   
        Vector2 position = transform.position;

        //make vertical and horizontal movement work
        position.x = position.x + 3.0f * horizantal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);

        transform.position = position;
    }
    void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
