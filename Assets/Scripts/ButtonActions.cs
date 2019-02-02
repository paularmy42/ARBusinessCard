using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActions : MonoBehaviour
{
    public void OpenTwitter()
    {
        Application.OpenURL("https://twitter.com/paularmistead");
    }

    public void OpenInstagram()
    {
        Application.OpenURL("https://www.instagram.com/disruptiveclarity/");
    }

    public void OpenLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/paularmistead");
    }

    public void OpenEmail()
    {
        Application.OpenURL("mailto:paularmistead@disruptiveclarity.com");
    }
}