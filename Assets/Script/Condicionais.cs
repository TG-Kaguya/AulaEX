using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionais : MonoBehaviour
{
    float _flt1;
    float _flt2;
    
    [SerializeField] int _int1;
    [SerializeField] int _int2;

    [SerializeField] string _str1;
    string _str2;

    [SerializeField] bool _bl1;
    bool _bl2;

    // > more than
    // < less than
    // >= more than or equal
    // <= less than or equal
    // != different
    // == equals
    // && and
    // || or

    // Start is called before the first frame update
    void Start()
    {
        _str1 = "multiply";

        if (_int1 == 1)
        {
            _str1 = "a mimir";
            //Debug.Log("_int1 is 1");
            //Debug.Log("_str1 is " + _str1);
        }

        if (_int1 == _int2)
        {
            //Debug.Log("_int1 is equal to _int2");
        }

        if (_int1 == 1)
        {
            //Debug.Log("Stage 1 unlocked");
        }
        else
        {
            //Debug.Log("Stage 1 locked");
        }

        if (_str1 == "multiply")
        {
            _int1 = _int1 * _int2;
        }
        else
        {
            _int1 = _int1 + _int2;
        }
        //Debug.Log("result is " + _int1);

        if (_int1 == 2)
        {
            _str1 = "Open passage";
        }
        else
        {
            _str1 = "Blocked passage";
        }
        Debug.Log(_str1);

        if (_int1 == _int2 && _bl1 == true)
        {
            //Debug.Log("Enter stage");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
