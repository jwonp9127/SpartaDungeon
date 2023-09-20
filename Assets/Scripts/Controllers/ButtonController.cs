using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Button status, inventory;

    private void Awake()
    {
        status.onClick.AddListener(OpenStatus);
        inventory.onClick.AddListener(OpenInventory);
    }

    private void OpenStatus()
    {
        
    }
    
    private void OpenInventory()
    {
        
    }


}
