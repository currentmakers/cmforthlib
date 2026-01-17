\
\ @file exti.fs
\ @brief External interrupt/event controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] EXTI_DEF

  [ifdef] EXTI_EXTI_RTSR1_DEF
    \
    \ @brief EXTI rising trigger selection register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RT0                       \ [0x00] rising trigger event configuration bit of configurable event input 0
    $01 constant EXTI_RT1                       \ [0x01] rising trigger event configuration bit of configurable event input 1
    $02 constant EXTI_RT2                       \ [0x02] rising trigger event configuration bit of configurable event input 2
    $03 constant EXTI_RT3                       \ [0x03] rising trigger event configuration bit of configurable event input 3
    $04 constant EXTI_RT4                       \ [0x04] rising trigger event configuration bit of configurable event input 4
    $05 constant EXTI_RT5                       \ [0x05] rising trigger event configuration bit of configurable event input 5
    $06 constant EXTI_RT6                       \ [0x06] rising trigger event configuration bit of configurable event input 6
    $07 constant EXTI_RT7                       \ [0x07] rising trigger event configuration bit of configurable event input 7
    $08 constant EXTI_RT8                       \ [0x08] rising trigger event configuration bit of configurable event input 8
    $09 constant EXTI_RT9                       \ [0x09] rising trigger event configuration bit of configurable event input 9
    $0a constant EXTI_RT10                      \ [0x0a] rising trigger event configuration bit of configurable event input 10
    $0b constant EXTI_RT11                      \ [0x0b] rising trigger event configuration bit of configurable event input 11
    $0c constant EXTI_RT12                      \ [0x0c] rising trigger event configuration bit of configurable event input 12
    $0d constant EXTI_RT13                      \ [0x0d] rising trigger event configuration bit of configurable event input 13
    $0e constant EXTI_RT14                      \ [0x0e] rising trigger event configuration bit of configurable event input 14
    $0f constant EXTI_RT15                      \ [0x0f] rising trigger event configuration bit of configurable event input 15
    $10 constant EXTI_RT16                      \ [0x10] rising trigger event configuration bit of configurable event input 16
    $15 constant EXTI_RT21                      \ [0x15] rising trigger event configuration bit of configurable event input 21
    $16 constant EXTI_RT22                      \ [0x16] rising trigger event configuration bit of configurable event input 22 Note: The configurable event inputs are edge triggered. No glitch must be generated on these inputs. If a rising edge on the configurable event input occurs while writing to the register, the associated pending bit is not set. Note: Rising and falling edge triggers can be set for the same configurable event input. In this case, both edges generate a trigger.
  [then]


  [ifdef] EXTI_EXTI_FTSR1_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FT0                       \ [0x00] falling trigger event configuration bit of configurable event input 0
    $01 constant EXTI_FT1                       \ [0x01] falling trigger event configuration bit of configurable event input 1
    $02 constant EXTI_FT2                       \ [0x02] falling trigger event configuration bit of configurable event input 2
    $03 constant EXTI_FT3                       \ [0x03] falling trigger event configuration bit of configurable event input 3
    $04 constant EXTI_FT4                       \ [0x04] falling trigger event configuration bit of configurable event input 4
    $05 constant EXTI_FT5                       \ [0x05] falling trigger event configuration bit of configurable event input 5
    $06 constant EXTI_FT6                       \ [0x06] falling trigger event configuration bit of configurable event input 6
    $07 constant EXTI_FT7                       \ [0x07] falling trigger event configuration bit of configurable event input 7
    $08 constant EXTI_FT8                       \ [0x08] falling trigger event configuration bit of configurable event input 8
    $09 constant EXTI_FT9                       \ [0x09] falling trigger event configuration bit of configurable event input 9
    $0a constant EXTI_FT10                      \ [0x0a] falling trigger event configuration bit of configurable event input 10
    $0b constant EXTI_FT11                      \ [0x0b] falling trigger event configuration bit of configurable event input 11
    $0c constant EXTI_FT12                      \ [0x0c] falling trigger event configuration bit of configurable event input 12
    $0d constant EXTI_FT13                      \ [0x0d] falling trigger event configuration bit of configurable event input 13
    $0e constant EXTI_FT14                      \ [0x0e] falling trigger event configuration bit of configurable event input 14
    $0f constant EXTI_FT15                      \ [0x0f] falling trigger event configuration bit of configurable event input 15
    $10 constant EXTI_FT16                      \ [0x10] falling trigger event configuration bit of configurable event input 16
    $15 constant EXTI_FT21                      \ [0x15] falling trigger event configuration bit of configurable event input 21
    $16 constant EXTI_FT22                      \ [0x16] falling trigger event configuration bit of configurable event input 22 Note: The configurable event inputs are edge triggered. No glitch must be generated on these inputs. If a falling edge on the configurable event input occurs while writing to the register, the associated pending bit is not set. Note: Rising and falling edge triggers can be set for the same configurable event input. In this case, both edges generate a trigger.
  [then]


  [ifdef] EXTI_EXTI_SWIER1_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWI0                      \ [0x00] Software interrupt on line 0
    $01 constant EXTI_SWI1                      \ [0x01] Software interrupt on line 1
    $02 constant EXTI_SWI2                      \ [0x02] Software interrupt on line 2
    $03 constant EXTI_SWI3                      \ [0x03] Software interrupt on line 3
    $04 constant EXTI_SWI4                      \ [0x04] Software interrupt on line 4
    $05 constant EXTI_SWI5                      \ [0x05] Software interrupt on line 5
    $06 constant EXTI_SWI6                      \ [0x06] Software interrupt on line 6
    $07 constant EXTI_SWI7                      \ [0x07] Software interrupt on line 7
    $08 constant EXTI_SWI8                      \ [0x08] Software interrupt on line 8
    $09 constant EXTI_SWI9                      \ [0x09] Software interrupt on line 9
    $0a constant EXTI_SWI10                     \ [0x0a] Software interrupt on line 10
    $0b constant EXTI_SWI11                     \ [0x0b] Software interrupt on line 11
    $0c constant EXTI_SWI12                     \ [0x0c] Software interrupt on line 12
    $0d constant EXTI_SWI13                     \ [0x0d] Software interrupt on line 13
    $0e constant EXTI_SWI14                     \ [0x0e] Software interrupt on line 14
    $0f constant EXTI_SWI15                     \ [0x0f] Software interrupt on line 15
    $10 constant EXTI_SWI16                     \ [0x10] Software interrupt on line 16
    $15 constant EXTI_SWI21                     \ [0x15] Software interrupt on line 21
    $16 constant EXTI_SWI22                     \ [0x16] Software interrupt on line 22 A software interrupt is generated independently from the setting in EXTI_RTSR and EXTI_FTSR. This bit always returns 0 when read. This bit is automatically cleared by hardware.
  [then]


  [ifdef] EXTI_EXTI_PR1_DEF
    \
    \ @brief EXTI pending register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PIF0                      \ [0x00] pending bit on event input 0
    $01 constant EXTI_PIF1                      \ [0x01] pending bit on event input 1
    $02 constant EXTI_PIF2                      \ [0x02] pending bit on event input 2
    $03 constant EXTI_PIF3                      \ [0x03] pending bit on event input 3
    $04 constant EXTI_PIF4                      \ [0x04] pending bit on event input 4
    $05 constant EXTI_PIF5                      \ [0x05] pending bit on event input 5
    $06 constant EXTI_PIF6                      \ [0x06] pending bit on event input 6
    $07 constant EXTI_PIF7                      \ [0x07] pending bit on event input 7
    $08 constant EXTI_PIF8                      \ [0x08] pending bit on event input 8
    $09 constant EXTI_PIF9                      \ [0x09] pending bit on event input 9
    $0a constant EXTI_PIF10                     \ [0x0a] pending bit on event input 10
    $0b constant EXTI_PIF11                     \ [0x0b] pending bit on event input 11
    $0c constant EXTI_PIF12                     \ [0x0c] pending bit on event input 12
    $0d constant EXTI_PIF13                     \ [0x0d] pending bit on event input 13
    $0e constant EXTI_PIF14                     \ [0x0e] pending bit on event input 14
    $0f constant EXTI_PIF15                     \ [0x0f] pending bit on event input 15
    $10 constant EXTI_PIF16                     \ [0x10] pending bit on event input 16
    $15 constant EXTI_PIF21                     \ [0x15] pending bit on event input 21
    $16 constant EXTI_PIF22                     \ [0x16] pending bit on event input 22 These bits are set when the selected edge event or an EXTI_SWIER software trigger arrives on the configurable event line. This bit is cleared by writing 1 to it.
  [then]


  [ifdef] EXTI_EXTI_RTSR2_DEF
    \
    \ @brief EXTI rising trigger selection register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_RT34                      \ [0x02] rising trigger event configuration bit of configurable event input 34
    $08 constant EXTI_RT40                      \ [0x08] rising trigger event configuration bit of configurable event input 40
    $09 constant EXTI_RT41                      \ [0x09] rising trigger event configuration bit of configurable event input 41
    $0d constant EXTI_RT45                      \ [0x0d] rising trigger event configuration bit of configurable event input 45 Note: The configurable event inputs are edge triggered. No glitch must be generated on these inputs. If a rising edge on the configurable event input occurs while writing to the register, the associated pending bit is not set. Note: Rising and falling edge triggers can be set for the same configurable event input. In this case, both edges generate a trigger.
  [then]


  [ifdef] EXTI_EXTI_FTSR2_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_FT34                      \ [0x02] falling trigger event configuration bit of configurable event input 34
    $08 constant EXTI_FT40                      \ [0x08] falling trigger event configuration bit of configurable event input 40
    $09 constant EXTI_FT41                      \ [0x09] falling trigger event configuration bit of configurable event input 41
    $0d constant EXTI_FT45                      \ [0x0d] falling trigger event configuration bit of configurable event input 45 Note: The configurable event inputs are edge triggered. No glitch must be generated on these inputs. If a falling edge on the configurable event input occurs while writing to the register, the associated pending bit is not set. Note: Rising and falling edge triggers can be set for the same configurable event input. In this case, both edges generate a trigger.
  [then]


  [ifdef] EXTI_EXTI_SWIER2_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_SWI34                     \ [0x02] software interrupt on event 34
    $08 constant EXTI_SWI40                     \ [0x08] software interrupt on event 40
    $09 constant EXTI_SWI41                     \ [0x09] software interrupt on event 41
    $0d constant EXTI_SWI45                     \ [0x0d] software interrupt on event 45 A software interrupt is generated independently from the setting in EXTI_RTSR and EXTI_FTSR. This bit always returns 0 when read. This bit is automatically cleared by hardware.
  [then]


  [ifdef] EXTI_EXTI_PR2_DEF
    \
    \ @brief EXTI pending register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_PIF34                     \ [0x02] pending bit on event input 34
    $08 constant EXTI_PIF40                     \ [0x08] pending bit on event input 40
    $09 constant EXTI_PIF41                     \ [0x09] pending bit on event input 41
    $0d constant EXTI_PIF45                     \ [0x0d] pending bit on event input 45 These bits are set when the selected edge event or an EXTI_SWIER software trigger arrives on the configurable event line. This bit is cleared by writing 1 to it.
  [then]


  [ifdef] EXTI_EXTI_C1IMR1_DEF
    \
    \ @brief EXTI interrupt mask register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_IM                        \ [0x00 : 32] Wake-up with interrupt mask on event input x For each bit of this field:
  [then]


  [ifdef] EXTI_EXTI_C1EMR1_DEF
    \
    \ @brief EXTI event mask register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0                       \ [0x00] Wake-up with event generation mask on event input 0
    $01 constant EXTI_EM1                       \ [0x01] Wake-up with event generation mask on event input 1
    $02 constant EXTI_EM2                       \ [0x02] Wake-up with event generation mask on event input 2
    $03 constant EXTI_EM3                       \ [0x03] Wake-up with event generation mask on event input 3
    $04 constant EXTI_EM4                       \ [0x04] Wake-up with event generation mask on event input 4
    $05 constant EXTI_EM5                       \ [0x05] Wake-up with event generation mask on event input 5
    $06 constant EXTI_EM6                       \ [0x06] Wake-up with event generation mask on event input 6
    $07 constant EXTI_EM7                       \ [0x07] Wake-up with event generation mask on event input 7
    $08 constant EXTI_EM8                       \ [0x08] Wake-up with event generation mask on event input 8
    $09 constant EXTI_EM9                       \ [0x09] Wake-up with event generation mask on event input 19
    $0a constant EXTI_EM10                      \ [0x0a] Wake-up with event generation mask on event input 10
    $0b constant EXTI_EM11                      \ [0x0b] Wake-up with event generation mask on event input 11
    $0c constant EXTI_EM12                      \ [0x0c] Wake-up with event generation mask on event input 12
    $0d constant EXTI_EM13                      \ [0x0d] Wake-up with event generation mask on event input 13
    $0e constant EXTI_EM14                      \ [0x0e] Wake-up with event generation mask on event input 14
    $0f constant EXTI_EM15                      \ [0x0f] Wake-up with event generation mask on event input 15
    $11 constant EXTI_EM17                      \ [0x11] Wake-up with event generation mask on event input 17
    $12 constant EXTI_EM18                      \ [0x12] Wake-up with event generation mask on event input 18
    $13 constant EXTI_EM19                      \ [0x13] Wake-up with event generation mask on event input 19
    $14 constant EXTI_EM20                      \ [0x14] Wake-up with event generation mask on event input 20
    $15 constant EXTI_EM21                      \ [0x15] Wake-up with event generation mask on event input 21
    $16 constant EXTI_EM22                      \ [0x16] Wake-up with event generation mask on event input 22
  [then]


  [ifdef] EXTI_EXTI_C1IMR2_DEF
    \
    \ @brief EXTI interrupt mask register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_IM34                      \ [0x02] Wake-up with interrupt mask on event input 34
    $04 constant EXTI_IM36                      \ [0x04] Wake-up with interrupt mask on event input 36
    $05 constant EXTI_IM37                      \ [0x05] Wake-up with interrupt mask on event input 37
    $06 constant EXTI_IM38                      \ [0x06] Wake-up with interrupt mask on event input 38
    $07 constant EXTI_IM39                      \ [0x07] Wake-up with interrupt mask on event input 39
    $08 constant EXTI_IM40                      \ [0x08] Wake-up with interrupt mask on event input 40
    $09 constant EXTI_IM41                      \ [0x09] Wake-up with interrupt mask on event input 41
    $0a constant EXTI_IM42                      \ [0x0a] Wake-up with interrupt mask on event input 42
    $0b constant EXTI_IM43                      \ [0x0b] Wake-up with interrupt mask on event input 43
    $0c constant EXTI_IM44                      \ [0x0c] Wake-up with interrupt mask on event input 44
    $0d constant EXTI_IM45                      \ [0x0d] Wake-up with interrupt mask on event input 45
    $0e constant EXTI_IM46                      \ [0x0e] Wake-up with interrupt mask on event input 46
  [then]


  [ifdef] EXTI_EXTI_C1EMR2_DEF
    \
    \ @brief EXTI event mask register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $08 constant EXTI_EM40                      \ [0x08] Wake-up with event generation mask on event input 40
    $09 constant EXTI_EM41                      \ [0x09] Wake-up with event generation mask on event input 41
  [then]


  [ifdef] EXTI_EXTI_C2IMR1_DEF
    \
    \ @brief EXTI interrupt mask register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_IM                        \ [0x00 : 32] Wake-up with interrupt mask on event input x For each bit of this field:
  [then]


  [ifdef] EXTI_EXTI_C2EMR1_DEF
    \
    \ @brief EXTI event mask register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0                       \ [0x00] Wake-up with event generation mask on event input 0
    $01 constant EXTI_EM1                       \ [0x01] Wake-up with event generation mask on event input 1
    $02 constant EXTI_EM2                       \ [0x02] Wake-up with event generation mask on event input 2
    $03 constant EXTI_EM3                       \ [0x03] Wake-up with event generation mask on event input 3
    $04 constant EXTI_EM4                       \ [0x04] Wake-up with event generation mask on event input 4
    $05 constant EXTI_EM5                       \ [0x05] Wake-up with event generation mask on event input 5
    $06 constant EXTI_EM6                       \ [0x06] Wake-up with event generation mask on event input 6
    $07 constant EXTI_EM7                       \ [0x07] Wake-up with event generation mask on event input 7
    $08 constant EXTI_EM8                       \ [0x08] Wake-up with event generation mask on event input 8
    $09 constant EXTI_EM9                       \ [0x09] Wake-up with event generation mask on event input 19
    $0a constant EXTI_EM10                      \ [0x0a] Wake-up with event generation mask on event input 10
    $0b constant EXTI_EM11                      \ [0x0b] Wake-up with event generation mask on event input 11
    $0c constant EXTI_EM12                      \ [0x0c] Wake-up with event generation mask on event input 12
    $0d constant EXTI_EM13                      \ [0x0d] Wake-up with event generation mask on event input 13
    $0e constant EXTI_EM14                      \ [0x0e] Wake-up with event generation mask on event input 14
    $0f constant EXTI_EM15                      \ [0x0f] Wake-up with event generation mask on event input 15
    $11 constant EXTI_EM17                      \ [0x11] Wake-up with event generation mask on event input 17
    $12 constant EXTI_EM18                      \ [0x12] Wake-up with event generation mask on event input 18
    $13 constant EXTI_EM19                      \ [0x13] Wake-up with event generation mask on event input 19
    $14 constant EXTI_EM20                      \ [0x14] Wake-up with event generation mask on event input 20
    $15 constant EXTI_EM21                      \ [0x15] Wake-up with event generation mask on event input 21
    $16 constant EXTI_EM22                      \ [0x16] Wake-up with event generation mask on event input 22
  [then]


  [ifdef] EXTI_EXTI_C2IMR2_DEF
    \
    \ @brief EXTI interrupt mask register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_IM34                      \ [0x02] Wake-up with interrupt mask on event input 34
    $04 constant EXTI_IM36                      \ [0x04] Wake-up with interrupt mask on event input 36
    $05 constant EXTI_IM37                      \ [0x05] Wake-up with interrupt mask on event input 37
    $06 constant EXTI_IM38                      \ [0x06] Wake-up with interrupt mask on event input 38
    $07 constant EXTI_IM39                      \ [0x07] Wake-up with interrupt mask on event input 39
    $08 constant EXTI_IM40                      \ [0x08] Wake-up with interrupt mask on event input 40
    $09 constant EXTI_IM41                      \ [0x09] Wake-up with interrupt mask on event input 41
    $0a constant EXTI_IM42                      \ [0x0a] Wake-up with interrupt mask on event input 42
    $0b constant EXTI_IM43                      \ [0x0b] Wake-up with interrupt mask on event input 43
    $0c constant EXTI_IM44                      \ [0x0c] Wake-up with interrupt mask on event input 44
    $0d constant EXTI_IM45                      \ [0x0d] Wake-up with interrupt mask on event input 45
    $0e constant EXTI_IM46                      \ [0x0e] Wake-up with interrupt mask on event input 46
  [then]


  [ifdef] EXTI_EXTI_C2EMR2_DEF
    \
    \ @brief EXTI event mask register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $08 constant EXTI_EM40                      \ [0x08] Wake-up with event generation mask on event input 40
    $09 constant EXTI_EM41                      \ [0x09] Wake-up with event generation mask on event input 41
  [then]

  \
  \ @brief External interrupt/event controller
  \
  $00 constant EXTI_EXTI_RTSR1          \ EXTI rising trigger selection register
  $04 constant EXTI_EXTI_FTSR1          \ EXTI falling trigger selection register
  $08 constant EXTI_EXTI_SWIER1         \ EXTI software interrupt event register
  $0C constant EXTI_EXTI_PR1            \ EXTI pending register
  $20 constant EXTI_EXTI_RTSR2          \ EXTI rising trigger selection register
  $24 constant EXTI_EXTI_FTSR2          \ EXTI falling trigger selection register
  $28 constant EXTI_EXTI_SWIER2         \ EXTI software interrupt event register
  $2C constant EXTI_EXTI_PR2            \ EXTI pending register
  $80 constant EXTI_EXTI_C1IMR1         \ EXTI interrupt mask register
  $84 constant EXTI_EXTI_C1EMR1         \ EXTI event mask register
  $90 constant EXTI_EXTI_C1IMR2         \ EXTI interrupt mask register
  $94 constant EXTI_EXTI_C1EMR2         \ EXTI event mask register
  $C0 constant EXTI_EXTI_C2IMR1         \ EXTI interrupt mask register
  $C4 constant EXTI_EXTI_C2EMR1         \ EXTI event mask register
  $D0 constant EXTI_EXTI_C2IMR2         \ EXTI interrupt mask register
  $D4 constant EXTI_EXTI_C2EMR2         \ EXTI event mask register

: EXTI_DEF ; [then]
