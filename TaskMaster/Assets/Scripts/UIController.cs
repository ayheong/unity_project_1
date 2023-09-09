using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject blackOutSquare;

    public GameObject player;

    void Update()
    {

    }

    public IEnumerator FadeBlackOutSquare(int fadeSpeed = 5)
    {
        Color objectColor = blackOutSquare.GetComponent<Image>().color;
        float fadeAmount;

        while (blackOutSquare.GetComponent<Image>().color.a < 1)
        {
            fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            blackOutSquare.GetComponent<Image>().color = objectColor;
            yield return null;
        }

        player.transform.position = new Vector3 (-13.5f, player.transform.position.y, 0f);
        yield return new WaitForSeconds(1);

        while (blackOutSquare.GetComponent<Image>().color.a > 0)
        {
            fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            blackOutSquare.GetComponent<Image>().color = objectColor;
            yield return null;
        }

        yield return new WaitForSeconds(0.25f);
        player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        StartCoroutine(FadeBlackOutSquare());
        
    }
}
