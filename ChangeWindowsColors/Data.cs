using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeWindowsColors
{
    static class Data
    {
        public static Dictionary<string, string> defColorReg = new Dictionary<string, string>()
        {

            {"ActiveBorder","180 180 180"},
            {"ActiveTitle","153 180 209"},
            {"AppWorkspace","171 171 171"},
            {"Background","0 0 0"},
            {"ButtonAlternateFace","0 0 0"},
            {"ButtonDkShadow","105 105 105"},
            {"ButtonFace","240 240 240"},
            {"ButtonHilight","255 255 255"},
            {"ButtonLight","227 227 227"},
            {"ButtonShadow","160 160 160"},
            {"ButtonText","0 0 0"},
            {"GradientActiveTitle","185 209 234"},
            {"GradientInactiveTitle","215 228 242"},
            {"GrayText","109 109 109"},
            {"Hilight","0 120 215"},
            {"HilightText","255 255 255"},
            {"HotTrackingColor","0 102 204"},
            {"InactiveBorder","244 247 252"},
            {"InactiveTitle","191 205 219"},
            {"InactiveTitleText","0 0 0"},
            {"InfoText","0 0 0"},
            {"InfoWindow","255 255 225"},
            {"Menu","240 240 240"},
            {"MenuBar","240 240 240"},
            {"MenuHilight","0 120 215"},
            {"MenuText","0 0 0"},
            {"Scrollbar","200 200 200"},
            {"TitleText","0 0 0"},
            {"Window","255 255 255"},
            {"WindowFrame","100 100 100"},
            {"WindowText","0 0 0"}
        };
        public static Dictionary<string, Color> defColorApp = new Dictionary<string, Color>()
        {
            {"Background", Color.AntiqueWhite },
            {"Menu",Color.BurlyWood},
            {"Buttons", Color.FromArgb(216, 221, 255) },
            {"ButtonsHover", Color.FromArgb(50, 200, 70, 234) }
        };
    }
}
