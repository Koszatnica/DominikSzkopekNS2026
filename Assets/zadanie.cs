using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class zadanie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> dane = new List<int> { 1, 3, 3, 1, 2, 2, 3, 1, 3, 2 };
        List<int> jedynki = new  List<int>();
        List<int> dwojki = new List<int>();
        List<int> trojki = new List<int>();

        foreach (int numer in dane)
        {
            if (numer == 1)
            {
                jedynki.Add(numer);
            }
            else if (numer == 2)
            {
                dwojki.Add(numer);
            }
            else if (numer == 3)
            {
                trojki.Add(numer);
            }
        }
        dane.Clear();
        Debug.Log(dane.Count);
        Debug.Log(jedynki.Count);
        Debug.Log(dwojki.Count);
        Debug.Log(trojki.Count);
    }
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
