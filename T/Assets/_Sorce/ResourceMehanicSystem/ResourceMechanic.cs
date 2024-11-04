using Res.ResourceService;
using UnityEngine;
using UnityEngine.UI;

public class ResourceMechanic : MonoBehaviour
{
    public bool isbuttonActive => !isEnrichment;
    //public Decay openDecay => decay; 

    [SerializeField] private ObjectsType objectsType;
    [SerializeField] private Image TimeImage;

    private Enrichment enrichment;
    public Decay decay {  get; private set; }
    private TimerBar timerBar;
    private bool isDecay;
    private bool isEnrichment;
    private float timeDecay;
    private float timeEnrichment;
    private float DefaulttimeDecay;
    private float DefaulttimeEnrichment;

    void Awake()
    {
        timerBar = new TimerBar(TimeImage);
        decay = new Decay();
        enrichment = new Enrichment();

        RecourcParamService.instance.SetEnebleTime(ref DefaulttimeEnrichment, objectsType);
        RecourcParamService.instance.SetDisableTime(ref DefaulttimeDecay, objectsType);

        Reset();
    }

    public void Reset()
    {
        timeDecay = DefaulttimeDecay;
        timeEnrichment = DefaulttimeEnrichment;
        isDecay = false;
        isEnrichment = true;
        timerBar.reset();
    }

    private void Update()
    {
        if (isEnrichment)
        {
            enrichment.StartEnrichment(ref timeEnrichment, out isEnrichment);
            timerBar.BarUp(DefaulttimeEnrichment);
        }
        else
        {
            Debug.Log(decay);
            decay.StartDecay(ref timeDecay, out isDecay);

            timerBar.BarDown(DefaulttimeDecay);
        }
    }
}