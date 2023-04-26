using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionais : MonoBehaviour
{
    float _flt1;
    float _flt2;
    
    [SerializeField] int _int1;
    [SerializeField] int _int2;

    string _str1;
    string _str2;

    bool _bl1;
    bool _bl2;

    // > more than
    // < less than
    // >= more than or equal
    // <= less than or equal
    // != different
    // == equals

    // Start is called before the first frame update
    void Start()
    {
        if (_int1 == 1)
        {
            _str1 = "a mimir";
            Debug.Log("_int1 is 1");
            Debug.Log("_str1 is " + _str1);
        }

        if (_int1 == _int2)
        {
            Debug.Log("_int1 is equal to _int2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
