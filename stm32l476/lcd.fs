\
\ @file lcd.fs
\ @brief Liquid crystal display controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LCD control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LCD_LCD_CR_LCDEN                                 \ LCD controller enable This bit is set by software to enable the LCD Controller/Driver. It is cleared by software to turn off the LCD at the beginning of the next frame. When the LCD is disabled all COM and SEG pins are driven to V<sub>SS</sub>.
$00000002 constant LCD_LCD_CR_VSEL                                  \ Voltage source selection The VSEL bit determines the voltage source for the LCD.
$0000001c constant LCD_LCD_CR_DUTY                                  \ Duty selection These bits determine the duty cycle.Unused COM pins can serve as general purpose input pins if COMIN is set. Values 101, 110 and 111 are forbidden. Others: Reserved
$00000060 constant LCD_LCD_CR_BIAS                                  \ Bias selector These bits determine the bias used. Value 11 is forbidden.
$00000080 constant LCD_LCD_CR_MUX_SEG                               \ Mux segment enable This bit is used to enable SEG pin remapping. Four SEG pins can be multiplexed with SEG[31:28] or SEG[15:12]. See Sectionm19.3.7.
$00000100 constant LCD_LCD_CR_BUFEN                                 \ Voltage output buffer enable This bit is used to enable/disable the voltage output buffer for higher driving capability.


\
\ @brief LCD frame control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LCD_LCD_FCR_HD                                   \ High drive enable This bit is written by software to enable a low resistance divider. Displays with high internal resistance may need a longer drive time to achieve satisfactory contrast. This bit is useful in this case if some additional power consumption can be tolerated.
$00000002 constant LCD_LCD_FCR_SOFIE                                \ Start of frame interrupt enable This bit is set and cleared by software.
$00000008 constant LCD_LCD_FCR_UDDIE                                \ Update display done interrupt enable This bit is set and cleared by software.
$00000070 constant LCD_LCD_FCR_PON                                  \ Pulse ON duration These bits are written by software to define the pulse duration in terms of ck_ps pulses. Amshort pulse leads to lower power consumption, but displays with high internal resistance may need a longer pulse to achieve satisfactory contrast. Note that the pulse is never longer than one half prescaled LCD clock period. PON duration example with LCDCLK = 32.768mkHz and PS=0x03:
$00000380 constant LCD_LCD_FCR_DEAD                                 \ Dead time duration These bits are written by software to configure the length of the dead time between frames. During the dead time the COM and SEG voltage levels are held at 0 V to reduce the contrast without modifying the frame rate. ......
$00001c00 constant LCD_LCD_FCR_CC                                   \ Contrast control
$0000e000 constant LCD_LCD_FCR_BLINKF                               \ Blink frequency selection
$00030000 constant LCD_LCD_FCR_BLINK                                \ Blink mode selection
$003c0000 constant LCD_LCD_FCR_DIV                                  \ DIV clock divider
$03c00000 constant LCD_LCD_FCR_PS                                   \ PS 16-bit prescaler


\
\ @brief LCD status register
\ Address offset: 0x08
\ Reset value: 0x00000020
\

$00000001 constant LCD_LCD_SR_ENS                                   \ LCD enabled status This bit is set and cleared by hardware. It indicates the LCD controller status. The ENS bit is set immediately when the LCDEN bit in the LCD_CR goes from 0 to 1. On deactivation it reflects the real status of LCD so it becomes 0 at the end of the last displayed frame.
$00000002 constant LCD_LCD_SR_SOF                                   \ Start-of-frame flag This bit is set by hardware at the beginning of a new frame, at the same time as the display data is updated. It is cleared by writing a 1 to the SOFC bit in the LCD_CLR register. The bit clear has priority over the set.
$00000004 constant LCD_LCD_SR_UDR                                   \ Update display request
$00000008 constant LCD_LCD_SR_UDD                                   \ Update display done This bit is set by hardware. It is cleared by writing 1 to the UDDC bit in the LCD_CLR register. The bit set has priority over the clear. If the device is in Stop mode (PCLK not provided), UDD does not generate an interrupt even if UDDIE = 1. If the display is not enabled the UDD interrupt never occurs.
$00000010 constant LCD_LCD_SR_RDY                                   \ Ready flag This bit is set and cleared by hardware. It indicates the status of the step-up converter.
$00000020 constant LCD_LCD_SR_FCRSF                                 \ LCD frame control register synchronization flag This bit is set by hardware each time the LCD_FCR register is updated in the LCDCLK domain. It is cleared by hardware when writing to the LCD_FCR register.


\
\ @brief LCD clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant LCD_LCD_CLR_SOFC                                 \ Start of frame flag clear This bit is written by software to clear the SOF flag in the LCD_SR register.
$00000008 constant LCD_LCD_CLR_UDDC                                 \ Update display done clear This bit is written by software to clear the UDD flag in the LCD_SR register.


\
\ @brief LCD display memory
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant LCD_LCD_RAM0_SEGMENT_DATA                        \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000fff constant LCD_LCD_RAM1_SEGMENT_DATA                        \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant LCD_LCD_RAM2_SEGMENT_DATA                        \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000fff constant LCD_LCD_RAM3_SEGMENT_DATA                        \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant LCD_LCD_RAM4_SEGMENT_DATA                        \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000fff constant LCD_LCD_RAM5_SEGMENT_DATA                        \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant LCD_LCD_RAM6_SEGMENT_DATA                        \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000fff constant LCD_LCD_RAM7_SEGMENT_DATA                        \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant LCD_LCD_RAM8_SEGMENT_DATA                        \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000000ff constant LCD_LCD_RAM9_SEGMENT_DATA                        \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant LCD_LCD_RAM10_SEGMENT_DATA                       \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000000ff constant LCD_LCD_RAM11_SEGMENT_DATA                       \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant LCD_LCD_RAM12_SEGMENT_DATA                       \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000000ff constant LCD_LCD_RAM13_SEGMENT_DATA                       \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant LCD_LCD_RAM14_SEGMENT_DATA                       \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD display memory
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$000000ff constant LCD_LCD_RAM15_SEGMENT_DATA                       \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief Liquid crystal display controller
\
$40002400 constant LCD_LCD_CR     \ offset: 0x00 : LCD control register
$40002404 constant LCD_LCD_FCR    \ offset: 0x04 : LCD frame control register
$40002408 constant LCD_LCD_SR     \ offset: 0x08 : LCD status register
$4000240c constant LCD_LCD_CLR    \ offset: 0x0C : LCD clear register
$40002414 constant LCD_LCD_RAM0   \ offset: 0x14 : LCD display memory
$40002418 constant LCD_LCD_RAM1   \ offset: 0x18 : LCD display memory
$4000241c constant LCD_LCD_RAM2   \ offset: 0x1C : LCD display memory
$40002420 constant LCD_LCD_RAM3   \ offset: 0x20 : LCD display memory
$40002424 constant LCD_LCD_RAM4   \ offset: 0x24 : LCD display memory
$40002428 constant LCD_LCD_RAM5   \ offset: 0x28 : LCD display memory
$4000242c constant LCD_LCD_RAM6   \ offset: 0x2C : LCD display memory
$40002430 constant LCD_LCD_RAM7   \ offset: 0x30 : LCD display memory
$40002434 constant LCD_LCD_RAM8   \ offset: 0x34 : LCD display memory
$40002438 constant LCD_LCD_RAM9   \ offset: 0x38 : LCD display memory
$4000243c constant LCD_LCD_RAM10  \ offset: 0x3C : LCD display memory
$40002440 constant LCD_LCD_RAM11  \ offset: 0x40 : LCD display memory
$40002444 constant LCD_LCD_RAM12  \ offset: 0x44 : LCD display memory
$40002448 constant LCD_LCD_RAM13  \ offset: 0x48 : LCD display memory
$4000244c constant LCD_LCD_RAM14  \ offset: 0x4C : LCD display memory
$40002450 constant LCD_LCD_RAM15  \ offset: 0x50 : LCD display memory

