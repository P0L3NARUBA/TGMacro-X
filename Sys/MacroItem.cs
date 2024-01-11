using System;
using System.Drawing;

namespace TGMacro
{
    public class MacroItem : IDisposable
    {
        public string Name { get; set; }

        public bool Enable
        {
            get => Trigger != null && Trigger.IsEnable;
            set { if (Trigger != null) { Trigger.IsEnable = value; } }
        }

        public Bases.TriggerBase Trigger;

        public Image Icon
        {
            get
            {
                if (Trigger != null)
                {
                    switch (Trigger.TriggerType)
                    {
                        case Enums.TriggerTypes.Mouse:
                            return TGMacroX.Properties.Resources.mouse_16px;
                        case Enums.TriggerTypes.Keyboard:
                            return TGMacroX.Properties.Resources.keyboard_16px;
                        case Enums.TriggerTypes.Pixel:
                            return TGMacroX.Properties.Resources.color_16;
                        default:
                            return TGMacroX.Properties.Resources.keyboard_16px;
                    }
                }
                else
                {
                    return TGMacroX.Properties.Resources.keyboard_16px;
                }
            }
        }



        public void Dispose()
        {
            if (Trigger != null)
            {
                Trigger.Stop();
            }
        }
    }
}
