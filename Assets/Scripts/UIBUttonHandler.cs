using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBUttonHandler : MonoBehaviour
{

    [SerializeField] private Button UIStartButton;
    [SerializeField] private Button UIShootButton;
    [SerializeField] private Button UIResetButton;

    public static event Action OnUIStartButtonClicked;
    public static event Action OnUIShootButtonClicked;
    public static event Action OnUIResetButtonClicked;

    // Start is called before the first frame update
    void Start()
    {
        UIStartButton.onClick.AddListener(OnStartbuttonClicked);
        UIShootButton.onClick.AddListener(OnShootbuttonClicked);
        UIResetButton.onClick.AddListener(OnResetbuttonClicked);
        UIShootButton.gameObject.SetActive(false);
    }

    void OnStartbuttonClicked()
    {
        OnUIStartButtonClicked?.Invoke();

        UIStartButton.gameObject.SetActive(false);
        UIShootButton.gameObject.SetActive(true);
    }

    void OnShootbuttonClicked()
    {
        OnUIShootButtonClicked?.Invoke();

    }

    void OnResetbuttonClicked()
    {
        OnUIResetButtonClicked?.Invoke();
        UIStartButton.gameObject.SetActive(true);
        UIShootButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
