using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBoy.Core
{
    // 12 registers

    // 160 x 144 pixel
    // 4 shades of grey
    // 8x8 tile based
    // 20x18 tiles

    // pixels
    // 00 => black
    // 01 => light gray
    // 10 => gray
    // 11 => white

    // vram can contain more tiles

    // viewport only shows 20x18 tiles

    // window => overlay, used for scores and such

    // sprites (obj) => oam entry

    // 40 sprites in total
    // 10 sprites per line

    // Background and Window and Sprites

    class PixelProcessingUnit
    {
    }
}
