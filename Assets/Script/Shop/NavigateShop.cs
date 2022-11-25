using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateShop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Character;
    public GameObject Weapon;
    public GameObject ShopMenu;

    private int currentSceneIndex;

    public void ChangeCharacter()
    {
        ShopMenu.SetActive(false);
        Character.SetActive(true);
    }

    public void ChangeWeapon()
    {
        ShopMenu.SetActive(false);
        Weapon.SetActive(true);
    }

    public void BacktoGame()
    {
        currentSceneIndex = PlayerPrefs.GetInt("LevelSaved");

        if (PlayerPrefs.HasKey("LevelSaved"))
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("Scenes/Level_1");
        }
    }

    public void BackToShopMenu()
    {
        Character.SetActive(false);
        Weapon.SetActive(false);
        ShopMenu.SetActive(true);
    }
}
