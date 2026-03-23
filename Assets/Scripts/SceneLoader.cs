using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime;
    private bool buttonClicked = false;
    private string scene;
    private Scene currentScene;
    private string currentSceneName;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
    }
    void Update()
    {
        if(buttonClicked)
        {
            PreviousScene.OldScene = SceneManager.GetActiveScene().name;
            if(currentSceneName == "Title") {
                Load();
            }
            else {
                LoadVariant();
            }
        }
    }
    public void click(bool clicked)
    {
        buttonClicked = clicked;
    }
    public void setScene(string s)
    {
        scene = s;
    }
    public void Load()
    {
        StartCoroutine(LoadLevel());
    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("End");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(scene);
        
    }
    public void LoadVariant()
    {
        StartCoroutine(LoadLevelVariant());
    }
    IEnumerator LoadLevelVariant()
    {
        transition.SetTrigger("End_Variant");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(scene);
        
    }
}
