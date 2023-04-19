using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade : MonoBehaviour
{
    [SerializeField] string _firststring = "biscoito";
    [SerializeField] string _secondstring;
    [SerializeField] string _thirdstring;

    // Start is called before the first frame update
    void Start()
    {
        _thirdstring = _firststring + " " + _secondstring;
    }

    // Update is called once per frame
    void Update()
    {
        if (_secondstring == "")
        {
            _secondstring = "de morango";
        }
        _thirdstring = _firststring + " " + _secondstring;
    }
}
