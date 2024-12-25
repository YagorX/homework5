using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public class Test : MonoBehaviour
{
    
    [NonSerialized] public int _num = 5;
    public string word;
    [SerializeField] private float nums;
    // Start is called before the first frame update

    public int[] numbers = new int[3];
    public List<string> words = new List<string>();

    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void Start()
    {
        Debug.Log("Hello their. Num: " + _num);
    }

    private void FixedUpdate() {
        Debug.Log("Fixed update");
    }
    private void OnEnable() {
        Debug.Log("OnEnable");
    }
    private void OnDestroy() {
        Debug.Log("OnDestroy");
    }
    // Update is called once per frame

/*    private void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate() {
        
    }*/
}
