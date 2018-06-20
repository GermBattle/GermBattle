// Copyright (C) 2015 ricimi - All rights reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement.
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms.

using UnityEngine;
using UnityEngine.SceneManagement;
// Specialized version of the PopupOpener class that opens the PlayPopup popup
// and sets an appropriate number of stars (that can be configured from within the
// editor).
public class PlayPopupOpener : PopupOpener
{
    private int starsObtained = 3;
    public int levelnum;
    public Color color = Color.black;
    public override void OpenPopup()
    {
        if (PlayerPrefs.HasKey("isLevel" + levelnum.ToString()))
        {
            var popup = Instantiate(popupPrefab) as GameObject;
            popup.SetActive(true);
            popup.transform.localScale = Vector3.zero;
            popup.transform.SetParent(m_canvas.transform, false);

            var playPopup = popup.GetComponent<PlayPopup>();
            playPopup.Open();
            if (PlayerPrefs.GetInt("Level" + levelnum.ToString()) > 150)
                starsObtained = 1;
            else if (PlayerPrefs.GetInt("Level" + levelnum.ToString()) > 100)
                starsObtained = 2;
            else
                starsObtained = 3;
            playPopup.SetAchievedStars(starsObtained);
            playPopup.SetScore(PlayerPrefs.GetInt("Level" + levelnum.ToString()));
        } else if (levelnum == 1 || PlayerPrefs.HasKey("isLevel" + (levelnum-1).ToString()))
        {
            SceneManager.LoadScene("GameScene" + levelnum.ToString());
            //Transition.LoadLevel("GameScene"+ levelnum.ToString(), 0.0f, color);
        }
    }
}