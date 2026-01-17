\
\ @file lcd.fs
\ @brief Liquid crystal display controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LCD_DEF

  [ifdef] LCD_LCD_CR_DEF
    \
    \ @brief LCD control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LCD_LCDEN                      \ [0x00] LCD controller enable This bit is set by software to enable the LCD Controller/Driver. It is cleared by software to turn off the LCD at the beginning of the next frame. When the LCD is disabled all COM and SEG pins are driven to V<sub>SS</sub>.
    $01 constant LCD_VSEL                       \ [0x01] Voltage source selection The VSEL bit determines the voltage source for the LCD.
    $02 constant LCD_DUTY                       \ [0x02 : 3] Duty selection These bits determine the duty cycle.Unused COM pins can serve as general purpose input pins if COMIN is set. Values 101, 110 and 111 are forbidden. Others: Reserved
    $05 constant LCD_BIAS                       \ [0x05 : 2] Bias selector These bits determine the bias used. Value 11 is forbidden.
    $07 constant LCD_MUX_SEG                    \ [0x07] Mux segment enable This bit is used to enable SEG pin remapping. Four SEG pins can be multiplexed with SEG[31:28] or SEG[15:12]. See Sectionm19.3.7.
    $08 constant LCD_BUFEN                      \ [0x08] Voltage output buffer enable This bit is used to enable/disable the voltage output buffer for higher driving capability.
  [then]


  [ifdef] LCD_LCD_FCR_DEF
    \
    \ @brief LCD frame control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LCD_HD                         \ [0x00] High drive enable This bit is written by software to enable a low resistance divider. Displays with high internal resistance may need a longer drive time to achieve satisfactory contrast. This bit is useful in this case if some additional power consumption can be tolerated.
    $01 constant LCD_SOFIE                      \ [0x01] Start of frame interrupt enable This bit is set and cleared by software.
    $03 constant LCD_UDDIE                      \ [0x03] Update display done interrupt enable This bit is set and cleared by software.
    $04 constant LCD_PON                        \ [0x04 : 3] Pulse ON duration These bits are written by software to define the pulse duration in terms of ck_ps pulses. Amshort pulse leads to lower power consumption, but displays with high internal resistance may need a longer pulse to achieve satisfactory contrast. Note that the pulse is never longer than one half prescaled LCD clock period. PON duration example with LCDCLK = 32.768mkHz and PS=0x03:
    $07 constant LCD_DEAD                       \ [0x07 : 3] Dead time duration These bits are written by software to configure the length of the dead time between frames. During the dead time the COM and SEG voltage levels are held at 0 V to reduce the contrast without modifying the frame rate. ......
    $0a constant LCD_CC                         \ [0x0a : 3] Contrast control
    $0d constant LCD_BLINKF                     \ [0x0d : 3] Blink frequency selection
    $10 constant LCD_BLINK                      \ [0x10 : 2] Blink mode selection
    $12 constant LCD_DIV                        \ [0x12 : 4] DIV clock divider
    $16 constant LCD_PS                         \ [0x16 : 4] PS 16-bit prescaler
  [then]


  [ifdef] LCD_LCD_SR_DEF
    \
    \ @brief LCD status register
    \ Address offset: 0x08
    \ Reset value: 0x00000020
    \
    $00 constant LCD_ENS                        \ [0x00] LCD enabled status This bit is set and cleared by hardware. It indicates the LCD controller status. The ENS bit is set immediately when the LCDEN bit in the LCD_CR goes from 0 to 1. On deactivation it reflects the real status of LCD so it becomes 0 at the end of the last displayed frame.
    $01 constant LCD_SOF                        \ [0x01] Start-of-frame flag This bit is set by hardware at the beginning of a new frame, at the same time as the display data is updated. It is cleared by writing a 1 to the SOFC bit in the LCD_CLR register. The bit clear has priority over the set.
    $02 constant LCD_UDR                        \ [0x02] Update display request
    $03 constant LCD_UDD                        \ [0x03] Update display done This bit is set by hardware. It is cleared by writing 1 to the UDDC bit in the LCD_CLR register. The bit set has priority over the clear. If the device is in Stop mode (PCLK not provided), UDD does not generate an interrupt even if UDDIE = 1. If the display is not enabled the UDD interrupt never occurs.
    $04 constant LCD_RDY                        \ [0x04] Ready flag This bit is set and cleared by hardware. It indicates the status of the step-up converter.
    $05 constant LCD_FCRSF                      \ [0x05] LCD frame control register synchronization flag This bit is set by hardware each time the LCD_FCR register is updated in the LCDCLK domain. It is cleared by hardware when writing to the LCD_FCR register.
  [then]


  [ifdef] LCD_LCD_CLR_DEF
    \
    \ @brief LCD clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant LCD_SOFC                       \ [0x01] Start of frame flag clear This bit is written by software to clear the SOF flag in the LCD_SR register.
    $03 constant LCD_UDDC                       \ [0x03] Update display done clear This bit is written by software to clear the UDD flag in the LCD_SR register.
  [then]


  [ifdef] LCD_LCD_RAM0_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 32] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM1_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 12] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM2_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 32] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM3_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 12] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM4_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 32] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM5_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 12] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM6_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 32] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM7_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 12] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM8_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 32] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM9_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 8] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM10_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 32] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM11_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 8] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM12_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 32] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM13_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 8] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM14_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 32] Each bit corresponds to one pixel of the LCD display.
  [then]


  [ifdef] LCD_LCD_RAM15_DEF
    \
    \ @brief LCD display memory
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant LCD_SEGMENT_DATA               \ [0x00 : 8] Each bit corresponds to one pixel of the LCD display.
  [then]

  \
  \ @brief Liquid crystal display controller
  \
  $00 constant LCD_LCD_CR               \ LCD control register
  $04 constant LCD_LCD_FCR              \ LCD frame control register
  $08 constant LCD_LCD_SR               \ LCD status register
  $0C constant LCD_LCD_CLR              \ LCD clear register
  $14 constant LCD_LCD_RAM0             \ LCD display memory
  $18 constant LCD_LCD_RAM1             \ LCD display memory
  $1C constant LCD_LCD_RAM2             \ LCD display memory
  $20 constant LCD_LCD_RAM3             \ LCD display memory
  $24 constant LCD_LCD_RAM4             \ LCD display memory
  $28 constant LCD_LCD_RAM5             \ LCD display memory
  $2C constant LCD_LCD_RAM6             \ LCD display memory
  $30 constant LCD_LCD_RAM7             \ LCD display memory
  $34 constant LCD_LCD_RAM8             \ LCD display memory
  $38 constant LCD_LCD_RAM9             \ LCD display memory
  $3C constant LCD_LCD_RAM10            \ LCD display memory
  $40 constant LCD_LCD_RAM11            \ LCD display memory
  $44 constant LCD_LCD_RAM12            \ LCD display memory
  $48 constant LCD_LCD_RAM13            \ LCD display memory
  $4C constant LCD_LCD_RAM14            \ LCD display memory
  $50 constant LCD_LCD_RAM15            \ LCD display memory

: LCD_DEF ; [then]
