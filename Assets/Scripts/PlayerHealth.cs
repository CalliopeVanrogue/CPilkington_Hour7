using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
float health;
float poisonDamage;
    // Start is called before the first frame update
    void Start()
    {
      health = 1004f;
	poisonDamage = 125.5f; 
	health = (health - poisonDamage);
	health = (health - poisonDamage);
	health = (health - poisonDamage);
	health = (health - poisonDamage);
	health = (health - poisonDamage);
	health = (health - poisonDamage);
	health = (health - poisonDamage);
	health = (health - poisonDamage);
print(health);	
print("Player has been unalived");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
