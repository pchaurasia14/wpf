// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
#if PBTCOMPILER
namespace MS.Internal.Markup
#else
using System.Windows.Media;
using MS.Internal;
using System.Runtime.CompilerServices;

using System;

namespace System.Windows.Media
#endif
{
    /// Enum containing handles to all known colors
    /// Since the first element is 0, second is 1, etc, we can use this to index
    /// directly into an array
    internal enum KnownColor : uint
    {
        // We've reserved the value "1" as unknown.  If for some odd reason "1" is added to the
        // list, redefined UnknownColor

        AliceBlue = 0xFFF0F8FF,
        AntiqueWhite = 0xFFFAEBD7,
        Aqua = 0xFF00FFFF,
        Aquamarine = 0xFF7FFFD4,
        Azure = 0xFFF0FFFF,
        Beige = 0xFFF5F5DC,
        Bisque = 0xFFFFE4C4,
        Black = 0xFF000000,
        BlanchedAlmond = 0xFFFFEBCD,
        Blue = 0xFF0000FF,
        BlueViolet = 0xFF8A2BE2,
        Brown = 0xFFA52A2A,
        BurlyWood = 0xFFDEB887,
        CadetBlue = 0xFF5F9EA0,
        Chartreuse = 0xFF7FFF00,
        Chocolate = 0xFFD2691E,
        Coral = 0xFFFF7F50,
        CornflowerBlue = 0xFF6495ED,
        Cornsilk = 0xFFFFF8DC,
        Crimson = 0xFFDC143C,
        Cyan = 0xFF00FFFF,
        DarkBlue = 0xFF00008B,
        DarkCyan = 0xFF008B8B,
        DarkGoldenrod = 0xFFB8860B,
        DarkGray = 0xFFA9A9A9,
        DarkGreen = 0xFF006400,
        DarkKhaki = 0xFFBDB76B,
        DarkMagenta = 0xFF8B008B,
        DarkOliveGreen = 0xFF556B2F,
        DarkOrange = 0xFFFF8C00,
        DarkOrchid = 0xFF9932CC,
        DarkRed = 0xFF8B0000,
        DarkSalmon = 0xFFE9967A,
        DarkSeaGreen = 0xFF8FBC8F,
        DarkSlateBlue = 0xFF483D8B,
        DarkSlateGray = 0xFF2F4F4F,
        DarkTurquoise = 0xFF00CED1,
        DarkViolet = 0xFF9400D3,
        DeepPink = 0xFFFF1493,
        DeepSkyBlue = 0xFF00BFFF,
        DimGray = 0xFF696969,
        DodgerBlue = 0xFF1E90FF,
        Firebrick = 0xFFB22222,
        FloralWhite = 0xFFFFFAF0,
        ForestGreen = 0xFF228B22,
        Fuchsia = 0xFFFF00FF,
        Gainsboro = 0xFFDCDCDC,
        GhostWhite = 0xFFF8F8FF,
        Gold = 0xFFFFD700,
        Goldenrod = 0xFFDAA520,
        Gray = 0xFF808080,
        Green = 0xFF008000,
        GreenYellow = 0xFFADFF2F,
        Honeydew = 0xFFF0FFF0,
        HotPink = 0xFFFF69B4,
        IndianRed = 0xFFCD5C5C,
        Indigo = 0xFF4B0082,
        Ivory = 0xFFFFFFF0,
        Khaki = 0xFFF0E68C,
        Lavender = 0xFFE6E6FA,
        LavenderBlush = 0xFFFFF0F5,
        LawnGreen = 0xFF7CFC00,
        LemonChiffon = 0xFFFFFACD,
        LightBlue = 0xFFADD8E6,
        LightCoral = 0xFFF08080,
        LightCyan = 0xFFE0FFFF,
        LightGoldenrodYellow = 0xFFFAFAD2,
        LightGreen = 0xFF90EE90,
        LightGray = 0xFFD3D3D3,
        LightPink = 0xFFFFB6C1,
        LightSalmon = 0xFFFFA07A,
        LightSeaGreen = 0xFF20B2AA,
        LightSkyBlue = 0xFF87CEFA,
        LightSlateGray = 0xFF778899,
        LightSteelBlue = 0xFFB0C4DE,
        LightYellow = 0xFFFFFFE0,
        Lime = 0xFF00FF00,
        LimeGreen = 0xFF32CD32,
        Linen = 0xFFFAF0E6,
        Magenta = 0xFFFF00FF,
        Maroon = 0xFF800000,
        MediumAquamarine = 0xFF66CDAA,
        MediumBlue = 0xFF0000CD,
        MediumOrchid = 0xFFBA55D3,
        MediumPurple = 0xFF9370DB,
        MediumSeaGreen = 0xFF3CB371,
        MediumSlateBlue = 0xFF7B68EE,
        MediumSpringGreen = 0xFF00FA9A,
        MediumTurquoise = 0xFF48D1CC,
        MediumVioletRed = 0xFFC71585,
        MidnightBlue = 0xFF191970,
        MintCream = 0xFFF5FFFA,
        MistyRose = 0xFFFFE4E1,
        Moccasin = 0xFFFFE4B5,
        NavajoWhite = 0xFFFFDEAD,
        Navy = 0xFF000080,
        OldLace = 0xFFFDF5E6,
        Olive = 0xFF808000,
        OliveDrab = 0xFF6B8E23,
        Orange = 0xFFFFA500,
        OrangeRed = 0xFFFF4500,
        Orchid = 0xFFDA70D6,
        PaleGoldenrod = 0xFFEEE8AA,
        PaleGreen = 0xFF98FB98,
        PaleTurquoise = 0xFFAFEEEE,
        PaleVioletRed = 0xFFDB7093,
        PapayaWhip = 0xFFFFEFD5,
        PeachPuff = 0xFFFFDAB9,
        Peru = 0xFFCD853F,
        Pink = 0xFFFFC0CB,
        Plum = 0xFFDDA0DD,
        PowderBlue = 0xFFB0E0E6,
        Purple = 0xFF800080,
        Red = 0xFFFF0000,
        RosyBrown = 0xFFBC8F8F,
        RoyalBlue = 0xFF4169E1,
        SaddleBrown = 0xFF8B4513,
        Salmon = 0xFFFA8072,
        SandyBrown = 0xFFF4A460,
        SeaGreen = 0xFF2E8B57,
        SeaShell = 0xFFFFF5EE,
        Sienna = 0xFFA0522D,
        Silver = 0xFFC0C0C0,
        SkyBlue = 0xFF87CEEB,
        SlateBlue = 0xFF6A5ACD,
        SlateGray = 0xFF708090,
        Snow = 0xFFFFFAFA,
        SpringGreen = 0xFF00FF7F,
        SteelBlue = 0xFF4682B4,
        Tan = 0xFFD2B48C,
        Teal = 0xFF008080,
        Thistle = 0xFFD8BFD8,
        Tomato = 0xFFFF6347,
        Transparent = 0x00FFFFFF,
        Turquoise = 0xFF40E0D0,
        Violet = 0xFFEE82EE,
        Wheat = 0xFFF5DEB3,
        White = 0xFFFFFFFF,
        WhiteSmoke = 0xFFF5F5F5,
        Yellow = 0xFFFFFF00,
        YellowGreen = 0xFF9ACD32,
        UnknownColor = 0x00000001
    }

    internal static class KnownColors
    {
#if !PBTCOMPILER

        static KnownColors()
        {
            KnownColor[] knownColorValues = Enum.GetValues<KnownColor>();
            foreach (KnownColor colorValue in knownColorValues)
            {
                string aRGBString = ToArgbString((uint)colorValue);
                s_knownArgbColors[aRGBString] = colorValue;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string ToArgbString(uint colorValue)
        {
            return string.Create(9, colorValue, (span, value) =>
            {
                span[0] = '#';
                value.TryFormat(span[1..], out _, "X8");
            });
        }

        /// Return the solid color brush from a color string.  If there's no match, null
        public static SolidColorBrush ColorStringToKnownBrush(string s)
        {
            if (string.IsNullOrEmpty(s)) return null;

            // If the result is UnknownColor, that means this string wasn't found
            // Otherwise, return the appropriate SolidColorBrush
            return ColorStringToKnownColor(s) != KnownColor.UnknownColor ? SolidColorBrushFromUint((uint)result) : null;
        }

        public static bool IsKnownSolidColorBrush(SolidColorBrush scp)
        {
            lock (s_solidColorBrushCache)
            {
                return s_solidColorBrushCache.ContainsValue(scp);
            }
        }

        public static SolidColorBrush SolidColorBrushFromUint(uint argb)
        {
            SolidColorBrush scp = null;

            lock (s_solidColorBrushCache)
            {
                // Attempt to retrieve the color.  If it fails create it.
                if (!s_solidColorBrushCache.TryGetValue(argb, out scp))
                {
                    scp = new SolidColorBrush(Color.FromUInt32(argb));
                    scp.Freeze();
                    s_solidColorBrushCache[argb] = scp;
                }
#if DEBUG
                else
                {
                    s_count++;
                }
#endif
            }

            return scp;
        }

        static internal string MatchColor(string colorString, out bool isKnownColor, out bool isNumericColor, out bool isContextColor, out bool isScRgbColor)
        {
            string trimmedString = colorString.Trim();

            if (((trimmedString.Length == 4) ||
                (trimmedString.Length == 5) ||
                (trimmedString.Length == 7) ||
                (trimmedString.Length == 9)) &&
                (trimmedString[0] == '#'))
            {
                isNumericColor = true;
                isScRgbColor = false;
                isKnownColor = false;
                isContextColor = false;
                return trimmedString;
            }
            else
                isNumericColor = false;

            if ((trimmedString.StartsWith("sc#", StringComparison.Ordinal) == true))
            {
                isNumericColor = false;
                isScRgbColor = true;
                isKnownColor = false;
                isContextColor = false;
            }
            else
            {
                isScRgbColor = false;
            }

            if ((trimmedString.StartsWith(Parsers.s_ContextColor, StringComparison.OrdinalIgnoreCase) == true))
            {
                isContextColor = true;
                isScRgbColor = false;
                isKnownColor = false;
                return trimmedString;
            }
            else
            {
                isContextColor = false;
                isKnownColor = true;
            }

            return trimmedString;
        }
#endif

        /// Return the KnownColor from a color string.  If there's no match, KnownColor.UnknownColor
        internal static KnownColor ColorStringToKnownColor(string colorString)
        {
            if (string.IsNullOrEmpty(colorString)) return KnownColor.UnknownColor;

            return s_colorMap.TryGetValue(colorString, out var knownColor) ? knownColor : KnownColor.UnknownColor;
        }

#if !PBTCOMPILER
        internal static KnownColor ArgbStringToKnownColor(string argbString)
        {
            string argbUpper = argbString.Trim().ToUpper(System.Globalization.CultureInfo.InvariantCulture);

            KnownColor color;
            if (s_knownArgbColors.TryGetValue(argbUpper, out color))
                return color;

            return KnownColor.UnknownColor;
        }
#if DEBUG
        private static int s_count = 0;
#endif

        private static Dictionary<uint, SolidColorBrush> s_solidColorBrushCache = new Dictionary<uint, SolidColorBrush>();
        private static Dictionary<string, KnownColor> s_knownArgbColors = new Dictionary<string, KnownColor>();
#endif
        private static Dictionary<string, KnownColor> s_colorMap = new()
        {
            { "RED", KnownColor.Red },
            { "TAN", KnownColor.Tan },
            { "AQUA", KnownColor.Aqua },
            { "BLUE", KnownColor.Blue },
            { "CYAN", KnownColor.Cyan },
            { "GOLD", KnownColor.Gold },
            { "GRAY", KnownColor.Gray },
            { "LIME", KnownColor.Lime },
            { "NAVY", KnownColor.Navy },
            { "PERU", KnownColor.Peru },
            { "PINK", KnownColor.Pink },
            { "PLUM", KnownColor.Plum },
            { "SNOW", KnownColor.Snow },
            { "TEAL", KnownColor.Teal },
            { "AZURE", KnownColor.Azure },
            { "BEIGE", KnownColor.Beige },
            { "BLACK", KnownColor.Black },
            { "BROWN", KnownColor.Brown },
            { "CORAL", KnownColor.Coral },
            { "GREEN", KnownColor.Green },
            { "IVORY", KnownColor.Ivory },
            { "KHAKI", KnownColor.Khaki },
            { "LINEN", KnownColor.Linen },
            { "OLIVE", KnownColor.Olive },
            { "WHEAT", KnownColor.Wheat },
            { "WHITE", KnownColor.White },
            { "BISQUE", KnownColor.Bisque },
            { "INDIGO", KnownColor.Indigo },
            { "MAROON", KnownColor.Maroon },
            { "ORANGE", KnownColor.Orange },
            { "ORCHID", KnownColor.Orchid },
            { "PURPLE", KnownColor.Purple },
            { "SALMON", KnownColor.Salmon },
            { "SIENNA", KnownColor.Sienna },
            { "SILVER", KnownColor.Silver },
            { "TOMATO", KnownColor.Tomato },
            { "VIOLET", KnownColor.Violet },
            { "YELLOW", KnownColor.Yellow },
            { "CRIMSON", KnownColor.Crimson },
            { "DARKRED", KnownColor.DarkRed },
            { "DIMGRAY", KnownColor.DimGray },
            { "FUCHSIA", KnownColor.Fuchsia },
            { "HOTPINK", KnownColor.HotPink },
            { "MAGENTA", KnownColor.Magenta },
            { "OLDLACE", KnownColor.OldLace },
            { "SKYBLUE", KnownColor.SkyBlue },
            { "THISTLE", KnownColor.Thistle },
            { "CORNSILK", KnownColor.Cornsilk },
            { "DARKBLUE", KnownColor.DarkBlue },
            { "DARKCYAN", KnownColor.DarkCyan },
            { "DARKGRAY", KnownColor.DarkGray },
            { "DEEPPINK", KnownColor.DeepPink },
            { "HONEYDEW", KnownColor.Honeydew },
            { "LAVENDER", KnownColor.Lavender },
            { "MOCCASIN", KnownColor.Moccasin },
            { "SEAGREEN", KnownColor.SeaGreen },
            { "SEASHELL", KnownColor.SeaShell },
            { "ALICEBLUE", KnownColor.AliceBlue },
            { "BURLYWOOD", KnownColor.BurlyWood },
            { "CADETBLUE", KnownColor.CadetBlue },
            { "CHOCOLATE", KnownColor.Chocolate },
            { "DARKGREEN", KnownColor.DarkGreen },
            { "DARKKHAKI", KnownColor.DarkKhaki },
            { "FIREBRICK", KnownColor.Firebrick },
            { "GAINSBORO", KnownColor.Gainsboro },
            { "GOLDENROD", KnownColor.Goldenrod },
            { "INDIANRED", KnownColor.IndianRed },
            { "LAWNGREEN", KnownColor.LawnGreen },
            { "LIGHTBLUE", KnownColor.LightBlue },
            { "LIGHTCYAN", KnownColor.LightCyan },
            { "LIGHTGRAY", KnownColor.LightGray },
            { "LIGHTPINK", KnownColor.LightPink },
            { "LIMEGREEN", KnownColor.LimeGreen },
            { "MINTCREAM", KnownColor.MintCream },
            { "MISTYROSE", KnownColor.MistyRose },
            { "OLIVEDRAB", KnownColor.OliveDrab },
            { "ORANGERED", KnownColor.OrangeRed },
            { "PALEGREEN", KnownColor.PaleGreen },
            { "PEACHPUFF", KnownColor.PeachPuff },
            { "ROSYBROWN", KnownColor.RosyBrown },
            { "ROYALBLUE", KnownColor.RoyalBlue },
            { "SLATEBLUE", KnownColor.SlateBlue },
            { "SLATEGRAY", KnownColor.SlateGray },
            { "STEELBLUE", KnownColor.SteelBlue },
            { "TURQUOISE", KnownColor.Turquoise },
            { "AQUAMARINE", KnownColor.Aquamarine },
            { "BLUEVIOLET", KnownColor.BlueViolet },
            { "CHARTREUSE", KnownColor.Chartreuse },
            { "DARKORANGE", KnownColor.DarkOrange },
            { "DARKORCHID", KnownColor.DarkOrchid },
            { "DARKSALMON", KnownColor.DarkSalmon },
            { "DARKVIOLET", KnownColor.DarkViolet },
            { "DODGERBLUE", KnownColor.DodgerBlue },
            { "GHOSTWHITE", KnownColor.GhostWhite },
            { "LIGHTCORAL", KnownColor.LightCoral },
            { "LIGHTGREEN", KnownColor.LightGreen },
            { "MEDIUMBLUE", KnownColor.MediumBlue },
            { "PAPAYAWHIP", KnownColor.PapayaWhip },
            { "POWDERBLUE", KnownColor.PowderBlue },
            { "SANDYBROWN", KnownColor.SandyBrown },
            { "WHITESMOKE", KnownColor.WhiteSmoke },
            { "DARKMAGENTA", KnownColor.DarkMagenta },
            { "DEEPSKYBLUE", KnownColor.DeepSkyBlue },
            { "FLORALWHITE", KnownColor.FloralWhite },
            { "FORESTGREEN", KnownColor.ForestGreen },
            { "GREENYELLOW", KnownColor.GreenYellow },
            { "LIGHTSALMON", KnownColor.LightSalmon },
            { "LIGHTYELLOW", KnownColor.LightYellow },
            { "NAVAJOWHITE", KnownColor.NavajoWhite },
            { "SADDLEBROWN", KnownColor.SaddleBrown },
            { "SPRINGGREEN", KnownColor.SpringGreen },
            { "TRANSPARENT", KnownColor.Transparent },
            { "YELLOWGREEN", KnownColor.YellowGreen },
            { "ANTIQUEWHITE", KnownColor.AntiqueWhite },
            { "DARKSEAGREEN", KnownColor.DarkSeaGreen },
            { "LIGHTSKYBLUE", KnownColor.LightSkyBlue },
            { "LEMONCHIFFON", KnownColor.LemonChiffon },
            { "MEDIUMORCHID", KnownColor.MediumOrchid },
            { "MEDIUMPURPLE", KnownColor.MediumPurple },
            { "MIDNIGHTBLUE", KnownColor.MidnightBlue },
            { "DARKSLATEBLUE", KnownColor.DarkSlateBlue },
            { "DARKSLATEGRAY", KnownColor.DarkSlateGray },
            { "DARKGOLDENROD", KnownColor.DarkGoldenrod },
            { "DARKTURQUOISE", KnownColor.DarkTurquoise },
            { "LIGHTSEAGREEN", KnownColor.LightSeaGreen },
            { "LAVENDERBLUSH", KnownColor.LavenderBlush },
            { "PALEGOLDENROD", KnownColor.PaleGoldenrod },
            { "PALETURQUOISE", KnownColor.PaleTurquoise },
            { "PALEVIOLETRED", KnownColor.PaleVioletRed },
            { "BLANCHEDALMOND", KnownColor.BlanchedAlmond },
            { "CORNFLOWERBLUE", KnownColor.CornflowerBlue },
            { "DARKOLIVEGREEN", KnownColor.DarkOliveGreen },
            { "LIGHTSLATEGRAY", KnownColor.LightSlateGray },
            { "LIGHTSTEELBLUE", KnownColor.LightSteelBlue },
            { "MEDIUMSEAGREEN", KnownColor.MediumSeaGreen },
            { "MEDIUMSLATEBLUE", KnownColor.MediumSlateBlue },
            { "MEDIUMTURQUOISE", KnownColor.MediumTurquoise },
            { "MEDIUMVIOLETRED", KnownColor.MediumVioletRed },
            { "MEDIUMAQUAMARINE", KnownColor.MediumAquamarine },
            { "MEDIUMSPRINGGREEN", KnownColor.MediumSpringGreen },
            { "LIGHTGOLDENRODYELLOW", KnownColor.LightGoldenrodYellow}
        };

    }

#if !PBTCOMPILER
    /// <summary>
    /// Colors - A collection of well-known Colors
    /// </summary>
    public sealed class Colors
    {

        #region Constructors
        // Colors only has static members, so it shouldn't be constructable.
        private Colors()
        {
        }

        #endregion Constructors

        #region static Known Colors

        /// <summary>
        /// Well-known color: AliceBlue
        /// </summary>
        public static Color AliceBlue => Color.FromUInt32((uint)KnownColor.AliceBlue);

        /// <summary>
        /// Well-known color: AntiqueWhite
        /// </summary>
        public static Color AntiqueWhite => Color.FromUInt32((uint)KnownColor.AntiqueWhite);

        /// <summary>
        /// Well-known color: Aqua
        /// </summary>
        public static Color Aqua => Color.FromUInt32((uint)KnownColor.Aqua);

        /// <summary>
        /// Well-known color: Aquamarine
        /// </summary>
        public static Color Aquamarine => Color.FromUInt32((uint)KnownColor.Aquamarine);

        /// <summary>
        /// Well-known color: Azure
        /// </summary>
        public static Color Azure => Color.FromUInt32((uint)KnownColor.Azure);

        /// <summary>
        /// Well-known color: Beige
        /// </summary>
        public static Color Beige => Color.FromUInt32((uint)KnownColor.Beige);

        /// <summary>
        /// Well-known color: Bisque
        /// </summary>
        public static Color Bisque => Color.FromUInt32((uint)KnownColor.Bisque);

        /// <summary>
        /// Well-known color: Black
        /// </summary>
        public static Color Black => Color.FromUInt32((uint)KnownColor.Black);

        /// <summary>
        /// Well-known color: BlanchedAlmond
        /// </summary>
        public static Color BlanchedAlmond => Color.FromUInt32((uint)KnownColor.BlanchedAlmond);

        /// <summary>
        /// Well-known color: Blue
        /// </summary>
        public static Color Blue => Color.FromUInt32((uint)KnownColor.Blue);

        /// <summary>
        /// Well-known color: BlueViolet
        /// </summary>
        public static Color BlueViolet => Color.FromUInt32((uint)KnownColor.BlueViolet);

        /// <summary>
        /// Well-known color: Brown
        /// </summary>
        public static Color Brown => Color.FromUInt32((uint)KnownColor.Brown);

        /// <summary>
        /// Well-known color: BurlyWood
        /// </summary>
        public static Color BurlyWood => Color.FromUInt32((uint)KnownColor.BurlyWood);

        /// <summary>
        /// Well-known color: CadetBlue
        /// </summary>
        public static Color CadetBlue => Color.FromUInt32((uint)KnownColor.CadetBlue);

        /// <summary>
        /// Well-known color: Chartreuse
        /// </summary>
        public static Color Chartreuse => Color.FromUInt32((uint)KnownColor.Chartreuse);

        /// <summary>
        /// Well-known color: Chocolate
        /// </summary>
        public static Color Chocolate => Color.FromUInt32((uint)KnownColor.Chocolate);

        /// <summary>
        /// Well-known color: Coral
        /// </summary>
        public static Color Coral => Color.FromUInt32((uint)KnownColor.Coral);

        /// <summary>
        /// Well-known color: CornflowerBlue
        /// </summary>
        public static Color CornflowerBlue => Color.FromUInt32((uint)KnownColor.CornflowerBlue);

        /// <summary>
        /// Well-known color: Cornsilk
        /// </summary>
        public static Color Cornsilk => Color.FromUInt32((uint)KnownColor.Cornsilk);

        /// <summary>
        /// Well-known color: Crimson
        /// </summary>
        public static Color Crimson => Color.FromUInt32((uint)KnownColor.Crimson);

        /// <summary>
        /// Well-known color: Cyan
        /// </summary>
        public static Color Cyan => Color.FromUInt32((uint)KnownColor.Cyan);

        /// <summary>
        /// Well-known color: DarkBlue
        /// </summary>
        public static Color DarkBlue => Color.FromUInt32((uint)KnownColor.DarkBlue);

        /// <summary>
        /// Well-known color: DarkCyan
        /// </summary>
        public static Color DarkCyan => Color.FromUInt32((uint)KnownColor.DarkCyan);

        /// <summary>
        /// Well-known color: DarkGoldenrod
        /// </summary>
        public static Color DarkGoldenrod => Color.FromUInt32((uint)KnownColor.DarkGoldenrod);

        /// <summary>
        /// Well-known color: DarkGray
        /// </summary>
        public static Color DarkGray => Color.FromUInt32((uint)KnownColor.DarkGray);

        /// <summary>
        /// Well-known color: DarkGreen
        /// </summary>
        public static Color DarkGreen => Color.FromUInt32((uint)KnownColor.DarkGreen);

        /// <summary>
        /// Well-known color: DarkKhaki
        /// </summary>
        public static Color DarkKhaki => Color.FromUInt32((uint)KnownColor.DarkKhaki);

        /// <summary>
        /// Well-known color: DarkMagenta
        /// </summary>
        public static Color DarkMagenta => Color.FromUInt32((uint)KnownColor.DarkMagenta);

        /// <summary>
        /// Well-known color: DarkOliveGreen
        /// </summary>
        public static Color DarkOliveGreen => Color.FromUInt32((uint)KnownColor.DarkOliveGreen);

        /// <summary>
        /// Well-known color: DarkOrange
        /// </summary>
        public static Color DarkOrange => Color.FromUInt32((uint)KnownColor.DarkOrange);

        /// <summary>
        /// Well-known color: DarkOrchid
        /// </summary>
        public static Color DarkOrchid => Color.FromUInt32((uint)KnownColor.DarkOrchid);

        /// <summary>
        /// Well-known color: DarkRed
        /// </summary>
        public static Color DarkRed => Color.FromUInt32((uint)KnownColor.DarkRed);

        /// <summary>
        /// Well-known color: DarkSalmon
        /// </summary>
        public static Color DarkSalmon => Color.FromUInt32((uint)KnownColor.DarkSalmon);

        /// <summary>
        /// Well-known color: DarkSeaGreen
        /// </summary>
        public static Color DarkSeaGreen => Color.FromUInt32((uint)KnownColor.DarkSeaGreen);

        /// <summary>
        /// Well-known color: DarkSlateBlue
        /// </summary>
        public static Color DarkSlateBlue => Color.FromUInt32((uint)KnownColor.DarkSlateBlue);

        /// <summary>
        /// Well-known color: DarkSlateGray
        /// </summary>
        public static Color DarkSlateGray => Color.FromUInt32((uint)KnownColor.DarkSlateGray);

        /// <summary>
        /// Well-known color: DarkTurquoise
        /// </summary>
        public static Color DarkTurquoise => Color.FromUInt32((uint)KnownColor.DarkTurquoise);

        /// <summary>
        /// Well-known color: DarkViolet
        /// </summary>
        public static Color DarkViolet => Color.FromUInt32((uint)KnownColor.DarkViolet);

        /// <summary>
        /// Well-known color: DeepPink
        /// </summary>
        public static Color DeepPink => Color.FromUInt32((uint)KnownColor.DeepPink);

        /// <summary>
        /// Well-known color: DeepSkyBlue
        /// </summary>
        public static Color DeepSkyBlue => Color.FromUInt32((uint)KnownColor.DeepSkyBlue);

        /// <summary>
        /// Well-known color: DimGray
        /// </summary>
        public static Color DimGray => Color.FromUInt32((uint)KnownColor.DimGray);

        /// <summary>
        /// Well-known color: DodgerBlue
        /// </summary>
        public static Color DodgerBlue => Color.FromUInt32((uint)KnownColor.DodgerBlue);

        /// <summary>
        /// Well-known color: Firebrick
        /// </summary>
        public static Color Firebrick => Color.FromUInt32((uint)KnownColor.Firebrick);

        /// <summary>
        /// Well-known color: FloralWhite
        /// </summary>
        public static Color FloralWhite => Color.FromUInt32((uint)KnownColor.FloralWhite);

        /// <summary>
        /// Well-known color: ForestGreen
        /// </summary>
        public static Color ForestGreen => Color.FromUInt32((uint)KnownColor.ForestGreen);

        /// <summary>
        /// Well-known color: Fuchsia
        /// </summary>
        public static Color Fuchsia => Color.FromUInt32((uint)KnownColor.Fuchsia);

        /// <summary>
        /// Well-known color: Gainsboro
        /// </summary>
        public static Color Gainsboro => Color.FromUInt32((uint)KnownColor.Gainsboro);

        /// <summary>
        /// Well-known color: GhostWhite
        /// </summary>
        public static Color GhostWhite => Color.FromUInt32((uint)KnownColor.GhostWhite);

        /// <summary>
        /// Well-known color: Gold
        /// </summary>
        public static Color Gold => Color.FromUInt32((uint)KnownColor.Gold);

        /// <summary>
        /// Well-known color: Goldenrod
        /// </summary>
        public static Color Goldenrod => Color.FromUInt32((uint)KnownColor.Goldenrod);

        /// <summary>
        /// Well-known color: Gray
        /// </summary>
        public static Color Gray => Color.FromUInt32((uint)KnownColor.Gray);

        /// <summary>
        /// Well-known color: Green
        /// </summary>
        public static Color Green => Color.FromUInt32((uint)KnownColor.Green);

        /// <summary>
        /// Well-known color: GreenYellow
        /// </summary>
        public static Color GreenYellow => Color.FromUInt32((uint)KnownColor.GreenYellow);

        /// <summary>
        /// Well-known color: Honeydew
        /// </summary>
        public static Color Honeydew => Color.FromUInt32((uint)KnownColor.Honeydew);

        /// <summary>
        /// Well-known color: HotPink
        /// </summary>
        public static Color HotPink => Color.FromUInt32((uint)KnownColor.HotPink);

        /// <summary>
        /// Well-known color: IndianRed
        /// </summary>
        public static Color IndianRed => Color.FromUInt32((uint)KnownColor.IndianRed);

        /// <summary>
        /// Well-known color: Indigo
        /// </summary>
        public static Color Indigo => Color.FromUInt32((uint)KnownColor.Indigo);

        /// <summary>
        /// Well-known color: Ivory
        /// </summary>
        public static Color Ivory => Color.FromUInt32((uint)KnownColor.Ivory);

        /// <summary>
        /// Well-known color: Khaki
        /// </summary>
        public static Color Khaki => Color.FromUInt32((uint)KnownColor.Khaki);

        /// <summary>
        /// Well-known color: Lavender
        /// </summary>
        public static Color Lavender => Color.FromUInt32((uint)KnownColor.Lavender);

        /// <summary>
        /// Well-known color: LavenderBlush
        /// </summary>
        public static Color LavenderBlush => Color.FromUInt32((uint)KnownColor.LavenderBlush);

        /// <summary>
        /// Well-known color: LawnGreen
        /// </summary>
        public static Color LawnGreen => Color.FromUInt32((uint)KnownColor.LawnGreen);

        /// <summary>
        /// Well-known color: LemonChiffon
        /// </summary>
        public static Color LemonChiffon => Color.FromUInt32((uint)KnownColor.LemonChiffon);

        /// <summary>
        /// Well-known color: LightBlue
        /// </summary>
        public static Color LightBlue => Color.FromUInt32((uint)KnownColor.LightBlue);

        /// <summary>
        /// Well-known color: LightCoral
        /// </summary>
        public static Color LightCoral => Color.FromUInt32((uint)KnownColor.LightCoral);

        /// <summary>
        /// Well-known color: LightCyan
        /// </summary>
        public static Color LightCyan => Color.FromUInt32((uint)KnownColor.LightCyan);

        /// <summary>
        /// Well-known color: LightGoldenrodYellow
        /// </summary>
        public static Color LightGoldenrodYellow => Color.FromUInt32((uint)KnownColor.LightGoldenrodYellow);

        /// <summary>
        /// Well-known color: LightGray
        /// </summary>
        public static Color LightGray => Color.FromUInt32((uint)KnownColor.LightGray);

        /// <summary>
        /// Well-known color: LightGreen
        /// </summary>
        public static Color LightGreen => Color.FromUInt32((uint)KnownColor.LightGreen);

        /// <summary>
        /// Well-known color: LightPink
        /// </summary>
        public static Color LightPink => Color.FromUInt32((uint)KnownColor.LightPink);

        /// <summary>
        /// Well-known color: LightSalmon
        /// </summary>
        public static Color LightSalmon => Color.FromUInt32((uint)KnownColor.LightSalmon);

        /// <summary>
        /// Well-known color: LightSeaGreen
        /// </summary>
        public static Color LightSeaGreen => Color.FromUInt32((uint)KnownColor.LightSeaGreen);

        /// <summary>
        /// Well-known color: LightSkyBlue
        /// </summary>
        public static Color LightSkyBlue => Color.FromUInt32((uint)KnownColor.LightSkyBlue);

        /// <summary>
        /// Well-known color: LightSlateGray
        /// </summary>
        public static Color LightSlateGray => Color.FromUInt32((uint)KnownColor.LightSlateGray);

        /// <summary>
        /// Well-known color: LightSteelBlue
        /// </summary>
        public static Color LightSteelBlue => Color.FromUInt32((uint)KnownColor.LightSteelBlue);

        /// <summary>
        /// Well-known color: LightYellow
        /// </summary>
        public static Color LightYellow => Color.FromUInt32((uint)KnownColor.LightYellow);

        /// <summary>
        /// Well-known color: Lime
        /// </summary>
        public static Color Lime => Color.FromUInt32((uint)KnownColor.Lime);

        /// <summary>
        /// Well-known color: LimeGreen
        /// </summary>
        public static Color LimeGreen => Color.FromUInt32((uint)KnownColor.LimeGreen);

        /// <summary>
        /// Well-known color: Linen
        /// </summary>
        public static Color Linen => Color.FromUInt32((uint)KnownColor.Linen);

        /// <summary>
        /// Well-known color: Magenta
        /// </summary>
        public static Color Magenta => Color.FromUInt32((uint)KnownColor.Magenta);

        /// <summary>
        /// Well-known color: Maroon
        /// </summary>
        public static Color Maroon => Color.FromUInt32((uint)KnownColor.Maroon);

        /// <summary>
        /// Well-known color: MediumAquamarine
        /// </summary>
        public static Color MediumAquamarine => Color.FromUInt32((uint)KnownColor.MediumAquamarine);

        /// <summary>
        /// Well-known color: MediumBlue
        /// </summary>
        public static Color MediumBlue => Color.FromUInt32((uint)KnownColor.MediumBlue);

        /// <summary>
        /// Well-known color: MediumOrchid
        /// </summary>
        public static Color MediumOrchid => Color.FromUInt32((uint)KnownColor.MediumOrchid);

        /// <summary>
        /// Well-known color: MediumPurple
        /// </summary>
        public static Color MediumPurple => Color.FromUInt32((uint)KnownColor.MediumPurple);

        /// <summary>
        /// Well-known color: MediumSeaGreen
        /// </summary>
        public static Color MediumSeaGreen => Color.FromUInt32((uint)KnownColor.MediumSeaGreen);

        /// <summary>
        /// Well-known color: MediumSlateBlue
        /// </summary>
        public static Color MediumSlateBlue => Color.FromUInt32((uint)KnownColor.MediumSlateBlue);

        /// <summary>
        /// Well-known color: MediumSpringGreen
        /// </summary>
        public static Color MediumSpringGreen => Color.FromUInt32((uint)KnownColor.MediumSpringGreen);

        /// <summary>
        /// Well-known color: MediumTurquoise
        /// </summary>
        public static Color MediumTurquoise => Color.FromUInt32((uint)KnownColor.MediumTurquoise);

        /// <summary>
        /// Well-known color: MediumVioletRed
        /// </summary>
        public static Color MediumVioletRed => Color.FromUInt32((uint)KnownColor.MediumVioletRed);

        /// <summary>
        /// Well-known color: MidnightBlue
        /// </summary>
        public static Color MidnightBlue => Color.FromUInt32((uint)KnownColor.MidnightBlue);

        /// <summary>
        /// Well-known color: MintCream
        /// </summary>
        public static Color MintCream => Color.FromUInt32((uint)KnownColor.MintCream);

        /// <summary>
        /// Well-known color: MistyRose
        /// </summary>
        public static Color MistyRose => Color.FromUInt32((uint)KnownColor.MistyRose);

        /// <summary>
        /// Well-known color: Moccasin
        /// </summary>
        public static Color Moccasin => Color.FromUInt32((uint)KnownColor.Moccasin);

        /// <summary>
        /// Well-known color: NavajoWhite
        /// </summary>
        public static Color NavajoWhite => Color.FromUInt32((uint)KnownColor.NavajoWhite);

        /// <summary>
        /// Well-known color: Navy
        /// </summary>
        public static Color Navy => Color.FromUInt32((uint)KnownColor.Navy);

        /// <summary>
        /// Well-known color: OldLace
        /// </summary>
        public static Color OldLace => Color.FromUInt32((uint)KnownColor.OldLace);

        /// <summary>
        /// Well-known color: Olive
        /// </summary>
        public static Color Olive => Color.FromUInt32((uint)KnownColor.Olive);

        /// <summary>
        /// Well-known color: OliveDrab
        /// </summary>
        public static Color OliveDrab => Color.FromUInt32((uint)KnownColor.OliveDrab);

        /// <summary>
        /// Well-known color: Orange
        /// </summary>
        public static Color Orange => Color.FromUInt32((uint)KnownColor.Orange);

        /// <summary>
        /// Well-known color: OrangeRed
        /// </summary>
        public static Color OrangeRed => Color.FromUInt32((uint)KnownColor.OrangeRed);

        /// <summary>
        /// Well-known color: Orchid
        /// </summary>
        public static Color Orchid => Color.FromUInt32((uint)KnownColor.Orchid);

        /// <summary>
        /// Well-known color: PaleGoldenrod
        /// </summary>
        public static Color PaleGoldenrod => Color.FromUInt32((uint)KnownColor.PaleGoldenrod);

        /// <summary>
        /// Well-known color: PaleGreen
        /// </summary>
        public static Color PaleGreen => Color.FromUInt32((uint)KnownColor.PaleGreen);

        /// <summary>
        /// Well-known color: PaleTurquoise
        /// </summary>
        public static Color PaleTurquoise => Color.FromUInt32((uint)KnownColor.PaleTurquoise);

        /// <summary>
        /// Well-known color: PaleVioletRed
        /// </summary>
        public static Color PaleVioletRed => Color.FromUInt32((uint)KnownColor.PaleVioletRed);

        /// <summary>
        /// Well-known color: PapayaWhip
        /// </summary>
        public static Color PapayaWhip => Color.FromUInt32((uint)KnownColor.PapayaWhip);

        /// <summary>
        /// Well-known color: PeachPuff
        /// </summary>
        public static Color PeachPuff => Color.FromUInt32((uint)KnownColor.PeachPuff);

        /// <summary>
        /// Well-known color: Peru
        /// </summary>
        public static Color Peru => Color.FromUInt32((uint)KnownColor.Peru);

        /// <summary>
        /// Well-known color: Pink
        /// </summary>
        public static Color Pink => Color.FromUInt32((uint)KnownColor.Pink);

        /// <summary>
        /// Well-known color: Plum
        /// </summary>
        public static Color Plum => Color.FromUInt32((uint)KnownColor.Plum);

        /// <summary>
        /// Well-known color: PowderBlue
        /// </summary>
        public static Color PowderBlue => Color.FromUInt32((uint)KnownColor.PowderBlue);

        /// <summary>
        /// Well-known color: Purple
        /// </summary>
        public static Color Purple => Color.FromUInt32((uint)KnownColor.Purple);

        /// <summary>
        /// Well-known color: Red
        /// </summary>
        public static Color Red => Color.FromUInt32((uint)KnownColor.Red);

        /// <summary>
        /// Well-known color: RosyBrown
        /// </summary>
        public static Color RosyBrown => Color.FromUInt32((uint)KnownColor.RosyBrown);

        /// <summary>
        /// Well-known color: RoyalBlue
        /// </summary>
        public static Color RoyalBlue => Color.FromUInt32((uint)KnownColor.RoyalBlue);

        /// <summary>
        /// Well-known color: SaddleBrown
        /// </summary>
        public static Color SaddleBrown => Color.FromUInt32((uint)KnownColor.SaddleBrown);

        /// <summary>
        /// Well-known color: Salmon
        /// </summary>
        public static Color Salmon => Color.FromUInt32((uint)KnownColor.Salmon);

        /// <summary>
        /// Well-known color: SandyBrown
        /// </summary>
        public static Color SandyBrown => Color.FromUInt32((uint)KnownColor.SandyBrown);

        /// <summary>
        /// Well-known color: SeaGreen
        /// </summary>
        public static Color SeaGreen => Color.FromUInt32((uint)KnownColor.SeaGreen);

        /// <summary>
        /// Well-known color: SeaShell
        /// </summary>
        public static Color SeaShell => Color.FromUInt32((uint)KnownColor.SeaShell);

        /// <summary>
        /// Well-known color: Sienna
        /// </summary>
        public static Color Sienna => Color.FromUInt32((uint)KnownColor.Sienna);

        /// <summary>
        /// Well-known color: Silver
        /// </summary>
        public static Color Silver => Color.FromUInt32((uint)KnownColor.Silver);

        /// <summary>
        /// Well-known color: SkyBlue
        /// </summary>
        public static Color SkyBlue => Color.FromUInt32((uint)KnownColor.SkyBlue);

        /// <summary>
        /// Well-known color: SlateBlue
        /// </summary>
        public static Color SlateBlue => Color.FromUInt32((uint)KnownColor.SlateBlue);

        /// <summary>
        /// Well-known color: SlateGray
        /// </summary>
        public static Color SlateGray => Color.FromUInt32((uint)KnownColor.SlateGray);

        /// <summary>
        /// Well-known color: Snow
        /// </summary>
        public static Color Snow => Color.FromUInt32((uint)KnownColor.Snow);

        /// <summary>
        /// Well-known color: SpringGreen
        /// </summary>
        public static Color SpringGreen => Color.FromUInt32((uint)KnownColor.SpringGreen);

        /// <summary>
        /// Well-known color: SteelBlue
        /// </summary>
        public static Color SteelBlue => Color.FromUInt32((uint)KnownColor.SteelBlue);

        /// <summary>
        /// Well-known color: Tan
        /// </summary>
        public static Color Tan => Color.FromUInt32((uint)KnownColor.Tan);

        /// <summary>
        /// Well-known color: Teal
        /// </summary>
        public static Color Teal => Color.FromUInt32((uint)KnownColor.Teal);

        /// <summary>
        /// Well-known color: Thistle
        /// </summary>
        public static Color Thistle => Color.FromUInt32((uint)KnownColor.Thistle);

        /// <summary>
        /// Well-known color: Tomato
        /// </summary>
        public static Color Tomato => Color.FromUInt32((uint)KnownColor.Tomato);

        /// <summary>
        /// Well-known color: Transparent
        /// </summary>
        public static Color Transparent => Color.FromUInt32((uint)KnownColor.Transparent);

        /// <summary>
        /// Well-known color: Turquoise
        /// </summary>
        public static Color Turquoise => Color.FromUInt32((uint)KnownColor.Turquoise);

        /// <summary>
        /// Well-known color: Violet
        /// </summary>
        public static Color Violet => Color.FromUInt32((uint)KnownColor.Violet);

        /// <summary>
        /// Well-known color: Wheat
        /// </summary>
        public static Color Wheat => Color.FromUInt32((uint)KnownColor.Wheat);

        /// <summary>
        /// Well-known color: White
        /// </summary>
        public static Color White => Color.FromUInt32((uint)KnownColor.White);

        /// <summary>
        /// Well-known color: WhiteSmoke
        /// </summary>
        public static Color WhiteSmoke => Color.FromUInt32((uint)KnownColor.WhiteSmoke);

        /// <summary>
        /// Well-known color: Yellow
        /// </summary>
        public static Color Yellow => Color.FromUInt32((uint)KnownColor.Yellow);

        /// <summary>
        /// Well-known color: YellowGreen
        /// </summary>
        public static Color YellowGreen => Color.FromUInt32((uint)KnownColor.YellowGreen);

        #endregion static Known Colors
    }
#endif
}
