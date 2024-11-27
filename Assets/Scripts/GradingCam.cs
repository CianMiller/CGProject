using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ScreenCameraShader : MonoBehaviour
{
    
    
    public Material m_renderMaterialWarm;
    public Material m_renderMaterialCool;
    public Material m_renderMaterialCustom;
    Material main;
   
  
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {


        if (main != null)
        {
            Graphics.Blit(source, destination, main);
        }
        else
        {
            Graphics.Blit(source, destination);
        }
     
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            main = m_renderMaterialCustom;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            main = m_renderMaterialCool;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            main = m_renderMaterialWarm;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            main = null;
        }

    }
}

