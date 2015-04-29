using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;

       private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
			if (Input.GetMouseButtonDown (0)) {
				m_Jump = true;		
			}
        }


        private void FixedUpdate()
        {
			m_Character.Move (0.4f, false, m_Jump);
            m_Jump = false;

       }
    }
}
