namespace AnsiToHtml

module internal Constants = 
    open System.Collections.Generic
    [<Literal>]
    let ANSI_FULL_RESET = 0
    [<Literal>]
    let ANSI_INTENSITY_INCREASED = 1
    [<Literal>]
    let ANSI_INTENSITY_REDUCED = 2
    [<Literal>]
    let ANSI_INTENSITY_NORMAL = 22
    [<Literal>]
    let ANSI_STYLE_ITALIC = 3
    [<Literal>]
    let ANSI_STYLE_NORMAL = 23
    [<Literal>]
    let ANSI_BLINK_SLOW = 5
    [<Literal>]
    let ANSI_BLINK_FAST = 6
    [<Literal>]
    let ANSI_BLINK_OFF = 25
    [<Literal>]
    let ANSI_UNDERLINE_ON = 4
    [<Literal>]
    let ANSI_UNDERLINE_OFF = 24
    [<Literal>]
    let ANSI_CROSSED_OUT_ON = 9
    [<Literal>]
    let ANSI_CROSSED_OUT_OFF = 29
    [<Literal>]
    let ANSI_VISIBILITY_ON = 28
    [<Literal>]
    let ANSI_VISIBILITY_OFF = 8
    [<Literal>]
    let ANSI_FOREGROUND_CUSTOM_MIN = 30
    [<Literal>]
    let ANSI_FOREGROUND_CUSTOM_MAX = 37
    [<Literal>]
    let ANSI_FOREGROUND = 38
    [<Literal>]
    let ANSI_FOREGROUND_DEFAULT = 39
    [<Literal>]
    let ANSI_BACKGROUND_CUSTOM_MIN = 40
    [<Literal>]
    let ANSI_BACKGROUND_CUSTOM_MAX = 47
    [<Literal>]
    let ANSI_BACKGROUND = 48
    [<Literal>]
    let ANSI_BACKGROUND_DEFAULT = 49
    [<Literal>]
    let ANSI_NEGATIVE_ON = 7
    [<Literal>]
    let ANSI_NEGATIVE_OFF = 27
    [<Literal>]
    let ANSI_FOREGROUND_HIGH_INTENSITY_MIN = 90
    [<Literal>]
    let ANSI_FOREGROUND_HIGH_INTENSITY_MAX = 97
    [<Literal>]
    let ANSI_BACKGROUND_HIGH_INTENSITY_MIN = 100
    [<Literal>]
    let ANSI_BACKGROUND_HIGH_INTENSITY_MAX = 107
    [<Literal>]
    let ANSI_256_COLOR_ID = 5
    [<Literal>]
    let ANSI_TRUECOLOR_ID = 2

    let VT100_BOX_CODES = readOnlyDict[("0x71", "─"); ("0x74", "├"); ("0x75", "┤"); ("0x76", "┴"); ("0x77", "┬"); ("0x78", "│"); ("0x6a", "┘"); ("0x6b", "┐"); ("0x6c", "┌"); ("0x6d", "└"); ("0x6e", "┼")]

module Say =

    let hello name =
        printfn "Hello %d" Constants.ANSI_256_COLOR_ID
