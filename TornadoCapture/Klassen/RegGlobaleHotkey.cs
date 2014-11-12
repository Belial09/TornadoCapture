using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TornadoCapture_v2.Klassen
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

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public override int GetHashCode()
        {
            return _modifier ^ _key ^ _hWnd.ToInt32();
        }

        public bool Register()
        {
            return RegisterHotKey(_hWnd, _id, _modifier, _key);
        }

        public bool Unregister()
        {
            return UnregisterHotKey(_hWnd, _id);
        }
    }
}