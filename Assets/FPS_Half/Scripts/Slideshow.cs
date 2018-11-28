using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Slideshow : MonoBehaviour {

    public List<GameObject> slidesInOrder;
    public List<GameObject> slideTextInOrder;
    public int currentPage = 0;
    public string nextScene;

    public void NextPage()
    {
        CrossFadeAlphaFixed(slidesInOrder[currentPage].GetComponent<Image>(), 0.0f, 2.0f, false);
        slidesInOrder[currentPage].GetComponent<Image>().CrossFadeColor(Color.black, 2.0f, false, false);
        slideTextInOrder[currentPage].SetActive(false);
        currentPage++;
        if (currentPage == slidesInOrder.Count)
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            CrossFadeAlphaFixed(slidesInOrder[currentPage].GetComponent<Image>(), 255.0f, 2.0f, false);
            slidesInOrder[currentPage].GetComponent<Image>().CrossFadeColor(Color.white, 2.0f, false, false);
            slideTextInOrder[currentPage].SetActive(true);
        }
    }
    
    void CrossFadeAlphaFixed(Graphic img, float alpha, float duration, bool ignoreTimeScale)
    {
        //Make the alpha 1
        Color fixedColor = img.color;
        fixedColor.a = 1;
        img.color = fixedColor;

        //Set the 0 to zero then duration to 0
        img.CrossFadeAlpha(0f, 0f, true);

        //Finally perform CrossFadeAlpha
        img.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
    }
}
