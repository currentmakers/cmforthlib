\
\ @file lcd.fs
\ @brief Liquid crystal display controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LCD_DEF

  [ifdef] LCD_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LCD_LCDEN                      \ [0x00] LCD controller enable
    $01 constant LCD_VSEL                       \ [0x01] Voltage source selection
    $02 constant LCD_DUTY                       \ [0x02 : 3] Duty selection
    $05 constant LCD_BIAS                       \ [0x05 : 2] Bias selector
    $07 constant LCD_MUX_SEG                    \ [0x07] Mux segment enable
    $08 constant LCD_BUFEN                      \ [0x08] Voltage output buffer enable
  [then]


  [ifdef] LCD_FCR_DEF
    \
    \ @brief frame control register
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


  [ifdef] LCD_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x08
    \ Reset value: 0x00000020
    \
    $00 constant LCD_ENS                        \ [0x00] ENS
    $01 constant LCD_SOF                        \ [0x01] Start of frame flag
    $02 constant LCD_UDR                        \ [0x02] Update display request
    $03 constant LCD_UDD                        \ [0x03] Update Display Done
    $04 constant LCD_RDY                        \ [0x04] Ready flag
    $05 constant LCD_FCRSF                      \ [0x05] LCD Frame Control Register Synchronization flag
  [then]


  [ifdef] LCD_CLR_DEF
    \
    \ @brief clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant LCD_SOFC                       \ [0x01] Start of frame flag clear
    $03 constant LCD_UDDC                       \ [0x03] Update display done clear
  [then]


  [ifdef] LCD_RAM_COM0_DEF
    \
    \ @brief display memory
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LCD_S00                        \ [0x00] S00
    $01 constant LCD_S01                        \ [0x01] S01
    $02 constant LCD_S02                        \ [0x02] S02
    $03 constant LCD_S03                        \ [0x03] S03
    $04 constant LCD_S04                        \ [0x04] S04
    $05 constant LCD_S05                        \ [0x05] S05
    $06 constant LCD_S06                        \ [0x06] S06
    $07 constant LCD_S07                        \ [0x07] S07
    $08 constant LCD_S08                        \ [0x08] S08
    $09 constant LCD_S09                        \ [0x09] S09
    $0a constant LCD_S10                        \ [0x0a] S10
    $0b constant LCD_S11                        \ [0x0b] S11
    $0c constant LCD_S12                        \ [0x0c] S12
    $0d constant LCD_S13                        \ [0x0d] S13
    $0e constant LCD_S14                        \ [0x0e] S14
    $0f constant LCD_S15                        \ [0x0f] S15
    $10 constant LCD_S16                        \ [0x10] S16
    $11 constant LCD_S17                        \ [0x11] S17
    $12 constant LCD_S18                        \ [0x12] S18
    $13 constant LCD_S19                        \ [0x13] S19
    $14 constant LCD_S20                        \ [0x14] S20
    $15 constant LCD_S21                        \ [0x15] S21
    $16 constant LCD_S22                        \ [0x16] S22
    $17 constant LCD_S23                        \ [0x17] S23
    $18 constant LCD_S24                        \ [0x18] S24
    $19 constant LCD_S25                        \ [0x19] S25
    $1a constant LCD_S26                        \ [0x1a] S26
    $1b constant LCD_S27                        \ [0x1b] S27
    $1c constant LCD_S28                        \ [0x1c] S28
    $1d constant LCD_S29                        \ [0x1d] S29
    $1e constant LCD_S30                        \ [0x1e] S30
    $1f constant LCD_S31                        \ [0x1f] S31
  [then]


  [ifdef] LCD_RAM_COM1_DEF
    \
    \ @brief display memory
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LCD_S00                        \ [0x00] S00
    $01 constant LCD_S01                        \ [0x01] S01
    $02 constant LCD_S02                        \ [0x02] S02
    $03 constant LCD_S03                        \ [0x03] S03
    $04 constant LCD_S04                        \ [0x04] S04
    $05 constant LCD_S05                        \ [0x05] S05
    $06 constant LCD_S06                        \ [0x06] S06
    $07 constant LCD_S07                        \ [0x07] S07
    $08 constant LCD_S08                        \ [0x08] S08
    $09 constant LCD_S09                        \ [0x09] S09
    $0a constant LCD_S10                        \ [0x0a] S10
    $0b constant LCD_S11                        \ [0x0b] S11
    $0c constant LCD_S12                        \ [0x0c] S12
    $0d constant LCD_S13                        \ [0x0d] S13
    $0e constant LCD_S14                        \ [0x0e] S14
    $0f constant LCD_S15                        \ [0x0f] S15
    $10 constant LCD_S16                        \ [0x10] S16
    $11 constant LCD_S17                        \ [0x11] S17
    $12 constant LCD_S18                        \ [0x12] S18
    $13 constant LCD_S19                        \ [0x13] S19
    $14 constant LCD_S20                        \ [0x14] S20
    $15 constant LCD_S21                        \ [0x15] S21
    $16 constant LCD_S22                        \ [0x16] S22
    $17 constant LCD_S23                        \ [0x17] S23
    $18 constant LCD_S24                        \ [0x18] S24
    $19 constant LCD_S25                        \ [0x19] S25
    $1a constant LCD_S26                        \ [0x1a] S26
    $1b constant LCD_S27                        \ [0x1b] S27
    $1c constant LCD_S28                        \ [0x1c] S28
    $1d constant LCD_S29                        \ [0x1d] S29
    $1e constant LCD_S30                        \ [0x1e] S30
    $1f constant LCD_S31                        \ [0x1f] S31
  [then]


  [ifdef] LCD_RAM_COM2_DEF
    \
    \ @brief display memory
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LCD_S00                        \ [0x00] S00
    $01 constant LCD_S01                        \ [0x01] S01
    $02 constant LCD_S02                        \ [0x02] S02
    $03 constant LCD_S03                        \ [0x03] S03
    $04 constant LCD_S04                        \ [0x04] S04
    $05 constant LCD_S05                        \ [0x05] S05
    $06 constant LCD_S06                        \ [0x06] S06
    $07 constant LCD_S07                        \ [0x07] S07
    $08 constant LCD_S08                        \ [0x08] S08
    $09 constant LCD_S09                        \ [0x09] S09
    $0a constant LCD_S10                        \ [0x0a] S10
    $0b constant LCD_S11                        \ [0x0b] S11
    $0c constant LCD_S12                        \ [0x0c] S12
    $0d constant LCD_S13                        \ [0x0d] S13
    $0e constant LCD_S14                        \ [0x0e] S14
    $0f constant LCD_S15                        \ [0x0f] S15
    $10 constant LCD_S16                        \ [0x10] S16
    $11 constant LCD_S17                        \ [0x11] S17
    $12 constant LCD_S18                        \ [0x12] S18
    $13 constant LCD_S19                        \ [0x13] S19
    $14 constant LCD_S20                        \ [0x14] S20
    $15 constant LCD_S21                        \ [0x15] S21
    $16 constant LCD_S22                        \ [0x16] S22
    $17 constant LCD_S23                        \ [0x17] S23
    $18 constant LCD_S24                        \ [0x18] S24
    $19 constant LCD_S25                        \ [0x19] S25
    $1a constant LCD_S26                        \ [0x1a] S26
    $1b constant LCD_S27                        \ [0x1b] S27
    $1c constant LCD_S28                        \ [0x1c] S28
    $1d constant LCD_S29                        \ [0x1d] S29
    $1e constant LCD_S30                        \ [0x1e] S30
    $1f constant LCD_S31                        \ [0x1f] S31
  [then]


  [ifdef] LCD_RAM_COM3_DEF
    \
    \ @brief display memory
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LCD_S00                        \ [0x00] S00
    $01 constant LCD_S01                        \ [0x01] S01
    $02 constant LCD_S02                        \ [0x02] S02
    $03 constant LCD_S03                        \ [0x03] S03
    $04 constant LCD_S04                        \ [0x04] S04
    $05 constant LCD_S05                        \ [0x05] S05
    $06 constant LCD_S06                        \ [0x06] S06
    $07 constant LCD_S07                        \ [0x07] S07
    $08 constant LCD_S08                        \ [0x08] S08
    $09 constant LCD_S09                        \ [0x09] S09
    $0a constant LCD_S10                        \ [0x0a] S10
    $0b constant LCD_S11                        \ [0x0b] S11
    $0c constant LCD_S12                        \ [0x0c] S12
    $0d constant LCD_S13                        \ [0x0d] S13
    $0e constant LCD_S14                        \ [0x0e] S14
    $0f constant LCD_S15                        \ [0x0f] S15
    $10 constant LCD_S16                        \ [0x10] S16
    $11 constant LCD_S17                        \ [0x11] S17
    $12 constant LCD_S18                        \ [0x12] S18
    $13 constant LCD_S19                        \ [0x13] S19
    $14 constant LCD_S20                        \ [0x14] S20
    $15 constant LCD_S21                        \ [0x15] S21
    $16 constant LCD_S22                        \ [0x16] S22
    $17 constant LCD_S23                        \ [0x17] S23
    $18 constant LCD_S24                        \ [0x18] S24
    $19 constant LCD_S25                        \ [0x19] S25
    $1a constant LCD_S26                        \ [0x1a] S26
    $1b constant LCD_S27                        \ [0x1b] S27
    $1c constant LCD_S28                        \ [0x1c] S28
    $1d constant LCD_S29                        \ [0x1d] S29
    $1e constant LCD_S30                        \ [0x1e] S30
    $1f constant LCD_S31                        \ [0x1f] S31
  [then]


  [ifdef] LCD_RAM_COM4_DEF
    \
    \ @brief display memory
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant LCD_S00                        \ [0x00] S00
    $01 constant LCD_S01                        \ [0x01] S01
    $02 constant LCD_S02                        \ [0x02] S02
    $03 constant LCD_S03                        \ [0x03] S03
    $04 constant LCD_S04                        \ [0x04] S04
    $05 constant LCD_S05                        \ [0x05] S05
    $06 constant LCD_S06                        \ [0x06] S06
    $07 constant LCD_S07                        \ [0x07] S07
    $08 constant LCD_S08                        \ [0x08] S08
    $09 constant LCD_S09                        \ [0x09] S09
    $0a constant LCD_S10                        \ [0x0a] S10
    $0b constant LCD_S11                        \ [0x0b] S11
    $0c constant LCD_S12                        \ [0x0c] S12
    $0d constant LCD_S13                        \ [0x0d] S13
    $0e constant LCD_S14                        \ [0x0e] S14
    $0f constant LCD_S15                        \ [0x0f] S15
    $10 constant LCD_S16                        \ [0x10] S16
    $11 constant LCD_S17                        \ [0x11] S17
    $12 constant LCD_S18                        \ [0x12] S18
    $13 constant LCD_S19                        \ [0x13] S19
    $14 constant LCD_S20                        \ [0x14] S20
    $15 constant LCD_S21                        \ [0x15] S21
    $16 constant LCD_S22                        \ [0x16] S22
    $17 constant LCD_S23                        \ [0x17] S23
    $18 constant LCD_S24                        \ [0x18] S24
    $19 constant LCD_S25                        \ [0x19] S25
    $1a constant LCD_S26                        \ [0x1a] S26
    $1b constant LCD_S27                        \ [0x1b] S27
    $1c constant LCD_S28                        \ [0x1c] S28
    $1d constant LCD_S29                        \ [0x1d] S29
    $1e constant LCD_S30                        \ [0x1e] S30
    $1f constant LCD_S31                        \ [0x1f] S31
  [then]


  [ifdef] LCD_RAM_COM5_DEF
    \
    \ @brief display memory
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant LCD_S00                        \ [0x00] S00
    $01 constant LCD_S01                        \ [0x01] S01
    $02 constant LCD_S02                        \ [0x02] S02
    $03 constant LCD_S03                        \ [0x03] S03
    $04 constant LCD_S04                        \ [0x04] S04
    $05 constant LCD_S05                        \ [0x05] S05
    $06 constant LCD_S06                        \ [0x06] S06
    $07 constant LCD_S07                        \ [0x07] S07
    $08 constant LCD_S08                        \ [0x08] S08
    $09 constant LCD_S09                        \ [0x09] S09
    $0a constant LCD_S10                        \ [0x0a] S10
    $0b constant LCD_S11                        \ [0x0b] S11
    $0c constant LCD_S12                        \ [0x0c] S12
    $0d constant LCD_S13                        \ [0x0d] S13
    $0e constant LCD_S14                        \ [0x0e] S14
    $0f constant LCD_S15                        \ [0x0f] S15
    $10 constant LCD_S16                        \ [0x10] S16
    $11 constant LCD_S17                        \ [0x11] S17
    $12 constant LCD_S18                        \ [0x12] S18
    $13 constant LCD_S19                        \ [0x13] S19
    $14 constant LCD_S20                        \ [0x14] S20
    $15 constant LCD_S21                        \ [0x15] S21
    $16 constant LCD_S22                        \ [0x16] S22
    $17 constant LCD_S23                        \ [0x17] S23
    $18 constant LCD_S24                        \ [0x18] S24
    $19 constant LCD_S25                        \ [0x19] S25
    $1a constant LCD_S26                        \ [0x1a] S26
    $1b constant LCD_S27                        \ [0x1b] S27
    $1c constant LCD_S28                        \ [0x1c] S28
    $1d constant LCD_S29                        \ [0x1d] S29
    $1e constant LCD_S30                        \ [0x1e] S30
    $1f constant LCD_S31                        \ [0x1f] S31
  [then]


  [ifdef] LCD_RAM_COM6_DEF
    \
    \ @brief display memory
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant LCD_S00                        \ [0x00] S00
    $01 constant LCD_S01                        \ [0x01] S01
    $02 constant LCD_S02                        \ [0x02] S02
    $03 constant LCD_S03                        \ [0x03] S03
    $04 constant LCD_S04                        \ [0x04] S04
    $05 constant LCD_S05                        \ [0x05] S05
    $06 constant LCD_S06                        \ [0x06] S06
    $07 constant LCD_S07                        \ [0x07] S07
    $08 constant LCD_S08                        \ [0x08] S08
    $09 constant LCD_S09                        \ [0x09] S09
    $0a constant LCD_S10                        \ [0x0a] S10
    $0b constant LCD_S11                        \ [0x0b] S11
    $0c constant LCD_S12                        \ [0x0c] S12
    $0d constant LCD_S13                        \ [0x0d] S13
    $0e constant LCD_S14                        \ [0x0e] S14
    $0f constant LCD_S15                        \ [0x0f] S15
    $10 constant LCD_S16                        \ [0x10] S16
    $11 constant LCD_S17                        \ [0x11] S17
    $12 constant LCD_S18                        \ [0x12] S18
    $13 constant LCD_S19                        \ [0x13] S19
    $14 constant LCD_S20                        \ [0x14] S20
    $15 constant LCD_S21                        \ [0x15] S21
    $16 constant LCD_S22                        \ [0x16] S22
    $17 constant LCD_S23                        \ [0x17] S23
    $18 constant LCD_S24                        \ [0x18] S24
    $19 constant LCD_S25                        \ [0x19] S25
    $1a constant LCD_S26                        \ [0x1a] S26
    $1b constant LCD_S27                        \ [0x1b] S27
    $1c constant LCD_S28                        \ [0x1c] S28
    $1d constant LCD_S29                        \ [0x1d] S29
    $1e constant LCD_S30                        \ [0x1e] S30
    $1f constant LCD_S31                        \ [0x1f] S31
  [then]


  [ifdef] LCD_RAM_COM7_DEF
    \
    \ @brief display memory
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant LCD_S00                        \ [0x00] S00
    $01 constant LCD_S01                        \ [0x01] S01
    $02 constant LCD_S02                        \ [0x02] S02
    $03 constant LCD_S03                        \ [0x03] S03
    $04 constant LCD_S04                        \ [0x04] S04
    $05 constant LCD_S05                        \ [0x05] S05
    $06 constant LCD_S06                        \ [0x06] S06
    $07 constant LCD_S07                        \ [0x07] S07
    $08 constant LCD_S08                        \ [0x08] S08
    $09 constant LCD_S09                        \ [0x09] S09
    $0a constant LCD_S10                        \ [0x0a] S10
    $0b constant LCD_S11                        \ [0x0b] S11
    $0c constant LCD_S12                        \ [0x0c] S12
    $0d constant LCD_S13                        \ [0x0d] S13
    $0e constant LCD_S14                        \ [0x0e] S14
    $0f constant LCD_S15                        \ [0x0f] S15
    $10 constant LCD_S16                        \ [0x10] S16
    $11 constant LCD_S17                        \ [0x11] S17
    $12 constant LCD_S18                        \ [0x12] S18
    $13 constant LCD_S19                        \ [0x13] S19
    $14 constant LCD_S20                        \ [0x14] S20
    $15 constant LCD_S21                        \ [0x15] S21
    $16 constant LCD_S22                        \ [0x16] S22
    $17 constant LCD_S23                        \ [0x17] S23
    $18 constant LCD_S24                        \ [0x18] S24
    $19 constant LCD_S25                        \ [0x19] S25
    $1a constant LCD_S26                        \ [0x1a] S26
    $1b constant LCD_S27                        \ [0x1b] S27
    $1c constant LCD_S28                        \ [0x1c] S28
    $1d constant LCD_S29                        \ [0x1d] S29
    $1e constant LCD_S30                        \ [0x1e] S30
    $1f constant LCD_S31                        \ [0x1f] S31
  [then]

  \
  \ @brief Liquid crystal display controller
  \
  $00 constant LCD_CR                   \ control register
  $04 constant LCD_FCR                  \ frame control register
  $08 constant LCD_SR                   \ status register
  $0C constant LCD_CLR                  \ clear register
  $14 constant LCD_RAM_COM0             \ display memory
  $1C constant LCD_RAM_COM1             \ display memory
  $24 constant LCD_RAM_COM2             \ display memory
  $2C constant LCD_RAM_COM3             \ display memory
  $34 constant LCD_RAM_COM4             \ display memory
  $3C constant LCD_RAM_COM5             \ display memory
  $44 constant LCD_RAM_COM6             \ display memory
  $4C constant LCD_RAM_COM7             \ display memory

: LCD_DEF ; [then]
