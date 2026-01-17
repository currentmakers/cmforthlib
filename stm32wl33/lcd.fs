\
\ @file lcd.fs
\ @brief LCD interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LCD_DEF

  [ifdef] LCD_LCD_CR_DEF
    \
    \ @brief LCD_CR register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LCD_LCDEN                      \ [0x00] LCD controller enable
    $01 constant LCD_VSEL                       \ [0x01] Voltage source selection
    $02 constant LCD_DUTY                       \ [0x02 : 3] Duty selection
    $05 constant LCD_BIAS                       \ [0x05 : 2] Bias selector
    $08 constant LCD_BUFEN                      \ [0x08] Voltage output buffer enable
  [then]


  [ifdef] LCD_LCD_FCR_DEF
    \
    \ @brief LCD_FCR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LCD_HD                         \ [0x00] High drive enable
    $01 constant LCD_SOFIE                      \ [0x01] Start of frame interrupt enable
    $03 constant LCD_UDDIE                      \ [0x03] Update display done interrupt enable
    $04 constant LCD_PON                        \ [0x04 : 3] Pulse ON duration
    $07 constant LCD_DEAD                       \ [0x07 : 3] Dead time duration
    $0a constant LCD_CC                         \ [0x0a : 3] Contrast control
    $0d constant LCD_BLINKF                     \ [0x0d : 3] Blink frequency selection
    $10 constant LCD_BLINK                      \ [0x10 : 2] Blink mode selection
    $12 constant LCD_DIV                        \ [0x12 : 4] DIV clock divider
    $16 constant LCD_PS                         \ [0x16 : 4] PS 16-bit prescaler
  [then]


  [ifdef] LCD_LCD_SR_DEF
    \
    \ @brief LCD_SR register
    \ Address offset: 0x08
    \ Reset value: 0x00000020
    \
    $00 constant LCD_ENS                        \ [0x00] LCD enabled status
    $01 constant LCD_SOF                        \ [0x01] Start of frame flag
    $02 constant LCD_UDR                        \ [0x02] Update display request
    $03 constant LCD_UDD                        \ [0x03] Update Display Done
    $04 constant LCD_RDY                        \ [0x04] Ready flag
    $05 constant LCD_FCRSF                      \ [0x05] LCD Frame Control Register Synchronization flag
  [then]


  [ifdef] LCD_LCD_CLR_DEF
    \
    \ @brief LCD_CLR register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant LCD_SOFC                       \ [0x01] Start of frame flag clear
    $03 constant LCD_UDDC                       \ [0x03] Update display done clear
  [then]


  [ifdef] LCD_LCD_RAM_COM0_DEF
    \
    \ @brief LCD_RAM_COMx register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 16] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM_COM1_DEF
    \
    \ @brief LCD_RAM_COMx register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 16] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM_COM2_DEF
    \
    \ @brief LCD_RAM_COMx register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 16] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM_COM3_DEF
    \
    \ @brief LCD_RAM_COMx register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 16] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM_COM4_DEF
    \
    \ @brief LCD_RAM_COMx register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 16] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM_COM5_DEF
    \
    \ @brief LCD_RAM_COMx register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 16] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM_COM6_DEF
    \
    \ @brief LCD_RAM_COMx register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 16] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM_COM7_DEF
    \
    \ @brief LCD_RAM_COMx register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 16] Each bit corresponds to one pixel of the LCD display.
  [then]

  \
  \ @brief LCD interrupt
  \
  $00 constant LCD_LCD_CR               \ LCD_CR register
  $04 constant LCD_LCD_FCR              \ LCD_FCR register
  $08 constant LCD_LCD_SR               \ LCD_SR register
  $0C constant LCD_LCD_CLR              \ LCD_CLR register
  $14 constant LCD_LCD_RAM_COM0         \ LCD_RAM_COMx register
  $1C constant LCD_LCD_RAM_COM1         \ LCD_RAM_COMx register
  $24 constant LCD_LCD_RAM_COM2         \ LCD_RAM_COMx register
  $2C constant LCD_LCD_RAM_COM3         \ LCD_RAM_COMx register
  $34 constant LCD_LCD_RAM_COM4         \ LCD_RAM_COMx register
  $3C constant LCD_LCD_RAM_COM5         \ LCD_RAM_COMx register
  $44 constant LCD_LCD_RAM_COM6         \ LCD_RAM_COMx register
  $4C constant LCD_LCD_RAM_COM7         \ LCD_RAM_COMx register

: LCD_DEF ; [then]
