using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Navigation : MonoBehaviour
{
    public Button toGame;
    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(toGame.gameObject);
    }
    public void SceneNavigator(GameObject ui)
    {
        EventSystem.current.SetSelectedGameObject(ui);
    }
}
