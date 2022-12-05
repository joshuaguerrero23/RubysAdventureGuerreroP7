using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float speed = 3.0f;

    public int maxHealth = 5;

    public int health { get { return currentHealth; }}
    int currentHealth;


    Rigidbody2D rigidbody2d;
    float horizantal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        currentHealth = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        //create variables to use the built in axes
        horizantal = Input.GetAxis("Horizantal");
        vertical = Input.GetAxis("Vertical");

        //Create a movement vector
    }
    void FixedUpdate()
    {
   
        Vector2 position = transform.position;

        //make vertical and horizontal movement work
        position.x = position.x + speed * horizantal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);

        transform.position = position;
    }
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
