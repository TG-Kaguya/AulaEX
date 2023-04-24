using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numeros : MonoBehaviour
{
    [SerializeField] int _gravStrong;
    [SerializeField] int _gravWeak;
    [SerializeField] float _gravity;
    [SerializeField] GameObject _sphere;
    [SerializeField] Rigidbody _rigmass;
    [SerializeField] Text _tex;

    // Start is called before the first frame update
    void Start()
    {
        _rigmass.mass = _gravity;
        _gravity = _gravWeak;
        _gravity = _gravity * 3;
        _tex.text = "gravity value: " + _gravity;
    }

    // Update is called once per frame
    void Update()
    {
        _tex.text = "gravity value: " + _gravity;
    }
}
