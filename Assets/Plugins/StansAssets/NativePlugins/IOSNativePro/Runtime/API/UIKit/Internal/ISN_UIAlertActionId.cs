using System;
using UnityEngine;

namespace SA.iOS.UIKit.Internal
{
    [Serializable]
    class ISN_UIAlertActionId
    {
        [SerializeField]
        int m_alertId = 0;
        [SerializeField]
        int m_actionId = 0;

        public int AlertId
        {
            get { return m_alertId; }
        }

        public int ActionId
        {
            get { return m_actionId; }
        }
    }
}