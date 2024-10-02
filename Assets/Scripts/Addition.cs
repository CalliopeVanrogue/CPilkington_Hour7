using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
int a = 2;
int b = 4;
int c = 8;
int sum;

    // Start is called before the first frame update
    void Start()
    {
sum = (a + b + c);
sum++;
print(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
