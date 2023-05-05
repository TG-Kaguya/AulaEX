using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNum : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;

    [SerializeField] int _numb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_numb == 1)
        {
            _cube.SetActive(true);
            _sphere.SetActive(false);
            _capsule.SetActive(false);
            _cylinder.SetActive(false);
        }

        else if (_numb == 2)
        {
            _cube.SetActive(false);
            _sphere.SetActive(true);
            _capsule.SetActive(false);
            _cylinder.SetActive(false);
        }

        else if (_numb == 3)
        {
            _cube.SetActive(false);
            _sphere.SetActive(false);
            _capsule.SetActive(true);
            _cylinder.SetActive(false);
        }

        else if (_numb == 4)
        {
            _cube.SetActive(false);
            _sphere.SetActive(false);
            _capsule.SetActive(false);
            _cylinder.SetActive(true);
        }

        else if (_numb < 1)
        {
            _cube.SetActive(false);
            _sphere.SetActive(false);
            _capsule.SetActive(false);
            _cylinder.SetActive(false);
        }

        else if (_numb > 4)
        {
            _cube.SetActive(true);
            _sphere.SetActive(true);
            _capsule.SetActive(true);
            _cylinder.SetActive(true);
        }
    }
}
