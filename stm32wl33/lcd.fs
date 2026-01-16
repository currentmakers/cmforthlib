\
\ @file lcd.fs
\ @brief LCD interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LCD_CR register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LCD_LCD_CR_LCDEN                                 \ LCD controller enable
$00000002 constant LCD_LCD_CR_VSEL                                  \ Voltage source selection
$0000001c constant LCD_LCD_CR_DUTY                                  \ Duty selection
$00000060 constant LCD_LCD_CR_BIAS                                  \ Bias selector
$00000100 constant LCD_LCD_CR_BUFEN                                 \ Voltage output buffer enable


\
\ @brief LCD_FCR register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LCD_LCD_FCR_HD                                   \ High drive enable
$00000002 constant LCD_LCD_FCR_SOFIE                                \ Start of frame interrupt enable
$00000008 constant LCD_LCD_FCR_UDDIE                                \ Update display done interrupt enable
$00000070 constant LCD_LCD_FCR_PON                                  \ Pulse ON duration
$00000380 constant LCD_LCD_FCR_DEAD                                 \ Dead time duration
$00001c00 constant LCD_LCD_FCR_CC                                   \ Contrast control
$0000e000 constant LCD_LCD_FCR_BLINKF                               \ Blink frequency selection
$00030000 constant LCD_LCD_FCR_BLINK                                \ Blink mode selection
$003c0000 constant LCD_LCD_FCR_DIV                                  \ DIV clock divider
$03c00000 constant LCD_LCD_FCR_PS                                   \ PS 16-bit prescaler


\
\ @brief LCD_SR register
\ Address offset: 0x08
\ Reset value: 0x00000020
\

$00000001 constant LCD_LCD_SR_ENS                                   \ LCD enabled status
$00000002 constant LCD_LCD_SR_SOF                                   \ Start of frame flag
$00000004 constant LCD_LCD_SR_UDR                                   \ Update display request
$00000008 constant LCD_LCD_SR_UDD                                   \ Update Display Done
$00000010 constant LCD_LCD_SR_RDY                                   \ Ready flag
$00000020 constant LCD_LCD_SR_FCRSF                                 \ LCD Frame Control Register Synchronization flag


\
\ @brief LCD_CLR register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant LCD_LCD_CLR_SOFC                                 \ Start of frame flag clear
$00000008 constant LCD_LCD_CLR_UDDC                                 \ Update display done clear


\
\ @brief LCD_RAM_COMx register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LCD_LCD_RAM_COM0_SEGMENT_DATA                    \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD_RAM_COMx register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant LCD_LCD_RAM_COM1_SEGMENT_DATA                    \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD_RAM_COMx register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant LCD_LCD_RAM_COM2_SEGMENT_DATA                    \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD_RAM_COMx register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant LCD_LCD_RAM_COM3_SEGMENT_DATA                    \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD_RAM_COMx register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant LCD_LCD_RAM_COM4_SEGMENT_DATA                    \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD_RAM_COMx register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant LCD_LCD_RAM_COM5_SEGMENT_DATA                    \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD_RAM_COMx register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant LCD_LCD_RAM_COM6_SEGMENT_DATA                    \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD_RAM_COMx register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant LCD_LCD_RAM_COM7_SEGMENT_DATA                    \ Each bit corresponds to one pixel of the LCD display.


\
\ @brief LCD interrupt
\
$40007000 constant LCD_LCD_CR     \ offset: 0x00 : LCD_CR register
$40007004 constant LCD_LCD_FCR    \ offset: 0x04 : LCD_FCR register
$40007008 constant LCD_LCD_SR     \ offset: 0x08 : LCD_SR register
$4000700c constant LCD_LCD_CLR    \ offset: 0x0C : LCD_CLR register
$40007014 constant LCD_LCD_RAM_COM0  \ offset: 0x14 : LCD_RAM_COMx register
$4000701c constant LCD_LCD_RAM_COM1  \ offset: 0x1C : LCD_RAM_COMx register
$40007024 constant LCD_LCD_RAM_COM2  \ offset: 0x24 : LCD_RAM_COMx register
$4000702c constant LCD_LCD_RAM_COM3  \ offset: 0x2C : LCD_RAM_COMx register
$40007034 constant LCD_LCD_RAM_COM4  \ offset: 0x34 : LCD_RAM_COMx register
$4000703c constant LCD_LCD_RAM_COM5  \ offset: 0x3C : LCD_RAM_COMx register
$40007044 constant LCD_LCD_RAM_COM6  \ offset: 0x44 : LCD_RAM_COMx register
$4000704c constant LCD_LCD_RAM_COM7  \ offset: 0x4C : LCD_RAM_COMx register

