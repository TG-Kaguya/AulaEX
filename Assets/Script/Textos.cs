using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{
    [SerializeField] string _name = "Devin";
    [SerializeField] string _surname = "Vampyson";
    [SerializeField] string _fullname;
    [SerializeField] Text _nametext;

    // Start is called before the first frame update
    void Start()
    {
        _name = "Joel";
        _fullname = _name + " " + _surname;
        _nametext.text = _fullname;
    }

    // Update is called once per frame
    void Update()
    {
        if (_name == "Joel")
        {
            _surname = "Vinesauce";
        }
        else
        {
            _name = "Satan";
            _surname = "of the puyo";
        }
        _fullname = _name + " " + _surname;
        _nametext.text = _fullname;
    }
}
