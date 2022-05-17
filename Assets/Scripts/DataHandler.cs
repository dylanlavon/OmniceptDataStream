using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HP.Omnicept;
using HP.Omnicept.Messaging;
using HP.Omnicept.Messaging.Messages;
using TMPro;

public class DataHandler : MonoBehaviour
{

    ////////////////////////////////////////////////////////////////////////////////////

    [SerializeField]
    private bool showHeartRateMessages = true;
    [SerializeField]
    private bool showCognitiveLoadMessages = true;
    [SerializeField]
    private bool showEyeTrackingMessages = true;

    ////////////////////////////////////////////////////////////////////////////////////

    public TextMeshProUGUI heartRateTMP;

    public TextMeshProUGUI cognitiveLoadTMP;

    public TextMeshProUGUI gazeXTMP;
    public TextMeshProUGUI gazeYTMP;
    public TextMeshProUGUI gazeZTMP;


    ////////////////////////////////////////////////////////////////////////////////////




    public void HeartRateHandler(HeartRate hr)
    {
        if (showHeartRateMessages && hr != null)
        {
            heartRateTMP.text = hr.Rate.ToString() + " BPM";
        }
    }

    public void CognitiveLoadHandler(CognitiveLoad cl)
    {
        if (showCognitiveLoadMessages && cl != null)
        {
            cognitiveLoadTMP.text = (cl.CognitiveLoadValue * 100f).ToString("F3") + " %";
        }
    }

    public void EyeTrackingHandler(EyeTracking eyeTracking)
    {
        if (showEyeTrackingMessages && eyeTracking != null)
        {
            
            gazeXTMP.text = "X: " + eyeTracking.CombinedGaze.X.ToString("F3");
            gazeYTMP.text = "Y: " + eyeTracking.CombinedGaze.Y.ToString("F3");
            gazeZTMP.text = "Z: " + eyeTracking.CombinedGaze.Z.ToString("F3");
        }
    }
}
