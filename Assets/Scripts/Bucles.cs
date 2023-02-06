using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{
    public int x = 10;
    private int i;
    private int a = 1;
    private int b = 0;

    //instanciar elementos
    public Vector3[] positions;
    public GameObject prefab;

    //array
    public string[] names;

    // Start is called before the first frame update
    void Start()
    { /*
        //mostrar numero del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(i);
        }

        while (a <= 10)
        {
            Debug.Log(a);
            a++;
        }

        //mostrar numeros pares
        for (int i = 0; i <= 10; i += 2)
        {
            Debug.Log(i);
        }

        
        while (b <= 10)
        {
            Debug.Log(b);
            b += 2;
        }


        //multiplicar
        for (int i = 0; i <= 10; i++)
        {
            
            Debug.Log($"{x} * {i} = {x*i}");
        }
        
        while (b <= 10)
        {
            Debug.Log($"{x} x {b}={x * b}");
           b++;
        }
        
        //recorrer array
        for (int i = 0; i < names.Length; i++)
        {
            Debug.Log(names[i]);
        }

        foreach (string name in names)
        {
            Debug.Log(name);
        }

        while (i < names.Length)
        {
            Debug.Log(names[i]);
            i++
        }

        //Instanciar elementos
        for (int i = 0; i<positions.Length; i++)
        {
         Instantiate(prefab, positions[i], Quaternion.identity);
        }

        foreach (Vector3 p in positions)
        {
            Instantiate(prefab, p, Quaternion.identity);
        }

        int i = 0;
        while (i < positions.Length)
        {
             Instantiate(prefab, positions[i], Quaternion.identity);
             i++;
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
