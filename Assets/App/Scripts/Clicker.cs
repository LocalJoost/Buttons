
using System.Collections;
using UnityEngine;

public class Clicker : MonoBehaviour
{

    public GameObject ObjectToShow;

    private void Awake()
    {
        ObjectToShow.SetActive(false);
    }

    public void Click()
    {
        ObjectToShow.SetActive(true);
        StartCoroutine(HideAfterTimeout());
    }

    IEnumerator HideAfterTimeout()
    {
        yield return new WaitForSeconds(0.1f);
        ObjectToShow.SetActive(false);
    }
}
