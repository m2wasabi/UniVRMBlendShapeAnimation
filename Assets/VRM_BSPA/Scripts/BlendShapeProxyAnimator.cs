using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

namespace VRM.BSPA{
public class BlendShapeProxyAnimator : MonoBehaviour
    {

        [SerializeField]
        private float BlendShapeClip_A = 0;

        [SerializeField]
        private float BlendShapeClip_I = 0;

        [SerializeField]
        private float BlendShapeClip_U = 0;

        [SerializeField]
        private float BlendShapeClip_E = 0;

        [SerializeField]
        private float BlendShapeClip_O = 0;

        [SerializeField]
        private float BlendShapeClip_Blink = 0;

        [SerializeField]
        private float BlendShapeClip_Joy = 0;

        [SerializeField]
        private float BlendShapeClip_Angry = 0;

        [SerializeField]
        private float BlendShapeClip_Sorrow = 0;

        [SerializeField]
        private float BlendShapeClip_Fun = 0;

        [SerializeField]
        private float BlendShapeClip_LookUp = 0;

        [SerializeField]
        private float BlendShapeClip_LookDown = 0;

        [SerializeField]
        private float BlendShapeClip_LookLeft = 0;

        [SerializeField]
        private float BlendShapeClip_LookRight = 0;

        [SerializeField]
        private float BlendShapeClip_Blink_L = 0;

        [SerializeField]
        private float BlendShapeClip_Blink_R = 0;

        private VRMBlendShapeProxy _vrmBlendShapeProxy;

        void Awake()
        {
            _vrmBlendShapeProxy = GetComponent<VRMBlendShapeProxy>();
        }

        private void Update()
        {
            if (_vrmBlendShapeProxy)
            {
                var shapeKeyList = new List<KeyValuePair<BlendShapeKey, float>>()
                    {
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.A), BlendShapeClip_A),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.I), BlendShapeClip_I),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.U), BlendShapeClip_U),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.E), BlendShapeClip_E),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.O), BlendShapeClip_O),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.Blink), BlendShapeClip_Blink),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.Joy), BlendShapeClip_Joy),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.Angry), BlendShapeClip_Angry),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.Sorrow), BlendShapeClip_Sorrow),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.Fun), BlendShapeClip_Fun),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.LookUp), BlendShapeClip_LookUp),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.LookDown), BlendShapeClip_LookDown),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.LookLeft), BlendShapeClip_LookLeft),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.LookRight), BlendShapeClip_LookRight),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.Blink_L), BlendShapeClip_Blink_L),
                        new KeyValuePair<BlendShapeKey, float>(new BlendShapeKey(BlendShapePreset.Blink_R), BlendShapeClip_Blink_R),
                    };
                _vrmBlendShapeProxy.SetValues(shapeKeyList);
            }
        }
    }
}
