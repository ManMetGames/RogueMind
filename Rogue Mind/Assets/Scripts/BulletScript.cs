using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float damage = 1f;//the damage of the bullet
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);//after 5 seconds a bullet is destroyed 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnCollisionEnter2D(Collision2D collision)//on hitting something
	{
        if((collision.gameObject.tag != "Player") && (collision.gameObject.tag != "Enemy"))
        {
            Destroy(gameObject);//Destroy the bullet
        }
        
	}
}
