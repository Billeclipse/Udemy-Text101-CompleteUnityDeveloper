using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] public Text textCompontent;

    // Start is called before the first frame update
    void Start()
    {
        textCompontent.text = ("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
