﻿using KAMI.Core.Utilities;

namespace KAMI.Core
{
    public class KamiConfig : IConfig
    {
        public int? ToggleKey { get; internal set; }
        public int? Mouse1Key { get; internal set; }
        public int? Mouse2Key { get; internal set; }
        public float Sensitivity { get; internal set; }
        public bool HideCursor { get; internal set; }
        public MouseHandlerEnum MouseHandler { get; internal set; }
        public bool UsePCSX2 { get; internal set; }

        public KamiConfig(int? toggleKey, int? mouse1Key, int? mouse2Key, float sensitivity, bool hideCursor, MouseHandlerEnum mouseHandler, bool usePCSX2)
        {
            ToggleKey = toggleKey;
            Mouse1Key = mouse1Key;
            Mouse2Key = mouse2Key;
            Sensitivity = sensitivity;
            HideCursor = hideCursor;
            MouseHandler = mouseHandler;
            UsePCSX2 = usePCSX2;

        }

        public static IConfig GetDefaultConfig()
        {
            return new KamiConfig
            (
                toggleKey: null,
                mouse1Key: null,
                mouse2Key: null,
                sensitivity: 0.003f,
                hideCursor: false,
                mouseHandler: MouseHandlerEnum.Cursor,
                usePCSX2: false
            );
        }
    }

    public enum MouseHandlerEnum
    {
        Cursor,
        RawInput
    }
}
