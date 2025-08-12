using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Road"))
        {

            StartCoroutine(MyCoroutine(2.0f));
            Time.timeScale = 0f;
        }

    }
    IEnumerator MyCoroutine(float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
         Time.timeScale = 1f;
        SceneManager.LoadScene("GameOver");
    }
}
