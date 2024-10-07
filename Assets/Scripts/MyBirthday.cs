using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
     for (int julyDays = 1; julyDays <= 31; julyDays++)
	{
	if (julyDays == 24)
	{
	Debug.Log("Its my Birthday");
	}
	else
	{
	Debug.Log(julyDays);
	}
	}   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
