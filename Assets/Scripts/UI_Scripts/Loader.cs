using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public static void LoadCounter()
    {
        SceneManager.LoadScene("CounterScene");
    }
    public static void LoadKitchen()
    {
        SceneManager.LoadScene("KitchenScene");
    }
    public static void LoadSettings()
    {
        SceneManager.LoadScene("SettingsScene");
    }
    public static void LoadMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
