using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnStart : MonoBehaviour
{
    [SerializeField] private Canvas ARMagicBar;
    // Start is called before the first frame update
    void Start()
    {
        UIBUttonHandler.OnUIStartButtonClicked += OnStartButtonClicked;
        UIBUttonHandler.OnUIResetButtonClicked += OnResetButtonClicked;

    }

    private void OnResetButtonClicked()
    {
        ARMagicBar.enabled = true;
    }

    private void OnStartButtonClicked()
    {
        ARMagicBar.enabled = false;
    }
}
