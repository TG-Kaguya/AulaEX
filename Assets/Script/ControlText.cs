using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlText : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;
    [SerializeField] string _textCont;

    void SetFalse()
    {
        _cube.SetActive(false);
        _sphere.SetActive(false);
        _capsule.SetActive(false);
        _cylinder.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_textCont == "cube")
        {
            SetFalse();
            _cube.SetActive(true);
        }
        else if (_textCont == "sphere")
        {
            SetFalse();
            _sphere.SetActive(true);
        }
        else if (_textCont == "capsule")
        {
            SetFalse();
            _capsule.SetActive(true);
        }
        else if (_textCont == "cylinder")
        {
            SetFalse();
            _cylinder.SetActive(true);
        }
        else
        {
            SetFalse();
        }
    }
}
