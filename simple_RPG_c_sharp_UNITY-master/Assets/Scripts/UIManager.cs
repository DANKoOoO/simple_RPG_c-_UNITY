using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider healthbar;
    public Text HPText;
    public PlayerHealthManager playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        healthbar.maxValue = playerHealth.playerMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = playerHealth.playerCurrentHealth;
        HPText.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;
    }
}
