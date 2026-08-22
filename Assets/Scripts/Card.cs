using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
enum CardState
{
    Cooling,
    WaitingSun,
    Ready,
}
public class Card : MonoBehaviour
{
    private CardState cardState = CardState.Cooling;
    public GameObject cardLight;
    public GameObject cardGary;
    public Image cardMask;
    public float cdTime = 2;
    public float cdTimer = 0;
    private void Update()
    {
        switch (cardState)
        {
            case CardState.Cooling:
                CoolingUpdate();
                break;
            case CardState.WaitingSun:
                WaitingSunUpdate();
                break;
            case CardState.Ready:
                ReadyUpdate();
                break;
            
        }
    }
   void CoolingUpdate()
   {
        cdTimer += Time.deltaTime;

        cardMask.fillAmount = (cdTime - cdTimer)/cdTime;

        if(cdTimer >= cdTime)
        {
            TransitionToWaitingSun();
        }
   }
    void WaitingSunUpdate()
    {

    }
    void ReadyUpdate()
    {

    }

    void TransitionToWaitingSun()
    {
        cardState = CardState.WaitingSun;
        Debug.Log("×ª»»ÖÁµÈ´ý×´Ì¬");

        cardLight.SetActive(false);
        cardGary.SetActive(true);
        cardMask.gameObject.SetActive(false);
    }
}
