using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basics : MonoBehaviour
{
    public GameObject obj;
    public Transform targets;
    // Start is called before the first frame update
    void Start()
    {
        //obj.SetActive(false);
        obj.GetComponent<Transform>().position = new Vector3(10, 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
