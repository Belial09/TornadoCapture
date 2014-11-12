#region

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#endregion

namespace TornadoCapture.Klassen
{
    internal sealed class RegGlobaleHotkey
    {
        private readonly IntPtr _hWnd;
        private readonly int _id;
        private readonly int _key;
        private readonly int _modifier;

        public RegGlobaleHotkey(int modifier, Keys key, Form form)
        {
            _modifier = modifier;
            _key = (int) key;
            _hWnd = form.Handle;
            _id = GetHashCode();
        }

        public override int GetHashCode()
        {
            return _modifier ^ _key ^ _hWnd.ToInt32();
        }

        public bool Register()
        {
            return RegisterHotKey(_hWnd, _id, _modifier, _key);
        }

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        public bool Unregister()
        {
            return UnregisterHotKey(_hWnd, _id);
        }

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    }
}