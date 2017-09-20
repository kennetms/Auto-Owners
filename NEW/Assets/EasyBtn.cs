using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyBtn : MonoBehaviour {

    public void easyGameBtn(string newGameLvl)
    {
        SceneManager.LoadScene(newGameLvl);
    }
}
