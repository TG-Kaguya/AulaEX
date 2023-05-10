using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject _panelStart;
    [SerializeField] GameObject _panelLoad;
    [SerializeField] GameObject _panelPlayerSel;

    public void ActivateStartPanel()
    {
        _panelStart.SetActive(true);
        _panelLoad.SetActive(false);
        _panelPlayerSel.SetActive(false);
    }

    public void ActivateLoadPanel()
    {
        _panelStart.SetActive(false);
        _panelLoad.SetActive(true);
        _panelPlayerSel.SetActive(false);
    }
    public void ActivateCharPanel()
    {
        _panelStart.SetActive(false);
        _panelLoad.SetActive(false);
        _panelPlayerSel.SetActive(true);
    }

    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
