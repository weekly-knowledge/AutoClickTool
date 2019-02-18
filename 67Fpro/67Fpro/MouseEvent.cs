using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _67Fpro
{
    class MouseEvent
    {
        public void mouseClick(Point p, int Count)
        {
            mouseClick(p, Count, 100);
        }

        public void mouseClick(Point p, int Count, int interval)
        {
            for (int i = 0; i < Count; i++)
            {
                SetCursorPos(p.X, p.Y);
                mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);//自动按下的按键
                Thread.Sleep(interval);
                mouse_event((int)(MouseEventFlags.LeftUp | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);//自动按下的按键
            }
        }

        //获取鼠标事件
        [DllImport("User32")]
        public extern static void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);
        //mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);//自动按下的按键

        //设置鼠标点位置
        [DllImport("User32")]
        public extern static void SetCursorPos(int x, int y);

        //获取鼠标点位置
        [DllImport("User32")]
        public extern static bool GetCursorPos(out Point p);

        public enum MouseEventFlags       //鼠标按键的ASCLL码
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            Wheel = 0x0800,
            Absolute = 0x8000
        }
    }
}
