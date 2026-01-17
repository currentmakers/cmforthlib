\
\ @file ri.fs
\ @brief Routing interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RI_DEF

  [ifdef] RI_ICR_DEF
    \
    \ @brief RI input capture register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RI_IC1IOS                      \ [0x00 : 4] Input capture 1 select bits
    $04 constant RI_IC2IOS                      \ [0x04 : 4] Input capture 2 select bits
    $08 constant RI_IC3IOS                      \ [0x08 : 4] Input capture 3 select bits
    $0c constant RI_IC4IOS                      \ [0x0c : 4] Input capture 4 select bits
    $10 constant RI_TIM                         \ [0x10 : 2] Timer select bits
    $12 constant RI_IC1                         \ [0x12] IC1
    $13 constant RI_IC2                         \ [0x13] IC2
    $14 constant RI_IC3                         \ [0x14] IC3
    $15 constant RI_IC4                         \ [0x15] IC4
  [then]


  [ifdef] RI_ASCR1_DEF
    \
    \ @brief RI analog switches control register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant RI_CH0GR1_1                    \ [0x00] Analog switch control
    $01 constant RI_CH1GR1_2                    \ [0x01] Analog switch control
    $02 constant RI_CH2GR1_3                    \ [0x02] Analog switch control
    $03 constant RI_CH3GR1_4                    \ [0x03] Analog switch control
    $04 constant RI_CH31GR11_5                  \ [0x04] Analog switch control
    $05 constant RI_COMP1_SW1                   \ [0x05] Comparator 1 analog switch
    $06 constant RI_CH6GR2_1                    \ [0x06] Analog switch control
    $07 constant RI_CH7GR2_2                    \ [0x07] Analog switch control
    $08 constant RI_CH8GR3_1                    \ [0x08] Analog switch control
    $09 constant RI_CH9GR3_2                    \ [0x09] Analog switch control
    $0a constant RI_CH10GR8_1                   \ [0x0a] Analog switch control
    $0b constant RI_CH11GR8_2                   \ [0x0b] Analog switch control
    $0c constant RI_CH12GR8_3                   \ [0x0c] Analog switch control
    $0d constant RI_CH13GR8_4                   \ [0x0d] Analog switch control
    $0e constant RI_CH14GR9_1                   \ [0x0e] Analog switch control
    $0f constant RI_CH15GR9_2                   \ [0x0f] Analog switch control
    $10 constant RI_CH31GR7_1                   \ [0x10] Analog switch control
    $12 constant RI_CH18GR7_1                   \ [0x12] Analog switch control
    $13 constant RI_CH19GR7_2                   \ [0x13] Analog switch control
    $14 constant RI_CH20GR7_3                   \ [0x14] Analog switch control
    $15 constant RI_CH21GR7_4                   \ [0x15] Analog switch control
    $16 constant RI_CH22                        \ [0x16] Analog I/O switch control of channel CH22
    $17 constant RI_CH23                        \ [0x17] Analog I/O switch control of channel CH23
    $18 constant RI_CH24                        \ [0x18] Analog I/O switch control of channel CH24
    $19 constant RI_CH25                        \ [0x19] Analog I/O switch control of channel CH25
    $1a constant RI_VCOMP                       \ [0x1a] ADC analog switch selection for internal node to comparator 1
    $1b constant RI_CH27GR11_1                  \ [0x1b] Analog switch control
    $1c constant RI_CH28GR11_2                  \ [0x1c] Analog switch control
    $1d constant RI_CH29GR11_3                  \ [0x1d] Analog switch control
    $1e constant RI_CH30GR11_4                  \ [0x1e] Analog switch control
    $1f constant RI_SCM                         \ [0x1f] Switch control mode
  [then]


  [ifdef] RI_ASCR2_DEF
    \
    \ @brief RI analog switches control register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RI_GR10_1                      \ [0x00] GR10_1 analog switch control
    $01 constant RI_GR10_2                      \ [0x01] GR10_2 analog switch control
    $02 constant RI_GR10_3                      \ [0x02] GR10_3 analog switch control
    $03 constant RI_GR10_4                      \ [0x03] GR10_4 analog switch control
    $04 constant RI_GR6_1                       \ [0x04] GR6_1 analog switch control
    $05 constant RI_GR6_2                       \ [0x05] GR6_2 analog switch control
    $06 constant RI_GR5_1                       \ [0x06] GR5_1 analog switch control
    $07 constant RI_GR5_2                       \ [0x07] GR5_2 analog switch control
    $08 constant RI_GR5_3                       \ [0x08] GR5_3 analog switch control
    $09 constant RI_GR4_1                       \ [0x09] GR4_1 analog switch control
    $0a constant RI_GR4_2                       \ [0x0a] GR4_2 analog switch control
    $0b constant RI_GR4_3                       \ [0x0b] GR4_3 analog switch control
    $10 constant RI_GR3_3                       \ [0x10] GR3_3 analog switch control
    $11 constant RI_GR3_4                       \ [0x11] GR3_4 analog switch control
    $12 constant RI_GR3_5                       \ [0x12] GR3_5 analog switch control
    $13 constant RI_GR9_3                       \ [0x13] GR9_3 analog switch control
    $14 constant RI_GR9_4                       \ [0x14] GR9_4 analog switch control
    $15 constant RI_GR2_3                       \ [0x15] GR2_3 analog switch control
    $16 constant RI_GR2_4                       \ [0x16] GR2_4 analog switch control
    $17 constant RI_GR2_5                       \ [0x17] GR2_5 analog switch control
    $18 constant RI_GR7_5                       \ [0x18] GR7_5 analog switch control
    $19 constant RI_GR7_6                       \ [0x19] GR7_6 analog switch control
    $1a constant RI_GR7_7                       \ [0x1a] GR7_7 analog switch control
    $1b constant RI_GR6_3                       \ [0x1b] GR6_3 analog switch control
    $1c constant RI_GR6_4                       \ [0x1c] GR6_4 analog switch control
    $1d constant RI_GR5_4                       \ [0x1d] GR5_4 analog switch control
  [then]


  [ifdef] RI_HYSCR1_DEF
    \
    \ @brief RI hysteresis control register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant RI_PA                          \ [0x00 : 16] Port A hysteresis control on/off
    $10 constant RI_PB                          \ [0x10 : 16] Port B hysteresis control on/off
  [then]


  [ifdef] RI_HYSCR2_DEF
    \
    \ @brief RI hysteresis control register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RI_PC                          \ [0x00 : 16] Port C hysteresis control on/off
    $10 constant RI_PD                          \ [0x10 : 16] Port D hysteresis control on/off
  [then]


  [ifdef] RI_HYSCR3_DEF
    \
    \ @brief RI hysteresis control register 3
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant RI_PE                          \ [0x00 : 16] Port E hysteresis control on/off
    $10 constant RI_PF                          \ [0x10 : 16] Port F hysteresis control on/off
  [then]


  [ifdef] RI_HYSCR4_DEF
    \
    \ @brief Hysteresis control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RI_PG                          \ [0x00 : 16] Port G hysteresis control on/off
  [then]


  [ifdef] RI_ASMR1_DEF
    \
    \ @brief Analog switch mode register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RI_PA                          \ [0x00 : 16] Port A analog switch mode selection
  [then]


  [ifdef] RI_CMR1_DEF
    \
    \ @brief Channel mask register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RI_PA                          \ [0x00 : 16] Port A channel masking
  [then]


  [ifdef] RI_CICR1_DEF
    \
    \ @brief Channel identification for capture register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RI_PA                          \ [0x00 : 16] Port A channel identification for capture
  [then]


  [ifdef] RI_ASMR2_DEF
    \
    \ @brief Analog switch mode register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RI_PB                          \ [0x00 : 16] Port B analog switch mode selection
  [then]


  [ifdef] RI_CMR2_DEF
    \
    \ @brief Channel mask register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RI_PB                          \ [0x00 : 16] Port B channel masking
  [then]


  [ifdef] RI_CICR2_DEF
    \
    \ @brief Channel identification for capture register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RI_PB                          \ [0x00 : 16] Port B channel identification for capture
  [then]


  [ifdef] RI_ASMR3_DEF
    \
    \ @brief Analog switch mode register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RI_PC                          \ [0x00 : 16] Port C analog switch mode selection
  [then]


  [ifdef] RI_CMR3_DEF
    \
    \ @brief Channel mask register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RI_PC                          \ [0x00 : 16] Port C channel masking
  [then]


  [ifdef] RI_CICR3_DEF
    \
    \ @brief Channel identification for capture register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant RI_PC                          \ [0x00 : 16] Port C channel identification for capture
  [then]


  [ifdef] RI_ASMR4_DEF
    \
    \ @brief Analog switch mode register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RI_PF                          \ [0x00 : 16] Port F analog switch mode selection
  [then]


  [ifdef] RI_CMR4_DEF
    \
    \ @brief Channel mask register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RI_PF                          \ [0x00 : 16] Port F channel masking
  [then]


  [ifdef] RI_CICR4_DEF
    \
    \ @brief Channel identification for capture register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant RI_PF                          \ [0x00 : 16] Port F channel identification for capture
  [then]


  [ifdef] RI_ASMR5_DEF
    \
    \ @brief Analog switch mode register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RI_PG                          \ [0x00 : 16] Port G analog switch mode selection
  [then]


  [ifdef] RI_CMR5_DEF
    \
    \ @brief Channel mask register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RI_PG                          \ [0x00 : 16] Port G channel masking
  [then]


  [ifdef] RI_CICR5_DEF
    \
    \ @brief Channel identification for capture register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RI_PG                          \ [0x00 : 16] Port G channel identification for capture
  [then]

  \
  \ @brief Routing interface
  \
  $00 constant RI_ICR                   \ RI input capture register
  $04 constant RI_ASCR1                 \ RI analog switches control register 1
  $08 constant RI_ASCR2                 \ RI analog switches control register 2
  $0C constant RI_HYSCR1                \ RI hysteresis control register 1
  $10 constant RI_HYSCR2                \ RI hysteresis control register 2
  $14 constant RI_HYSCR3                \ RI hysteresis control register 3
  $18 constant RI_HYSCR4                \ Hysteresis control register
  $1C constant RI_ASMR1                 \ Analog switch mode register
  $20 constant RI_CMR1                  \ Channel mask register
  $24 constant RI_CICR1                 \ Channel identification for capture register
  $28 constant RI_ASMR2                 \ Analog switch mode register
  $2C constant RI_CMR2                  \ Channel mask register
  $30 constant RI_CICR2                 \ Channel identification for capture register
  $34 constant RI_ASMR3                 \ Analog switch mode register
  $38 constant RI_CMR3                  \ Channel mask register
  $3C constant RI_CICR3                 \ Channel identification for capture register
  $40 constant RI_ASMR4                 \ Analog switch mode register
  $44 constant RI_CMR4                  \ Channel mask register
  $48 constant RI_CICR4                 \ Channel identification for capture register
  $4C constant RI_ASMR5                 \ Analog switch mode register
  $50 constant RI_CMR5                  \ Channel mask register
  $54 constant RI_CICR5                 \ Channel identification for capture register

: RI_DEF ; [then]
