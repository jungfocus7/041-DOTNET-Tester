using System;


namespace HPO402.Common.EventManages
{
    public sealed class KeyboardManagerEventArgs : EventArgs
    {
        public readonly string KeyStr;

        public KeyboardManagerEventArgs(string keyStr)
        {
            KeyStr = keyStr;
        }
    }

    public static class GlobalKeyboardManager
    {
        //private static readonly List<Action<char>> m_cbfs = new List<Action<char>>();

        //public static void AddCallback()
        //{   
        //}

        public static EventHandler<KeyboardManagerEventArgs> m_ke;
        public static event EventHandler<KeyboardManagerEventArgs> KeyboardEvent
        {
            add { m_ke += value; }
            remove { m_ke -= value; }
        }
        public static void Clear()
        {
            m_ke = null;
        }

        public static void OnKeyboardEvent(string keyStr)
        {
            m_ke?.Invoke(null, new KeyboardManagerEventArgs(keyStr));
        }
    }
}
