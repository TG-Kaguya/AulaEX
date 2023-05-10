using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMockupBehavior : MonoBehaviour
{
    [SerializeField] GameObject _panelStart;
    [SerializeField] GameObject _panelMain;
    [SerializeField] GameObject _panelFileselect;
    [SerializeField] GameObject _panelOption;

    public void PressStart()
    {
        _panelStart.SetActive(false);
        _panelMain.SetActive(true);
        _panelFileselect.SetActive(false);
        _panelOption.SetActive(false);
    }

    public void FileSelect()
    {
        _panelStart.SetActive(false);
        _panelMain.SetActive(false);
        _panelFileselect.SetActive(true);
        _panelOption.SetActive(false);
    }

    public void OptionMenu()
    {
        _panelStart.SetActive(false);
        _panelMain.SetActive(false);
        _panelFileselect.SetActive(false);
        _panelOption.SetActive(true);
    }

    public void BackStart()
    {
        _panelStart.SetActive(true);
        _panelMain.SetActive(false);
        _panelFileselect.SetActive(false);
        _panelOption.SetActive(false);
    }

    /*
        void Start()
        {

        }


        void Update()
        {

        }
    */
}
