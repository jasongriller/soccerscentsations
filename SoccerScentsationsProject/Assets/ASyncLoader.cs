using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ASyncLoader : MonoBehaviour
{
  [Header("Menu Screens")]
  [SerializeField] private GameObject loadingScreen;
  [SerializeField] private GameObject mainMenu;

  [Header("Slider")]
  [SerializeField] private Slider loadingSlider;

  public void LoadLevelBtn(string levelToLoad)
  {
    mainMenu.SetActive(false);
    loadingScreen.SetActive(true);

    // Run the asynchronous operation
  }
  IEnumerator LoadLevelASync(string levelToLoad)
  {
    AsyncOperation loadOperation = SceneManager.LoadSceneAsync
  }

}
