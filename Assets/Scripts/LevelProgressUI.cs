using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelProgressUI : MonoBehaviour
{
    [SerializeField] private Image progressBar;
    [SerializeField] private TextMeshProUGUI distanceText;
    [SerializeField] private Transform playerTrans;
    [SerializeField] private Transform endTrans;

    private float endPos;
    private float playerPos;
    private float fullDist;
    // Start is called before the first frame update
    void Start()
    {
        endPos = endTrans.position.x;
        fullDist = endTrans.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        playerPos = playerTrans.position.x; //Update Player Pos

        float progressVal = Mathf.InverseLerp(0f, fullDist, playerPos); //Update Progress Value

        Debug.Log($"Ditance: {GetDistance()}, Progress: {progressVal}");

        UpdateBar(progressVal);

        distanceText.text = $"{progressVal * 1000:f0} meters";
    }
    private float GetDistance()
    {
        return endPos - playerPos;
    }
    private void UpdateBar (float value)
    {
        progressBar.fillAmount = value;
    }
}
