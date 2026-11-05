using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2 : MonoBehaviour
{
    public List<GameObject> ksztalt;
    // Start is called before the first frame update
    void Start()
    {
        SprawdzObiekty();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void SprawdzObiekty()
    {
        foreach (GameObject obj in ksztalt)
        {
            if (obj.GetComponent<SpriteRenderer>() != null)
            {
                Debug.Log(" jest obiektem 2D");
            }
            else if (obj.GetComponent<MeshRenderer>() != null)
            {
                Debug.Log(" jest obiektem 3D");
            }
        }
    }
}
