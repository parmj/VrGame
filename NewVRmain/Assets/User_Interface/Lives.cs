using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Lives : MonoBehaviour
{
    public static int lives = 3;
    public static int deduct(int x)
    {
        return x--;
    }

    void OnGUI()
    {
        //check if game is not over, if so, display the score and the time left
        if (lives > 0)
        {

            GUI.Label(new Rect(10, 10, Screen.width / 5, Screen.height / 6), ((int)lives).ToString());
        }
    }
}