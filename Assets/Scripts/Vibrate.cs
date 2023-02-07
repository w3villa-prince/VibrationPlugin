using TMPro;
using UnityEngine;

public class Vibrate : MonoBehaviour
{
    [SerializeField] private TMP_InputField _vibrationInput;
    public int k;

    private void Start()
    {
        Vibration.Init();
    }

    public void VibrateClasic()
    {
        Debug.Log("On Enter Clasic  vibrate");
        Vibration.Vibrate();
        Debug.Log("On End Clasic  vibrate");
    }

    public void VibratePOP()
    {
        Debug.Log("On Enter POP  vibrate");
        Vibration.VibratePop();
        Debug.Log("On End POP  vibrate");
    }

    public void VibratePeek()
    {
        Debug.Log("On Enter Peek  vibrate");
        Vibration.VibratePeek();
        Debug.Log("On End Peek  vibrate");
    }

    public void VibrateNOpe()
    {
        Debug.Log("On Enter Nope  vibrate");
        Vibration.VibrateNope();
        Debug.Log("On End Nope  vibrate");
    }

    public void VibratePattern()
    {
        Debug.Log("On Enter Pattern  vibrate");

        long[] pattern = { 0, 1000, 1000, 1000, 1000 };
        Vibration.Vibrate(pattern, -1);

        Debug.Log("On End Pattern  vibrate");
    }

    public void VibrateCancel()
    {
        Debug.Log("On Enter Cancel vibrate");
        Vibration.Cancel();
        Debug.Log("On End cancel  vibrate");
    }

    public void Vibrate500()
    {
        // k = System.Convert.ToInt32(text.text);
        string str = _vibrationInput.text;
        Debug.Log(str);

        k = int.Parse(str);

        Debug.Log("On Enter 500  vibrate" + k.ToString());
        Vibration.Vibrate(k);
        Debug.Log("On End 500  vibrate");
    }

    public void Vibrat()
    {
        Handheld.Vibrate();
    }
}
