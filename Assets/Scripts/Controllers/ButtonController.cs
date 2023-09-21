using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Button statusButton, inventoryButton, statusBackButton, InventoryBackButton;
    [SerializeField] private GameObject menuUI, statusUI, inventoryUI;

    private void Awake()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
        statusBackButton.onClick.AddListener(OpenMenu);
        InventoryBackButton.onClick.AddListener(OpenMenu);
    }

    private void OpenMenu()
    {
        statusUI.SetActive(false);
        inventoryUI.SetActive(false);
        menuUI.SetActive(true);
    }

    private void OpenStatus()
    {
        menuUI.SetActive(false);
        statusUI.SetActive(true);
    }
    
    private void OpenInventory()
    {
        menuUI.SetActive(false);
        inventoryUI.SetActive(true);
    }
}
