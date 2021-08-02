using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class colorchange : MonoBehaviour
{
    public Material pinkColor = null;
    public Material grayColor = null ;
    private MeshRenderer meshRenderer = null ;
    private XRGrabInteractable grabInteractable = null;

    private void Awake ()
    {
            meshRenderer = GetComponent<MeshRenderer>();
           // grabInteractable = GetComponent<XRGrabInteractable>();

           // grabInteractable.OnActivate.AddListener(SetPink);
           // grabInteractable.OnDeactivate.AddListener(SetGray);
    } 

       private void OnDestroy ()
    {
            //grabInteractable.OnActivate.RemoveListener(SetPink);
            //grabInteractable.OnDeactivate.RemoveListener(SetGray);
    }

       public void SetPink (/*XRBaseInteractor interactor*/)
    {
        meshRenderer.material =  pinkColor;  
    } 
    
       public void SetGray (/*XRBaseInteractor interactor*/)
    {
        meshRenderer.material =  grayColor;  
         
    } 
}

