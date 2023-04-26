using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo : MonoBehaviour
{
    [SerializeField] int _numInt;
    [SerializeField] string _text;
    [SerializeField] string _text2 = "fucc pizza";
    [SerializeField] bool _check;
    [SerializeField] float numFloat;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Variable numInt is " + _numInt);
        _numInt = 2;
        Debug.Log("Variable numInt's new value is " + _numInt);

        _text = "gib pizza b0ss";
        Debug.Log(_text);
        _text = "pls b0ss gib da pimza";
        Debug.Log(_text);

        _text = _text2;
        Debug.Log(_text);

        _check = true;
        Debug.Log("bool = " + _check);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
